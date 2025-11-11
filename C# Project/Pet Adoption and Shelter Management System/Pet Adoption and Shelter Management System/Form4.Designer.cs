namespace Pet_Adoption_and_Shelter_Management_System
{
    partial class FormPet
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
            label1 = new Label();
            LblName = new Label();
            LblAge = new Label();
            LblSpecies = new Label();
            LblBreed = new Label();
            LblGender = new Label();
            LblLocation = new Label();
            LblD = new Label();
            BtnAdd = new Button();
            BtnEdit = new Button();
            BtnDelete = new Button();
            BtnClear = new Button();
            TxtName = new TextBox();
            CBoxSpecies = new ComboBox();
            TxtBreed = new TextBox();
            TxtAge = new TextBox();
            GBoxSex = new GroupBox();
            RBtnMale = new RadioButton();
            RBtnFemale = new RadioButton();
            CBoxLocation = new ComboBox();
            TxtD = new TextBox();
            LblView = new Label();
            LBoxView = new ListBox();
            GBoxSex.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(332, 32);
            label1.Name = "label1";
            label1.Size = new Size(208, 32);
            label1.TabIndex = 0;
            label1.Text = "Pet Management";
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            LblName.Location = new Point(57, 94);
            LblName.Name = "LblName";
            LblName.Size = new Size(56, 21);
            LblName.TabIndex = 1;
            LblName.Text = "Name";
            // 
            // LblAge
            // 
            LblAge.AutoSize = true;
            LblAge.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            LblAge.Location = new Point(57, 141);
            LblAge.Name = "LblAge";
            LblAge.Size = new Size(40, 21);
            LblAge.TabIndex = 2;
            LblAge.Text = "Age";
            // 
            // LblSpecies
            // 
            LblSpecies.AutoSize = true;
            LblSpecies.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            LblSpecies.Location = new Point(280, 94);
            LblSpecies.Name = "LblSpecies";
            LblSpecies.Size = new Size(69, 21);
            LblSpecies.TabIndex = 3;
            LblSpecies.Text = "Species";
            // 
            // LblBreed
            // 
            LblBreed.AutoSize = true;
            LblBreed.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            LblBreed.Location = new Point(528, 94);
            LblBreed.Name = "LblBreed";
            LblBreed.Size = new Size(55, 21);
            LblBreed.TabIndex = 4;
            LblBreed.Text = "Breed";
            LblBreed.Click += label5_Click;
            // 
            // LblGender
            // 
            LblGender.AutoSize = true;
            LblGender.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            LblGender.Location = new Point(528, 143);
            LblGender.Name = "LblGender";
            LblGender.Size = new Size(67, 21);
            LblGender.TabIndex = 5;
            LblGender.Text = "Gender";
            // 
            // LblLocation
            // 
            LblLocation.AutoSize = true;
            LblLocation.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            LblLocation.Location = new Point(280, 146);
            LblLocation.Name = "LblLocation";
            LblLocation.Size = new Size(77, 21);
            LblLocation.TabIndex = 6;
            LblLocation.Text = "Location";
            // 
            // LblD
            // 
            LblD.AutoSize = true;
            LblD.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            LblD.Location = new Point(57, 191);
            LblD.Name = "LblD";
            LblD.Size = new Size(100, 21);
            LblD.TabIndex = 7;
            LblD.Text = "Description";
            // 
            // BtnAdd
            // 
            BtnAdd.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            BtnAdd.Location = new Point(102, 281);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(108, 36);
            BtnAdd.TabIndex = 8;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            BtnEdit.Location = new Point(241, 281);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(108, 36);
            BtnEdit.TabIndex = 9;
            BtnEdit.Text = "Edit";
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            BtnDelete.Location = new Point(395, 281);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(108, 36);
            BtnDelete.TabIndex = 10;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnClear
            // 
            BtnClear.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            BtnClear.Location = new Point(564, 281);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(108, 36);
            BtnClear.TabIndex = 11;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = true;
            // 
            // TxtName
            // 
            TxtName.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            TxtName.Location = new Point(121, 90);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(100, 29);
            TxtName.TabIndex = 12;
            // 
            // CBoxSpecies
            // 
            CBoxSpecies.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            CBoxSpecies.FormattingEnabled = true;
            CBoxSpecies.Items.AddRange(new object[] { "Dog", "Cat", "Rabbit", "Bird", "Other" });
            CBoxSpecies.Location = new Point(362, 91);
            CBoxSpecies.Name = "CBoxSpecies";
            CBoxSpecies.Size = new Size(121, 29);
            CBoxSpecies.TabIndex = 13;
            // 
            // TxtBreed
            // 
            TxtBreed.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            TxtBreed.Location = new Point(600, 90);
            TxtBreed.Name = "TxtBreed";
            TxtBreed.Size = new Size(131, 29);
            TxtBreed.TabIndex = 14;
            // 
            // TxtAge
            // 
            TxtAge.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            TxtAge.Location = new Point(121, 138);
            TxtAge.Name = "TxtAge";
            TxtAge.Size = new Size(100, 29);
            TxtAge.TabIndex = 15;
            // 
            // GBoxSex
            // 
            GBoxSex.Controls.Add(RBtnFemale);
            GBoxSex.Controls.Add(RBtnMale);
            GBoxSex.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            GBoxSex.Location = new Point(601, 141);
            GBoxSex.Name = "GBoxSex";
            GBoxSex.Size = new Size(199, 56);
            GBoxSex.TabIndex = 16;
            GBoxSex.TabStop = false;
            GBoxSex.Text = "Sex";
            // 
            // RBtnMale
            // 
            RBtnMale.AutoSize = true;
            RBtnMale.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            RBtnMale.Location = new Point(16, 27);
            RBtnMale.Name = "RBtnMale";
            RBtnMale.Size = new Size(66, 25);
            RBtnMale.TabIndex = 0;
            RBtnMale.TabStop = true;
            RBtnMale.Text = "Male";
            RBtnMale.UseVisualStyleBackColor = true;
            // 
            // RBtnFemale
            // 
            RBtnFemale.AutoSize = true;
            RBtnFemale.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            RBtnFemale.Location = new Point(88, 27);
            RBtnFemale.Name = "RBtnFemale";
            RBtnFemale.Size = new Size(84, 25);
            RBtnFemale.TabIndex = 1;
            RBtnFemale.TabStop = true;
            RBtnFemale.Text = "Female";
            RBtnFemale.UseVisualStyleBackColor = true;
            // 
            // CBoxLocation
            // 
            CBoxLocation.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            CBoxLocation.FormattingEnabled = true;
            CBoxLocation.Items.AddRange(new object[] { "London", "Paris", "Taiwan", "Canada", "USA", "Other" });
            CBoxLocation.Location = new Point(363, 143);
            CBoxLocation.Name = "CBoxLocation";
            CBoxLocation.Size = new Size(121, 29);
            CBoxLocation.TabIndex = 17;
            // 
            // TxtD
            // 
            TxtD.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            TxtD.Location = new Point(57, 215);
            TxtD.Multiline = true;
            TxtD.Name = "TxtD";
            TxtD.Size = new Size(679, 58);
            TxtD.TabIndex = 18;
            // 
            // LblView
            // 
            LblView.AutoSize = true;
            LblView.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            LblView.Location = new Point(57, 326);
            LblView.Name = "LblView";
            LblView.Size = new Size(112, 21);
            LblView.TabIndex = 19;
            LblView.Text = "View All Pets";
            // 
            // LBoxView
            // 
            LBoxView.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            LBoxView.FormattingEnabled = true;
            LBoxView.ItemHeight = 21;
            LBoxView.Location = new Point(57, 350);
            LBoxView.Name = "LBoxView";
            LBoxView.Size = new Size(716, 88);
            LBoxView.TabIndex = 20;
            // 
            // FormPet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(LBoxView);
            Controls.Add(LblView);
            Controls.Add(TxtD);
            Controls.Add(CBoxLocation);
            Controls.Add(GBoxSex);
            Controls.Add(TxtAge);
            Controls.Add(TxtBreed);
            Controls.Add(CBoxSpecies);
            Controls.Add(TxtName);
            Controls.Add(BtnClear);
            Controls.Add(BtnDelete);
            Controls.Add(BtnEdit);
            Controls.Add(BtnAdd);
            Controls.Add(LblD);
            Controls.Add(LblLocation);
            Controls.Add(LblGender);
            Controls.Add(LblBreed);
            Controls.Add(LblSpecies);
            Controls.Add(LblAge);
            Controls.Add(LblName);
            Controls.Add(label1);
            Name = "FormPet";
            Text = "Manage Pet ";
            GBoxSex.ResumeLayout(false);
            GBoxSex.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label LblName;
        private Label LblAge;
        private Label LblSpecies;
        private Label LblBreed;
        private Label LblGender;
        private Label LblLocation;
        private Label LblD;
        private Button BtnAdd;
        private Button BtnEdit;
        private Button BtnDelete;
        private Button BtnClear;
        private TextBox TxtName;
        private ComboBox CBoxSpecies;
        private TextBox TxtBreed;
        private TextBox TxtAge;
        private GroupBox GBoxSex;
        private RadioButton RBtnFemale;
        private RadioButton RBtnMale;
        private ComboBox CBoxLocation;
        private TextBox TxtD;
        private Label LblView;
        private ListBox LBoxView;
    }
}