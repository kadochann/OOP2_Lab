using System;
using System.Drawing;
using System.Windows.Forms;

namespace Prelab3
{
    public partial class Form1 : Form
    {
        private Color userDayColor = Color.Black;
        private DateTime currentTime;

        private int currentOffset = 0;

        public Form1()
        {
            InitializeComponent();

            timer1.Tick += timer1_Tick;
            dtpTime.ValueChanged += dtpTime_ValueChanged;
            btnColorPicker.Click += btnColorPicker_Click;
            btnAddZone.Click += btnAddZone_Click;
            btnDeleteZone.Click += btnDeleteZone_Click;
            cmbTimeZones.SelectedIndexChanged += cmbTimeZones_SelectedIndexChanged;

            InitializeCustomSettings();
        }

        private void InitializeCustomSettings()
        {
            currentTime = DateTime.Now;

            dtpTime.Format = DateTimePickerFormat.Time;
            dtpTime.ShowUpDown = true;

            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentTime = currentTime.AddSeconds(1);
            UpdateClockUI();
        }

        private void UpdateClockUI()
        {
            lblClock.Text = currentTime.ToString("HH:mm:ss");

            TimeSpan time = currentTime.TimeOfDay;
            TimeSpan dayStart = new TimeSpan(10, 0, 0);
            TimeSpan dayEnd = new TimeSpan(23, 0, 0);

            if (time >= dayStart && time < dayEnd)
            {
                lblClock.ForeColor = userDayColor;
            }
            else
            {
                lblClock.ForeColor = Color.Green;
            }
        }

        private void dtpTime_ValueChanged(object sender, EventArgs e)
        {
            currentTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day,
                                       dtpTime.Value.Hour, dtpTime.Value.Minute, dtpTime.Value.Second);
            UpdateClockUI();
        }

        private void btnColorPicker_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    userDayColor = colorDialog.Color;
                    UpdateClockUI();
                }
            }
        }

        private void btnAddZone_Click(object sender, EventArgs e)
        {
            string newZone = txtTimeZoneName.Text.Trim();
            if (string.IsNullOrEmpty(newZone)) return;

            if (!newZone.Contains("+") && !newZone.Contains("-"))
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = "Invalid format. Use format like 'Tokyo +9' or 'London -1'.";
                return;
            }

            cmbTimeZones.Items.Add(newZone);
            clbTimeZones.Items.Add(newZone);

            lblError.ForeColor = Color.DarkGreen;
            lblError.Text = "Time zone added successfully.";

            txtTimeZoneName.Clear();
        }

        private void btnDeleteZone_Click(object sender, EventArgs e)
        {
            for (int i = clbTimeZones.CheckedIndices.Count - 1; i >= 0; i--)
            {
                int index = clbTimeZones.CheckedIndices[i];
                cmbTimeZones.Items.RemoveAt(index);
                clbTimeZones.Items.RemoveAt(index);
            }
        }

        private void cmbTimeZones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTimeZones.SelectedItem == null) return;

            string selectedZone = cmbTimeZones.SelectedItem.ToString();
            int parsedOffset = 0;

            int startIndex = selectedZone.IndexOf('+');
            if (startIndex == -1) startIndex = selectedZone.IndexOf('-');

            if (startIndex != -1)
            {
                string offsetStr = selectedZone.Substring(startIndex);
                int.TryParse(offsetStr, out parsedOffset);
            }

            int diff = parsedOffset - currentOffset;
            currentTime = currentTime.AddHours(diff);
            currentOffset = parsedOffset;

            UpdateClockUI();
        }
    }
}