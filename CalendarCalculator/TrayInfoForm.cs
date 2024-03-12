using CalendarCalculator.Properties;
using System;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace CalendarCalculator
{
    public partial class TrayInfoForm : Form
    {
        private readonly ResourceManager RM = new ResourceManager("CalendarCalculator.WinFormStrings", Assembly.GetExecutingAssembly());

        private readonly DateConverterService converterService = new DateConverterService();

        public TrayInfoForm()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            this.LostFocus += LostFocus_Handler;

            string tutToday = converterService.ConvertToTUT(DateTime.Now);
            tutFormatInfoLabel.Text = tutToday;

            CultureInfo ci = CultureInfo.GetCultureInfo(GetAppLanguage());
            string days = $"{RM.GetString("day", ci)} {converterService.GetNumberOfDays(tutToday)}";
            daysInfoLabel.Text = days;
        }

        private static string GetAppLanguage()
        {
            return (string)Settings.Default["Language"];
        }

        private void LostFocus_Handler(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
