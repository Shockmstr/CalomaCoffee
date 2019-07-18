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
using Customer;

namespace CoffeeProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void linkLbForgetPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPasswordForm fpf = new ForgotPasswordForm();
            fpf.ShowDialog(this);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm rf = new RegisterForm();
            rf.ShowDialog(this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            UserDAO dao = new UserDAO();
            try
            {
                string role = dao.CheckLogin(username, password);
                if (role.Equals("Customer", StringComparison.CurrentCultureIgnoreCase))
                {
                    MessageBox.Show("CUSTOMER");
                } else if (role.Equals("Staff", StringComparison.CurrentCultureIgnoreCase))
                {
                    MessageBox.Show("STAFF");
                    MasterForm fs = new MasterForm();
                    fs.Show();

                }
                else
                {
                    MessageBox.Show("Username or password is wrong!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainCoffee mc = new MainCoffee();
            mc.Show();
            this.Hide();

        }
        
        
    }
}
