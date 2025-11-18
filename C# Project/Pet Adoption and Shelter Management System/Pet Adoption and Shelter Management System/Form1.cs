using System;
using System.Windows.Forms;

namespace Pet_Adoption_and_Shelter_Management_System
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            TxtPass.PasswordChar = '*';
            ComRole.SelectedIndex = 2;
        }

        private void LlblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            formRegister.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // Check if fields are empty
            if (string.IsNullOrWhiteSpace(TxtName.Text))
            {
                MessageBox.Show("Please enter a username.", "Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtPass.Text))
            {
                MessageBox.Show("Please enter a password.", "Error");
                return;
            }

            if (ComRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a role.", "Error");
                return;
            }

            // Get values
            string username = TxtName.Text.Trim();
            string password = TxtPass.Text;
            string role = ComRole.SelectedItem.ToString();

            // Check login (hardcoded users)
            bool loginSuccess = false;

            if (username == "admin" && password == "admin123" && role == "Admin")
            {
                loginSuccess = true;
                UserSession.SetUser(1, username, role);
            }
            else if (username == "staff" && password == "staff123" && role == "Shelter Staff")
            {
                loginSuccess = true;
                UserSession.SetUser(2, username, role);
            }
            else if (username == "user" && password == "user123" && role == "Adopter")
            {
                loginSuccess = true;
                UserSession.SetUser(3, username, role);
            }

            // Show result
            if (loginSuccess)
            {
                MessageBox.Show("Login Successful! Welcome " + username, "Success");
                FormHome homeForm = new FormHome();
                this.Hide();
                homeForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username, password, or role!", "Login Failed");
                TxtPass.Clear();
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            formRegister.ShowDialog();
        }
    }
}
