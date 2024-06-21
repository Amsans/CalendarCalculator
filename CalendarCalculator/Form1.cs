using CalendarCalculator.Properties;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarCalculator
{
    public partial class Form1 : Form
    {
        // The path to the key where Windows looks for startup applications
        private readonly RegistryKey rkAutostartApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        private readonly ResourceManager RM = new ResourceManager("CalendarCalculator.WinFormStrings", Assembly.GetExecutingAssembly());

        private readonly DateConverterService converterService = new DateConverterService();

        private NotifyIcon trayIcon;
        private MenuItem autostartOption;
        private MenuItem minimizedOption;
        private bool trayIconClicked;
        public Form1()
        {
            InitializeForm();
        }

        private void InitializeForm()
        {
            InitializeComponent();

            DateTime today = DateTime.Now;
            DatePicker.Value = today;
            chiliadDatePicker.Value = today;
            string tutToday = converterService.ConvertToTUT(today);
            tutFormatLabel.Text = tutToday;

            TutFormatInput.Text = tutToday;
            commonFormatLabel.Text = converterService.ConvertToCommon(tutToday);

            InitializeMenus(tutToday);
        }

        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime commonDate = DatePicker.Value;
            tutFormatLabel.Text = converterService.ConvertToTUT(commonDate);
        }

        private void ConvertToCommon()
        {
            string tutDate = TutFormatInput.Text;
            commonFormatLabel.Text = converterService.ConvertToCommon(tutDate);
        }

        private void ToCommonButton_Click(object sender, EventArgs e)
        {
            tutInputValidation.Visible = false;
            if (ValidateTutInput())
            {
                ConvertToCommon();
            }
            else
            {
                tutInputValidation.Visible = true;
            }
        }

        private bool ValidateTutInput()
        {
            string tutInput = TutFormatInput.Text.Trim();
            if (tutInput.EndsWith("."))
            {
                return false;
            }
            Regex regex = new Regex(DateConverterService.TUT_FORMAT_REGEXP, RegexOptions.None);
            Match matcher = regex.Match(tutInput);
            if (matcher == null)
            {
                return false;
            }
            else
            {
                string chiliadDigit = matcher.Groups[1].ToString();
                string gekatontadaDigit = matcher.Groups[2].ToString();
                string decadaDigit = matcher.Groups[3].ToString();
                string dayOfDecadaDigit = matcher.Groups[4].ToString();
                if (String.IsNullOrWhiteSpace(chiliadDigit)
                    || String.IsNullOrWhiteSpace(gekatontadaDigit)
                    || String.IsNullOrWhiteSpace(decadaDigit)
                    || String.IsNullOrWhiteSpace(dayOfDecadaDigit))
                {
                    return false;
                }
                return true;
            }
        }

        private void chiliadDatePicker_ValueChanged(object sender, EventArgs e)
        {
            CalculateHeliads();
        }

        private void chiliadUpDown_ValueChanged(object sender, EventArgs e)
        {
            CalculateHeliads();
        }
        private void CalculateHeliads()
        {
            DateTime date = chiliadDatePicker.Value;
            int chiliads = (int)chiliadUpDown.Value;
            DateTime resultDate = date.AddDays(1000 * chiliads);
            chiliadsInCommon.Text = resultDate.ToString(DateConverterService.DATE_PATTERN);
            chiliadsInTut.Text = converterService.ConvertToTUT(resultDate);
        }



        /// <summary>
        /// Initializes menu, Tray Icon and all app-related settings
        /// </summary>
        /// <param name="tutToday">Today's date in TUT format</param>
        private void InitializeMenus(string tutToday)
        {
            InitLabels();
            InitializeLanguageMenu();

            CultureInfo ci = CultureInfo.GetCultureInfo(GetAppLanguage());
            bool autostartChecked = rkAutostartApp.GetValue("CalendarCalculator") != null;
            autostartOption = new MenuItem(RM.GetString("autorun", ci), Autostart_Click)
            {
                Checked = autostartChecked,
            };
            this.autostartStripMenuItem.Checked = autostartChecked;
            this.autostartStripMenuItem.Click += Autostart_Click;

            bool minimizedChecked = (bool)Settings.Default["Minimized"];
            minimizedOption = new MenuItem(RM.GetString("minimized", ci), Minimized_Click)
            {
                Checked = minimizedChecked
            };
            this.minimizedStripMenuItem.Checked = minimizedChecked;
            this.minimizedStripMenuItem.Click += Minimized_Click;

            MenuItem options = new MenuItem(RM.GetString("settings", ci));
            options.MenuItems.Add(autostartOption);
            options.MenuItems.Add(minimizedOption);


            if (trayIcon != null)
            {
                trayIcon.Dispose();
            }
            trayIcon = new NotifyIcon
            {
                Icon = Resources.Icon,
                ContextMenu = new ContextMenu(new MenuItem[] {
                    new MenuItem(RM.GetString("open", ci), ShowForm_Click),
                    options,
                    new MenuItem(RM.GetString("exit", ci), Exit_Click)
                }),
                Visible = true,
                Text = GetTrayTooltipText(tutToday),
            };
            trayIcon.MouseClick += ShowTrayInfo_Click;
            trayIcon.MouseDoubleClick += ShowForm_Click;

            eosforcomToolStripMenuItem.MouseMove += LinkMouseMove;
            eosforcomToolStripMenuItem.MouseLeave += LinkMouseLeave;
        }

        private void ShowForm_Click(object sender, EventArgs e)
        {
            trayIconClicked = false;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private async void ShowTrayInfo_Click(object sender, EventArgs e)
        {
            int x = MousePosition.X;
            int y = MousePosition.Y;

            // Workaround to distinguish Click and Doubleclick on TrayIcon
            if (trayIconClicked) return;
            trayIconClicked = true;
            await Task.Delay(SystemInformation.DoubleClickTime);
            if (!trayIconClicked) return;
            trayIconClicked = false;

            TrayInfoForm trayInfo = new TrayInfoForm();
            trayInfo.Show();
            trayInfo.StartPosition = FormStartPosition.Manual;
            trayInfo.SetDesktopLocation(x - trayInfo.Width / 2, y - trayInfo.Height - 25);
            trayInfo.Show();
            trayInfo.Activate();
            trayInfo.TopMost = true;
        }

        void Exit_Click(object sender, EventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it
            trayIcon.Visible = false;
            Application.Exit();
        }

        void Autostart_Click(object sender, EventArgs e)
        {
            autostartOption.Checked = !autostartOption.Checked;
            autostartStripMenuItem.Checked = !autostartStripMenuItem.Checked;

            if (autostartOption.Checked)
            {
                rkAutostartApp.SetValue("CalendarCalculator", Application.ExecutablePath);
            }
            else
            {
                rkAutostartApp.DeleteValue("CalendarCalculator", false);
            }
        }
        void Minimized_Click(object sender, EventArgs e)
        {
            minimizedOption.Checked = !minimizedOption.Checked;
            minimizedStripMenuItem.Checked = !minimizedStripMenuItem.Checked;
            Settings.Default["Minimized"] = minimizedOption.Checked;
            Settings.Default.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bool isMinimized = (bool)Settings.Default["Minimized"];
            if (isMinimized)
            {
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
                this.ShowInTaskbar = false;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (trayIcon != null)
            {
                if (FormWindowState.Minimized == this.WindowState)
                {
                    this.Hide();
                }
            }
        }

        private void EosforcomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.eosfor.com");
        }

        private void LinkMouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void LinkMouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
        private static string GetAppLanguage()
        {
            return (string)Settings.Default["Language"];
        }
        private static void SetAppLanguage(string language)
        {
            Settings.Default["Language"] = language;
            Settings.Default.Save();
        }

        private string GetTrayTooltipText(string tutToday)
        {
            CultureInfo ci = CultureInfo.GetCultureInfo(GetAppLanguage());
            string days = $"{RM.GetString("day", ci)} {converterService.GetNumberOfDays(tutToday)}";
            return $"{tutToday}{Environment.NewLine}{Environment.NewLine}{days}";
        }

        private void InitLabels()
        {
            CultureInfo ci = CultureInfo.GetCultureInfo(GetAppLanguage());

            this.Text = RM.GetString("form_title", ci) + " " + Settings.Default["version"];
            propertiesStripMenuItem.Text = RM.GetString("settings", ci);
            autostartStripMenuItem.Text = RM.GetString("autorun", ci);
            minimizedStripMenuItem.Text = RM.GetString("minimized", ci);
            languageStripMenuItem.Text = RM.GetString("language", ci);
            exitStripMenuItem.Text = RM.GetString("exit", ci);
            helpStripMenuItem.Text = RM.GetString("help", ci);
            tutInputValidation.Text = RM.GetString("invalid_format", ci);
            tabControl.TabPages[0].Text = RM.GetString("converter", ci);
            tabControl.TabPages[1].Text = RM.GetString("chiliads", ci);
            chiliadLabel.Text = RM.GetString("chiliad_tab_info", ci);
            ToolTip tooltip = new ToolTip
            {
                IsBalloon = false,
                ToolTipTitle = RM.GetString("tooltip_title", ci)
            };
            tooltip.SetToolTip(tutInputValidation, RM.GetString("tooltip_tut_input", ci));
            tooltip.SetToolTip(tutFormatLabel, RM.GetString("tooltip_tut_label", ci));
            tooltip.SetToolTip(commonFormatLabel, RM.GetString("tooltip_tut_label", ci));
            tooltip.SetToolTip(chiliadsInCommon, RM.GetString("tooltip_tut_label", ci));
            tooltip.SetToolTip(chiliadsInTut, RM.GetString("tooltip_tut_label", ci));
        }

        private void InitializeLanguageMenu()
        {
            string appLanguage = GetAppLanguage();
            foreach (var lang in new List<string>()
            {
                "en",
                "be",
                "ru"
            })
            {
                ToolStripMenuItem menuItem = new ToolStripMenuItem(RM.GetString("lang_" + lang), null, Language_Click)
                {
                    ImageScaling = ToolStripItemImageScaling.None,
                    Tag = lang,
                    Checked = appLanguage.Equals(lang)
                };
                languageStripMenuItem.DropDownItems.Add(menuItem);
            }
        }

        void Language_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem currentItem)
            {
                ((ToolStripMenuItem)currentItem.OwnerItem).DropDownItems
                    .OfType<ToolStripMenuItem>().ToList()
                    .ForEach(item =>
                    {
                        item.Checked = false;
                    });

                currentItem.Checked = true;
                string language = (string)currentItem.Tag;
                System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(language);
                SetAppLanguage(language);

                this.Controls.Clear();
                InitializeForm();
            }
        }
    }
}
