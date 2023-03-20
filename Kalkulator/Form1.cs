using System.Data;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool checkChar()
        {
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "1";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "+";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + ".";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "/";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "*";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0)
            {
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
            }
            else
            { }
        }
        private void button18_Click(object sender, EventArgs e)
        {
            string pattern = "^(-?\\d+(.\\d+)?)(\\s*[\\+\\-\\*\\/]\\s*-?\\d+(.\\d+)?)*$";
            Regex rg = new Regex(pattern);
            if (rg.IsMatch(textBox2.Text))
            {
                DataTable dt = new DataTable();
                StringBuilder sb = new StringBuilder();
                try
                {
                    textBox1.Text = sb.Append(dt.Compute(textBox2.Text, "")).ToString();
                }
                catch (DivideByZeroException)
                {
                    textBox1.Text = "∞";
                }
                catch(OverflowException)
                {
                    MessageBox.Show("Za dużo byś chciał :(");
                }
            }
            else
            {
                MessageBox.Show("Nieprawidłowy wzór");
            }
        }

    }
}