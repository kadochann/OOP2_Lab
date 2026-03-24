namespace homework1
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
            this.tb_pwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_cipher = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_stat = new System.Windows.Forms.Label();
            this.lb_result = new System.Windows.Forms.Label();
            this.lb_ciipher = new System.Windows.Forms.Label();
            this.rb_rot2 = new System.Windows.Forms.RadioButton();
            this.rb_ceaser = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // tb_pwd
            // 
            this.tb_pwd.Location = new System.Drawing.Point(33, 50);
            this.tb_pwd.Margin = new System.Windows.Forms.Padding(4);
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.PasswordChar = '*';
            this.tb_pwd.Size = new System.Drawing.Size(188, 26);
            this.tb_pwd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password:";
            // 
            // tb_cipher
            // 
            this.tb_cipher.Location = new System.Drawing.Point(33, 122);
            this.tb_cipher.Name = "tb_cipher";
            this.tb_cipher.Size = new System.Drawing.Size(188, 26);
            this.tb_cipher.TabIndex = 4;
            this.tb_cipher.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Encrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_stat
            // 
            this.lb_stat.AutoSize = true;
            this.lb_stat.Location = new System.Drawing.Point(255, 176);
            this.lb_stat.MinimumSize = new System.Drawing.Size(160, 0);
            this.lb_stat.Name = "lb_stat";
            this.lb_stat.Size = new System.Drawing.Size(160, 20);
            this.lb_stat.TabIndex = 6;
            // 
            // lb_result
            // 
            this.lb_result.AutoSize = true;
            this.lb_result.Location = new System.Drawing.Point(255, 215);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(0, 20);
            this.lb_result.TabIndex = 7;
            // 
            // lb_ciipher
            // 
            this.lb_ciipher.AutoSize = true;
            this.lb_ciipher.Location = new System.Drawing.Point(29, 99);
            this.lb_ciipher.Name = "lb_ciipher";
            this.lb_ciipher.Size = new System.Drawing.Size(101, 20);
            this.lb_ciipher.TabIndex = 8;
            this.lb_ciipher.Text = "Cipher Code:";
            this.lb_ciipher.Visible = false;
            // 
            // rb_rot2
            // 
            this.rb_rot2.AutoSize = true;
            this.rb_rot2.Checked = true;
            this.rb_rot2.Location = new System.Drawing.Point(259, 50);
            this.rb_rot2.Name = "rb_rot2";
            this.rb_rot2.Size = new System.Drawing.Size(69, 24);
            this.rb_rot2.TabIndex = 9;
            this.rb_rot2.TabStop = true;
            this.rb_rot2.Text = "ROT2";
            this.rb_rot2.UseVisualStyleBackColor = true;
            // 
            // rb_ceaser
            // 
            this.rb_ceaser.AutoSize = true;
            this.rb_ceaser.Location = new System.Drawing.Point(259, 80);
            this.rb_ceaser.Name = "rb_ceaser";
            this.rb_ceaser.Size = new System.Drawing.Size(128, 24);
            this.rb_ceaser.TabIndex = 9;
            this.rb_ceaser.Text = "Ceaser Cipher";
            this.rb_ceaser.UseVisualStyleBackColor = true;
            this.rb_ceaser.CheckedChanged += new System.EventHandler(this.rb_ceaser_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 275);
            this.Controls.Add(this.rb_ceaser);
            this.Controls.Add(this.rb_rot2);
            this.Controls.Add(this.lb_ciipher);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.lb_stat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_cipher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_pwd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_pwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_cipher;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_stat;
        private System.Windows.Forms.Label lb_result;
        private System.Windows.Forms.Label lb_ciipher;
        private System.Windows.Forms.RadioButton rb_rot2;
        private System.Windows.Forms.RadioButton rb_ceaser;
    }
}

