namespace Pet_Adoption_and_Shelter_Management_System
{
    partial class UserManageForm
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
            LblPass = new Label();
            LblRole = new Label();
            BtnAdd = new Button();
            BtnEdit = new Button();
            BtnDelete = new Button();
            BtnClear = new Button();
            LblView = new Label();
            LBoxView = new ListBox();
            TxtName = new TextBox();
            TxtPass = new TextBox();
            CBoxRole = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(308, 38);
            label1.Name = "label1";
            label1.Size = new Size(175, 32);
            label1.TabIndex = 0;
            label1.Text = "Manage Users";
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            LblName.Location = new Point(63, 94);
            LblName.Name = "LblName";
            LblName.Size = new Size(92, 21);
            LblName.TabIndex = 1;
            LblName.Text = "UserName";
            // 
            // LblPass
            // 
            LblPass.AutoSize = true;
            LblPass.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            LblPass.Location = new Point(361, 94);
            LblPass.Name = "LblPass";
            LblPass.Size = new Size(88, 21);
            LblPass.TabIndex = 2;
            LblPass.Text = "PassWord";
            // 
            // LblRole
            // 
            LblRole.AutoSize = true;
            LblRole.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            LblRole.Location = new Point(63, 146);
            LblRole.Name = "LblRole";
            LblRole.Size = new Size(45, 21);
            LblRole.TabIndex = 4;
            LblRole.Text = "Role";
            // 
            // BtnAdd
            // 
            BtnAdd.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            BtnAdd.Location = new Point(118, 204);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(100, 36);
            BtnAdd.TabIndex = 5;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            BtnEdit.Location = new Point(249, 204);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(100, 36);
            BtnEdit.TabIndex = 6;
            BtnEdit.Text = "Edit";
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            BtnDelete.Location = new Point(389, 204);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(100, 36);
            BtnDelete.TabIndex = 7;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnClear
            // 
            BtnClear.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            BtnClear.Location = new Point(514, 204);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(100, 36);
            BtnClear.TabIndex = 8;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = true;
            // 
            // LblView
            // 
            LblView.AutoSize = true;
            LblView.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            LblView.Location = new Point(63, 250);
            LblView.Name = "LblView";
            LblView.Size = new Size(89, 21);
            LblView.TabIndex = 9;
            LblView.Text = "View User";
            // 
            // LBoxView
            // 
            LBoxView.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            LBoxView.FormattingEnabled = true;
            LBoxView.ItemHeight = 21;
            LBoxView.Location = new Point(63, 274);
            LBoxView.Name = "LBoxView";
            LBoxView.Size = new Size(564, 67);
            LBoxView.TabIndex = 10;
            // 
            // TxtName
            // 
            TxtName.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            TxtName.Location = new Point(182, 91);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(121, 29);
            TxtName.TabIndex = 11;
            // 
            // TxtPass
            // 
            TxtPass.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            TxtPass.Location = new Point(455, 91);
            TxtPass.Name = "TxtPass";
            TxtPass.Size = new Size(121, 29);
            TxtPass.TabIndex = 12;
            // 
            // CBoxRole
            // 
            CBoxRole.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            CBoxRole.FormattingEnabled = true;
            CBoxRole.Items.AddRange(new object[] { "Admin", "Staff", "User" });
            CBoxRole.Location = new Point(182, 143);
            CBoxRole.Name = "CBoxRole";
            CBoxRole.Size = new Size(121, 29);
            CBoxRole.TabIndex = 14;
            // 
            // UserManageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(CBoxRole);
            Controls.Add(TxtPass);
            Controls.Add(TxtName);
            Controls.Add(LBoxView);
            Controls.Add(LblView);
            Controls.Add(BtnClear);
            Controls.Add(BtnDelete);
            Controls.Add(BtnEdit);
            Controls.Add(BtnAdd);
            Controls.Add(LblRole);
            Controls.Add(LblPass);
            Controls.Add(LblName);
            Controls.Add(label1);
            Name = "UserManageForm";
            Text = "Manage User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label LblName;
        private Label LblPass;
        private Label LblRole;
        private Button BtnAdd;
        private Button BtnEdit;
        private Button BtnDelete;
        private Button BtnClear;
        private Label LblView;
        private ListBox LBoxView;
        private TextBox TxtName;
        private TextBox TxtPass;
        private ComboBox CBoxRole;
    }
}