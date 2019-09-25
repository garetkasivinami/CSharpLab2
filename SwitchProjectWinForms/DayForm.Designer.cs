namespace SwitchProjectWinForms
{
    partial class DayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DayForm));
            this.dayTextBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dayTextBox
            // 
            this.dayTextBox.Location = new System.Drawing.Point(12, 41);
            this.dayTextBox.Name = "dayTextBox";
            this.dayTextBox.Size = new System.Drawing.Size(100, 22);
            this.dayTextBox.TabIndex = 0;
            this.dayTextBox.TextChanged += new System.EventHandler(this.DayTextBox_TextChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(13, 13);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(180, 17);
            this.label.TabIndex = 1;
            this.label.Text = "Напишіть день тижня(1-7)";
            this.label.Click += new System.EventHandler(this.Label_Click);
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Location = new System.Drawing.Point(119, 41);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(0, 17);
            this.dayLabel.TabIndex = 2;
            this.dayLabel.Text = "???";
            // 
            // DayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 69);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dayTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(305, 116);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(305, 116);
            this.Name = "DayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DayForm";
            this.Load += new System.EventHandler(this.DayForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dayTextBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label dayLabel;
    }
}