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
            this.heliadsInTut = new System.Windows.Forms.Label();
            this.heliadsInCommon = new System.Windows.Forms.Label();
            this.plusLabel = new System.Windows.Forms.Label();
            this.heliadaUpDown = new System.Windows.Forms.NumericUpDown();
            this.HeliadaDatePicker = new System.Windows.Forms.DateTimePicker();
            this.FormTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.TabControl.SuspendLayout();
            this.converterTab.SuspendLayout();
            this.heliadaTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heliadaUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // DatePicker
            // 
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicker.Location = new System.Drawing.Point(34, 31);
            this.DatePicker.MinDate = new System.DateTime(1996, 3, 1, 0, 0, 0, 0);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(100, 20);
            this.DatePicker.TabIndex = 0;
            this.DatePicker.Value = new System.DateTime(2020, 6, 10, 0, 0, 0, 0);
            this.DatePicker.ValueChanged += new System.EventHandler(this.DatePicker_ValueChanged);
            // 
            // ToCommonButton
            // 
            this.ToCommonButton.Location = new System.Drawing.Point(104, 83);
            this.ToCommonButton.Name = "ToCommonButton";
            this.ToCommonButton.Size = new System.Drawing.Size(30, 20);
            this.ToCommonButton.TabIndex = 3;
            this.ToCommonButton.Text = ">";
            this.ToCommonButton.UseVisualStyleBackColor = true;
            this.ToCommonButton.Click += new System.EventHandler(this.ToCommonButton_Click);
            // 
            // CommonFormatLabel
            // 
            this.CommonFormatLabel.AutoSize = true;
            this.CommonFormatLabel.Location = new System.Drawing.Point(146, 86);
            this.CommonFormatLabel.Name = "CommonFormatLabel";
            this.CommonFormatLabel.Size = new System.Drawing.Size(105, 13);
            this.CommonFormatLabel.TabIndex = 4;
            this.CommonFormatLabel.Text = "commonFormatLabel";
            this.FormTooltip.SetToolTip(this.CommonFormatLabel, "Двойной клик по этой дате скопирует её в буфер обмена");
            // 
            // TutFormatInput
            // 
            this.TutFormatInput.Location = new System.Drawing.Point(34, 83);
            this.TutFormatInput.Name = "TutFormatInput";
            this.TutFormatInput.Size = new System.Drawing.Size(70, 20);
            this.TutFormatInput.TabIndex = 5;
            // 
            // TutFormatLabel
            // 
            this.TutFormatLabel.AutoSize = true;
            this.TutFormatLabel.Location = new System.Drawing.Point(146, 37);
            this.TutFormatLabel.Name = "TutFormatLabel";
            this.TutFormatLabel.Size = new System.Drawing.Size(77, 13);
            this.TutFormatLabel.TabIndex = 1;
            this.TutFormatLabel.Text = "tutFormatLabel";
            this.FormTooltip.SetToolTip(this.TutFormatLabel, "Двойной клик по этой дате скопирует её в буфер обмена");
            // 
            // TutInputValidation
            // 
            this.TutInputValidation.AutoSize = true;
            this.TutInputValidation.ForeColor = System.Drawing.Color.Red;
            this.TutInputValidation.Location = new System.Drawing.Point(31, 106);
            this.TutInputValidation.Name = "TutInputValidation";
            this.TutInputValidation.Size = new System.Drawing.Size(101, 13);
            this.TutInputValidation.TabIndex = 6;
            this.TutInputValidation.Text = "Неверный формат";
            this.FormTooltip.SetToolTip(this.TutInputValidation, "Формат даты должен быть I.II.IV.X");
            this.TutInputValidation.Visible = false;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.converterTab);
            this.TabControl.Controls.Add(this.heliadaTab);
            this.TabControl.Location = new System.Drawing.Point(1, 7);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(313, 188);
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
            this.converterTab.Location = new System.Drawing.Point(4, 22);
            this.converterTab.Name = "converterTab";
            this.converterTab.Padding = new System.Windows.Forms.Padding(3);
            this.converterTab.Size = new System.Drawing.Size(284, 162);
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
            this.heliadaTab.Location = new System.Drawing.Point(4, 22);
            this.heliadaTab.Name = "heliadaTab";
            this.heliadaTab.Padding = new System.Windows.Forms.Padding(3);
            this.heliadaTab.Size = new System.Drawing.Size(305, 162);
            this.heliadaTab.TabIndex = 1;
            this.heliadaTab.Text = "Хелиады";
            // 
            // heliadsInTut
            // 
            this.heliadsInTut.AutoSize = true;
            this.heliadsInTut.Location = new System.Drawing.Point(203, 86);
            this.heliadsInTut.Name = "heliadsInTut";
            this.heliadsInTut.Size = new System.Drawing.Size(35, 13);
            this.heliadsInTut.TabIndex = 4;
            this.heliadsInTut.Text = "label2";
            // 
            // heliadsInCommon
            // 
            this.heliadsInCommon.AutoSize = true;
            this.heliadsInCommon.Location = new System.Drawing.Point(199, 61);
            this.heliadsInCommon.Name = "heliadsInCommon";
            this.heliadsInCommon.Size = new System.Drawing.Size(35, 13);
            this.heliadsInCommon.TabIndex = 3;
            this.heliadsInCommon.Text = "label1";
            // 
            // plusLabel
            // 
            this.plusLabel.AutoSize = true;
            this.plusLabel.Location = new System.Drawing.Point(128, 61);
            this.plusLabel.Name = "plusLabel";
            this.plusLabel.Size = new System.Drawing.Size(13, 13);
            this.plusLabel.TabIndex = 2;
            this.plusLabel.Text = "+";
            // 
            // heliadaUpDown
            // 
            this.heliadaUpDown.Location = new System.Drawing.Point(144, 58);
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
            this.heliadaUpDown.Size = new System.Drawing.Size(39, 20);
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
            this.HeliadaDatePicker.Location = new System.Drawing.Point(24, 58);
            this.HeliadaDatePicker.MinDate = new System.DateTime(1996, 3, 1, 0, 0, 0, 0);
            this.HeliadaDatePicker.Name = "HeliadaDatePicker";
            this.HeliadaDatePicker.Size = new System.Drawing.Size(100, 20);
            this.HeliadaDatePicker.TabIndex = 0;
            this.HeliadaDatePicker.Value = new System.DateTime(2029, 12, 25, 23, 59, 59, 0);
            this.HeliadaDatePicker.ValueChanged += new System.EventHandler(this.heliadaDatePicker_ValueChanged);
            // 
            // FormTooltip
            // 
            this.FormTooltip.ToolTipTitle = "Подсказка";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Подсчёт N-ой хелиады (1000 дней) для указанной даты";
            // 
            // Form1
            // 
            this.AcceptButton = this.ToCommonButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 194);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Конвертер дат УЕХ";
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

