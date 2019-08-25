using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class formCalulator : Form
    {
        public formCalulator()
        {
            InitializeComponent();
        }

        public string expression = "";
        public string savedValue = "";

        public bool inputValidation()
        {
            if (expression.Length > 0)
            {
                return true;
            }
            return false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            expression = expression + '2';
            txtCalcArea.Text = expression;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            expression = expression + '1';
            txtCalcArea.Text = expression;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            expression = expression + '3';
            txtCalcArea.Text = expression;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if(expression != "+" && expression != "-")
            {
                expression = expression + '+';
                txtCalcArea.Text = expression;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            expression = expression + '4';
            txtCalcArea.Text = expression;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            expression = expression + '5';
            txtCalcArea.Text = expression;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            expression = expression + '6';
            txtCalcArea.Text = expression;
        }

        private void ButtonSub_Click(object sender, EventArgs e)
        {
            if(expression!="+" && expression != "-")
            {
                expression = expression + '-';
                txtCalcArea.Text = expression;
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            expression = expression + '7';
            txtCalcArea.Text = expression;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            expression = expression + '8';
            txtCalcArea.Text = expression;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            expression = expression + '9';
            txtCalcArea.Text = expression;
        }

        private void ButtonMult_Click(object sender, EventArgs e)
        {
            bool c = inputValidation();
            if (c)
            {
                expression = expression + '*';
                txtCalcArea.Text = expression;
            }
        }

        private void ButtonPoint_Click(object sender, EventArgs e)
        {
            expression = expression + '.';
            txtCalcArea.Text = expression;
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            expression = expression + '0';
            txtCalcArea.Text = expression;
        }

        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            if (expression == "")
            {
                return;
            }
            double result = Convert.ToDouble(new DataTable().Compute(expression, null));
            txtAnsArea.Text = result.ToString();
        }

        private void ButtonDiv_Click(object sender, EventArgs e)
        {
            bool c = inputValidation();
            if (c)
            {
                expression = expression + '/';
                txtCalcArea.Text = expression;
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            savedValue = txtAnsArea.Text;
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            expression = "";
            txtCalcArea.Text = "";
            txtAnsArea.Text = "";
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            expression = savedValue;
            txtCalcArea.Text = expression;
            txtAnsArea.Text = "";
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            if (expression.Length > 0)
            {
                expression = expression.Remove(expression.Length - 1);
                txtCalcArea.Text = expression;
            }
        }
    }
}
