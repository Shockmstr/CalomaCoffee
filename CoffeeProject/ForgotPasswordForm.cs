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
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void btnFindPass_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string validate = "";
            if (email.Length == 0) validate += "Email is empty!\n";
            
            if (validate.Equals(""))
            {
                try
                {
                    UserDAO dao = new UserDAO();
                    string pass = dao.FindPassword(email);
                    if (!pass.Equals(""))
                    {
                        string noti = "Your password is: \n\n" + pass;
                        DialogResult res = MessageBox.Show(noti, "Find Your Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (res.Equals(DialogResult.OK))
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email's not found!", "Error");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show(validate, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
