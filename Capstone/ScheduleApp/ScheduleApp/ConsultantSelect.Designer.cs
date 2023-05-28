
namespace ScheduleApp
{
    partial class ConsultantSelect
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
            this.consultant = new System.Windows.Forms.ComboBox();
            this.Select = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // consultant
            // 
            this.consultant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.consultant.FormattingEnabled = true;
            this.consultant.Location = new System.Drawing.Point(12, 47);
            this.consultant.Name = "consultant";
            this.consultant.Size = new System.Drawing.Size(166, 21);
            this.consultant.TabIndex = 0;
            // 
            // Select
            // 
            this.Select.Location = new System.Drawing.Point(58, 107);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(75, 23);
            this.Select.TabIndex = 1;
            this.Select.Text = "Select";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // ConsultantSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 168);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.consultant);
            this.Name = "ConsultantSelect";
            this.Text = "consultantSelect";
            this.Load += new System.EventHandler(this.ConsultantSelect_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Select;
        private System.Windows.Forms.ComboBox consultant;
    }
}