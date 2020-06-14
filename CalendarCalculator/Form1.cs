using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CalendarCalculator
{
    public partial class Form1 : Form
    {
        private readonly DateConverterService converterService = new DateConverterService();
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
    }
}
