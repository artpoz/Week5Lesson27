﻿namespace Week5Lesson27
{
    partial class Main
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dgvEmployeeDatabase = new System.Windows.Forms.DataGridView();
            this.btnFire = new System.Windows.Forms.Button();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeDatabase)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(42, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 42);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(164, 30);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(107, 42);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edytuj";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dgvEmployeeDatabase
            // 
            this.dgvEmployeeDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployeeDatabase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployeeDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeDatabase.Location = new System.Drawing.Point(42, 101);
            this.dgvEmployeeDatabase.Name = "dgvEmployeeDatabase";
            this.dgvEmployeeDatabase.RowHeadersVisible = false;
            this.dgvEmployeeDatabase.RowHeadersWidth = 51;
            this.dgvEmployeeDatabase.RowTemplate.Height = 24;
            this.dgvEmployeeDatabase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeeDatabase.Size = new System.Drawing.Size(769, 220);
            this.dgvEmployeeDatabase.TabIndex = 2;
            // 
            // btnFire
            // 
            this.btnFire.Location = new System.Drawing.Point(308, 30);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(107, 42);
            this.btnFire.TabIndex = 3;
            this.btnFire.Text = "Zwolnij";
            this.btnFire.UseVisualStyleBackColor = true;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(475, 40);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(232, 24);
            this.cbFilter.TabIndex = 4;
            this.cbFilter.SelectedValueChanged += new System.EventHandler(this.cbFilter_SelectedValueChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 357);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.dgvEmployeeDatabase);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.MinimumSize = new System.Drawing.Size(861, 404);
            this.Name = "Main";
            this.Text = "Baza pracowników";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeDatabase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dgvEmployeeDatabase;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.ComboBox cbFilter;
    }
}

