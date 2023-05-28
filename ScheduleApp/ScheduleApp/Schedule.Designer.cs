
namespace ScheduleApp
{
    partial class Schedule
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
            this.ScheduleFormatSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateRange = new System.Windows.Forms.Label();
            this.scheduleView = new System.Windows.Forms.DataGridView();
            this.apointmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.previous = new System.Windows.Forms.Button();
            this.search_bar = new System.Windows.Forms.TextBox();
            this.clear_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleView)).BeginInit();
            this.SuspendLayout();
            // 
            // ScheduleFormatSelector
            // 
            this.ScheduleFormatSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScheduleFormatSelector.FormattingEnabled = true;
            this.ScheduleFormatSelector.Items.AddRange(new object[] {
            "None",
            "Week",
            "Month"});
            this.ScheduleFormatSelector.Location = new System.Drawing.Point(121, 26);
            this.ScheduleFormatSelector.Name = "ScheduleFormatSelector";
            this.ScheduleFormatSelector.Size = new System.Drawing.Size(121, 21);
            this.ScheduleFormatSelector.TabIndex = 0;
            this.ScheduleFormatSelector.SelectionChangeCommitted += new System.EventHandler(this.ScheduleFormatSelector_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Schedule";
            // 
            // dateRange
            // 
            this.dateRange.AutoSize = true;
            this.dateRange.Location = new System.Drawing.Point(55, 85);
            this.dateRange.Name = "dateRange";
            this.dateRange.Size = new System.Drawing.Size(60, 13);
            this.dateRange.TabIndex = 3;
            this.dateRange.Text = "dateRange";
            // 
            // scheduleView
            // 
            this.scheduleView.AllowUserToAddRows = false;
            this.scheduleView.AllowUserToDeleteRows = false;
            this.scheduleView.AllowUserToResizeColumns = false;
            this.scheduleView.AllowUserToResizeRows = false;
            this.scheduleView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.apointmentId,
            this.type,
            this.date,
            this.customerName,
            this.consultantName});
            this.scheduleView.Location = new System.Drawing.Point(58, 101);
            this.scheduleView.MultiSelect = false;
            this.scheduleView.Name = "scheduleView";
            this.scheduleView.ReadOnly = true;
            this.scheduleView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.scheduleView.Size = new System.Drawing.Size(680, 291);
            this.scheduleView.TabIndex = 4;
            // 
            // apointmentId
            // 
            this.apointmentId.HeaderText = "Apointment ID";
            this.apointmentId.Name = "apointmentId";
            this.apointmentId.ReadOnly = true;
            this.apointmentId.Width = 90;
            // 
            // type
            // 
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 176;
            // 
            // customerName
            // 
            this.customerName.HeaderText = "Customer Name";
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            this.customerName.Width = 135;
            // 
            // consultantName
            // 
            this.consultantName.HeaderText = "Consultant Name";
            this.consultantName.Name = "consultantName";
            this.consultantName.ReadOnly = true;
            this.consultantName.Width = 135;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(663, 398);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(582, 398);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(501, 398);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(405, 398);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(90, 23);
            this.viewButton.TabIndex = 8;
            this.viewButton.Text = "View Customer";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(663, 72);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 9;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // previous
            // 
            this.previous.Location = new System.Drawing.Point(582, 72);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(75, 23);
            this.previous.TabIndex = 10;
            this.previous.Text = "Previous";
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // search_bar
            // 
            this.search_bar.Location = new System.Drawing.Point(365, 72);
            this.search_bar.Name = "search_bar";
            this.search_bar.Size = new System.Drawing.Size(211, 20);
            this.search_bar.TabIndex = 11;
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(203, 72);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(75, 23);
            this.clear_button.TabIndex = 12;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(284, 72);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(75, 23);
            this.search_button.TabIndex = 13;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.search_bar);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.next);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.scheduleView);
            this.Controls.Add(this.dateRange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ScheduleFormatSelector);
            this.Name = "Schedule";
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.Schedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scheduleView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ScheduleFormatSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dateRange;
        private System.Windows.Forms.DataGridView scheduleView;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.DataGridViewTextBoxColumn apointmentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn consultantName;
        private System.Windows.Forms.TextBox search_bar;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button search_button;
    }
}