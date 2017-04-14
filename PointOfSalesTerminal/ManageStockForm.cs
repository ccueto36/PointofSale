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
    public partial class ManageStockForm : Form
    {
        MainForm parent;
        public ManageStockForm(MainForm parentForm)
        {
            InitializeComponent();
            parent = parentForm;
            products = parentForm.inventory.GetList();
            
        }

        public BindingList<Product> products;
        

        private void ManageStockForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = products;

            DataGridViewColumn idColumn = new DataGridViewTextBoxColumn();
            DataGridViewColumn nameColumn = new DataGridViewTextBoxColumn();
            DataGridViewColumn priceColumn = new DataGridViewTextBoxColumn();
            DataGridViewColumn quantityColumn = new DataGridViewTextBoxColumn();
            DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn();
            DataGridViewButtonColumn removeButtonColumn = new DataGridViewButtonColumn();

            idColumn.Name = "Id";
            idColumn.DataPropertyName = "Id";
            nameColumn.Name = "Name";
            nameColumn.DataPropertyName = "Name";
            priceColumn.Name = "Price";
            priceColumn.DataPropertyName = "Price";
            priceColumn.DefaultCellStyle.Format = "C";
            quantityColumn.Name = "Quantity";
            quantityColumn.DataPropertyName = "Quantity";
            updateButtonColumn.Name = "Update";
            updateButtonColumn.Text = "Update";
            updateButtonColumn.UseColumnTextForButtonValue = true;
            removeButtonColumn.Name = "Remove";
            removeButtonColumn.Text = "Remove";
            removeButtonColumn.UseColumnTextForButtonValue = true;

           
            dataGridView1.Columns.Add(idColumn);
            dataGridView1.Columns.Add(nameColumn);
            dataGridView1.Columns.Add(priceColumn);
            dataGridView1.Columns.Add(quantityColumn);
            dataGridView1.Columns.Add(updateButtonColumn);
            dataGridView1.Columns.Add(removeButtonColumn);
            
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            string productName = "";
            double productPrice;
            int productQuantity;
            string productDescription = "";

            if (nameButton.Text != "") productName = nameButton.Text;
            else MessageBox.Show("Please enter a product name");

            if (Double.TryParse(priceButton.Text, out productPrice)) productPrice = Double.Parse(priceButton.Text);  
            else MessageBox.Show("Please enter a valid product price");

            if (Int32.TryParse(quantityButton.Text, out productQuantity)) productQuantity = Int32.Parse(quantityButton.Text);
            else MessageBox.Show("Please enter a valid product quantity");

            if (descriptionButton.Text != "") productDescription = descriptionButton.Text;
            
            if( productName != "" && productPrice != 0 && productQuantity >= 0)
            {
                products.Add(new Product(productName, productPrice, productQuantity, productDescription));
            }
       
            dataGridView1.Refresh();
            ClearAddProductFields();
            if (parent.terminalForm != null)
            {
                parent.terminalForm.GenerateProductButtons();
            }

            if (parent.restockForm != null)
            {
                parent.restockForm.RefreshData();
            }
            


        }

        private void ClearAddProductFields()
        {
            nameButton.Clear();
            priceButton.Clear();
            quantityButton.Clear();
            descriptionButton.Clear();
        }

        public void RefreshChildrenForms()
        {
            dataGridView1.Refresh();
            if (parent.terminalForm != null)
            {
                parent.terminalForm.GenerateProductButtons();
            }

            if (parent.restockForm != null)
            {
                parent.restockForm.RefreshData();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView) sender;

            if (senderGrid.Columns[e.ColumnIndex].Name == "Remove" && e.RowIndex >= 0)
            { 
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "Confirm", 
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Yes)
                {
                    products.RemoveAt(e.RowIndex);
                    RefreshChildrenForms();
                }
                
            }

            if (senderGrid.Columns[e.ColumnIndex].Name == "Update" && e.RowIndex >= 0)
            {
                Product selectedProduct = products.ElementAt(e.RowIndex);
                new UpdateProductForm(selectedProduct).ShowDialog();
                RefreshChildrenForms();
            }
        }
    }


}
