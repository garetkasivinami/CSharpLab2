namespace SwitchProjectWinForms
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.Day = new System.Windows.Forms.Button();
            this.monthButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Day
            // 
            this.Day.Location = new System.Drawing.Point(13, 13);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(288, 45);
            this.Day.TabIndex = 0;
            this.Day.Text = "Разшифровка дня недели";
            this.Day.UseVisualStyleBackColor = true;
            this.Day.Click += new System.EventHandler(this.Day_Click);
            // 
            // monthButton
            // 
            this.monthButton.Location = new System.Drawing.Point(13, 64);
            this.monthButton.Name = "monthButton";
            this.monthButton.Size = new System.Drawing.Size(288, 45);
            this.monthButton.TabIndex = 1;
            this.monthButton.Text = "Разшифровка месяца";
            this.monthButton.UseVisualStyleBackColor = true;
            this.monthButton.Click += new System.EventHandler(this.MonthButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(288, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "Выполнение операций над числами";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(13, 217);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(288, 45);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Help
            // 
            this.Help.Location = new System.Drawing.Point(12, 166);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(288, 45);
            this.Help.TabIndex = 4;
            this.Help.Text = "Допомога";
            this.Help.UseVisualStyleBackColor = true;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 283);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.monthButton);
            this.Controls.Add(this.Day);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(336, 330);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(336, 330);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Day;
        private System.Windows.Forms.Button monthButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button Help;
    }
}

