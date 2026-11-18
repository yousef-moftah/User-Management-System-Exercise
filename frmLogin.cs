using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewExercise
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public struct UserProfile
        {
            public static List<string> FirstName = new List<string>();
            public static List<string> LastName= new List<string>();
            public static List<string> Email = new List<string>();
            public static List<string> Password = new List<string>();


        }

        public static string LoggedInName;


        private void button1_Click(object sender, EventArgs e)
        {
            if (UserProfile.Email.Count == 0)
            {
                MessageBox.Show("No accounts found! Please sign up first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int a = 0; a < UserProfile.Email.Count; a++)
            {
                if (txtEmail.Text.Trim() == UserProfile.Email[a])
                {
                    if (txtPassword.Text == UserProfile.Password[a])
                    {
                        LoggedInName = UserProfile.FirstName[a] + " " + UserProfile.LastName[a];
                        MessageBox.Show("Login Successful! Welcome.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPassword.Clear();
                        Form frm1 = new frmUsersList();
                        frm1.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Password! Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
                }
            }

            MessageBox.Show("Invalid Email Address! This email does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
            private void btnSignIn_Click(object sender, EventArgs e)
            {
                txtEmail.Clear();
                txtPassword.Clear();
                Form frm1 = new frmRegister();
                frm1.ShowDialog();
            }

        private void Form1_Load(object sender, EventArgs e)
        {
            AcceptButton = btnLogIn;
        }
    }
}
