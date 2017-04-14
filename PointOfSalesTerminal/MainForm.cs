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
    public partial class MainForm : Form
    {
        public Inventory inventory;
        public ManageStockForm manageStockForm;
        public RestockForm restockForm;
        public TerminalForm terminalForm;

        public MainForm()
        {
            InitializeComponent();
            inventory = new Inventory();
        }
        
        private void needRestockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            restockForm = new RestockForm(this);
            restockForm.MdiParent = this;
            restockForm.Show();
        }

        private void manageStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manageStockForm = new ManageStockForm(this);
            manageStockForm.MdiParent = this;
            manageStockForm.Show();
        }

        private void terminalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            terminalForm = new TerminalForm(this);
            terminalForm.MdiParent = this;
            terminalForm.Show();
        }

        private void closeAllButton_Click(object sender, EventArgs e)
        {
            if (manageStockForm != null) manageStockForm.Close();
            if (restockForm != null) restockForm.Close();
            if (terminalForm != null) terminalForm.Close();
        }
    }
}
