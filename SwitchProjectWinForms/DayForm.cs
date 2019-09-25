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
    public partial class DayForm : Form
    {

        public DayForm()
        {
            InitializeComponent();
        }

        private void DayForm_Load(object sender, EventArgs e)
        {
            this.dayTextBox.TextChanged += UpdateText;
        }
        static string[] days = { "Понеділок", "Вівторок", "Середа", "Четвер", "П'ятниця", "Субота", "Неділя" };
        int day = 0;
        private void UpdateText (object sender, EventArgs e)
        {
            if (int.TryParse(this.dayTextBox.Text,out day) && day >= 1 && day <= 7) // тут не треба виведення помилки
            {
                dayLabel.Text = $"- {days[day - 1]}";
            } else
            {
                dayLabel.Text = "???";
            }
        }

        private void DayTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label_Click(object sender, EventArgs e)
        {

        }
    }
}
