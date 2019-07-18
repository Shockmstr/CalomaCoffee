using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Customer
{
    public partial class MasterForm : Form
    {
        public MasterForm()
        {
            InitializeComponent();
            
           
        }
        User.UserDAO db = new User.UserDAO();

        void VerificationFunction()
        {
            CheckTextBox(txtUsername);
            CheckTextBox(txtPassword);
            CheckTextBox(txtFullname);
            CheckTextBox(txtEmail);
        }

        void CheckTextBox(TextBox textBox)
        {
          
            if (string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show(textBox.Name.Substring(3) + " must be filled");
                 
            }

          
        }



        private void MasterForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cSharpCoffeeDataSet1.User' table. You can move, or remove it, as needed.
            this.userTableAdapter1.Fill(this.cSharpCoffeeDataSet1.User);
            // TODO: This line of code loads data into the 'cSharpCoffeeDataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.cSharpCoffeeDataSet.User);
            cbRole.SelectedIndex = 1;
            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("1", "All");
            test.Add("2", "customer");
            test.Add("3", "no");
            test.Add("4", "staff");
            combobox.DataSource = new BindingSource(test, null);
            combobox.DisplayMember = "Value";
            combobox.ValueMember = "Key";
           
            // Get combobox selection (in handler)

        }



        private void btnCreate_Click(object sender, EventArgs e)
        {
            Boolean check = false;
            string username = txtUsername.Text;
            if(username.Trim().Equals(""))
            {
                check = true;
            }
            string role = cbRole.SelectedValue.ToString();

            string password = txtPassword.Text;
            if (password.Trim().Equals(""))
            {
                check = true;
            }
            string name = txtFullname.Text;
            if (name.Trim().Equals(""))
            {
                check = true;
            }
            string email = txtEmail.Text;
            if (email.Trim().Equals(""))
            {
                check = true;
            }
            VerificationFunction();
            if (check == false)
            {
                try
                {

                    User.UserDTO dto = new User.UserDTO
                    {
                        Username = username,
                        Password = password,
                        Email = email,
                        Role = role,
                        Fullname = name,

                    };
                    bool r = db.CreateUser(dto);
                    string s = (r == true ? "Successful" : "fail");
                    MessageBox.Show("Add Value " + s);
                    this.userTableAdapter.Fill(this.cSharpCoffeeDataSet.User);
                    DataTable dt = db.searchAllByRoleAll();
                    dgvEmp.DataSource = dt;
                }
                catch (Exception exp)
                {
                    if (exp.Message.Contains("PRIMARY") )
                    {
                        MessageBox.Show("This username is already existed !");

                    }
                    else if( exp.Message.Contains("UNIQUE"))
                    {

                        MessageBox.Show("This Email is already existed !");
                    }
                    else
                    {
                        MessageBox.Show(exp.Message);
                    }

                }
            }else
            {
                MessageBox.Show("Please reinput all text fields correctly !");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Boolean check = false;
            
            string username = txtUsername.Text;
            if (username.Trim().Equals(""))
            {
                check = true;
            }
            string role = cbRole.SelectedValue.ToString();

            string password = txtPassword.Text;
            if (password.Trim().Equals(""))
            {
                check = true;
            }
            string name = txtFullname.Text;
            if (name.Trim().Equals(""))
            {
                check = true;
            }
            string email = txtEmail.Text;
            if (email.Trim().Equals("") )
            {
                check = true;
                
            }
            
            VerificationFunction();
            if (check == false )
            {
                try
                {
                    User.UserDTO dto = new User.UserDTO
                    {
                        Username = username,
                        Password = password,
                        Email = email,
                        Role = role,
                        Fullname = name,

                    };
                    bool r = db.UpdateUser(dto);
                    string s = (r == true ? "Successful" : "fail");
                    MessageBox.Show("Update User " + s);
                    string searchvalue = txtSearchVal.Text;
                    DataTable dtEmp = db.searchByUserName(searchvalue);
                    dgvEmp.DataSource = dtEmp;


                    this.userTableAdapter.Fill(this.cSharpCoffeeDataSet.User);
                }
                catch (Exception exp)
                {
                    if (exp.Message.Contains("PRIMARY"))
                    {
                        MessageBox.Show("This username is already existed !");

                    }
                    else if (exp.Message.Contains("UNIQUE"))
                    {

                        MessageBox.Show("This Email is already existed !");
                    }
                    else
                    {
                        MessageBox.Show(exp.Message);
                    }
                
            }
        }else
            {
                MessageBox.Show("Please reinput all text fields correctly !");
            }
            }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            bool flag = false;
            if(username.Trim().Equals(""))
            {
                flag = true;
            }
            string password = txtPassword.Text;
            if(password.Trim().Equals(""))
            {
                flag = true;
            }
            if (flag == false)
            {
                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Username must be filled first");
                }
                bool r = db.DeleteUser(username);
                string s = (r == true ? "Successful" : "fail");
                MessageBox.Show("Delete User " + s);
                this.userTableAdapter.Fill(this.cSharpCoffeeDataSet.User);
                DataTable dt = db.searchAllByRoleAll();
                dgvEmp.DataSource = dt;
            }
            else
            {
                MessageBox.Show("This function requires filling both Username and Password text fields to execute !");
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtFullname.Clear();
            txtEmail.Clear();
            cbRole.SelectedIndex = 1; 
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string searchvalue = txtSearchVal.Text;
            if(string.IsNullOrEmpty(searchvalue))
            {
                MessageBox.Show("Search value must be filled first");
            }
            DataTable  dtEmp= db.searchByUserName(searchvalue);

            dgvEmp.DataSource = dtEmp;
            this.userTableAdapter.Fill(this.cSharpCoffeeDataSet.User);

        }

      

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void FillBy1ToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void FillBy1ToolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void FillToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void FillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.userTableAdapter1.Fill(this.cSharpCoffeeDataSet1.User);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FillToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dgv_(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dgvEmp.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                txtUsername.Text = row.Cells[0].Value.ToString();
                txtPassword.Text = row.Cells[1].Value.ToString();
                txtFullname.Text = row.Cells[3].Value.ToString();
                txtEmail.Text = row.Cells[4].Value.ToString();
                cbRole.Text = row.Cells[2].Value.ToString();
               
            }
        }

        private void com_ád(object sender, EventArgs e)
        {
            string a = ((KeyValuePair<string, string>)combobox.SelectedItem).Value;
            if (a.Equals("customer"))
            {
                
                DataTable dt = db.searchAllByRole(a);
                dgvEmp.DataSource = dt;
            }
            else if (a.Equals("no"))
            {
                
                DataTable dt = db.searchAllByRole(a);
                dgvEmp.DataSource = dt;
            }
            else if (a.Equals("staff"))
            {

                DataTable dt = db.searchAllByRole(a);
                dgvEmp.DataSource = dt;
            }
            else if (a.Equals("All"))
            {
                DataTable dt = db.searchAllByRoleAll();
                dgvEmp.DataSource = dt;
                this.userTableAdapter1.Fill(this.cSharpCoffeeDataSet1.User);
            }


        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void DgvEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
