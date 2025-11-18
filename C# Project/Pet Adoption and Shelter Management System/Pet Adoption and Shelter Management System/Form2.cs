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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
            TxtPass.PasswordChar = '*';
            TxtCpass.PasswordChar = '*';
            ComRole.SelectedIndex = 0;
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtName.Text))
            {
                MessageBox.Show("Enter username!");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtPass.Text))
            {
                MessageBox.Show("Enter password!");
                return;
            }

            if (TxtPass.Text != TxtCpass.Text)
            {
                MessageBox.Show("Passwords don't match!");
                return;
            }

            MessageBox.Show("Registration Successful!");
            this.Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtName.Clear();
            TxtPass.Clear();
            TxtCpass.Clear();
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void LblName_Click(object sender, EventArgs e) { }
        private void TxtName_TextChanged(object sender, EventArgs e) { }
        private void FormRegister_Load(object sender, EventArgs e) { }
        private void TxtPass_TextChanged(object sender, EventArgs e) { }
        private void LblCpass_Click(object sender, EventArgs e) { }
        private void TxtCpass_TextChanged(object sender, EventArgs e) { }
        private void LblRole_Click(object sender, EventArgs e) { }
        private void ComRole_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
