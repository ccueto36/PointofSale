namespace PointOfSalesTerminal
{
    partial class ManageStockForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nameButton = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.descriptionButton = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.quantityButton = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.priceButton = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addProductButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(629, 445);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nameButton);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.descriptionButton);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.quantityButton);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.priceButton);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.addProductButton);
            this.groupBox1.Location = new System.Drawing.Point(1, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 90);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Product";
            // 
            // nameButton
            // 
            this.nameButton.Location = new System.Drawing.Point(6, 49);
            this.nameButton.Name = "nameButton";
            this.nameButton.Size = new System.Drawing.Size(100, 20);
            this.nameButton.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(251, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Description";
            // 
            // descriptionButton
            // 
            this.descriptionButton.Location = new System.Drawing.Point(250, 49);
            this.descriptionButton.Name = "descriptionButton";
            this.descriptionButton.Size = new System.Drawing.Size(187, 20);
            this.descriptionButton.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(180, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Quantity";
            // 
            // quantityButton
            // 
            this.quantityButton.Location = new System.Drawing.Point(193, 49);
            this.quantityButton.Name = "quantityButton";
            this.quantityButton.Size = new System.Drawing.Size(33, 20);
            this.quantityButton.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(125, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Price";
            // 
            // priceButton
            // 
            this.priceButton.Location = new System.Drawing.Point(124, 49);
            this.priceButton.Name = "priceButton";
            this.priceButton.Size = new System.Drawing.Size(53, 20);
            this.priceButton.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Name";
            // 
            // addProductButton
            // 
            this.addProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductButton.Location = new System.Drawing.Point(456, 46);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(75, 23);
            this.addProductButton.TabIndex = 10;
            this.addProductButton.Text = "Add";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // ManageStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(627, 554);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManageStockForm";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.ManageStockForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nameButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox descriptionButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox quantityButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox priceButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button addProductButton;
    }
}