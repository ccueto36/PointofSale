namespace PointOfSalesTerminal
{
    partial class SellItemForm
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
            this.quantityEnterButton = new System.Windows.Forms.Button();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // quantityEnterButton
            // 
            this.quantityEnterButton.Location = new System.Drawing.Point(170, 10);
            this.quantityEnterButton.Name = "quantityEnterButton";
            this.quantityEnterButton.Size = new System.Drawing.Size(75, 23);
            this.quantityEnterButton.TabIndex = 0;
            this.quantityEnterButton.Text = "Enter";
            this.quantityEnterButton.UseVisualStyleBackColor = true;
            this.quantityEnterButton.Click += new System.EventHandler(this.quantityEnterButton_Click);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(53, 12);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 1;
            // 
            // SellItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 51);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.quantityEnterButton);
            this.Name = "SellItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Enter Quantity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button quantityEnterButton;
        private System.Windows.Forms.TextBox quantityTextBox;
    }
}