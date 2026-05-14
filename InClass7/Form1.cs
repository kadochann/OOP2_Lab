using System;
using System.Windows.Forms;

public partial class Form1 : Form
{
    private UserService _userService = new UserService(); // Kullanıcı işlemlerini yöneten servis

    public Form1()
    {
        InitializeComponent();
    }

    // Kayıt Butonu
    private void btnRegister_Click(object sender, EventArgs e)
    {
        string user = txtUsername.Text;
        string pass = txtPassword.Text;

        if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
        {
            MessageBox.Show("Username and Password cannot be empty!");
            return;
        }

        bool success = _userService.Register(user, pass);
        if (success)
        {
            MessageBox.Show("Registration successful!"); 
        }
        else
        {
            MessageBox.Show("Username already exists!"); 
        }
    }

    // Giriş Butonu
    private void btnLogin_Click(object sender, EventArgs e)
    {
        string user = txtUsername.Text;
        string pass = txtPassword.Text;

        if (_userService.Login(user, pass))
        {
            Form2 dashboard = new Form2(user);
            dashboard.Show();
            this.Hide(); // Giriş formunu gizle
        }
        else
        {
            MessageBox.Show("Invalid username or password!"); 
        }
    }
}