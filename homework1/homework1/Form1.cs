using System;
using System.Drawing;
using System.Windows.Forms;

namespace homework1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rb_ceaser_CheckedChanged(object sender, EventArgs e)
        {
            lb_ciipher.Visible = rb_ceaser.Checked;
            tb_cipher.Visible = rb_ceaser.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lb_stat.TextAlign = ContentAlignment.MiddleCenter;

            if (string.IsNullOrWhiteSpace(tb_pwd.Text))
            {
                UpdateStatus(false);
                lb_result.Text = "Error: Input text is empty.";
                return;
            }

            int shift = 0;

            if (rb_rot2.Checked)
            {
                shift = 2;
            }
            else if (rb_ceaser.Checked)
            {
                if (string.IsNullOrWhiteSpace(tb_cipher.Text))
                {
                    shift = 1;
                }
                else if (!int.TryParse(tb_cipher.Text, out shift))
                {
                    UpdateStatus(false);
                    lb_result.Text = "Error: Invalid shift character.";
                    return;
                }
            }
            else
            {
                UpdateStatus(false);
                lb_result.Text = "Error: Select a cipher method.";
                return;
            }

            lb_result.Text = "Result: " + ApplyCipher(tb_pwd.Text, shift);
            UpdateStatus(true);
        }

        private string ApplyCipher(string input, int shift)
        {
            char[] buffer = input.ToCharArray();

            for (int i = 0; i < buffer.Length; i++)
            {
                char c = buffer[i];

                if (char.IsLetter(c))
                {
                    char offset = char.IsUpper(c) ? 'A' : 'a';
                    buffer[i] = (char)((((c + shift - offset) % 26) + 26) % 26 + offset);
                }
                else if (char.IsDigit(c))
                {
                    int x = c - '0';
                    int result = (2 * x * x * x) - (7 * x) + 6;
                    buffer[i] = (char)((result % 10) + '0');
                }
            }

            return new string(buffer);
        }

        private void UpdateStatus(bool isSuccess)
        {
            if (isSuccess)
            {
                lb_stat.Text = "SUCCESS";
                lb_stat.BackColor = Color.LightGreen;
            }
            else
            {
                lb_stat.Text = "FAILED";
                lb_stat.BackColor = Color.LightSalmon;
            }
        }
    }
}