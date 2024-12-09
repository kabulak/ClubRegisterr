namespace ClubRegisterr
{
    partial class FrmClubRegistration
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
            txtStudentID = new TextBox();
            btnRegister = new Button();
            dataGridView1 = new DataGridView();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtAge = new TextBox();
            txtMiddleName = new TextBox();
            btnRefresh = new Button();
            txtProgram = new TextBox();
            cmbGender = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(36, 78);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(100, 23);
            txtStudentID.TabIndex = 0;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(759, 52);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "btnRegister";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 288);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(837, 150);
            dataGridView1.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(36, 147);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 3;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(369, 147);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 4;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(36, 214);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 5;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(629, 147);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(100, 23);
            txtMiddleName.TabIndex = 6;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(759, 91);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "btnRefresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // txtProgram
            // 
            txtProgram.Location = new Point(629, 78);
            txtProgram.Name = "txtProgram";
            txtProgram.Size = new Size(100, 23);
            txtProgram.TabIndex = 8;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(348, 208);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(121, 23);
            cmbGender.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 60);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 10;
            label1.Text = "Student ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 129);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 11;
            label2.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 190);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 12;
            label3.Text = "Age:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(382, 129);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 13;
            label4.Text = "First Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(382, 190);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 14;
            label5.Text = "Gender:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(644, 56);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 15;
            label6.Text = "Program:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(644, 129);
            label7.Name = "label7";
            label7.Size = new Size(82, 15);
            label7.TabIndex = 16;
            label7.Text = "Middle Name:";
            // 
            // FrmClubRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(861, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbGender);
            Controls.Add(txtProgram);
            Controls.Add(btnRefresh);
            Controls.Add(txtMiddleName);
            Controls.Add(txtAge);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(dataGridView1);
            Controls.Add(btnRegister);
            Controls.Add(txtStudentID);
            Name = "FrmClubRegistration";
            Text = "FrmClubRegistration";
            Load += FrmClubRegistration_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStudentID;
        private Button btnRegister;
        private DataGridView dataGridView1;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtAge;
        private TextBox txtMiddleName;
        private Button btnRefresh;
        private TextBox txtProgram;
        private ComboBox cmbGender;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}