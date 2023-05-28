namespace ThomasHalleyC968Project
{
    partial class InventoryManagementSystem
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
            this.dgParts = new System.Windows.Forms.DataGridView();
            this.dgProducts = new System.Windows.Forms.DataGridView();
            this.searchPart = new System.Windows.Forms.Button();
            this.searchBarPart = new System.Windows.Forms.TextBox();
            this.searchBarProduct = new System.Windows.Forms.TextBox();
            this.searchProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deletePart = new System.Windows.Forms.Button();
            this.modifyPart = new System.Windows.Forms.Button();
            this.addPart = new System.Windows.Forms.Button();
            this.addProduct = new System.Windows.Forms.Button();
            this.modifyProduct = new System.Windows.Forms.Button();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgParts
            // 
            this.dgParts.AllowUserToAddRows = false;
            this.dgParts.AllowUserToDeleteRows = false;
            this.dgParts.AllowUserToResizeColumns = false;
            this.dgParts.AllowUserToResizeRows = false;
            this.dgParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgParts.Location = new System.Drawing.Point(64, 105);
            this.dgParts.MultiSelect = false;
            this.dgParts.Name = "dgParts";
            this.dgParts.ReadOnly = true;
            this.dgParts.RowHeadersVisible = false;
            this.dgParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgParts.Size = new System.Drawing.Size(514, 347);
            this.dgParts.TabIndex = 0;
            this.dgParts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.myBindingComplete);
            // 
            // dgProducts
            // 
            this.dgProducts.AllowUserToAddRows = false;
            this.dgProducts.AllowUserToDeleteRows = false;
            this.dgProducts.AllowUserToResizeColumns = false;
            this.dgProducts.AllowUserToResizeRows = false;
            this.dgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dgProducts.Location = new System.Drawing.Point(634, 105);
            this.dgProducts.MultiSelect = false;
            this.dgProducts.Name = "dgProducts";
            this.dgProducts.ReadOnly = true;
            this.dgProducts.RowHeadersVisible = false;
            this.dgProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProducts.Size = new System.Drawing.Size(514, 347);
            this.dgProducts.TabIndex = 1;
            // 
            // searchPart
            // 
            this.searchPart.AutoEllipsis = true;
            this.searchPart.Location = new System.Drawing.Point(332, 67);
            this.searchPart.Name = "searchPart";
            this.searchPart.Size = new System.Drawing.Size(75, 23);
            this.searchPart.TabIndex = 2;
            this.searchPart.Text = "Search";
            this.searchPart.UseVisualStyleBackColor = true;
            this.searchPart.Click += new System.EventHandler(this.searchPart_Click);
            // 
            // searchBarPart
            // 
            this.searchBarPart.Location = new System.Drawing.Point(413, 67);
            this.searchBarPart.Name = "searchBarPart";
            this.searchBarPart.Size = new System.Drawing.Size(165, 20);
            this.searchBarPart.TabIndex = 3;
            // 
            // searchBarProduct
            // 
            this.searchBarProduct.Location = new System.Drawing.Point(979, 67);
            this.searchBarProduct.Name = "searchBarProduct";
            this.searchBarProduct.Size = new System.Drawing.Size(165, 20);
            this.searchBarProduct.TabIndex = 5;
            // 
            // searchProduct
            // 
            this.searchProduct.AutoEllipsis = true;
            this.searchProduct.Location = new System.Drawing.Point(898, 67);
            this.searchProduct.Name = "searchProduct";
            this.searchProduct.Size = new System.Drawing.Size(75, 23);
            this.searchProduct.TabIndex = 4;
            this.searchProduct.Text = "Search";
            this.searchProduct.UseVisualStyleBackColor = true;
            this.searchProduct.Click += new System.EventHandler(this.searchProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Parts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(630, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Products";
            // 
            // deletePart
            // 
            this.deletePart.Location = new System.Drawing.Point(516, 483);
            this.deletePart.Name = "deletePart";
            this.deletePart.Size = new System.Drawing.Size(61, 23);
            this.deletePart.TabIndex = 8;
            this.deletePart.Text = "Delete";
            this.deletePart.UseVisualStyleBackColor = true;
            this.deletePart.Click += new System.EventHandler(this.deletePart_Click);
            // 
            // modifyPart
            // 
            this.modifyPart.Location = new System.Drawing.Point(456, 483);
            this.modifyPart.Name = "modifyPart";
            this.modifyPart.Size = new System.Drawing.Size(54, 23);
            this.modifyPart.TabIndex = 9;
            this.modifyPart.Text = "Modify";
            this.modifyPart.UseVisualStyleBackColor = true;
            this.modifyPart.Click += new System.EventHandler(this.modifyPart_Click);
            // 
            // addPart
            // 
            this.addPart.Location = new System.Drawing.Point(402, 483);
            this.addPart.Name = "addPart";
            this.addPart.Size = new System.Drawing.Size(48, 23);
            this.addPart.TabIndex = 10;
            this.addPart.Text = "Add";
            this.addPart.UseVisualStyleBackColor = true;
            this.addPart.Click += new System.EventHandler(this.addPart_Click);
            // 
            // addProduct
            // 
            this.addProduct.Location = new System.Drawing.Point(967, 483);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(48, 23);
            this.addProduct.TabIndex = 13;
            this.addProduct.Text = "Add";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // modifyProduct
            // 
            this.modifyProduct.Location = new System.Drawing.Point(1021, 483);
            this.modifyProduct.Name = "modifyProduct";
            this.modifyProduct.Size = new System.Drawing.Size(54, 23);
            this.modifyProduct.TabIndex = 12;
            this.modifyProduct.Text = "Modify";
            this.modifyProduct.UseVisualStyleBackColor = true;
            this.modifyProduct.Click += new System.EventHandler(this.modifyProduct_Click);
            // 
            // deleteProduct
            // 
            this.deleteProduct.Location = new System.Drawing.Point(1081, 483);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(61, 23);
            this.deleteProduct.TabIndex = 11;
            this.deleteProduct.Text = "Delete";
            this.deleteProduct.UseVisualStyleBackColor = true;
            this.deleteProduct.Click += new System.EventHandler(this.deleteProduct_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(1068, 528);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 14;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Inventory Management System";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PartID";
            this.Column1.HeaderText = "Part ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "InStock";
            this.Column3.HeaderText = "Inventory";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Price";
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Min";
            this.Column5.HeaderText = "Min";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 70;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Max";
            this.Column6.HeaderText = "Max";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 70;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "ProductId";
            this.Column7.HeaderText = "Product ID";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 85;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Name";
            this.Column8.HeaderText = "Name";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 95;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "InStock";
            this.Column9.HeaderText = "Inventory";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 95;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Price";
            this.Column10.HeaderText = "Price";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 95;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "Min";
            this.Column11.HeaderText = "Min";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 70;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "Max";
            this.Column12.HeaderText = "Max";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 70;
            // 
            // InventoryManagementSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 563);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.modifyProduct);
            this.Controls.Add(this.deleteProduct);
            this.Controls.Add(this.addPart);
            this.Controls.Add(this.modifyPart);
            this.Controls.Add(this.deletePart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBarProduct);
            this.Controls.Add(this.searchProduct);
            this.Controls.Add(this.searchBarPart);
            this.Controls.Add(this.searchPart);
            this.Controls.Add(this.dgProducts);
            this.Controls.Add(this.dgParts);
            this.Name = "InventoryManagementSystem";
            this.RightToLeftLayout = true;
            this.Text = "Inventory Management System";
            ((System.ComponentModel.ISupportInitialize)(this.dgParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgParts;
        private System.Windows.Forms.DataGridView dgProducts;
        private System.Windows.Forms.Button searchPart;
        private System.Windows.Forms.TextBox searchBarPart;
        private System.Windows.Forms.TextBox searchBarProduct;
        private System.Windows.Forms.Button searchProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deletePart;
        private System.Windows.Forms.Button modifyPart;
        private System.Windows.Forms.Button addPart;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.Button modifyProduct;
        private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
    }
}

