using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coffee;

namespace CoffeeProject
{  
    public partial class MainCoffee : Form
    {
        string username;
        public MainCoffee()
        {
            InitializeComponent();
        }

        public MainCoffee(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void MainCoffee_Load(object sender, EventArgs e)
        {
            LoadList();
            GetAutoCompleteFilter();
        }

        private void LoadList()
        {
            CoffeeDAO dao = new CoffeeDAO();
            List<CoffeeDTO> list = dao.getCoffeeList();
            bsCoffee.DataSource = list;

            lbName.DataBindings.Clear();
            txtDesc.DataBindings.Clear();
            TotalPrice.DataBindings.Clear();

            lbName.DataBindings.Add("Text", bsCoffee, "Name");
            txtDesc.DataBindings.Add("Text", bsCoffee, "Description");
            txtPrice.DataBindings.Add("Text", bsCoffee, "Price");
            TotalPrice.DataBindings.Add("Text", bsCoffee, "Price");

            listCoffee.DataSource = bsCoffee;
            listCoffee.DisplayMember = "Name";
            /*foreach (CoffeeDTO item in list)
            {
                listCoffee.Items.Add(item.Name);
            }*/
           
        }
        private void GetAutoCompleteFilter()
        {
            CoffeeDAO dao = new CoffeeDAO();
            List<CoffeeDTO> list = dao.getCoffeeList();
            var source = new AutoCompleteStringCollection();
            foreach (var dto in list)
            {
                source.Add(dto.Name);
            }
            txtFilter.AutoCompleteCustomSource = source;
            txtFilter.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtFilter.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void amountBox_ValueChanged(object sender, EventArgs e)
        {
            int value = (int)amountBox.Value;
            int price = Int32.Parse(txtPrice.Text);
            int total = price * value;
            TotalPrice.Text = total.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnProceed_Click(object sender, EventArgs e)
        {

        }

        private void listCoffee_SelectedValueChanged(object sender, EventArgs e)
        {
            amountBox.Value = 1;
        }

        private void txtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listCoffee.DataSource = null;
                string sFilter = txtFilter.Text;
                listCoffee.BeginUpdate();
                listCoffee.Items.Clear();
                CoffeeDAO dao = new CoffeeDAO();
                List<CoffeeDTO> list = dao.getCoffeeList();
                List<CoffeeDTO> filterList = new List<CoffeeDTO>();
                foreach (var dto in list)
                {
                    if (dto.Name.ToLower().Contains(sFilter.ToLower()))
                    {
                        filterList.Add(dto);
                    }
                }
                bsCoffee.DataSource = filterList;
                listCoffee.DataSource = bsCoffee;
                listCoffee.DisplayMember = "Name";
                listCoffee.EndUpdate();
            }
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            UserAccount ua = new UserAccount(username);
            ua.ShowDialog(this);
        }
    }
}
