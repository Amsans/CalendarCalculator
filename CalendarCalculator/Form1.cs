using CalendarCalculator.Properties;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CalendarCalculator
{
    public partial class Form1 : Form
    {
        // The path to the key where Windows looks for startup applications
        private readonly RegistryKey rkAutostartApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        private readonly DateConverterService converterService = new DateConverterService();

        private NotifyIcon trayIcon;
        private MenuItem autostartOption;
        private MenuItem minimizedOption;
        public Form1()
        {
            InitializeComponent();
            DateTime today = DateTime.Now;
            DatePicker.Value = today;
            HeliadaDatePicker.Value = today;
            string tutToday = converterService.ConvertToTUT(today);
            TutFormatLabel.Text = tutToday;

            TutFormatInput.Text = tutToday;
            CommonFormatLabel.Text = converterService.ConvertToCommon(tutToday);

            InitializeMenus(tutToday);
        }
        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime commonDate = DatePicker.Value;
            TutFormatLabel.Text = converterService.ConvertToTUT(commonDate);
        }

        private void ConvertToCommon()
        {
            string tutDate = TutFormatInput.Text;
            CommonFormatLabel.Text = converterService.ConvertToCommon(tutDate);
        }

        private void ToCommonButton_Click(object sender, EventArgs e)
        {
            TutInputValidation.Visible = false;
            if (ValidateTutInput())
            {
                ConvertToCommon();
            }
            else
            {
                TutInputValidation.Visible = true;
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
                string heliadaDigit = matcher.Groups[1].ToString();
                string gekatontadaDigit = matcher.Groups[2].ToString();
                string decadaDigit = matcher.Groups[3].ToString();
                string dayOfDecadaDigit = matcher.Groups[4].ToString();
                if (String.IsNullOrWhiteSpace(heliadaDigit)
                    || String.IsNullOrWhiteSpace(gekatontadaDigit)
                    || String.IsNullOrWhiteSpace(decadaDigit)
                    || String.IsNullOrWhiteSpace(dayOfDecadaDigit))
                {
                    return false;
                }
                return true;
            }
        }

        private void HeliadaDatePicker_ValueChanged(object sender, EventArgs e)
        {
            CalculateHeliads();
        }

        private void HeliadaUpDown_ValueChanged(object sender, EventArgs e)
        {
            CalculateHeliads();
        }
        private void CalculateHeliads()
        {
            DateTime date = HeliadaDatePicker.Value;
            int heliadas = (int)heliadaUpDown.Value;
            DateTime resultDate = date.AddDays(1000 * heliadas);
            heliadsInCommon.Text = resultDate.ToString(DateConverterService.DATE_PATTERN);
            heliadsInTut.Text = converterService.ConvertToTUT(resultDate);
        }



        /// <summary>
        /// Initializes menu, Tray Icon and all app-related settings
        /// </summary>
        /// <param name="tutToday">Today's date in TUT format</param>
        private void InitializeMenus(string tutToday)
        {
            bool autostartChecked = rkAutostartApp.GetValue("CalendarCalculator") != null;
            autostartOption = new MenuItem("Автозапуск", Autostart_Click)
            {
                Checked = autostartChecked
            };
            this.autostartStripMenuItem.Checked = autostartChecked;

            bool minimizedChecked = (bool)Settings.Default["Minimized"];
            minimizedOption = new MenuItem("Запускать свёрнутым", Minimized_Click)
            {
                Checked = minimizedChecked
            };
            this.minimizedStripMenuItem.Checked = minimizedChecked;

            MenuItem options = new MenuItem("Настройки");
            options.MenuItems.Add(autostartOption);
            options.MenuItems.Add(minimizedOption);

            trayIcon = new NotifyIcon
            {
                Icon = Resources.Icon,
                ContextMenu = new ContextMenu(new MenuItem[] {
                    new MenuItem("Открыть", ShowForm_Click),
                    options,
                    new MenuItem("Выход", Exit_Click)
                }),
                Visible = true,
                Text = tutToday,
            };
            trayIcon.MouseDoubleClick += ShowForm_Click;

            eosforcomToolStripMenuItem.MouseMove += LinkMouseMove;
            eosforcomToolStripMenuItem.MouseLeave += LinkMouseLeave;
        }

        private void ShowForm_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
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

        private void eosforcomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.eosfor.com");
        }

        private void LinkMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void LinkMouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
