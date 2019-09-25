using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;
using System.Windows.Forms;

namespace SwitchProjectWinForms
{
    public partial class mainForm : Form
    {
        public static bool[] childrensStates = new bool[4];
        public mainForm()
        {
            CultureInfo ci = (CultureInfo.InvariantCulture.Clone() as CultureInfo);
            ci.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = ci;
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Day_Click(object sender, EventArgs e)
        {
            if (!childrensStates[0])
            {
                DayForm form = new DayForm();
                childrensStates[0] = true;
                form.Show(this);
                form.FormClosed += OnExitOneForm;
            }
        }

        public void OnExitOneForm(object sender, EventArgs e)
        {
            if (sender is DayForm)
            {
                childrensStates[0] = false;
            } else if (sender is monthForm)
            {
                childrensStates[1] = false;
            } else if (sender is calculateForm)
            {
                childrensStates[2] = false;
            } else if (sender is helpForm)
            {
                childrensStates[3] = false;
            }
        }

        private void MonthButton_Click(object sender, EventArgs e)
        {
            if (!childrensStates[1])
            {
                monthForm form = new monthForm();
                childrensStates[1] = true;
                form.Show(this);
                form.FormClosed += OnExitOneForm;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (!childrensStates[2])
            {
                calculateForm form = new calculateForm();
                childrensStates[2] = true;
                form.Show(this);
                form.FormClosed += OnExitOneForm;
            }
        }

        private void Help_Click(object sender, EventArgs e)
        {
            if (!childrensStates[3])
            {
                helpForm form = new helpForm();
                childrensStates[3] = true;
                form.Show(this);
                form.FormClosed += OnExitOneForm;
            }
        }
    }
}
