namespace SwitchProjectWinForms
{
    partial class monthForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(monthForm));
            this.MonthTextBox = new System.Windows.Forms.TextBox();
            this.monthLabel = new System.Windows.Forms.Label();
            this.monthLabelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MonthTextBox
            // 
            this.MonthTextBox.Location = new System.Drawing.Point(12, 29);
            this.MonthTextBox.Name = "MonthTextBox";
            this.MonthTextBox.Size = new System.Drawing.Size(100, 22);
            this.MonthTextBox.TabIndex = 0;
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(12, 9);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(188, 17);
            this.monthLabel.TabIndex = 1;
            this.monthLabel.Text = "Введіть номер місяця(1-12)";
            // 
            // monthLabelResult
            // 
            this.monthLabelResult.AutoSize = true;
            this.monthLabelResult.Location = new System.Drawing.Point(118, 32);
            this.monthLabelResult.Name = "monthLabelResult";
            this.monthLabelResult.Size = new System.Drawing.Size(0, 17);
            this.monthLabelResult.TabIndex = 2;
            this.monthLabelResult.Text = "???";
            // 
            // monthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 52);
            this.Controls.Add(this.monthLabelResult);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.MonthTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(355, 99);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(355, 99);
            this.Name = "monthForm";
            this.Text = "monthForm";
            this.Load += new System.EventHandler(this.MonthForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MonthTextBox;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label monthLabelResult;
    }
}