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
    public partial class calculateForm : Form
    {
        enum operation {_null, plus, minus, mnozenua, dilenua }
        static char[] numberChars = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.' };
        static char[] operationsChars = { '+', '-', '*', '/' };
        public calculateForm()
        {
            InitializeComponent();
        }

        private void CalculateForm_Load(object sender, EventArgs e)
        {
            this.mathBox.TextChanged += UpdateText;
            this.mathBox.Text = "15/3+(85*0.25-8*(-5)+3/2)";
        }
        static bool isError = false;
        private void UpdateText(object sender, EventArgs e)
        {
            isError = false;
            decimal result = decimalCalculate(mathBox.Text);
            if (!isError) {
                resultLabel.Text = "=" + result;
            } else
            {
                resultLabel.Text = "Error";
            }
        }

        static decimal decimalCalculate(string data)
        { // варто оптимізувати все це
            // варто переробити на кнопки, краще буде.
            int level = 0;
            int lastWork = 0;
            List<decimal> numbersString = new List<decimal>();
            List<operation> operations = new List<operation>();
            decimal result = 0;
            string localNumber = "";
            bool skobkiRead = false;
            string skobkiInfo = "";
            for (int i = 0; i < data.Length; i++)
            {
                char ch = data[i];
                if (!skobkiRead) {
                    if (ch == ',')
                    {
                        ch = '.';
                    }
                    if (Array.IndexOf(numberChars, ch) != -1)
                    {
                        localNumber += ch;
                        lastWork = 0;
                    } else if (isOperation(ch))
                    {
                        operations.Add(returnOperation(ch));
                        if (lastWork == 0) {
                            numbersString.Add(convertToDecimal(localNumber));
                        }
                        localNumber = "";
                        lastWork = 1;

                    } else if (ch == '(')
                    {
                        if (i == 0 || isOperation(data[i - 1]) || data[i - 1] == '(')
                        {
                            level = 1;
                            skobkiRead = true;
                            skobkiInfo = "";
                            localNumber = "";
                        }
                    }
                } else
                {
                    if (ch == '(') {
                        level++;
                        skobkiInfo += ch;
                    } else  if (ch == ')')
                    {
                        level -= 1;
                        if (level == 0)
                        {
                            lastWork = 2;
                            numbersString.Add(decimalCalculate(skobkiInfo));
                            skobkiRead = false;
                        } else
                        {
                            skobkiInfo += ch;
                        }
                    }else
                    {
                        skobkiInfo += ch;
                    }
                }
            }
            if (lastWork - 2 < 0) {
                numbersString.Add(convertToDecimal(localNumber));
            }
            if (numbersString.Count == operations.Count + 1)
            {
                for (int i = 0; i < operations.Count; i++)
                {
                    if (operations[i] == operation.mnozenua)
                    {
                        numbersString[i] = numbersString[i] * numbersString[i + 1];
                        numbersString.RemoveAt(i+1);
                        operations.RemoveAt(i);
                        i -= 1;
                    }
                    else if (operations[i] == operation.dilenua)
                    {
                        if (numbersString[i + 1] == 0)
                        {
                            numbersString[i] = 0;
                            isError = true;
                        } else
                        {
                            numbersString[i] = numbersString[i] / numbersString[i + 1];
                        }
                        numbersString.RemoveAt(i + 1);
                        operations.RemoveAt(i);
                        i -= 1;
                    }
                }
                result = numbersString[0];
                for (int i = 0; i < operations.Count; i++)
                {
                    if (operations[i] == operation.plus)
                    {
                        result += numbersString[i + 1];
                    }
                    else if (operations[i] == operation.minus)
                    {
                        result -= numbersString[i + 1];
                    }
                }
            } else
            {
                isError = true;
            }
            return result;
        }
        static bool isOperation(char Abs)
        {
            if(Array.IndexOf(operationsChars, Abs) != -1) {
                return true;
            } else
            {
                return false;
            }
        }
        static decimal convertToDecimal (string data)
        {
            decimal result = 0;
            if (data.Length > 0 && decimal.TryParse(data, out result))
            {
            }
            return result;
        }
        static operation returnOperation(char letter)
        {
            switch (letter) {
                case '+':
                    return operation.plus;
                case '-':
                    return operation.minus;
                case '*':
                    return operation.mnozenua;
                case '/':
                    return operation.dilenua;
                default:
                    return operation._null;
            }
        }
    }
}
