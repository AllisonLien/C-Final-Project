using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Adoption_and_Shelter_Management_System
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();

            // Show welcome message
            LblWelcome.Text = "Welcome, " + UserSession.Username + "!";

            // Configure UI based on role
            SetupUIForRole();
        }

        private void SetupUIForRole()
        {
            if (UserSession.Role == "Admin")
            {
                // Admin sees everything
                BtnPets.Text = "Manage Pets";
                BtnUser.Text = "Manage Users";
                BtnRequest.Text = "Adoption Requests";
                BtnView.Text = "View Reports";
                BtnUser.Visible = true;
            }
            else if (UserSession.Role == "Shelter Staff")
            {
                // Staff manages pets and reviews requests
                BtnPets.Text = "Manage Pets";
                BtnRequest.Text = "Review Requests";
                BtnView.Text = "All Requests";
                BtnUser.Visible = false; // Hide manage users
            }
            else // Adopter
            {
                // Adopter only browses and submits
                BtnPets.Text = "Browse Pets";
                BtnRequest.Text = "Submit Request";
                BtnView.Text = "My Requests";
                BtnUser.Visible = false; // Hide manage users
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void BtnPets_Click(object sender, EventArgs e)
        {
            // Open pet form differently based on role
            if (UserSession.Role == "Adopter")
            {
                MessageBox.Show("Browse available pets (View Only Mode)", "Browse Pets");
                // Later: Open FormPet in view-only mode
            }

            FormPet formPet = new FormPet();
            formPet.ShowDialog();
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            // Only Admin can access
            if (UserSession.Role == "Admin")
            {
                UserManageForm userForm = new UserManageForm();
                userForm.ShowDialog();
            }
        }

        private void BtnRequest_Click(object sender, EventArgs e)
        {
            if (UserSession.Role == "Adopter")
            {
                MessageBox.Show("Submit a new adoption request", "Submit Request");
            }
            else if (UserSession.Role == "Shelter Staff")
            {
                MessageBox.Show("Review and approve/reject requests", "Review Requests");
            }
            else // Admin
            {
                MessageBox.Show("View all adoption requests", "Adoption Requests");
            }

            FormAdoptionRequest adoptionForm = new FormAdoptionRequest();
            adoptionForm.ShowDialog();
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            if (UserSession.Role == "Admin")
            {
                MessageBox.Show("Admin: View reports and statistics", "View Reports");
            }
            else if (UserSession.Role == "Shelter Staff")
            {
                MessageBox.Show("Staff: View all pending requests", "All Requests");
            }
            else // Adopter
            {
                MessageBox.Show("Adopter: View YOUR submitted requests only", "My Requests");
            }
        }

        private void Btnout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                UserSession.Clear();
                MessageBox.Show("Logged out successfully!");

                FormLogin loginForm = new FormLogin();
                this.Hide();
                loginForm.ShowDialog();
                this.Close();
            }
        }
    }
}
