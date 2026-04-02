namespace InClass_4
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
            this.lblIsim = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grpShoe = new System.Windows.Forms.GroupBox();
            this.lstShoeModel = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpShoeSize = new System.Windows.Forms.GroupBox();
            this.chk44 = new System.Windows.Forms.CheckBox();
            this.chk43 = new System.Windows.Forms.CheckBox();
            this.chk42 = new System.Windows.Forms.CheckBox();
            this.chk41 = new System.Windows.Forms.CheckBox();
            this.chk40 = new System.Windows.Forms.CheckBox();
            this.chk39 = new System.Windows.Forms.CheckBox();
            this.chk38 = new System.Windows.Forms.CheckBox();
            this.grpShipping = new System.Windows.Forms.GroupBox();
            this.cmbDistrict = new System.Windows.Forms.ComboBox();
            this.cmbProvince = new System.Windows.Forms.ComboBox();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.grpOrders = new System.Windows.Forms.GroupBox();
            this.lstOrders = new System.Windows.Forms.ListBox();
            this.grpInfo.SuspendLayout();
            this.grpShoe.SuspendLayout();
            this.grpShoeSize.SuspendLayout();
            this.grpShipping.SuspendLayout();
            this.grpOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Location = new System.Drawing.Point(21, 62);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(120, 20);
            this.lblIsim.TabIndex = 0;
            this.lblIsim.Text = "Name Surname";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(21, 101);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(55, 20);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "Phone";
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.textBox2);
            this.grpInfo.Controls.Add(this.textBox1);
            this.grpInfo.Controls.Add(this.lblPhone);
            this.grpInfo.Controls.Add(this.lblIsim);
            this.grpInfo.Location = new System.Drawing.Point(28, 42);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(355, 174);
            this.grpInfo.TabIndex = 2;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Customer Information";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(156, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(193, 26);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 26);
            this.textBox1.TabIndex = 2;
            // 
            // grpShoe
            // 
            this.grpShoe.Controls.Add(this.lstShoeModel);
            this.grpShoe.Location = new System.Drawing.Point(28, 222);
            this.grpShoe.Name = "grpShoe";
            this.grpShoe.Size = new System.Drawing.Size(355, 210);
            this.grpShoe.TabIndex = 3;
            this.grpShoe.TabStop = false;
            this.grpShoe.Text = "Shoe Model Selection";
            // 
            // lstShoeModel
            // 
            this.lstShoeModel.FormattingEnabled = true;
            this.lstShoeModel.ItemHeight = 20;
            this.lstShoeModel.Location = new System.Drawing.Point(6, 44);
            this.lstShoeModel.Name = "lstShoeModel";
            this.lstShoeModel.Size = new System.Drawing.Size(317, 84);
            this.lstShoeModel.TabIndex = 0;
            // 
            // grpShoeSize
            // 
            this.grpShoeSize.Controls.Add(this.chk44);
            this.grpShoeSize.Controls.Add(this.chk43);
            this.grpShoeSize.Controls.Add(this.chk42);
            this.grpShoeSize.Controls.Add(this.chk41);
            this.grpShoeSize.Controls.Add(this.chk40);
            this.grpShoeSize.Controls.Add(this.chk39);
            this.grpShoeSize.Controls.Add(this.chk38);
            this.grpShoeSize.Location = new System.Drawing.Point(389, 43);
            this.grpShoeSize.Name = "grpShoeSize";
            this.grpShoeSize.Size = new System.Drawing.Size(350, 173);
            this.grpShoeSize.TabIndex = 4;
            this.grpShoeSize.TabStop = false;
            this.grpShoeSize.Text = "Shoe Size Selection";
            // 
            // chk44
            // 
            this.chk44.AutoSize = true;
            this.chk44.Location = new System.Drawing.Point(89, 109);
            this.chk44.Name = "chk44";
            this.chk44.Size = new System.Drawing.Size(53, 24);
            this.chk44.TabIndex = 6;
            this.chk44.Text = "44";
            this.chk44.UseVisualStyleBackColor = true;
            // 
            // chk43
            // 
            this.chk43.AutoSize = true;
            this.chk43.Location = new System.Drawing.Point(30, 109);
            this.chk43.Name = "chk43";
            this.chk43.Size = new System.Drawing.Size(53, 24);
            this.chk43.TabIndex = 5;
            this.chk43.Text = "43";
            this.chk43.UseVisualStyleBackColor = true;
            // 
            // chk42
            // 
            this.chk42.AutoSize = true;
            this.chk42.Location = new System.Drawing.Point(266, 69);
            this.chk42.Name = "chk42";
            this.chk42.Size = new System.Drawing.Size(53, 24);
            this.chk42.TabIndex = 4;
            this.chk42.Text = "42";
            this.chk42.UseVisualStyleBackColor = true;
            // 
            // chk41
            // 
            this.chk41.AutoSize = true;
            this.chk41.Location = new System.Drawing.Point(207, 69);
            this.chk41.Name = "chk41";
            this.chk41.Size = new System.Drawing.Size(53, 24);
            this.chk41.TabIndex = 3;
            this.chk41.Text = "41";
            this.chk41.UseVisualStyleBackColor = true;
            // 
            // chk40
            // 
            this.chk40.AutoSize = true;
            this.chk40.Location = new System.Drawing.Point(148, 69);
            this.chk40.Name = "chk40";
            this.chk40.Size = new System.Drawing.Size(53, 24);
            this.chk40.TabIndex = 2;
            this.chk40.Text = "40";
            this.chk40.UseVisualStyleBackColor = true;
            // 
            // chk39
            // 
            this.chk39.AutoSize = true;
            this.chk39.Location = new System.Drawing.Point(89, 69);
            this.chk39.Name = "chk39";
            this.chk39.Size = new System.Drawing.Size(53, 24);
            this.chk39.TabIndex = 1;
            this.chk39.Text = "39";
            this.chk39.UseVisualStyleBackColor = true;
            // 
            // chk38
            // 
            this.chk38.AutoSize = true;
            this.chk38.Location = new System.Drawing.Point(30, 69);
            this.chk38.Name = "chk38";
            this.chk38.Size = new System.Drawing.Size(53, 24);
            this.chk38.TabIndex = 0;
            this.chk38.Text = "38";
            this.chk38.UseVisualStyleBackColor = true;
            // 
            // grpShipping
            // 
            this.grpShipping.Controls.Add(this.cmbDistrict);
            this.grpShipping.Controls.Add(this.cmbProvince);
            this.grpShipping.Controls.Add(this.lblDistrict);
            this.grpShipping.Controls.Add(this.lblProvince);
            this.grpShipping.Location = new System.Drawing.Point(389, 222);
            this.grpShipping.Name = "grpShipping";
            this.grpShipping.Size = new System.Drawing.Size(350, 151);
            this.grpShipping.TabIndex = 5;
            this.grpShipping.TabStop = false;
            this.grpShipping.Text = "Shipping Address";
            // 
            // cmbDistrict
            // 
            this.cmbDistrict.FormattingEnabled = true;
            this.cmbDistrict.Location = new System.Drawing.Point(136, 84);
            this.cmbDistrict.Name = "cmbDistrict";
            this.cmbDistrict.Size = new System.Drawing.Size(90, 28);
            this.cmbDistrict.TabIndex = 5;
            // 
            // cmbProvince
            // 
            this.cmbProvince.FormattingEnabled = true;
            this.cmbProvince.Location = new System.Drawing.Point(18, 84);
            this.cmbProvince.Name = "cmbProvince";
            this.cmbProvince.Size = new System.Drawing.Size(90, 28);
            this.cmbProvince.TabIndex = 4;
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Location = new System.Drawing.Point(132, 44);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(58, 20);
            this.lblDistrict.TabIndex = 1;
            this.lblDistrict.Text = "District";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(14, 44);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(69, 20);
            this.lblProvince.TabIndex = 0;
            this.lblProvince.Text = "Province";
            // 
            // btnCreate
            // 
            this.btnCreate.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.btnCreate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(389, 379);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(291, 62);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create Order";
            this.btnCreate.UseVisualStyleBackColor = false;
            // 
            // grpOrders
            // 
            this.grpOrders.Controls.Add(this.lstOrders);
            this.grpOrders.Location = new System.Drawing.Point(28, 438);
            this.grpOrders.Name = "grpOrders";
            this.grpOrders.Size = new System.Drawing.Size(735, 146);
            this.grpOrders.TabIndex = 7;
            this.grpOrders.TabStop = false;
            this.grpOrders.Text = "Created Orders";
            // 
            // lstOrders
            // 
            this.lstOrders.FormattingEnabled = true;
            this.lstOrders.ItemHeight = 20;
            this.lstOrders.Location = new System.Drawing.Point(25, 39);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(663, 104);
            this.lstOrders.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 611);
            this.Controls.Add(this.grpOrders);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.grpShipping);
            this.Controls.Add(this.grpShoeSize);
            this.Controls.Add(this.grpShoe);
            this.Controls.Add(this.grpInfo);
            this.Name = "Form1";
            this.Text = "Shoe Ordering System";
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.grpShoe.ResumeLayout(false);
            this.grpShoeSize.ResumeLayout(false);
            this.grpShoeSize.PerformLayout();
            this.grpShipping.ResumeLayout(false);
            this.grpShipping.PerformLayout();
            this.grpOrders.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblIsim;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox grpShoe;
        private System.Windows.Forms.ListBox lstShoeModel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpShoeSize;
        private System.Windows.Forms.CheckBox chk44;
        private System.Windows.Forms.CheckBox chk43;
        private System.Windows.Forms.CheckBox chk42;
        private System.Windows.Forms.CheckBox chk41;
        private System.Windows.Forms.CheckBox chk40;
        private System.Windows.Forms.CheckBox chk39;
        private System.Windows.Forms.CheckBox chk38;
        private System.Windows.Forms.GroupBox grpShipping;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.ComboBox cmbDistrict;
        private System.Windows.Forms.ComboBox cmbProvince;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox grpOrders;
        private System.Windows.Forms.ListBox lstOrders;
    }
}

