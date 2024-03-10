using CalendarCalculator.Properties;
using System;
using System.Windows.Forms;

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
            this.commonFormatLabel = new System.Windows.Forms.Label();
            this.TutFormatInput = new System.Windows.Forms.MaskedTextBox();
            this.tutFormatLabel = new System.Windows.Forms.Label();
            this.tutInputValidation = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.converterTab = new System.Windows.Forms.TabPage();
            this.heliadaTab = new System.Windows.Forms.TabPage();
            this.heliadaLabel = new System.Windows.Forms.Label();
            this.heliadsInTut = new System.Windows.Forms.Label();
            this.heliadsInCommon = new System.Windows.Forms.Label();
            this.plusLabel = new System.Windows.Forms.Label();
            this.heliadaUpDown = new System.Windows.Forms.NumericUpDown();
            this.HeliadaDatePicker = new System.Windows.Forms.DateTimePicker();
            this.formTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.propertiesStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autostartStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizedStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eosforcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl.SuspendLayout();
            this.converterTab.SuspendLayout();
            this.heliadaTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heliadaUpDown)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DatePicker
            // 
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.DatePicker, "DatePicker");
            this.DatePicker.MinDate = new System.DateTime(1996, 3, 1, 0, 0, 0, 0);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Value = new System.DateTime(2020, 6, 10, 0, 0, 0, 0);
            this.DatePicker.ValueChanged += new System.EventHandler(this.DatePicker_ValueChanged);
            // 
            // ToCommonButton
            // 
            resources.ApplyResources(this.ToCommonButton, "ToCommonButton");
            this.ToCommonButton.Name = "ToCommonButton";
            this.ToCommonButton.UseVisualStyleBackColor = true;
            this.ToCommonButton.Click += new System.EventHandler(this.ToCommonButton_Click);
            // 
            // commonFormatLabel
            // 
            resources.ApplyResources(this.commonFormatLabel, "commonFormatLabel");
            this.commonFormatLabel.Name = "commonFormatLabel";
            // 
            // TutFormatInput
            // 
            resources.ApplyResources(this.TutFormatInput, "TutFormatInput");
            this.TutFormatInput.Name = "TutFormatInput";
            // 
            // tutFormatLabel
            // 
            resources.ApplyResources(this.tutFormatLabel, "tutFormatLabel");
            this.tutFormatLabel.Name = "tutFormatLabel";
            // 
            // tutInputValidation
            // 
            resources.ApplyResources(this.tutInputValidation, "tutInputValidation");
            this.tutInputValidation.ForeColor = System.Drawing.Color.Red;
            this.tutInputValidation.Name = "tutInputValidation";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.converterTab);
            this.tabControl.Controls.Add(this.heliadaTab);
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            // 
            // converterTab
            // 
            this.converterTab.Controls.Add(this.tutFormatLabel);
            this.converterTab.Controls.Add(this.tutInputValidation);
            this.converterTab.Controls.Add(this.DatePicker);
            this.converterTab.Controls.Add(this.TutFormatInput);
            this.converterTab.Controls.Add(this.ToCommonButton);
            this.converterTab.Controls.Add(this.commonFormatLabel);
            resources.ApplyResources(this.converterTab, "converterTab");
            this.converterTab.Name = "converterTab";
            // 
            // heliadaTab
            // 
            this.heliadaTab.Controls.Add(this.heliadaLabel);
            this.heliadaTab.Controls.Add(this.heliadsInTut);
            this.heliadaTab.Controls.Add(this.heliadsInCommon);
            this.heliadaTab.Controls.Add(this.plusLabel);
            this.heliadaTab.Controls.Add(this.heliadaUpDown);
            this.heliadaTab.Controls.Add(this.HeliadaDatePicker);
            resources.ApplyResources(this.heliadaTab, "heliadaTab");
            this.heliadaTab.Name = "heliadaTab";
            // 
            // heliadaLabel
            // 
            resources.ApplyResources(this.heliadaLabel, "heliadaLabel");
            this.heliadaLabel.Name = "heliadaLabel";
            // 
            // heliadsInTut
            // 
            resources.ApplyResources(this.heliadsInTut, "heliadsInTut");
            this.heliadsInTut.Name = "heliadsInTut";
            // 
            // heliadsInCommon
            // 
            resources.ApplyResources(this.heliadsInCommon, "heliadsInCommon");
            this.heliadsInCommon.Name = "heliadsInCommon";
            // 
            // plusLabel
            // 
            resources.ApplyResources(this.plusLabel, "plusLabel");
            this.plusLabel.Name = "plusLabel";
            // 
            // heliadaUpDown
            // 
            resources.ApplyResources(this.heliadaUpDown, "heliadaUpDown");
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
            this.heliadaUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.heliadaUpDown.ValueChanged += new System.EventHandler(this.HeliadaUpDown_ValueChanged);
            // 
            // HeliadaDatePicker
            // 
            this.HeliadaDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.HeliadaDatePicker, "HeliadaDatePicker");
            this.HeliadaDatePicker.MinDate = new System.DateTime(1996, 3, 1, 0, 0, 0, 0);
            this.HeliadaDatePicker.Name = "HeliadaDatePicker";
            this.HeliadaDatePicker.Value = new System.DateTime(2029, 12, 25, 23, 59, 59, 0);
            this.HeliadaDatePicker.ValueChanged += new System.EventHandler(this.HeliadaDatePicker_ValueChanged);
            // 
            // formTooltip
            // 
            this.formTooltip.ToolTipTitle = "Подсказка";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propertiesStripMenuItem,
            this.helpStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // propertiesStripMenuItem
            // 
            this.propertiesStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageStripMenuItem,
            this.autostartStripMenuItem,
            this.minimizedStripMenuItem,
            this.exitStripMenuItem});
            this.propertiesStripMenuItem.Name = "propertiesStripMenuItem";
            resources.ApplyResources(this.propertiesStripMenuItem, "propertiesStripMenuItem");
            // 
            // autostartStripMenuItem
            // 
            resources.ApplyResources(this.autostartStripMenuItem, "autostartStripMenuItem");
            this.autostartStripMenuItem.Name = "autostartStripMenuItem";
            // 
            // minimizedStripMenuItem
            // 
            resources.ApplyResources(this.minimizedStripMenuItem, "minimizedStripMenuItem");
            this.minimizedStripMenuItem.Name = "minimizedStripMenuItem";
            // 
            // languageStripMenuItem
            // 
            this.languageStripMenuItem.Name = "languageStripMenuItem";
            resources.ApplyResources(this.languageStripMenuItem, "languageStripMenuItem");
            // 
            // exitStripMenuItem
            // 
            this.exitStripMenuItem.Name = "exitStripMenuItem";
            resources.ApplyResources(this.exitStripMenuItem, "exitStripMenuItem");
            // 
            // helpStripMenuItem
            // 
            this.helpStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eosforcomToolStripMenuItem});
            this.helpStripMenuItem.Name = "helpStripMenuItem";
            resources.ApplyResources(this.helpStripMenuItem, "helpStripMenuItem");
            // 
            // eosforcomToolStripMenuItem
            // 
            resources.ApplyResources(this.eosforcomToolStripMenuItem, "eosforcomToolStripMenuItem");
            this.eosforcomToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.eosforcomToolStripMenuItem.Name = "eosforcomToolStripMenuItem";
            this.eosforcomToolStripMenuItem.Click += new System.EventHandler(this.eosforcomToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.ToCommonButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tabControl.ResumeLayout(false);
            this.converterTab.ResumeLayout(false);
            this.converterTab.PerformLayout();
            this.heliadaTab.ResumeLayout(false);
            this.heliadaTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heliadaUpDown)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Button ToCommonButton;
        private System.Windows.Forms.Label commonFormatLabel;
        private System.Windows.Forms.MaskedTextBox TutFormatInput;
        private System.Windows.Forms.Label tutFormatLabel;
        private System.Windows.Forms.Label tutInputValidation;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage converterTab;
        private System.Windows.Forms.TabPage heliadaTab;
        private System.Windows.Forms.Label heliadsInTut;
        private System.Windows.Forms.Label heliadsInCommon;
        private System.Windows.Forms.Label plusLabel;
        private System.Windows.Forms.NumericUpDown heliadaUpDown;
        private System.Windows.Forms.DateTimePicker HeliadaDatePicker;
        private System.Windows.Forms.ToolTip formTooltip;
        private System.Windows.Forms.Label heliadaLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem propertiesStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autostartStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizedStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eosforcomToolStripMenuItem;
        private ToolStripMenuItem languageStripMenuItem;
    }
}

