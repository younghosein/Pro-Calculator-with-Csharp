using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace WindowsFormsAppPractice1
{
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
        }

        double num;
        string op;
        bool t = false;

        void clear()
        {
            txtNum.Text = "";
            txtNum.Focus();
        }
        private void Button15_Click(object sender, EventArgs e)
        {
            txtNum.Text += "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            txtNum.Text += "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            txtNum.Text += "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            txtNum.Text += "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            txtNum.Text += "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            txtNum.Text += "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            txtNum.Text += "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            txtNum.Text += "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            txtNum.Text += "9";
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            txtNum.Text += "0";
        }

        private void Btn000_Click(object sender, EventArgs e)
        {
            txtNum.Text += "000";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void BtnSum_Click(object sender, EventArgs e)
        {
                op = "+";
                num = double.Parse(txtNum.Text);
                clear();
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            if (txtNum.Text == "")
            {
                txtNum.Text = "-";
            }
            else
            {
                op = "-";
                num = double.Parse(txtNum.Text);
                clear();

            }
        }

        private void BtnNG_Click(object sender, EventArgs e)
        {
            num = double.Parse(txtNum.Text);
            double a = Math.Abs(num);
            txtNum.Text = a.ToString().Replace('/', '.');
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            op = "/";
            num = double.Parse(txtNum.Text);
            clear();
        }

        private void BtnMultipication_Click(object sender, EventArgs e)
        {
            op = "*";
            num = double.Parse(txtNum.Text);
            clear();
        }

        private void BtnPower_Click(object sender, EventArgs e)
        {
            op = "^";
            num = double.Parse(txtNum.Text);
            clear();
        }

        private void BtnMod_Click(object sender, EventArgs e)
        {
            op = "%";
            num = double.Parse(txtNum.Text);
            clear();
        }

        private void BtnPoint_Click(object sender, EventArgs e)
        {
            if (txtNum.Text == "")
            {
                txtNum.Text = "0.";
            }
            if (txtNum.Text.IndexOf(".") > 0)
            {
                txtNum.Text += ".";
            }
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            if (op == "+")
            {
                txtNum.Text = (num + double.Parse(txtNum.Text)).ToString().Replace('/','.');
            }
            else if (op == "-")
            {
                txtNum.Text = (num - double.Parse(txtNum.Text)).ToString().Replace('/', '.');
            }
            else if (op == "/")
            {
                txtNum.Text = (num / double.Parse(txtNum.Text)).ToString().Replace('/', '.');
            }
            else if (op == "*")
            {
                txtNum.Text = (num * double.Parse(txtNum.Text)).ToString().Replace('/', '.');
            }
            else if (op == "%")
            {
                txtNum.Text = (num % double.Parse(txtNum.Text)).ToString().Replace('/', '.');
            }
            else if (op == "^")
            {
                double a = double.Parse(txtNum.Text);
                double b = Math.Pow(num,a);
                txtNum.Text = b.ToString().Replace('/', '.');
            }
        }

        private void BtnRadical_Click(object sender, EventArgs e)
        {
            num = double.Parse(txtNum.Text);
            double a = Math.Sqrt(num);
            txtNum.Text = a.ToString().Replace('/', '.');
        }

        private void BtnPi_Click(object sender, EventArgs e)
        {
            double pi = 3.1415926535;
            txtNum.Text = pi.ToString().Replace('/', '.');
        }

        private void BtnRound_Click(object sender, EventArgs e)
        {
            num = double.Parse(txtNum.Text);
            double a = Math.Log10(num);
            txtNum.Text = a.ToString().Replace('/', '.');
        }

        private void FormCalculator_Load(object sender, EventArgs e)
        {
            
        }

        private void TxtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
