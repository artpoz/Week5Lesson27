﻿namespace Week5Lesson27
{
    partial class AddEditEmployee
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbHireDate = new System.Windows.Forms.TextBox();
            this.tbTerminationDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbComments = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Imię";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nazwisko";
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(190, 19);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(193, 22);
            this.tbId.TabIndex = 3;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(190, 73);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(193, 22);
            this.tbFirstName.TabIndex = 4;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(190, 117);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(193, 22);
            this.tbLastName.TabIndex = 5;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(48, 399);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(130, 23);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Zatwierdź";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(219, 399);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data zatrudnienia";
            // 
            // tbHireDate
            // 
            this.tbHireDate.Location = new System.Drawing.Point(190, 171);
            this.tbHireDate.Name = "tbHireDate";
            this.tbHireDate.Size = new System.Drawing.Size(193, 22);
            this.tbHireDate.TabIndex = 9;
            // 
            // tbTerminationDate
            // 
            this.tbTerminationDate.Location = new System.Drawing.Point(190, 222);
            this.tbTerminationDate.Name = "tbTerminationDate";
            this.tbTerminationDate.Size = new System.Drawing.Size(193, 22);
            this.tbTerminationDate.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Data zwolnienia";
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(190, 277);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(193, 22);
            this.tbSalary.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Zarobki";
            // 
            // tbComments
            // 
            this.tbComments.Location = new System.Drawing.Point(190, 322);
            this.tbComments.Name = "tbComments";
            this.tbComments.Size = new System.Drawing.Size(193, 22);
            this.tbComments.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Uwagi";
            // 
            // AddEditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbComments);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbSalary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTerminationDate);
            this.Controls.Add(this.tbHireDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEditEmployee";
            this.Text = "Dodaj pracownika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbHireDate;
        private System.Windows.Forms.TextBox tbTerminationDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbComments;
        private System.Windows.Forms.Label label7;
    }
}