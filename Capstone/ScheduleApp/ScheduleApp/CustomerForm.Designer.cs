
namespace ScheduleApp
{
    partial class CustomerForm
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
            this.countryBox = new System.Windows.Forms.TextBox();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.phoneNumberBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addEditLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.postalCodeBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // countryBox
            // 
            this.countryBox.Location = new System.Drawing.Point(100, 257);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(140, 20);
            this.countryBox.TabIndex = 0;
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(100, 217);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(140, 20);
            this.cityBox.TabIndex = 1;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(100, 137);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(140, 20);
            this.addressBox.TabIndex = 2;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(100, 57);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(140, 20);
            this.nameBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Country";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name";
            // 
            // phoneNumberBox
            // 
            this.phoneNumberBox.Location = new System.Drawing.Point(100, 93);
            this.phoneNumberBox.Name = "phoneNumberBox";
            this.phoneNumberBox.Size = new System.Drawing.Size(140, 20);
            this.phoneNumberBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone Number";
            // 
            // addEditLabel
            // 
            this.addEditLabel.AutoSize = true;
            this.addEditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEditLabel.Location = new System.Drawing.Point(13, 20);
            this.addEditLabel.Name = "addEditLabel";
            this.addEditLabel.Size = new System.Drawing.Size(187, 25);
            this.addEditLabel.TabIndex = 10;
            this.addEditLabel.Text = "add/edit Customer";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(125, 301);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Postal Code";
            // 
            // postalCodeBox
            // 
            this.postalCodeBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.postalCodeBox.Location = new System.Drawing.Point(100, 177);
            this.postalCodeBox.Name = "postalCodeBox";
            this.postalCodeBox.Size = new System.Drawing.Size(140, 20);
            this.postalCodeBox.TabIndex = 13;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 344);
            this.Controls.Add(this.postalCodeBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addEditLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.phoneNumberBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.countryBox);
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox countryBox;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phoneNumberBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label addEditLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox postalCodeBox;
    }
}