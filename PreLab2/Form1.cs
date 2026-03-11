using System;
using System.Linq;
using System.Windows.Forms;

namespace PreLab1
{
    public partial class Form1 : Form
    {
        int[] dizi; // Checkpoint 2: Array tanımı

        public Form1()
        {
            InitializeComponent();
            // Sayı kontrolü için event bağlama
            this.textBox1.KeyPress += textBox1_KeyPress;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Checkpoint 3: Buton metni güncelleme
            button1.Text = checkBox1.Checked ? "Generate and Calculate" : "Generate";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int boyut) && boyut > 0)
            {
                // Diziyi yeniden boyutlandır ve listeyi temizle
                dizi = new int[boyut];
                listBox1.Items.Clear();
                double toplam = 0;

                for (int i = 0; i < boyut; i++)
                {
                    dizi[i] = i + 1;
                    listBox1.Items.Add(dizi[i]);
                    toplam += dizi[i];
                }

                // Ortalama hesabı ve label güncelleme
                if (checkBox1.Checked)
                {
                    double ortalama = toplam / boyut;
                    labelAverage.Text = "AVERAGE: " + ortalama.ToString();
                }
                else
                {
                    labelAverage.Text = "AVERAGE: -";
                }
            }
            else
            {
                MessageBox.Show("Geçerli bir sayı girin!");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Checkpoint 1: Sadece rakam girişi
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Kullanılmayan metodlar
        private void label1_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}