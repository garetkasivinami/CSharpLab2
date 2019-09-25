using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchProjectWinForms
{
    public partial class monthForm : Form
    {
        public monthForm()
        {
            InitializeComponent();
        }

        private void MonthForm_Load(object sender, EventArgs e)
        {
            this.MonthTextBox.TextChanged += UpdateText;
        }
        static string[] months = { "Січень", "Лютий", "Березень", "Квітень", "Травень", "Червень", "Липень", "Серпень", "Вересень", "Жовтень", "Листопад", "Грудень" };
        int month = 0;
        private void UpdateText(object sender, EventArgs e)
        {
            if (int.TryParse(this.MonthTextBox.Text, out month) && month >= 1 && month <= 12) // тут не треба виведення помилки
            {
                monthLabelResult.Text = $"- {months[month - 1]}";
            } else
            {
                monthLabelResult.Text = "???";
            }
        }
    }
}
