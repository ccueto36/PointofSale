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
    public partial class UpdateProductForm : Form
    {
        private Product selectedProduct;
        public UpdateProductForm(Product product)
        {
            InitializeComponent();
            selectedProduct = product;
        }

        private void UpdateProductForm_Load(object sender, EventArgs e)
        {
            nameTextBox.Text = selectedProduct.Name;
            priceTextBox.Text = selectedProduct.Price.ToString();
            quantityTextBox.Text = selectedProduct.Quantity.ToString();
            descriptionTextBox.Text = selectedProduct.Description;
        }

        private void updateProductButton_Click(object sender, EventArgs e)
        {
            double price;
            int quantity;
            selectedProduct.Name = nameTextBox.Text;
            if (Double.TryParse(priceTextBox.Text, out price)) selectedProduct.Price = price;
            else MessageBox.Show("Enter valid price");
            if (Int32.TryParse(quantityTextBox.Text, out quantity)) selectedProduct.Quantity = quantity;
            else MessageBox.Show("Enter valid quantity");
            selectedProduct.Description = descriptionTextBox.Text;
            if (selectedProduct.Name != "" && quantity >= 0)
            {
                Close();
            }
            else MessageBox.Show("Please revise input fields");
        }
    }
}
