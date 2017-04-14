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
    public partial class SellItemForm : Form
    {
        private int quantitySold;
        public int soldAmount
        {
            get
            {
                return quantitySold;
            }
        }
        Product selectedProduct;
        public SellItemForm(Product selectedProduct)
        {
            InitializeComponent();
            this.selectedProduct = selectedProduct;
        }

        private bool SellItem(out int qty)
        {
            int quantity;
            if (Int32.TryParse(quantityTextBox.Text, out quantity)) quantity = Int32.Parse(quantityTextBox.Text);
            if (selectedProduct.Quantity < quantity)
            {
                MessageBox.Show("Not enough stock available");
                qty = 0;
                return false;
                
            }
                
            else
            {
                selectedProduct.Quantity -= quantity;
                qty = quantity;
            }
            
            return true;
        }

        private void quantityEnterButton_Click(object sender, EventArgs e)
        {
           if(SellItem(out quantitySold))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Enter valid quantity");
            }
            
        }
    }
}
