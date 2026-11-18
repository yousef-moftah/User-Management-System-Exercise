using NewExercise.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NewExercise
{
    public partial class frmUsersList : Form
    {
        public frmUsersList()
        {
            InitializeComponent();
        }
        private enum Gender
        {
            Girl = 0,
            Boy = 1 
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            AcceptButton = btnAdd;
            CancelButton = btnClose;
            lblWelcome.Text = "Welcome " + frmLogin.LoggedInName;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPhone.Text) ||
                (!rbMale.Checked && !rbFemale.Checked))
                
            {
                MessageBox.Show("Please fill in all fields and choose a gender!", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            ListViewItem item = new ListViewItem(txtID.Text.Trim());
            if(rbMale.Checked)
            {
                item.ImageIndex = (int)Gender.Boy;
            }    
            else
            {
                item.ImageIndex = (int)Gender.Girl;
            }

            item.SubItems.Add(txtName.Text.Trim());
            item.SubItems.Add(txtEmail.Text.Trim());
            item.SubItems.Add(txtPhone.Text.Trim());
            listView1.Items.Add(item);

            txtID.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();

            txtID.Focus();
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources. male_avatar_64;

        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.female_avatar_64;

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Please select an item to remove!", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFillRandom_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                ListViewItem item = new ListViewItem(i.ToString());

                if (i % 2 == 0)
                    item.ImageIndex = (int)Gender.Boy;
                else
                    item.ImageIndex = (int)Gender.Girl;

                item.SubItems.Add("Person" + i);
                item.SubItems.Add("person" + i + "@example.com");
                item.SubItems.Add("010000000" + i.ToString("00"));
                listView1.Items.Add(item);

            }

        }

        private void rbDetails_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void rbLargeIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void rbSmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void rbList_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void rbTile_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("The list view is empty");
                return;
            }

           if (MessageBox.Show("Are you sure to reset", "Warrning", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2)==DialogResult.OK)
            { 
                listView1.Items.Clear();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {


            if (listView1.SelectedItems.Count > 0)
            {
                if ( string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtPhone.Text) || (!rbMale.Checked && !rbFemale.Checked))

                {
                    MessageBox.Show("Please fill in all fields and choose a gender!", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ListViewItem selectedItem = listView1.SelectedItems[0];

                selectedItem.SubItems[1].Text = txtName.Text.Trim();
                selectedItem.SubItems[2].Text = txtEmail.Text.Trim();
                selectedItem.SubItems[3].Text = txtPhone.Text.Trim();
                selectedItem.ImageIndex = rbMale.Checked ? (int)Gender.Boy : (int)Gender.Girl;

                txtID.Clear();
                txtName.Clear();
                txtEmail.Clear();
                txtPhone.Clear();   

                txtID.Focus();
            }
            else
            {
                MessageBox.Show("Please select item to edit first");
            }
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
