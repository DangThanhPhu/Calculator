using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcuator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string sign;
        double value1;
        double value2;
        int trackkeypoint = 0;

        private void btnresult_Click(object sender, EventArgs e)
        {
            value2 = double.Parse(txtresult.Text);
            double result;
            if(sign == "+")
            {
                result = value1 + value2;
                txtresult.Text = result.ToString();
            }
            else if (sign == "-")
            {
                result = value1 - value2;
                txtresult.Text = result.ToString();
            }
            else if (sign == "x")
            {
                result = value1 * value2;
                txtresult.Text = result.ToString();
            }
            else if (sign == "/")
            {
                result = value1 / value2;
                txtresult.Text = result.ToString();
            }


        }

        private void btncong_Click(object sender, EventArgs e)
        {
            sign = "+";
            value1 = double.Parse(txtresult.Text);
            txtresult.Text = "";
            txtresult.Focus();
        }

        private void btntru_Click(object sender, EventArgs e)
        {
            sign = "-";
            value1 = double.Parse(txtresult.Text);
            txtresult.Text = "";
            txtresult.Focus();
        }

        private void btnnhan_Click(object sender, EventArgs e)
        {
            sign = "x";
            value1 = double.Parse(txtresult.Text);
            txtresult.Text = "";
            txtresult.Focus();
        }

        private void btnchia_Click(object sender, EventArgs e)
        {
            sign = "/";
            value1 = double.Parse(txtresult.Text);
            txtresult.Text = "";
            txtresult.Focus();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtresult.Text = "";
            value1 = 0;
            value2 = 0;
            sign = "";
            txtresult.Focus();
        }

        private void btngiaithua_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(txtgtn.Text);
            txtresultgt.Text = giaithua(n).ToString();

        }

        private double giaithua(int n)
        {
            if (n == 1)
                return 1;
            return n * giaithua(n - 1);
        }

        private void txtresult_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keycode;
            keycode = e.KeyChar;
            if (keycode >= 48 && keycode <= 57 || keycode == 8 || keycode == 32 || keycode == 46)
            {
                if (keycode == 46) ++trackkeypoint;
                if (trackkeypoint > 1) { e.Handled = true; --trackkeypoint; }
            }
            else e.Handled = true;
        }

        private void txtgtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keycode;
            keycode = e.KeyChar;
            if (keycode >= 48 && keycode <= 57 || keycode == 8 || keycode == 32 || keycode == 46)
            {
                if (keycode == 46) ++trackkeypoint;
                if (trackkeypoint > 1) { e.Handled = true; --trackkeypoint; }
            }
            else e.Handled = true;
        }

        private void txtresultgt_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keycode;
            keycode = e.KeyChar;
            if (keycode >= 48 && keycode <= 57 || keycode == 8 || keycode == 32 || keycode == 46)
            {
                if (keycode == 46) ++trackkeypoint;
                if (trackkeypoint > 1) { e.Handled = true; --trackkeypoint; }
            }
            else e.Handled = true;
        }
    }
}
