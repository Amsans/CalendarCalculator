namespace CalendarCalculator
{
    partial class TrayInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrayInfoForm));
            this.tutFormatInfoLabel = new System.Windows.Forms.Label();
            this.daysInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tutFormatInfoLabel
            // 
            this.tutFormatInfoLabel.AutoSize = true;
            this.tutFormatInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutFormatInfoLabel.Location = new System.Drawing.Point(38, 9);
            this.tutFormatInfoLabel.Name = "tutFormatInfoLabel";
            this.tutFormatInfoLabel.Size = new System.Drawing.Size(145, 32);
            this.tutFormatInfoLabel.TabIndex = 0;
            this.tutFormatInfoLabel.Text = "X.IV.V.XII";
            // 
            // daysInfoLabel
            // 
            this.daysInfoLabel.AutoSize = true;
            this.daysInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysInfoLabel.Location = new System.Drawing.Point(53, 55);
            this.daysInfoLabel.Name = "daysInfoLabel";
            this.daysInfoLabel.Size = new System.Drawing.Size(107, 25);
            this.daysInfoLabel.TabIndex = 1;
            this.daysInfoLabel.Text = "Day 10239";
            // 
            // TrayInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 89);
            this.ControlBox = false;
            this.Controls.Add(this.daysInfoLabel);
            this.Controls.Add(this.tutFormatInfoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TrayInfoForm";
            this.Text = "TrayInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tutFormatInfoLabel;
        private System.Windows.Forms.Label daysInfoLabel;
    }
}