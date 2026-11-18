using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NewExercise.frmLogin;

namespace NewExercise
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }
        private bool IsEmailExist(string Email)
        {
            return frmLogin.UserProfile.Email.Contains(Email);
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {

            string email = txtEmail.Text.Trim();

          

            if (string.IsNullOrWhiteSpace(txtFirstName.Text)|| string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill in all required fields!", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsEmailExist(email))
            {
                MessageBox.Show("This account already exists! Please log in.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

         
                frmLogin.UserProfile.FirstName.Add(txtFirstName.Text.Trim());
                frmLogin.UserProfile.LastName.Add(txtLastName.Text.Trim());
                frmLogin.UserProfile.Email.Add(email);
                frmLogin.UserProfile.Password.Add(txtPassword.Text);

                MessageBox.Show("Registration successful! Account created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            
          

        }
        private void frmSignIn_Load(object sender, EventArgs e)
        {
            AcceptButton = btnRegister;
            CancelButton = btnBacktoLogin;
        }
        private void btnBacktoLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
