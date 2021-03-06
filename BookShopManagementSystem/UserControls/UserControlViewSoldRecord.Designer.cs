﻿namespace BookShopManagementSystem.UserControls
{
    partial class UserControlViewSoldRecord
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelTotal = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.labelSales = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridSold = new System.Windows.Forms.DataGridView();
            this.netAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netDiscountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookshopDataSet3 = new BookShopManagementSystem.bookshopDataSet3();
            this.soldTableAdapter = new BookShopManagementSystem.bookshopDataSet3TableAdapters.SoldTableAdapter();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookshopDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(13, 468);
            this.panel1.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(848, 15);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(13, 468);
            this.panel4.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.labelTotal);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(13, 457);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(835, 26);
            this.panel3.TabIndex = 7;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.Color.White;
            this.labelTotal.Font = new System.Drawing.Font("Comic Sans MS", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.CadetBlue;
            this.labelTotal.Location = new System.Drawing.Point(45, 3);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(111, 22);
            this.labelTotal.TabIndex = 13;
            this.labelTotal.Text = "Recieved:  00";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.CadetBlue;
            this.panel5.Controls.Add(this.btnRefresh);
            this.panel5.Controls.Add(this.labelSales);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(13, 15);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(835, 63);
            this.panel5.TabIndex = 8;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Comic Sans MS", 9.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = global::BookShopManagementSystem.Properties.Resources.icons8_synchronize_24px;
            this.btnRefresh.Location = new System.Drawing.Point(0, 0);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(64, 63);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // labelSales
            // 
            this.labelSales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSales.AutoSize = true;
            this.labelSales.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSales.ForeColor = System.Drawing.Color.White;
            this.labelSales.Location = new System.Drawing.Point(346, 19);
            this.labelSales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSales.Name = "labelSales";
            this.labelSales.Size = new System.Drawing.Size(142, 34);
            this.labelSales.TabIndex = 2;
            this.labelSales.Text = "Sold Books";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(861, 15);
            this.panel2.TabIndex = 4;
            // 
            // dataGridSold
            // 
            this.dataGridSold.AllowUserToAddRows = false;
            this.dataGridSold.AllowUserToDeleteRows = false;
            this.dataGridSold.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridSold.AutoGenerateColumns = false;
            this.dataGridSold.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSold.BackgroundColor = System.Drawing.Color.White;
            this.dataGridSold.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridSold.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSold.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.netAmountDataGridViewTextBoxColumn,
            this.netDiscountDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridSold.DataSource = this.soldBindingSource;
            this.dataGridSold.Location = new System.Drawing.Point(13, 78);
            this.dataGridSold.Name = "dataGridSold";
            this.dataGridSold.ReadOnly = true;
            this.dataGridSold.RowHeadersVisible = false;
            this.dataGridSold.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSold.Size = new System.Drawing.Size(835, 379);
            this.dataGridSold.TabIndex = 9;
            // 
            // netAmountDataGridViewTextBoxColumn
            // 
            this.netAmountDataGridViewTextBoxColumn.DataPropertyName = "NetAmount";
            this.netAmountDataGridViewTextBoxColumn.HeaderText = "NetAmount";
            this.netAmountDataGridViewTextBoxColumn.Name = "netAmountDataGridViewTextBoxColumn";
            this.netAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // netDiscountDataGridViewTextBoxColumn
            // 
            this.netDiscountDataGridViewTextBoxColumn.DataPropertyName = "NetDiscount";
            this.netDiscountDataGridViewTextBoxColumn.HeaderText = "NetDiscount";
            this.netDiscountDataGridViewTextBoxColumn.Name = "netDiscountDataGridViewTextBoxColumn";
            this.netDiscountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            this.totalAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soldBindingSource
            // 
            this.soldBindingSource.DataMember = "Sold";
            this.soldBindingSource.DataSource = this.bookshopDataSet3;
            // 
            // bookshopDataSet3
            // 
            this.bookshopDataSet3.DataSetName = "bookshopDataSet3";
            this.bookshopDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // soldTableAdapter
            // 
            this.soldTableAdapter.ClearBeforeFill = true;
            // 
            // UserControlViewSoldRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridSold);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.CadetBlue;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlViewSoldRecord";
            this.Size = new System.Drawing.Size(861, 483);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookshopDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label labelSales;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridSold;
        private System.Windows.Forms.DataGridViewTextBoxColumn netAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netDiscountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource soldBindingSource;
        private bookshopDataSet3 bookshopDataSet3;
        private bookshopDataSet3TableAdapters.SoldTableAdapter soldTableAdapter;
    }
}
