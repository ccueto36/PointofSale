namespace PointOfSalesTerminal
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.needRestockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.terminalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageStockToolStripMenuItem,
            this.needRestockToolStripMenuItem,
            this.toolStripMenuItem1,
            this.terminalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1484, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageStockToolStripMenuItem
            // 
            this.manageStockToolStripMenuItem.Name = "manageStockToolStripMenuItem";
            this.manageStockToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.manageStockToolStripMenuItem.Text = "Manage Stock";
            this.manageStockToolStripMenuItem.Click += new System.EventHandler(this.manageStockToolStripMenuItem_Click);
            // 
            // needRestockToolStripMenuItem
            // 
            this.needRestockToolStripMenuItem.Name = "needRestockToolStripMenuItem";
            this.needRestockToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.needRestockToolStripMenuItem.Text = "Need Restock";
            this.needRestockToolStripMenuItem.Click += new System.EventHandler(this.needRestockToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // terminalToolStripMenuItem
            // 
            this.terminalToolStripMenuItem.Name = "terminalToolStripMenuItem";
            this.terminalToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.terminalToolStripMenuItem.Text = "Point-of-Sales Terminal";
            this.terminalToolStripMenuItem.Click += new System.EventHandler(this.terminalToolStripMenuItem_Click);
            // 
            // closeAllButton
            // 
            this.closeAllButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.closeAllButton.Location = new System.Drawing.Point(0, 1003);
            this.closeAllButton.Name = "closeAllButton";
            this.closeAllButton.Size = new System.Drawing.Size(1484, 50);
            this.closeAllButton.TabIndex = 3;
            this.closeAllButton.Text = "Close All";
            this.closeAllButton.UseVisualStyleBackColor = true;
            this.closeAllButton.Click += new System.EventHandler(this.closeAllButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 1053);
            this.Controls.Add(this.closeAllButton);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Point of Sales Terminal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem needRestockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem terminalToolStripMenuItem;
        private System.Windows.Forms.Button closeAllButton;
    }
}

