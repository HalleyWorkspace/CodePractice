namespace ThomasHalleyC968Project
{
    partial class PartForm
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
            this.inhouse = new System.Windows.Forms.RadioButton();
            this.outsourced = new System.Windows.Forms.RadioButton();
            this.windowName = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textInventory = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textMax = new System.Windows.Forms.TextBox();
            this.textChange = new System.Windows.Forms.TextBox();
            this.textMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.changeField = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inhouse
            // 
            this.inhouse.AutoSize = true;
            this.inhouse.Checked = true;
            this.inhouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inhouse.Location = new System.Drawing.Point(177, 31);
            this.inhouse.Name = "inhouse";
            this.inhouse.Size = new System.Drawing.Size(79, 20);
            this.inhouse.TabIndex = 0;
            this.inhouse.TabStop = true;
            this.inhouse.Text = "In-House";
            this.inhouse.UseVisualStyleBackColor = true;
            this.inhouse.UseWaitCursor = true;
            this.inhouse.CheckedChanged += new System.EventHandler(this.inhouse_CheckedChanged);
            // 
            // outsourced
            // 
            this.outsourced.AutoSize = true;
            this.outsourced.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outsourced.Location = new System.Drawing.Point(294, 31);
            this.outsourced.Name = "outsourced";
            this.outsourced.Size = new System.Drawing.Size(94, 20);
            this.outsourced.TabIndex = 1;
            this.outsourced.Text = "Outsourced";
            this.outsourced.UseVisualStyleBackColor = true;
            // 
            // windowName
            // 
            this.windowName.AutoSize = true;
            this.windowName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowName.Location = new System.Drawing.Point(13, 13);
            this.windowName.Name = "windowName";
            this.windowName.Size = new System.Drawing.Size(142, 24);
            this.windowName.TabIndex = 2;
            this.windowName.Text = "Modify/Add Part";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(216, 94);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(100, 20);
            this.textID.TabIndex = 3;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(216, 129);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 20);
            this.textName.TabIndex = 4;
            // 
            // textInventory
            // 
            this.textInventory.Location = new System.Drawing.Point(216, 166);
            this.textInventory.Name = "textInventory";
            this.textInventory.Size = new System.Drawing.Size(100, 20);
            this.textInventory.TabIndex = 5;
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(216, 203);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(100, 20);
            this.textPrice.TabIndex = 6;
            // 
            // textMax
            // 
            this.textMax.Location = new System.Drawing.Point(325, 236);
            this.textMax.Name = "textMax";
            this.textMax.Size = new System.Drawing.Size(63, 20);
            this.textMax.TabIndex = 7;
            // 
            // textChange
            // 
            this.textChange.Location = new System.Drawing.Point(216, 277);
            this.textChange.Name = "textChange";
            this.textChange.Size = new System.Drawing.Size(100, 20);
            this.textChange.TabIndex = 8;
            // 
            // textMin
            // 
            this.textMin.Location = new System.Drawing.Point(216, 240);
            this.textMin.Name = "textMin";
            this.textMin.Size = new System.Drawing.Size(63, 20);
            this.textMin.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Inventory";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Price / Cost";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Max";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(159, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Min";
            // 
            // changeField
            // 
            this.changeField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeField.Location = new System.Drawing.Point(44, 284);
            this.changeField.Name = "changeField";
            this.changeField.Size = new System.Drawing.Size(139, 13);
            this.changeField.TabIndex = 16;
            this.changeField.Text = "Machine ID";
            this.changeField.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.changeField.UseWaitCursor = true;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(323, 330);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(52, 23);
            this.save.TabIndex = 17;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(386, 330);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(60, 23);
            this.cancel.TabIndex = 18;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // PartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 427);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.changeField);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textMin);
            this.Controls.Add(this.textChange);
            this.Controls.Add(this.textMax);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textInventory);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.windowName);
            this.Controls.Add(this.outsourced);
            this.Controls.Add(this.inhouse);
            this.Name = "PartForm";
            this.Text = "Part";
            this.Load += new System.EventHandler(this.PartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton inhouse;
        private System.Windows.Forms.RadioButton outsourced;
        private System.Windows.Forms.Label windowName;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textInventory;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.TextBox textMax;
        private System.Windows.Forms.TextBox textChange;
        private System.Windows.Forms.TextBox textMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label changeField;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
    }
}