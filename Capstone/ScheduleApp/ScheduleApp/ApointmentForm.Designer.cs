
namespace ScheduleApp
{
    partial class ApointmentForm
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
            this.formNameLabel = new System.Windows.Forms.Label();
            this.apointmentDate = new System.Windows.Forms.DateTimePicker();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.apointmentTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.consultantSelect = new System.Windows.Forms.ComboBox();
            this.apointmentView = new System.Windows.Forms.DataGridView();
            this.customerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.apointmentView)).BeginInit();
            this.SuspendLayout();
            // 
            // formNameLabel
            // 
            this.formNameLabel.AutoSize = true;
            this.formNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formNameLabel.Location = new System.Drawing.Point(13, 20);
            this.formNameLabel.Name = "formNameLabel";
            this.formNameLabel.Size = new System.Drawing.Size(215, 25);
            this.formNameLabel.TabIndex = 1;
            this.formNameLabel.Text = "add/edit Appointment";
            // 
            // apointmentDate
            // 
            this.apointmentDate.Location = new System.Drawing.Point(123, 104);
            this.apointmentDate.Name = "apointmentDate";
            this.apointmentDate.Size = new System.Drawing.Size(200, 20);
            this.apointmentDate.TabIndex = 2;
            this.apointmentDate.Value = new System.DateTime(2022, 8, 4, 0, 0, 0, 0);
            // 
            // typeBox
            // 
            this.typeBox.Location = new System.Drawing.Point(123, 69);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(151, 20);
            this.typeBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Apointment Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apointment Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Customer";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(705, 350);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // apointmentTime
            // 
            this.apointmentTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.apointmentTime.Location = new System.Drawing.Point(329, 104);
            this.apointmentTime.Name = "apointmentTime";
            this.apointmentTime.ShowUpDown = true;
            this.apointmentTime.Size = new System.Drawing.Size(200, 20);
            this.apointmentTime.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Consultant";
            // 
            // consultantSelect
            // 
            this.consultantSelect.FormattingEnabled = true;
            this.consultantSelect.Location = new System.Drawing.Point(377, 69);
            this.consultantSelect.Name = "consultantSelect";
            this.consultantSelect.Size = new System.Drawing.Size(152, 21);
            this.consultantSelect.TabIndex = 10;
            // 
            // apointmentView
            // 
            this.apointmentView.AllowUserToAddRows = false;
            this.apointmentView.AllowUserToDeleteRows = false;
            this.apointmentView.AllowUserToResizeColumns = false;
            this.apointmentView.AllowUserToResizeRows = false;
            this.apointmentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.apointmentView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerId,
            this.customerName,
            this.phone,
            this.address,
            this.postalCode,
            this.city,
            this.country});
            this.apointmentView.Location = new System.Drawing.Point(36, 158);
            this.apointmentView.MultiSelect = false;
            this.apointmentView.Name = "apointmentView";
            this.apointmentView.ReadOnly = true;
            this.apointmentView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.apointmentView.Size = new System.Drawing.Size(744, 186);
            this.apointmentView.TabIndex = 11;
            // 
            // customerId
            // 
            this.customerId.HeaderText = "Customer ID";
            this.customerId.Name = "customerId";
            this.customerId.ReadOnly = true;
            // 
            // customerName
            // 
            this.customerName.HeaderText = "Customer Name";
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.HeaderText = "Phone Number";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // postalCode
            // 
            this.postalCode.HeaderText = "Postal Code";
            this.postalCode.Name = "postalCode";
            this.postalCode.ReadOnly = true;
            // 
            // city
            // 
            this.city.HeaderText = "City";
            this.city.Name = "city";
            this.city.ReadOnly = true;
            // 
            // country
            // 
            this.country.HeaderText = "Country";
            this.country.Name = "country";
            this.country.ReadOnly = true;
            // 
            // ApointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 390);
            this.Controls.Add(this.apointmentView);
            this.Controls.Add(this.consultantSelect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.apointmentTime);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.apointmentDate);
            this.Controls.Add(this.formNameLabel);
            this.Name = "ApointmentForm";
            this.Text = "ApointmentForm";
            this.Load += new System.EventHandler(this.ApointmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.apointmentView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label formNameLabel;
        private System.Windows.Forms.DateTimePicker apointmentDate;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DateTimePicker apointmentTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox consultantSelect;
        private System.Windows.Forms.DataGridView apointmentView;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn country;
    }
}