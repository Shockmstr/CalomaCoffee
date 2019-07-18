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
    public partial class UserAccount : Form
    {
        string username;
        public UserAccount()
        {
            InitializeComponent();
        }

        public UserAccount(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void LoadInfo()
        {
            UserDAO dao = new UserDAO();
            UserDTO dto = dao.FindUser(username);
            if (dto != null)
            {
                txtFullname.Text = dto.Fullname;
                txtUsername.Text = dto.Username;
                txtPassword.Text = dto.Password;
                txtEmail.Text = dto.Email;
            }
        }

        private void chkUnmask_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUnmask.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void UserAccount_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }
    }
}
