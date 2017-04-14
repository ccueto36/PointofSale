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
    public partial class TerminalForm : Form
    {
        BindingList<Product> products;
        Inventory inventory;
        MainForm parent;
        BindingList<Product> transaction = new BindingList<Product>();
        double finalPrice = 0;

        public TerminalForm(MainForm parent)
        {
            InitializeComponent();

            products = parent.inventory.GetList();
            inventory = parent.inventory;
            this.parent = parent;
        }

        public void GenerateProductButtons()
        {
            Controls.Clear();

            int topDistance = 10;
            int leftDistance = 10;
            for(int i = 0; i < products.Count; i++)
            {
                Button productButton = new Button();
                productButton.Parent = this;
                productButton.Name = products.ElementAt(i).Name + "Button";
                productButton.Text = products.ElementAt(i).Name;
                productButton.ForeColor = Color.Red;
                productButton.Top = topDistance;
                productButton.Left = leftDistance;
                if (i % 5 == 0 && i != 0)
                {
                    topDistance += 100;
                    leftDistance = 10;
                    productButton.Top = topDistance;
                    productButton.Left = leftDistance;
                }
                leftDistance += 100;
                productButton.Size = new Size(80, 60);

                productButton.Click += ProductButton_Click;
            }

            DrawGenerateReceiptButton();

        }

        private void DrawGenerateReceiptButton()
        {
            Button finishButton = new Button();
            finishButton.Parent = this;
            finishButton.Text = "Generate Receipt";
            finishButton.Font = new Font(this.Font, FontStyle.Bold);
            finishButton.ForeColor = System.Drawing.Color.DarkGreen;
            finishButton.Name = "finishTransactionButton";
            finishButton.Anchor = AnchorStyles.None;
            finishButton.Top = (this.ClientSize.Height - finishButton.Height);
            finishButton.Left = (this.ClientSize.Width - finishButton.Width) / 2;
            finishButton.Size = new Size(100, 100);
            finishButton.Click += FinishButton_Click;

        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            string output = "";
            foreach(Product record in transaction)
            {
                finalPrice += record.Price * record.Quantity;
                output += record.Name + ": x" + record.Quantity + "  @" + record.Price.ToString("C") +  "/each\n";
                
            }
            output += "----Total Price: " + finalPrice.ToString("C") + "----";
            MessageBox.Show(output, "Receipt");
        
            
        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Product product = inventory.FindProductByName(button.Text);
            SellItemForm itemQuantity = new SellItemForm(product);
            itemQuantity.ShowDialog(this);
            RefreshChildrenForms();
            Product prod = new Product(0, button.Text, product.Price, itemQuantity.soldAmount, "");
            transaction.Add(prod);


        }

        private void RefreshChildrenForms()
        {
            
            if (parent.manageStockForm != null)
            {
                parent.manageStockForm.RefreshChildrenForms();
            }

            if (parent.restockForm != null)
            {
                parent.restockForm.RefreshData();
            }
        }

        private void TerminalForm_Load(object sender, EventArgs e)
        {
            GenerateProductButtons();

        }
    }
}
