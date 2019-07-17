using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeOrder;

namespace CoffeeProject
{
    public partial class CoffeeORderDetai : Form
    {
        DataTable dt;
        BindingSource bs = new BindingSource();
        CoffeeOrderDetailDAO dao = new CoffeeOrderDetailDAO();
        CoffeeOrderDAO cofDao = new CoffeeOrderDAO();
        string username;
        CoffeeOrder.CoffeeOrder COdetail ;

        public CoffeeORderDetai()
        {
            InitializeComponent();
        }

        public CoffeeORderDetai(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void CoffeeORderDetai_Load(object sender, EventArgs e)
        {
            showDetailAboutCustomer();
        }
        //show detail about customer
        public void showDetailAboutCustomer()
        {
            dt = dao.getOrderOfCustomer(username);

            dt.Columns.Add("SubTotal", typeof(double), "Quantity*Price");
            txtOrderID.DataBindings.Clear();
            txtCoffeeID.DataBindings.Clear();
            txtQuantity.DataBindings.Clear();
            txtPrice.DataBindings.Clear();

            bs.DataSource = dt;
            dgvCoffeeOrderDetail.DataSource = bs;

            txtOrderID.DataBindings.Add("Text", bs, "CoffeeOrderId");
            txtCoffeeID.DataBindings.Add("Text", bs, "CoffeeId");
            txtQuantity.DataBindings.Add("Text", bs, "Quantity");
            txtPrice.DataBindings.Add("Text", bs, "Price");
        }
     
        // delete one history of customer
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            
            string id = txtOrderID.Text;
            if (!id.Equals("")){
                // delete one value of coffee order details
                if (dao.deleteCoffee(int.Parse(id)))
                {
                    // delete one value of coffee order when delete one value of coffee order details
                    cofDao.deleteCoffee(int.Parse(id));
                    MessageBox.Show("Delete success");
                    showDetailAboutCustomer();
                    COdetail = new CoffeeOrder.CoffeeOrder();
                    COdetail.getAllvalue();
                }
                else
                {
                    MessageBox.Show("Delete Fail");
                }
            }
            else
            {
                MessageBox.Show("Id is not null!!!");
            }
        }
        // update value customer ex:quantity,price...
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (!txtCoffeeID.Text.Equals("") || !txtOrderID.Text.Equals("") || !txtPrice.Text.Equals("") || !txtQuantity.Text.Equals(""))
            {
                CoffeeOrderDetailDTO dto = new CoffeeOrderDetailDTO
                {
                    OrderID = Int32.Parse(txtOrderID.Text),
                    CoffeeID = Int32.Parse(txtCoffeeID.Text),
                    Quantity = Int32.Parse(txtQuantity.Text),
                    Price = Int32.Parse(txtPrice.Text),
                };
                if (dao.updateCoffee(dto))
                {
                    MessageBox.Show("Update success");
                    showDetailAboutCustomer();
                }
                else
                {
                    MessageBox.Show("Update Fail");
                }
            }
            else
            {
                MessageBox.Show("Value of ID , CoffeeID , Quantity and Price is not null");
            }
        }

    }
}
