using System;
using System.Windows.Forms;

namespace PreLab1
{
    public partial class Form1 : Form
    {
        int[] dizi;

        public Form1()
        {
            InitializeComponent();

            this.textBox1.KeyPress += textBox1_KeyPress;

            // Checkbox başlangıçta işaretli 
            checkBox1.Checked = true;
            button1.Text = "Generate and Calculate";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Text = checkBox1.Checked ? "Generate and Calculate" : "Generate";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                // İşaretlendiğinde değeri 10 yap ve inputu kilitle
                textBox1.Text = "10";
                textBox1.ReadOnly = true;
                textBox1.Enabled = false;
            }
            else
            {
                // İşaret kaldırıldığında input kilidini aç
                textBox1.ReadOnly = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int boyut) && boyut > 0)
            {
                dizi = new int[3];
                dizi[0] = 0;
                dizi[1] = 1;
                dizi[2] = 1;

                Array.Resize(ref dizi, boyut);

                for (int i = 2; i < boyut; i++)
                {
                    dizi[i] = dizi[i - 1] + dizi[i - 2];
                }

                textBoxOutput.Clear();
                double toplam = 0;

                for (int i = 0; i < boyut; i++)
                {
                    textBoxOutput.AppendText(dizi[i].ToString() + Environment.NewLine);
                    toplam += dizi[i];
                }

                if (checkBox1.Checked)
                {
                    double ortalama = toplam / boyut;
                    labelAverage.Text = "AVERAGE: " + ortalama.ToString("F2");
                }
                else
                {
                    labelAverage.Text = "AVERAGE: -";
                }
            }
            else
            {
                MessageBox.Show("Lütfen terim sayısı (N) için geçerli ve pozitif bir tam sayı girin!", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}