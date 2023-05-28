namespace ThomasHalleyC968Project
{
    partial class ProductForm
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
            this.allParts = new System.Windows.Forms.DataGridView();
            this.associatedParts = new System.Windows.Forms.DataGridView();
            this.addPart = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.productId = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.inventory = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.min = new System.Windows.Forms.TextBox();
            this.max = new System.Windows.Forms.TextBox();
            this.windowName = new System.Windows.Forms.Label();
            this.partSearchBar = new System.Windows.Forms.TextBox();
            this.partSearch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
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
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.allParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedParts)).BeginInit();
            this.SuspendLayout();
            // 
            // allParts
            // 
            this.allParts.AllowUserToAddRows = false;
            this.allParts.AllowUserToDeleteRows = false;
            this.allParts.AllowUserToResizeColumns = false;
            this.allParts.AllowUserToResizeRows = false;
            this.allParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.allParts.Location = new System.Drawing.Point(441, 61);
            this.allParts.MultiSelect = false;
            this.allParts.Name = "allParts";
            this.allParts.ReadOnly = true;
            this.allParts.RowHeadersVisible = false;
            this.allParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allParts.Size = new System.Drawing.Size(458, 162);
            this.allParts.TabIndex = 0;
            // 
            // associatedParts
            // 
            this.associatedParts.AllowUserToAddRows = false;
            this.associatedParts.AllowUserToDeleteRows = false;
            this.associatedParts.AllowUserToResizeColumns = false;
            this.associatedParts.AllowUserToResizeRows = false;
            this.associatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.associatedParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column13});
            this.associatedParts.Location = new System.Drawing.Point(441, 315);
            this.associatedParts.MultiSelect = false;
            this.associatedParts.Name = "associatedParts";
            this.associatedParts.ReadOnly = true;
            this.associatedParts.RowHeadersVisible = false;
            this.associatedParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.associatedParts.Size = new System.Drawing.Size(458, 168);
            this.associatedParts.TabIndex = 1;
            // 
            // addPart
            // 
            this.addPart.Location = new System.Drawing.Point(834, 238);
            this.addPart.Name = "addPart";
            this.addPart.Size = new System.Drawing.Size(53, 23);
            this.addPart.TabIndex = 2;
            this.addPart.Text = "Add";
            this.addPart.UseVisualStyleBackColor = true;
            this.addPart.Click += new System.EventHandler(this.addPart_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(834, 503);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(53, 23);
            this.delete.TabIndex = 3;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(834, 532);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(52, 23);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(775, 532);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(53, 23);
            this.save.TabIndex = 5;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Inventory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Max";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(53, 340);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(24, 13);
            this.label.TabIndex = 11;
            this.label.Text = "Min";
            // 
            // productId
            // 
            this.productId.Location = new System.Drawing.Point(132, 172);
            this.productId.Name = "productId";
            this.productId.ReadOnly = true;
            this.productId.Size = new System.Drawing.Size(124, 20);
            this.productId.TabIndex = 12;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(132, 203);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(124, 20);
            this.name.TabIndex = 13;
            // 
            // inventory
            // 
            this.inventory.Location = new System.Drawing.Point(132, 241);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(124, 20);
            this.inventory.TabIndex = 14;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(132, 282);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(124, 20);
            this.price.TabIndex = 15;
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(98, 332);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(75, 20);
            this.min.TabIndex = 16;
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(239, 331);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(88, 20);
            this.max.TabIndex = 17;
            // 
            // windowName
            // 
            this.windowName.AutoSize = true;
            this.windowName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowName.Location = new System.Drawing.Point(42, 29);
            this.windowName.Name = "windowName";
            this.windowName.Size = new System.Drawing.Size(175, 24);
            this.windowName.TabIndex = 18;
            this.windowName.Text = "Add/Modify Product";
            // 
            // partSearchBar
            // 
            this.partSearchBar.Location = new System.Drawing.Point(798, 29);
            this.partSearchBar.Name = "partSearchBar";
            this.partSearchBar.Size = new System.Drawing.Size(100, 20);
            this.partSearchBar.TabIndex = 19;
            // 
            // partSearch
            // 
            this.partSearch.Location = new System.Drawing.Point(717, 26);
            this.partSearch.Name = "partSearch";
            this.partSearch.Size = new System.Drawing.Size(75, 23);
            this.partSearch.TabIndex = 20;
            this.partSearch.Text = "Search";
            this.partSearch.UseVisualStyleBackColor = true;
            this.partSearch.Click += new System.EventHandler(this.partSearch_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(441, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "All candidate Parts";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(441, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Parts Associated with this Product";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PartId";
            this.Column1.HeaderText = "Part Id";
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
            this.Column2.Width = 85;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "InStock";
            this.Column3.HeaderText = "Inventory";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Price";
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
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
            this.Column7.DataPropertyName = "PartId";
            this.Column7.HeaderText = "Part ID";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 70;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Name";
            this.Column8.HeaderText = "Name";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 85;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "InStock";
            this.Column9.HeaderText = "Inventory";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 80;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Price";
            this.Column10.HeaderText = "Price";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 80;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "Min";
            this.Column11.HeaderText = "Min";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 70;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "Max";
            this.Column13.HeaderText = "Max";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 70;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 567);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.partSearch);
            this.Controls.Add(this.partSearchBar);
            this.Controls.Add(this.windowName);
            this.Controls.Add(this.max);
            this.Controls.Add(this.min);
            this.Controls.Add(this.price);
            this.Controls.Add(this.inventory);
            this.Controls.Add(this.name);
            this.Controls.Add(this.productId);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.addPart);
            this.Controls.Add(this.associatedParts);
            this.Controls.Add(this.allParts);
            this.Name = "ProductForm";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView allParts;
        private System.Windows.Forms.DataGridView associatedParts;
        private System.Windows.Forms.Button addPart;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox productId;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox inventory;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox min;
        private System.Windows.Forms.TextBox max;
        private System.Windows.Forms.Label windowName;
        private System.Windows.Forms.TextBox partSearchBar;
        private System.Windows.Forms.Button partSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
    }
}