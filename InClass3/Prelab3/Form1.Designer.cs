namespace Prelab3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblClock = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.btnColorPicker = new System.Windows.Forms.Button();
            this.cmbTimeZones = new System.Windows.Forms.ComboBox();
            this.clbTimeZones = new System.Windows.Forms.CheckedListBox();
            this.txtTimeZoneName = new System.Windows.Forms.TextBox();
            this.btnAddZone = new System.Windows.Forms.Button();
            this.btnDeleteZone = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblClock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.Location = new System.Drawing.Point(53, 78);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(286, 75);
            this.lblClock.TabIndex = 0;
            this.lblClock.Text = "00:00:00";
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "hh:mm:ss";
            this.dtpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTime.Location = new System.Drawing.Point(49, 229);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(142, 31);
            this.dtpTime.TabIndex = 1;
            this.dtpTime.Value = new System.DateTime(2026, 3, 25, 23, 14, 0, 0);
            // 
            // btnColorPicker
            // 
            this.btnColorPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColorPicker.Location = new System.Drawing.Point(100, 266);
            this.btnColorPicker.Name = "btnColorPicker";
            this.btnColorPicker.Size = new System.Drawing.Size(179, 31);
            this.btnColorPicker.TabIndex = 2;
            this.btnColorPicker.Text = "Pick Color For PM";
            this.btnColorPicker.UseVisualStyleBackColor = true;
            // 
            // cmbTimeZones
            // 
            this.cmbTimeZones.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTimeZones.FormattingEnabled = true;
            this.cmbTimeZones.Location = new System.Drawing.Point(197, 229);
            this.cmbTimeZones.Name = "cmbTimeZones";
            this.cmbTimeZones.Size = new System.Drawing.Size(149, 33);
            this.cmbTimeZones.TabIndex = 3;
            // 
            // clbTimeZones
            // 
            this.clbTimeZones.FormattingEnabled = true;
            this.clbTimeZones.Location = new System.Drawing.Point(374, 30);
            this.clbTimeZones.Name = "clbTimeZones";
            this.clbTimeZones.Size = new System.Drawing.Size(269, 154);
            this.clbTimeZones.TabIndex = 4;
            // 
            // txtTimeZoneName
            // 
            this.txtTimeZoneName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeZoneName.Location = new System.Drawing.Point(374, 233);
            this.txtTimeZoneName.Name = "txtTimeZoneName";
            this.txtTimeZoneName.Size = new System.Drawing.Size(269, 31);
            this.txtTimeZoneName.TabIndex = 5;
            this.txtTimeZoneName.Tag = "";
            // 
            // btnAddZone
            // 
            this.btnAddZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddZone.Location = new System.Drawing.Point(374, 270);
            this.btnAddZone.Name = "btnAddZone";
            this.btnAddZone.Size = new System.Drawing.Size(130, 31);
            this.btnAddZone.TabIndex = 6;
            this.btnAddZone.Text = "Add Zone";
            this.btnAddZone.UseVisualStyleBackColor = true;
            // 
            // btnDeleteZone
            // 
            this.btnDeleteZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteZone.Location = new System.Drawing.Point(515, 270);
            this.btnDeleteZone.Name = "btnDeleteZone";
            this.btnDeleteZone.Size = new System.Drawing.Size(128, 31);
            this.btnDeleteZone.TabIndex = 7;
            this.btnDeleteZone.Text = "Delete Zone";
            this.btnDeleteZone.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select Zone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(370, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "New Zone Name:";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Crimson;
            this.lblError.Location = new System.Drawing.Point(49, 323);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 20);
            this.lblError.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(722, 383);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteZone);
            this.Controls.Add(this.btnAddZone);
            this.Controls.Add(this.txtTimeZoneName);
            this.Controls.Add(this.clbTimeZones);
            this.Controls.Add(this.cmbTimeZones);
            this.Controls.Add(this.btnColorPicker);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.lblClock);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Button btnColorPicker;
        private System.Windows.Forms.ComboBox cmbTimeZones;
        private System.Windows.Forms.CheckedListBox clbTimeZones;
        private System.Windows.Forms.TextBox txtTimeZoneName;
        private System.Windows.Forms.Button btnAddZone;
        private System.Windows.Forms.Button btnDeleteZone;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblError;
    }
}

