using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSalesTerminal
{
    public partial class RestockForm : Form
    {
        
        private BindingList<Product> products;

        public RestockForm(MainForm products)
        {
            InitializeComponent();
            this.products = products.inventory.GetList();
        }

        private void RestockForm_Load(object sender, EventArgs e)
        {
            productListView.View = View.Details;
            productListView.GridLines = true;
            productListView.FullRowSelect = true;
            productListView.AutoSize = true;

            productListView.Columns.Add("Id", 40);
            productListView.Columns.Add("Name", 150);
            productListView.Columns.Add("Price", 100);
            productListView.Columns.Add("Quantity", 100);

            PopulateList();
        }

        private void PopulateList()
        {
            string[] arr = new string[4];
            ListViewItem item;

            for (int i = 0; i < products.Count; i++)
            {
                if(products.ElementAt(i).Quantity < 20)
                {
                    arr[0] = products.ElementAt(i).Id.ToString();
                    arr[1] = products.ElementAt(i).Name;
                    arr[2] = products.ElementAt(i).Price.ToString("C");
                    arr[3] = products.ElementAt(i).Quantity.ToString();
                    item = new ListViewItem(arr);
                    productListView.Items.Add(item);
                }
                
            }
        }

        public void RefreshData()
        {
            productListView.Items.Clear();
            PopulateList();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
