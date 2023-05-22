using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FormProCal : Form
    {
        public FormProCal()
        {
            InitializeComponent();
        }
        double num;
        string op;

        void cl()
        {
            txtSc.Text = "";
            txtSc.Focus();
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            cl();
        }

        private void TxtSc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(text: "In This Calculator, You Can Give A Numeric Value\n\nOnly Twice In One Calculation And For More\n\nCalculations, After Viewing The Answer, Clear The\n\nDisplay And Calculate Separately");
        }

        private void BtnPi_Click(object sender, EventArgs e)
        {
            txtSc.Text =(3.1415926535).ToString();
        }

        private void BtnPoint_Click(object sender, EventArgs e)
        {
            if (txtSc.Text == "" || txtSc.Text == "000")
            {
                txtSc.Text = "0.";
            }
            if (txtSc.Text == "-")
            {
                txtSc.Text += "0.";
            }
            if (txtSc.Text.IndexOf(".") < 0)
            {
                txtSc.Text += ".";
            }
        }

        private void BtnNG_Click(object sender, EventArgs e)
        {
            num = double.Parse(txtSc.Text);
            txtSc.Text = Math.Abs(num).ToString();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            txtSc.Text += "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            txtSc.Text += "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            txtSc.Text += "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            txtSc.Text += "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            txtSc.Text += "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            txtSc.Text += "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            txtSc.Text += "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            txtSc.Text += "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            txtSc.Text += "9";
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            if (txtSc.Text != "")
            {
                txtSc.Text += "0";
            }
        }

        private void Bn000_Click(object sender, EventArgs e)
        {
            if (txtSc.Text != "")
            {
                txtSc.Text += "000";
            }
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            if (txtSc.Text == "")
            {
                txtSc.Text = "-";
            }
            else
            {
                op = "-";
                num = double.Parse(txtSc.Text);
                cl();
            }
        }

        private void BtnRad_Click(object sender, EventArgs e)
        {
            num = double.Parse(txtSc.Text);
            txtSc.Text = Math.Sqrt(num).ToString();
        }

        private void BtnRD_Click(object sender, EventArgs e)
        {
            num = double.Parse(txtSc.Text);
            txtSc.Text = Math.Ceiling(num).ToString();
        }

        private void BtnRU_Click(object sender, EventArgs e)
        {
            num = double.Parse(txtSc.Text);
            txtSc.Text = Math.Floor(num).ToString();
        }

        private void BtnSin_Click(object sender, EventArgs e)
        {
            num = double.Parse(txtSc.Text);
            num = double.Parse(txtSc.Text);
            txtSc.Text = Math.Sin(num).ToString();
        }

        private void BtnCos_Click(object sender, EventArgs e)
        {
            num = double.Parse(txtSc.Text);
            txtSc.Text = Math.Cos(num).ToString();
        }

        private void BtnTan_Click(object sender, EventArgs e)
        {
            num = double.Parse(txtSc.Text);
            txtSc.Text = Math.Tan(num).ToString();
        }

        private void BtnLn_Click(object sender, EventArgs e)
        {
            num = double.Parse(txtSc.Text);
            txtSc.Text = Math.Log(num).ToString();
        }

        private void BtnLog_Click(object sender, EventArgs e)
        {
            num = double.Parse(txtSc.Text);
            txtSc.Text = Math.Log10(num).ToString();
        }

        private void BtnFact_Click(object sender, EventArgs e)
        {
            num = double.Parse(txtSc.Text);
            if (txtSc.Text.IndexOf(".") < 0 && num > 0)
            {
                int f = 1;
                for (int i = 1; i <= num; i++)
                {
                    f *= i;
                }
                txtSc.Text = f.ToString();
            }
        }

        private void BtnPow2_Click(object sender, EventArgs e)
        {
            num = double.Parse(txtSc.Text);
            txtSc.Text = Math.Pow(num, 2).ToString();
        }

        private void BtnRe_Click(object sender, EventArgs e)
        {
            num = double.Parse(txtSc.Text);
            txtSc.Text = (1 / num).ToString();
        }
        private void BtnBK_Click(object sender, EventArgs e)
        {
            txtSc.Text = txtSc.Text.Remove(txtSc.Text.Length - 1);
        }

        private void BtnMod_Click(object sender, EventArgs e)
        {
            op = "mod";
            num = double.Parse(txtSc.Text);
            cl();
        }

        private void BtnPow_Click(object sender, EventArgs e)
        {
            op = "^";
            num = double.Parse(txtSc.Text);
            cl();
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            op = "÷";
            num = double.Parse(txtSc.Text);
            cl();
        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            op = "×";
            num = double.Parse(txtSc.Text);
            cl();
        }

        private void BtnSum_Click(object sender, EventArgs e)
        {
            op = "+";
            num = double.Parse(txtSc.Text);
            cl();
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            if (op == "mod")
            {
                txtSc.Text = (num % double.Parse(txtSc.Text)).ToString();
            }
            else if (op == "^")
            {
                double a = num;
                double b = double.Parse(txtSc.Text);
                txtSc.Text = (Math.Pow(a, b)).ToString();
            }
            else if (op == "÷")
            {
                txtSc.Text = (num / double.Parse(txtSc.Text)).ToString();
            }
            else if (op == "×")
            {
                txtSc.Text = (num * double.Parse(txtSc.Text)).ToString();
            }
            else if (op == "+")
            {
                txtSc.Text = (num + double.Parse(txtSc.Text)).ToString();
            }
            else if (op == "-")
            {
                txtSc.Text = (num - double.Parse(txtSc.Text)).ToString();
            }
        }

        private void FormProCal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = new DialogResult();
            d = MessageBox.Show("Do You Want To Exit The Program ?", "Close", MessageBoxButtons.YesNo);
            if (d == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}

