
namespace ScheduleApp
{
    partial class Menu
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
            this.fullSchduleButton = new System.Windows.Forms.Button();
            this.consultantScheduleButton = new System.Windows.Forms.Button();
            this.customerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.reportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fullSchduleButton
            // 
            this.fullSchduleButton.Location = new System.Drawing.Point(30, 30);
            this.fullSchduleButton.Name = "fullSchduleButton";
            this.fullSchduleButton.Size = new System.Drawing.Size(75, 23);
            this.fullSchduleButton.TabIndex = 0;
            this.fullSchduleButton.Text = "Go";
            this.fullSchduleButton.UseVisualStyleBackColor = true;
            this.fullSchduleButton.Click += new System.EventHandler(this.fullSchduleButton_Click);
            // 
            // consultantScheduleButton
            // 
            this.consultantScheduleButton.Location = new System.Drawing.Point(30, 80);
            this.consultantScheduleButton.Name = "consultantScheduleButton";
            this.consultantScheduleButton.Size = new System.Drawing.Size(75, 23);
            this.consultantScheduleButton.TabIndex = 1;
            this.consultantScheduleButton.Text = "Go";
            this.consultantScheduleButton.UseVisualStyleBackColor = true;
            this.consultantScheduleButton.Click += new System.EventHandler(this.consultantScheduleButton_Click);
            // 
            // customerButton
            // 
            this.customerButton.Location = new System.Drawing.Point(30, 130);
            this.customerButton.Name = "customerButton";
            this.customerButton.Size = new System.Drawing.Size(75, 23);
            this.customerButton.TabIndex = 2;
            this.customerButton.Text = "Go";
            this.customerButton.UseVisualStyleBackColor = true;
            this.customerButton.Click += new System.EventHandler(this.customerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "View and edit all scheduled apointments. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select a consultant to view their schedule";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "View and Edit Customer List";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "View Reports";
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(30, 180);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(75, 23);
            this.reportButton.TabIndex = 8;
            this.reportButton.Text = "Go";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 239);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerButton);
            this.Controls.Add(this.consultantScheduleButton);
            this.Controls.Add(this.fullSchduleButton);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fullSchduleButton;
        private System.Windows.Forms.Button consultantScheduleButton;
        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button reportButton;
    }
}