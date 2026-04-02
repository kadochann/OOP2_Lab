using System;
using System.Windows.Forms;

namespace InClass_4
{
    public partial class Form1 : Form
    {
        private string[] provinces;
        private string[][] districts;
        private string[] shoeName;

        public Form1()
        {
            InitializeComponent();
            InitializeData(); // Fixed: Added missing method call
        }

        private void InitializeData()
        {
            shoeName = new string[]
            {
                "Nike Air Max 90",
                "Nike Air Max 91",
                "Kinetix Junior",
                "Nike Air Max 74",
                "Nike Air Max 75"
            };

            lstShoeModel.Items.AddRange(shoeName); // Fixed: Added shoes to ListBox

            provinces = new string[]
            {
                "İstanbul",
                "Ankara",
                "Eskişehir",
                "İzmir"
            };

            districts = new string[][]
            {
                new string[] { "Kadıköy", "Beşiktaş", "Şişli", "Üsküdar", "Maltepe" },
                new string[] { "Çankaya", "Keçiören", "Yenimahalle", "Mamak" },
                new string[] { "Odunpazarı", "Tepebaşı", "Sivrihisar" },
                new string[] { "Bornova", "Karşıyaka", "Konak", "Buca" }
            };

            cmbProvince.Items.Clear();
            cmbProvince.Items.AddRange(provinces);

            cmbProvince.SelectedIndexChanged += CmbProvince_SelectedIndexChanged;
            btnCreate.Click += BtnCreate_Click;
        }

        // Fixed: Implemented missing event handler
        private void CmbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cmbProvince.SelectedIndex;

            if (selectedIndex == -1) return;

            cmbDistrict.Items.Clear();
            cmbDistrict.Text = "";
            cmbDistrict.Items.AddRange(districts[selectedIndex]);
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            string customerName = textBox1.Text.Trim();
            string customerPhone = textBox2.Text.Trim();

            string shoeModel = lstShoeModel.SelectedItem != null ? lstShoeModel.SelectedItem.ToString() : "Not Selected";

            string shoeSize = "Not Selected";
            if (chk38.Checked) shoeSize = "38";
            else if (chk39.Checked) shoeSize = "39";
            else if (chk40.Checked) shoeSize = "40";
            else if (chk41.Checked) shoeSize = "41";
            else if (chk42.Checked) shoeSize = "42";
            else if (chk43.Checked) shoeSize = "43";
            else if (chk44.Checked) shoeSize = "44";

            string province = cmbProvince.SelectedItem != null ? cmbProvince.SelectedItem.ToString() : "-";
            string districtStr = cmbDistrict.SelectedItem != null ? cmbDistrict.SelectedItem.ToString() : "-";

            if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(customerPhone))
            {
                MessageBox.Show("Name and Phone fields cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string orderRecord = $"{customerName} - {customerPhone} | Model: {shoeModel} | Size: {shoeSize} | Address: {province}/{districtStr}";

            lstOrders.Items.Add(orderRecord);
        }
    }
}