
namespace ScheduleApp
{
    partial class ConsultantSchedule
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
            this.schedule = new System.Windows.Forms.DataGridView();
            this.apointmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.schedule)).BeginInit();
            this.SuspendLayout();
            // 
            // schedule
            // 
            this.schedule.AllowUserToAddRows = false;
            this.schedule.AllowUserToDeleteRows = false;
            this.schedule.AllowUserToResizeColumns = false;
            this.schedule.AllowUserToResizeRows = false;
            this.schedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.schedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.apointmentId,
            this.date,
            this.customerName,
            this.consultantName});
            this.schedule.Location = new System.Drawing.Point(58, 82);
            this.schedule.MultiSelect = false;
            this.schedule.Name = "schedule";
            this.schedule.ReadOnly = true;
            this.schedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.schedule.Size = new System.Drawing.Size(680, 291);
            this.schedule.TabIndex = 0;
            // 
            // apointmentId
            // 
            this.apointmentId.HeaderText = "Apointment ID";
            this.apointmentId.Name = "apointmentId";
            this.apointmentId.ReadOnly = true;
            this.apointmentId.Width = 140;
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
            this.customerName.Width = 160;
            // 
            // consultantName
            // 
            this.consultantName.HeaderText = "Consultant Name";
            this.consultantName.Name = "consultantName";
            this.consultantName.ReadOnly = true;
            this.consultantName.Width = 160;
            // 
            // scheduleName
            // 
            this.scheduleName.AutoSize = true;
            this.scheduleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleName.Location = new System.Drawing.Point(58, 13);
            this.scheduleName.Name = "scheduleName";
            this.scheduleName.Size = new System.Drawing.Size(170, 25);
            this.scheduleName.TabIndex = 1;
            this.scheduleName.Text = "consultant name";
            // 
            // ConsultantSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scheduleName);
            this.Controls.Add(this.schedule);
            this.Name = "ConsultantSchedule";
            this.Text = "ConsultantSchedule";
            ((System.ComponentModel.ISupportInitialize)(this.schedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView schedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn apointmentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn consultantName;
        private System.Windows.Forms.Label scheduleName;
    }
}