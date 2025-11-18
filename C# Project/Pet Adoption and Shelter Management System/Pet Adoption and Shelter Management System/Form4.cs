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
    public partial class FormPet : Form
    {
        public FormPet()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TxtName.Text != "")
            {
                string pet = TxtName.Text + " - " + CBoxSpecies.Text + " - " + TxtBreed.Text;
                LBoxView.Items.Add(pet);
                MessageBox.Show("Pet added!");
                TxtName.Clear();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit - Coming Soon!");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (LBoxView.SelectedIndex != -1)
            {
                LBoxView.Items.RemoveAt(LBoxView.SelectedIndex);
                MessageBox.Show("Pet deleted!");
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtName.Clear();
            TxtAge.Clear();
            TxtBreed.Clear();
        }

        private void label5_Click(object sender, EventArgs e) { }
        private void TxtName_TextChanged(object sender, EventArgs e) { }
        private void LblName_Click(object sender, EventArgs e) { }
        private void TxtAge_TextChanged(object sender, EventArgs e) { }
        private void LblAge_Click(object sender, EventArgs e) { }
        private void LblSpecies_Click(object sender, EventArgs e) { }
        private void CBoxSpecies_SelectedIndexChanged(object sender, EventArgs e) { }
        private void LblLocation_Click(object sender, EventArgs e) { }
        private void CBoxLocation_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void TxtBreed_TextChanged(object sender, EventArgs e) { }
        private void LblGender_Click(object sender, EventArgs e) { }
        private void GBoxSex_Enter(object sender, EventArgs e) { }
        private void LblD_Click(object sender, EventArgs e) { }
        private void TxtD_TextChanged(object sender, EventArgs e) { }
        private void LBoxView_SelectedIndexChanged(object sender, EventArgs e) { }
        private void LblView_Click(object sender, EventArgs e) { }
    }
}
