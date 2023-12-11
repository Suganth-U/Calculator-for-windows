using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double valueResult;
        string perfomed;
        bool isperfomed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if (txt_result.Text == "0" || (isperfomed))
                txt_result.Clear();

            isperfomed = false;
            Button button = (Button)sender;
            if(button.Text == ".") {
                if (!txt_result.Text.Contains("."))
                    txt_result.Text += button.Text;
            }
            else
            {
                txt_result.Text += button.Text;
            }
        }

        private void click_operations(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            perfomed = button.Text;
            valueResult = double.Parse(txt_result.Text);
            lbl_displayValue.Text = valueResult + " " + perfomed;
            isperfomed = true;
        }

        private void btn_ac_Click(object sender, EventArgs e)
        {
            txt_result.Text = "0";
        }

        private void btn_eql_Click(object sender, EventArgs e)
        {
            if (perfomed == "+")
            {
                txt_result.Text = (valueResult + double.Parse(txt_result.Text)).ToString();
            }
            else if (perfomed == "-")
            {
                txt_result.Text = (valueResult - double.Parse(txt_result.Text)).ToString();
            }
            else if (perfomed == "x")
            {
                txt_result.Text = (valueResult * double.Parse(txt_result.Text)).ToString();
            }
            else
            {
                txt_result.Text = (valueResult / double.Parse(txt_result.Text)).ToString();
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if(txt_result.Text.Length > 0) 
                txt_result.Text = txt_result.Text.Remove(txt_result.Text.Length -1,1);
            
            if(txt_result.Text == "")
            {
                txt_result.Text = "0";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
