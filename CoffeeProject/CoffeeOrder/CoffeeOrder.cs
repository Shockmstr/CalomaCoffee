using CoffeeProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeOrder
{
    public partial class CoffeeOrder : Form
    {
        public CoffeeOrder()
        {
            InitializeComponent();
            
        }
        DataTable dtCoffee = new DataTable();
        CoffeeOrderDAO dao = new CoffeeOrderDAO();
        CoffeeORderDetai detail;
        public void getAllvalue()
        {
            dtCoffee = dao.GetAllCoffee();
            txtCoffeeOrderID.DataBindings.Clear();
            txtUserName.DataBindings.Clear();
            txtOrderDate.DataBindings.Clear();
            txtStatus.DataBindings.Clear();

            txtCoffeeOrderID.DataBindings.Add("Text", dtCoffee, "CoffeeOrderID");
            txtUserName.DataBindings.Add("Text", dtCoffee, "UserName");
            txtOrderDate.DataBindings.Add("Text", dtCoffee, "OrderDate");
            txtStatus.DataBindings.Add("Text", dtCoffee, "status");
            dgvCoffeeOrder.DataSource = dtCoffee;
        }
        // search one value or all value
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            this.btnDetail.Enabled = true;
            this.btnDelete.Enabled = true;
            this.btnUpdateCoffee.Enabled = true;
            if (txtCoffeeOrderID.Text.Equals(""))
            {
                getAllvalue();
            }
            else
            {
                int id = int.Parse(txtCoffeeOrderID.Text);
                dtCoffee = dao.findCoffee(id);

                txtCoffeeOrderID.DataBindings.Clear();
                txtUserName.DataBindings.Clear();
                txtOrderDate.DataBindings.Clear();
                txtStatus.DataBindings.Clear();

                txtCoffeeOrderID.DataBindings.Add("Text", dtCoffee, "CoffeeOrderID");
                txtUserName.DataBindings.Add("Text", dtCoffee, "UserName");
                txtOrderDate.DataBindings.Add("Text", dtCoffee, "OrderDate");
                txtStatus.DataBindings.Add("Text", dtCoffee, "status");
                dgvCoffeeOrder.DataSource = dtCoffee;
            }
        }

        // clear all text 
        private void BtnClear_Click(object sender, EventArgs e)
        {
            this.txtCoffeeOrderID.Enabled = true;
            txtCoffeeOrderID.Clear();
            txtUserName.Clear();
            txtOrderDate.Clear();
            txtStatus.Clear();
        }
        // update status 
        private void BtnUpdateCoffee_Click(object sender, EventArgs e)
        {
            string id = txtCoffeeOrderID.Text;
            if (!txtCoffeeOrderID.Text.Equals("") || !txtOrderDate.Text.Equals("") || !txtUserName.Text.Equals(""))
            {
                int status = int.Parse(txtStatus.Text);
                if (!status.Equals(""))
                {
                    bool r = dao.updateCoffee(status,int.Parse(id));
                    string s = (r == true ? "Update success" : "Update fail,you can not update Id ");
                    MessageBox.Show("Update Coffeee " + s);
                    getAllvalue();
                }
            }else if (id.Equals(0) || id.Equals(""))
            {
                MessageBox.Show("Id is not null!!");
            }
            else
            {
                MessageBox.Show("Status is not isEmpty!!!");
            }
            
        }
        // delete one order coffee
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string id =(txtCoffeeOrderID.Text);
            if (!id.Equals("")) { 
                bool r = dao.deleteCoffee(int.Parse(id));
                string s = (r == true ? "success" : "fail");
                MessageBox.Show("Delete Coffee " + s);
                getAllvalue();
            }
            else
            {
                MessageBox.Show("You need insert Id to delete coffee");
            }
        }
        // show detail about coffeeOrder
        private void BtnDetail_Click(object sender, EventArgs e)
        {
            String userName = txtUserName.Text;
            detail = new CoffeeORderDetai(userName);
            detail.ShowDialog(this);
        }
    }
}
