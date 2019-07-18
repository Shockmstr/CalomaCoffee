using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User;

namespace CoffeeProject
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
    
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string fullname = txtFullname.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPass = txtConfirm.Text;
            string email = txtEmail.Text;
            string validate = "";

            if (string.IsNullOrWhiteSpace(fullname)) validate += "Full Name\n";
            if (string.IsNullOrWhiteSpace(username)) validate += "Username\n";
            if (string.IsNullOrWhiteSpace(password)) validate += "Password\n";
            if (string.IsNullOrWhiteSpace(confirmPass)) validate += "Confirm Password\n";
            if (string.IsNullOrWhiteSpace(email)) validate += "Email\n";

            if (validate.Equals(""))
            {
                if (confirmPass.Equals(password))
                {
                    try
                    {
                        UserDAO dao = new UserDAO();
                        UserDTO dto = new UserDTO { Fullname = fullname, Username = username, Password = password, Email = email, Role = "customer" };
                        if (dao.CreateUser(dto))
                        {
                            MessageBox.Show("Create success!", "Success");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Create failed!", "Success");
                        } // end create
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show(ex.Message);
                        if (ex.Message.Contains("PRIMARY KEY"))
                        {
                            MessageBox.Show("Username has existed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtUsername.Focus();
                        }
                        if (ex.Message.Contains("Email"))
                        {
                            MessageBox.Show("Email has existed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtEmail.Focus();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Confirm password does not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtConfirm.Focus();
                } // end confirm
            }
            else
            {
                MessageBox.Show("Please fill in following textboxes:\n\n" + validate, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } // end validate
        }
    }
}
