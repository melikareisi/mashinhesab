using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mashin_hesab
{
    public partial class Form1 : Form
    {
        string op;
        string A2 = "";
        string A1 = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            op = button_times.Text;
            txt_res.Text = txt_res.Text + "*";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_res.Text == "0")
                txt_res.Clear();

            txt_res.Text = txt_res.Text + button1.Text;
            if (button_plus.Enabled == true || button_mines.Enabled==true || button_times.Enabled==true || button_division.Enabled==true)
            {
                A2 = A2 + 1 ;
            }
            else
            {
                A1 = A1 + 1 ;
            }
        }

        private void text_res_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_res.Text == "0")
                txt_res.Clear();

            txt_res.Text = txt_res.Text + button2.Text;
            if (button_plus.Enabled == true || button_mines.Enabled == true || button_times.Enabled == true || button_division.Enabled == true)
            {
                A2 = A2 + 2 ;
            }
            else
            {
                A1 = A1 + 2 ;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txt_res.Text == "0")
                txt_res.Clear();

            txt_res.Text = txt_res.Text + button3.Text;
            if (button_plus.Enabled == true || button_mines.Enabled == true || button_times.Enabled == true || button_division.Enabled == true)
            {
                A2 = A2 + 3 ;
            }
            else
            {
                A1 = A1 + 3 ;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txt_res.Text == "0")
                txt_res.Clear();

            txt_res.Text = txt_res.Text + button4.Text;
            if (button_plus.Enabled == true || button_mines.Enabled == true || button_times.Enabled == true || button_division.Enabled == true)
            {
                A2 = A2 + 4 ;
            }
            else
            {
                A1 = A1 + 4 ;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txt_res.Text == "0")
                txt_res.Clear();

            txt_res.Text = txt_res.Text + button5.Text;
            if (button_plus.Enabled == true || button_mines.Enabled == true || button_times.Enabled == true || button_division.Enabled == true)
            {
                A2 = A2 + 5 ;
            }
            else
            {
                A1 = A1 + 5 ;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txt_res.Text == "0")
                txt_res.Clear();

            txt_res.Text = txt_res.Text + button6.Text;
            if (button_plus.Enabled == true || button_mines.Enabled == true || button_times.Enabled == true || button_division.Enabled == true)
            {
                A2 = A2 + 6 ;
            }
            else
            {
                A1 = A1 + 6 ;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txt_res.Text == "0")
                txt_res.Clear();

            txt_res.Text = txt_res.Text + button7.Text;
            if (button_plus.Enabled == true || button_mines.Enabled == true || button_times.Enabled == true || button_division.Enabled == true)
            {
                A2 = A2 + 7 ;
            }
            else
            {
                A1 = A1 + 7 ;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txt_res.Text == "0")
                txt_res.Clear();

            txt_res.Text = txt_res.Text + button8.Text;
            if (button_plus.Enabled == true || button_mines.Enabled == true || button_times.Enabled == true || button_division.Enabled == true)
            {
                A2 = A2 + 8 ;
            }
            else
            {
                A1 = A1 + 8 ;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txt_res.Text == "0")
                txt_res.Clear();

            txt_res.Text = txt_res.Text + button9.Text;
            if (button_plus.Enabled == true || button_mines.Enabled == true || button_times.Enabled == true || button_division.Enabled == true)
            {
                 A2 = A2 + 9 ;
            }
            else
            {
                A1 = A1 + 9 ;
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (txt_res.Text == "0")
                txt_res.Clear();

            txt_res.Text = txt_res.Text + button0.Text;
            if (button_plus.Enabled == true || button_mines.Enabled == true || button_times.Enabled == true || button_division.Enabled == true)
            {
                A2 = A2 + 0 ;
            }
            else
            {
                A1 = A1 + 0 ;
            }
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            op = button_plus.Text;
            txt_res.Text = txt_res.Text + "+"; 
        }

        private void button_mines_Click(object sender, EventArgs e)
        {
            op = button_mines.Text;
            txt_res.Text = txt_res.Text + "-";
        }

        private void button_division_Click(object sender, EventArgs e)
        {
            op = button_division.Text;
            txt_res.Text = txt_res.Text + "/";
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            txt_res.Text = "0";
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case "+":
                    int result = int.Parse(A1) + int.Parse(A2);
                    txt_res.Text = result.ToString();
                    break;
                case "-":
                    int result2 = int.Parse(A1) - int.Parse(A2);
                    txt_res.Text = result2.ToString();
                    break;
                case "*":
                    int result3 = int.Parse(A1) * int.Parse(A2);
                    txt_res.Text = result3.ToString();
                    break;
                case "/":
                    int result4 = int.Parse(A1) / int.Parse(A2);
                    txt_res.Text = result4.ToString();
                    break;
            }
        }
    }
}
