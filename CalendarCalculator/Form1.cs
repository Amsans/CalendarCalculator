using CalendarCalculator.Properties;
using Microsoft.Win32;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CalendarCalculator
{
    public partial class Form1 : Form
    {
        // The path to the key where Windows looks for startup applications
        RegistryKey rkAutostartApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        private readonly DateConverterService converterService = new DateConverterService();
        private NotifyIcon trayIcon;
        MenuItem autostart;
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

            // Initialize Tray Icon
            MenuItem showForm = new MenuItem("Открыть", showForm_Click);
            MenuItem options = new MenuItem("Настройки");
            autostart = new MenuItem("Автозапуск", autostart_Click);
            autostart.Checked = rkAutostartApp.GetValue("CalendarCalculator") != null;
            options.MenuItems.Add(autostart);
            MenuItem exit = new MenuItem("Выход", exit_Click);

            trayIcon = new NotifyIcon()
            {
                Icon = Resources.Icon,
                ContextMenu = new ContextMenu(new MenuItem[] {
                    showForm,
                    options,
                    exit                    
                }),
                Visible = true
            };
            trayIcon.Text = tutToday;
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
            } else
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

        private void heliadaDatePicker_ValueChanged(object sender, EventArgs e)
        {
            CalculateHeliads();
        }

        private void heliadaUpDown_ValueChanged(object sender, EventArgs e)
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

        private void showForm_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        void exit_Click(object sender, EventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it
            trayIcon.Visible = false;
            Application.Exit();
        }

        void autostart_Click(object sender, EventArgs e)
        {
            autostart.Checked = !autostart.Checked;
            if (autostart.Checked)
            {
                rkAutostartApp.SetValue("CalendarCalculator", Application.ExecutablePath);
            }
            else
            {
                rkAutostartApp.DeleteValue("CalendarCalculator", false);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
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
    }
}
