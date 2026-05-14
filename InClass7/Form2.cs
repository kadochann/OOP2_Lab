using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

public partial class Form2 : Form
{
    private string _currentUsername;
    private LibraryService _libraryService = new LibraryService();
    private BorrowingService _borrowingService = new BorrowingService();

    public Form2(string username)
    {
        InitializeComponent();
        _currentUsername = username;
        lblWelcome.Text = $"Welcome, {_currentUsername}"; 
    }

    private void Form2_Load(object sender, EventArgs e)
    {
         cmbCategory.DataSource = _libraryService.GetCategories();
         cmbSubCategory.Enabled = false; 
         cmbBook.Enabled = false; 
    }

    private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cmbCategory.SelectedItem != null)
        {
            string category = cmbCategory.SelectedItem.ToString();
            cmbSubCategory.DataSource = _libraryService.GetSubCategories(category);
            cmbSubCategory.Enabled = true; 
            
            // Alt seçimleri temizle
            cmbBook.DataSource = null;
            cmbBook.Enabled = false;
        }
    }

    private void cmbSubCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cmbSubCategory.SelectedItem != null)
        {
            string subCat = cmbSubCategory.SelectedItem.ToString();
            cmbBook.DataSource = _libraryService.GetBooks(subCat);
            cmbBook.Enabled = true; 
        }
    }

    private void btnBorrow_Click(object sender, EventArgs e)
    {
        if (cmbCategory.SelectedItem == null || cmbSubCategory.SelectedItem == null || cmbBook.SelectedItem == null)
        {
             MessageBox.Show("Please select Category, Sub-Category, and Book!"); 
            return;
        }

        var record = new BorrowingRecord
        {
            Date = DateTime.Now.ToString("yyyy-MM-dd"),
            Username = _currentUsername,
            Category = cmbCategory.SelectedItem.ToString(),
            SubCategory = cmbSubCategory.SelectedItem.ToString(),
            BookTitle = cmbBook.SelectedItem.ToString()
        };

        _borrowingService.SaveBorrowing(record); 
        MessageBox.Show("Book borrowed successfully!"); 
    }

    private void btnHistory_Click(object sender, EventArgs e)
    {
        lstHistory.Items.Clear();
        var history = _borrowingService.GetHistory(_currentUsername);
        
        foreach (var item in history)
        {
            lstHistory.Items.Add(item); 
        }
    }
}