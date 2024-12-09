using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubRegisterr
{
    public partial class FrmClubRegistration : Form
    {
        private ClubRegistrationQuery clubQuery;
        public FrmClubRegistration()
        {
            InitializeComponent();
            clubQuery = new ClubRegistrationQuery();

        }

        private void FrmClubRegistration_Load(object sender, EventArgs e)
        {
            // Populate the ComboBox with Gender options
            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
            cmbGender.SelectedIndex = -1; // Ensure no selection by default
            RefreshList();
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            try
            {
               
                int id = GetNextID();
                long studentId = Convert.ToInt64(txtStudentID.Text);
                string firstName = txtFirstName.Text;
                string middleName = txtMiddleName.Text;
                string lastName = txtLastName.Text;
                int age = Convert.ToInt32(txtAge.Text);

                
                if (cmbGender.SelectedItem == null)
                {
                    MessageBox.Show("Please select a gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string gender = cmbGender.SelectedItem.ToString();
                string program = txtProgram.Text;

                
                if (clubQuery.RegisterStudent(id, studentId, firstName, middleName, lastName, age, gender, program))
                {
                    MessageBox.Show("Student Registered Successfully!");
                    RefreshList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RefreshList()
        {
            clubQuery.DisplayList(dataGridView1);
        }
    private int GetNextID()
        {
            return dataGridView1.Rows.Count + 1;
        }
    }
}
