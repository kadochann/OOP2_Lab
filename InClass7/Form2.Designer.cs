partial class Form2
{
    private System.ComponentModel.IContainer components = null;

    private void InitializeComponent()
    {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbSubCategory = new System.Windows.Forms.ComboBox();
            this.cmbBook = new System.Windows.Forms.ComboBox();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.lstHistory = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.Location = new System.Drawing.Point(20, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(200, 20);
            this.lblWelcome.TabIndex = 6;
            this.lblWelcome.Text = "Welcome, [User]";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Location = new System.Drawing.Point(20, 60);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(200, 28);
            this.cmbCategory.TabIndex = 5;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // cmbSubCategory
            // 
            this.cmbSubCategory.Location = new System.Drawing.Point(20, 100);
            this.cmbSubCategory.Name = "cmbSubCategory";
            this.cmbSubCategory.Size = new System.Drawing.Size(200, 28);
            this.cmbSubCategory.TabIndex = 4;
            this.cmbSubCategory.SelectedIndexChanged += new System.EventHandler(this.cmbSubCategory_SelectedIndexChanged);
            // 
            // cmbBook
            // 
            this.cmbBook.Location = new System.Drawing.Point(20, 140);
            this.cmbBook.Name = "cmbBook";
            this.cmbBook.Size = new System.Drawing.Size(200, 28);
            this.cmbBook.TabIndex = 3;
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(20, 180);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(200, 30);
            this.btnBorrow.TabIndex = 2;
            this.btnBorrow.Text = "BORROW THIS BOOK";
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(20, 230);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(200, 30);
            this.btnHistory.TabIndex = 1;
            this.btnHistory.Text = "VIEW MY BORROWING HISTORY";
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // lstHistory
            // 
            this.lstHistory.ItemHeight = 20;
            this.lstHistory.Location = new System.Drawing.Point(20, 270);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(350, 84);
            this.lstHistory.TabIndex = 0;
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(484, 400);
            this.Controls.Add(this.lstHistory);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.cmbBook);
            this.Controls.Add(this.cmbSubCategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblWelcome);
            this.Name = "Form2";
            this.Text = "User Dashboard";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

    }

    private System.Windows.Forms.Label lblWelcome;
    private System.Windows.Forms.ComboBox cmbCategory;
    private System.Windows.Forms.ComboBox cmbSubCategory;
    private System.Windows.Forms.ComboBox cmbBook;
    private System.Windows.Forms.Button btnBorrow;
    private System.Windows.Forms.Button btnHistory;
    private System.Windows.Forms.ListBox lstHistory;
}