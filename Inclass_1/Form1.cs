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

namespace InClass1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            errorLabel.Text = string.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Text = string.Empty;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Text = string.Empty;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Text = string.Empty; 
        }

        private bool TryParseInput(string input, out double value)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                value = 0;
                return false;
            }

            var normalized = input.Replace(',', '.');
            return double.TryParse(normalized, NumberStyles.Any, CultureInfo.InvariantCulture, out value);
        }

        private void cıkarButton_Click(object sender, EventArgs e)
        {
            double a, b;
            if (!TryParseInput(textBox1.Text, out a))
            {
                errorLabel.Text = "Sayı 1 geçerli değil.";
                return;
            }

            if (!TryParseInput(textBox2.Text, out b))
            {
                errorLabel.Text = "Sayı 2 geçerli değil.";
                return;
            }

            label5.Text = "-";
            var result = a - b;
            resultLabel.Text = result.ToString();
            resultLabel.BackColor = result > 0 ? Color.SkyBlue: Color.Pink;
            errorLabel.Text = string.Empty;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void errorLabel_Click(object sender, EventArgs e)
        {
        }

        private void toplaButton_Click(object sender, EventArgs e)
        {
            double a, b;
            if (!TryParseInput(textBox1.Text, out a))
            {
                errorLabel.Text = "Sayı 1 geçerli değil.";
                return;
            }

            if (!TryParseInput(textBox2.Text, out b))
            {
                errorLabel.Text = "Sayı 2 geçerli değil.";
                return;
            }

            label5.Text = "+";
            var result = a + b;
            resultLabel.Text = result.ToString();
            resultLabel.BackColor = result > 0 ? Color.SkyBlue: Color.Pink;
            errorLabel.Text = string.Empty;
        }

        private void carpButton_Click(object sender, EventArgs e)
        {
            double a, b;
            if (!TryParseInput(textBox1.Text, out a))
            {
                errorLabel.Text = "Sayı 1 geçerli değil.";
                return;
            }

            if (!TryParseInput(textBox2.Text, out b))
            {
                errorLabel.Text = "Sayı 2 geçerli değil.";
                return;
            }

            label5.Text = "*";
            var result = a * b;
            resultLabel.Text = result.ToString();
            resultLabel.BackColor = result > 0 ? Color.SkyBlue : Color.Pink;
            errorLabel.Text = string.Empty;
        }

        private void bolButton_Click(object sender, EventArgs e)
        {
            double a, b;
            if (!TryParseInput(textBox1.Text, out a))
            {
                errorLabel.Text = "Sayı 1 geçerli değil.";
                return;
            }

            if (!TryParseInput(textBox2.Text, out b))
            {
                errorLabel.Text = "Sayı 2 geçerli değil.";
                return;
            }

            if (b == 0)
            {
                errorLabel.Text = "Sayı 2 sıfır olamaz.";
                return;
            }

            label5.Text = "/";
            var result = a / b;
            resultLabel.Text = result.ToString();
            resultLabel.BackColor = result > 0 ? Color.SkyBlue : Color.Pink;
            errorLabel.Text = string.Empty;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
                btn.ForeColor = Color.Red;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
                btn.ForeColor = SystemColors.ControlText;
        }
    }
}
