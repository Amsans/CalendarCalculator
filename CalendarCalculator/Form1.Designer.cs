namespace CalendarCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.ToCommonButton = new System.Windows.Forms.Button();
            this.CommonFormatLabel = new System.Windows.Forms.Label();
            this.TutFormatInput = new System.Windows.Forms.MaskedTextBox();
            this.TutFormatLabel = new System.Windows.Forms.Label();
            this.TutInputValidation = new System.Windows.Forms.Label();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.converterTab = new System.Windows.Forms.TabPage();
            this.heliadaTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.heliadsInTut = new System.Windows.Forms.Label();
            this.heliadsInCommon = new System.Windows.Forms.Label();
            this.plusLabel = new System.Windows.Forms.Label();
            this.heliadaUpDown = new System.Windows.Forms.NumericUpDown();
            this.HeliadaDatePicker = new System.Windows.Forms.DateTimePicker();
            this.FormTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.TabControl.SuspendLayout();
            this.converterTab.SuspendLayout();
            this.heliadaTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heliadaUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // DatePicker
            // 
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicker.Location = new System.Drawing.Point(51, 48);
            this.DatePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DatePicker.MinDate = new System.DateTime(1996, 3, 1, 0, 0, 0, 0);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(148, 26);
            this.DatePicker.TabIndex = 0;
            this.DatePicker.Value = new System.DateTime(2020, 6, 10, 0, 0, 0, 0);
            this.DatePicker.ValueChanged += new System.EventHandler(this.DatePicker_ValueChanged);
            // 
            // ToCommonButton
            // 
            this.ToCommonButton.Location = new System.Drawing.Point(156, 128);
            this.ToCommonButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ToCommonButton.Name = "ToCommonButton";
            this.ToCommonButton.Size = new System.Drawing.Size(45, 31);
            this.ToCommonButton.TabIndex = 3;
            this.ToCommonButton.Text = ">";
            this.ToCommonButton.UseVisualStyleBackColor = true;
            this.ToCommonButton.Click += new System.EventHandler(this.ToCommonButton_Click);
            // 
            // CommonFormatLabel
            // 
            this.CommonFormatLabel.AutoSize = true;
            this.CommonFormatLabel.Location = new System.Drawing.Point(219, 132);
            this.CommonFormatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CommonFormatLabel.Name = "CommonFormatLabel";
            this.CommonFormatLabel.Size = new System.Drawing.Size(160, 20);
            this.CommonFormatLabel.TabIndex = 4;
            this.CommonFormatLabel.Text = "commonFormatLabel";
            this.FormTooltip.SetToolTip(this.CommonFormatLabel, "Двойной клик по этой дате скопирует её в буфер обмена");
            // 
            // TutFormatInput
            // 
            this.TutFormatInput.Location = new System.Drawing.Point(51, 128);
            this.TutFormatInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TutFormatInput.Name = "TutFormatInput";
            this.TutFormatInput.Size = new System.Drawing.Size(103, 26);
            this.TutFormatInput.TabIndex = 5;
            // 
            // TutFormatLabel
            // 
            this.TutFormatLabel.AutoSize = true;
            this.TutFormatLabel.Location = new System.Drawing.Point(219, 57);
            this.TutFormatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TutFormatLabel.Name = "TutFormatLabel";
            this.TutFormatLabel.Size = new System.Drawing.Size(118, 20);
            this.TutFormatLabel.TabIndex = 1;
            this.TutFormatLabel.Text = "tutFormatLabel";
            this.FormTooltip.SetToolTip(this.TutFormatLabel, "Двойной клик по этой дате скопирует её в буфер обмена");
            // 
            // TutInputValidation
            // 
            this.TutInputValidation.AutoSize = true;
            this.TutInputValidation.ForeColor = System.Drawing.Color.Red;
            this.TutInputValidation.Location = new System.Drawing.Point(46, 163);
            this.TutInputValidation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TutInputValidation.Name = "TutInputValidation";
            this.TutInputValidation.Size = new System.Drawing.Size(152, 20);
            this.TutInputValidation.TabIndex = 6;
            this.TutInputValidation.Text = "Неверный формат";
            this.FormTooltip.SetToolTip(this.TutInputValidation, "Формат даты должен быть I.II.IV.X");
            this.TutInputValidation.Visible = false;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.converterTab);
            this.TabControl.Controls.Add(this.heliadaTab);
            this.TabControl.Location = new System.Drawing.Point(2, 11);
            this.TabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(470, 289);
            this.TabControl.TabIndex = 7;
            // 
            // converterTab
            // 
            this.converterTab.Controls.Add(this.TutFormatLabel);
            this.converterTab.Controls.Add(this.TutInputValidation);
            this.converterTab.Controls.Add(this.DatePicker);
            this.converterTab.Controls.Add(this.TutFormatInput);
            this.converterTab.Controls.Add(this.ToCommonButton);
            this.converterTab.Controls.Add(this.CommonFormatLabel);
            this.converterTab.Location = new System.Drawing.Point(4, 29);
            this.converterTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.converterTab.Name = "converterTab";
            this.converterTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.converterTab.Size = new System.Drawing.Size(462, 256);
            this.converterTab.TabIndex = 0;
            this.converterTab.Text = "Конвертер";
            // 
            // heliadaTab
            // 
            this.heliadaTab.Controls.Add(this.label1);
            this.heliadaTab.Controls.Add(this.heliadsInTut);
            this.heliadaTab.Controls.Add(this.heliadsInCommon);
            this.heliadaTab.Controls.Add(this.plusLabel);
            this.heliadaTab.Controls.Add(this.heliadaUpDown);
            this.heliadaTab.Controls.Add(this.HeliadaDatePicker);
            this.heliadaTab.Location = new System.Drawing.Point(4, 29);
            this.heliadaTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.heliadaTab.Name = "heliadaTab";
            this.heliadaTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.heliadaTab.Size = new System.Drawing.Size(462, 256);
            this.heliadaTab.TabIndex = 1;
            this.heliadaTab.Text = "Хелиады";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Подсчёт N-ой хелиады (1000 дней) для указанной даты";
            // 
            // heliadsInTut
            // 
            this.heliadsInTut.AutoSize = true;
            this.heliadsInTut.Location = new System.Drawing.Point(304, 132);
            this.heliadsInTut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.heliadsInTut.Name = "heliadsInTut";
            this.heliadsInTut.Size = new System.Drawing.Size(51, 20);
            this.heliadsInTut.TabIndex = 4;
            this.heliadsInTut.Text = "label2";
            // 
            // heliadsInCommon
            // 
            this.heliadsInCommon.AutoSize = true;
            this.heliadsInCommon.Location = new System.Drawing.Point(298, 94);
            this.heliadsInCommon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.heliadsInCommon.Name = "heliadsInCommon";
            this.heliadsInCommon.Size = new System.Drawing.Size(51, 20);
            this.heliadsInCommon.TabIndex = 3;
            this.heliadsInCommon.Text = "label1";
            // 
            // plusLabel
            // 
            this.plusLabel.AutoSize = true;
            this.plusLabel.Location = new System.Drawing.Point(192, 94);
            this.plusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.plusLabel.Name = "plusLabel";
            this.plusLabel.Size = new System.Drawing.Size(18, 20);
            this.plusLabel.TabIndex = 2;
            this.plusLabel.Text = "+";
            // 
            // heliadaUpDown
            // 
            this.heliadaUpDown.Location = new System.Drawing.Point(216, 89);
            this.heliadaUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.heliadaUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.heliadaUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.heliadaUpDown.Name = "heliadaUpDown";
            this.heliadaUpDown.Size = new System.Drawing.Size(58, 26);
            this.heliadaUpDown.TabIndex = 1;
            this.heliadaUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.heliadaUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.heliadaUpDown.ValueChanged += new System.EventHandler(this.heliadaUpDown_ValueChanged);
            // 
            // HeliadaDatePicker
            // 
            this.HeliadaDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.HeliadaDatePicker.Location = new System.Drawing.Point(36, 89);
            this.HeliadaDatePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HeliadaDatePicker.MinDate = new System.DateTime(1996, 3, 1, 0, 0, 0, 0);
            this.HeliadaDatePicker.Name = "HeliadaDatePicker";
            this.HeliadaDatePicker.Size = new System.Drawing.Size(148, 26);
            this.HeliadaDatePicker.TabIndex = 0;
            this.HeliadaDatePicker.Value = new System.DateTime(2029, 12, 25, 23, 59, 59, 0);
            this.HeliadaDatePicker.ValueChanged += new System.EventHandler(this.heliadaDatePicker_ValueChanged);
            // 
            // FormTooltip
            // 
            this.FormTooltip.ToolTipTitle = "Подсказка";
            // 
            // Form1
            // 
            this.AcceptButton = this.ToCommonButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 298);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Конвертер дат УЕХ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.TabControl.ResumeLayout(false);
            this.converterTab.ResumeLayout(false);
            this.converterTab.PerformLayout();
            this.heliadaTab.ResumeLayout(false);
            this.heliadaTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heliadaUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Button ToCommonButton;
        private System.Windows.Forms.Label CommonFormatLabel;
        private System.Windows.Forms.MaskedTextBox TutFormatInput;
        private System.Windows.Forms.Label TutFormatLabel;
        private System.Windows.Forms.Label TutInputValidation;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage converterTab;
        private System.Windows.Forms.TabPage heliadaTab;
        private System.Windows.Forms.Label heliadsInTut;
        private System.Windows.Forms.Label heliadsInCommon;
        private System.Windows.Forms.Label plusLabel;
        private System.Windows.Forms.NumericUpDown heliadaUpDown;
        private System.Windows.Forms.DateTimePicker HeliadaDatePicker;
        private System.Windows.Forms.ToolTip FormTooltip;
        private System.Windows.Forms.Label label1;
    }
}

