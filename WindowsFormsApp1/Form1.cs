using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Double resultvalue = 0;
        String operationPerfomed = "";
        bool isOperationPerfomed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperationPerfomed))
            {
                textBox_Result.Clear();
            }
            isOperationPerfomed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox_Result.Text.Contains("."))
                {
                    textBox_Result.Text = textBox_Result.Text + button.Text;
                }
            } else
            {
                textBox_Result.Text = textBox_Result.Text + button.Text;
            }
            
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultvalue != 0)
            {
                button18.PerformClick(); operationPerfomed = button.Text;
                labelCurrent.Text = resultvalue + " " + operationPerfomed;
                isOperationPerfomed = true;
            }
            else
            {
                operationPerfomed = button.Text;
                resultvalue = Double.Parse(textBox_Result.Text);
                labelCurrent.Text = resultvalue + " " + operationPerfomed;
                isOperationPerfomed = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultvalue = 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            switch (operationPerfomed)
            {
                case "+":
                    textBox_Result.Text = (resultvalue + Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (resultvalue - Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (resultvalue * Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (resultvalue / Double.Parse(textBox_Result.Text)).ToString();
                    break;
                default:
                    break;



            }
            resultvalue = Double.Parse(textBox_Result.Text);
            labelCurrent.Text = " ";
                
        }
    }
}
