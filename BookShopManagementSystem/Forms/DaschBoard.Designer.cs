﻿namespace BookShopManagementSystem.Forms
{
    partial class DaschBoard
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
            this.components = new System.ComponentModel.Container();
            this.panelUpLeft = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.labelShopTwo = new System.Windows.Forms.Label();
            this.picShoopTwo = new System.Windows.Forms.PictureBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.labelCopy = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSaleBooks = new System.Windows.Forms.Button();
            this.panelSide = new System.Windows.Forms.Panel();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnExpenses = new System.Windows.Forms.Button();
            this.panelUp = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCloseTwo = new System.Windows.Forms.Button();
            this.labelMarker = new System.Windows.Forms.Label();
            this.labelTimeData = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.timerPanelLeft = new System.Windows.Forms.Timer(this.components);
            this.timerTimes = new System.Windows.Forms.Timer(this.components);
            this.panelUser = new System.Windows.Forms.Panel();
            this.dargControl = new BookShopManagementSystem.CostumControl.DargControl();
            this.panelUpLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShoopTwo)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.panelUp.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUpLeft
            // 
            this.panelUpLeft.BackColor = System.Drawing.Color.CadetBlue;
            this.panelUpLeft.Controls.Add(this.btnMenu);
            this.panelUpLeft.Controls.Add(this.labelShopTwo);
            this.panelUpLeft.Controls.Add(this.picShoopTwo);
            this.panelUpLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelUpLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpLeft.Location = new System.Drawing.Point(0, 0);
            this.panelUpLeft.Name = "panelUpLeft";
            this.panelUpLeft.Size = new System.Drawing.Size(189, 117);
            this.panelUpLeft.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.Color.CadetBlue;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Image = global::BookShopManagementSystem.Properties.Resources.icons8_menu_24px;
            this.btnMenu.Location = new System.Drawing.Point(143, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(43, 37);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // labelShopTwo
            // 
            this.labelShopTwo.AutoSize = true;
            this.labelShopTwo.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShopTwo.ForeColor = System.Drawing.Color.White;
            this.labelShopTwo.Location = new System.Drawing.Point(55, 91);
            this.labelShopTwo.Name = "labelShopTwo";
            this.labelShopTwo.Size = new System.Drawing.Size(85, 20);
            this.labelShopTwo.TabIndex = 1;
            this.labelShopTwo.Text = "Books Shop";
            // 
            // picShoopTwo
            // 
            this.picShoopTwo.Image = global::BookShopManagementSystem.Properties.Resources.icons8_books_32px;
            this.picShoopTwo.Location = new System.Drawing.Point(57, 12);
            this.picShoopTwo.Name = "picShoopTwo";
            this.picShoopTwo.Size = new System.Drawing.Size(83, 64);
            this.picShoopTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShoopTwo.TabIndex = 0;
            this.picShoopTwo.TabStop = false;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.CadetBlue;
            this.panelLeft.Controls.Add(this.labelCopy);
            this.panelLeft.Controls.Add(this.btnHome);
            this.panelLeft.Controls.Add(this.btnSaleBooks);
            this.panelLeft.Controls.Add(this.panelSide);
            this.panelLeft.Controls.Add(this.panelUpLeft);
            this.panelLeft.Controls.Add(this.btnPurchase);
            this.panelLeft.Controls.Add(this.btnUser);
            this.panelLeft.Controls.Add(this.btnView);
            this.panelLeft.Controls.Add(this.btnExpenses);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(189, 500);
            this.panelLeft.TabIndex = 1;
            // 
            // labelCopy
            // 
            this.labelCopy.AutoSize = true;
            this.labelCopy.BackColor = System.Drawing.Color.CadetBlue;
            this.labelCopy.Font = new System.Drawing.Font("Comic Sans MS", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCopy.ForeColor = System.Drawing.Color.White;
            this.labelCopy.Location = new System.Drawing.Point(8, 461);
            this.labelCopy.Name = "labelCopy";
            this.labelCopy.Size = new System.Drawing.Size(172, 30);
            this.labelCopy.TabIndex = 12;
            this.labelCopy.Text = "Copyrights © 2020.All rights\r\nreserved by BlueButterfliesDev";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.CadetBlue;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::BookShopManagementSystem.Properties.Resources.icons8_home_24px;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(19, 123);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(163, 35);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "   Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSaleBooks
            // 
            this.btnSaleBooks.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnSaleBooks.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSaleBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaleBooks.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSaleBooks.FlatAppearance.BorderSize = 0;
            this.btnSaleBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSaleBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaleBooks.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaleBooks.ForeColor = System.Drawing.Color.White;
            this.btnSaleBooks.Image = global::BookShopManagementSystem.Properties.Resources.icons8_sale_price_tag_24px;
            this.btnSaleBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaleBooks.Location = new System.Drawing.Point(19, 164);
            this.btnSaleBooks.Name = "btnSaleBooks";
            this.btnSaleBooks.Size = new System.Drawing.Size(163, 35);
            this.btnSaleBooks.TabIndex = 3;
            this.btnSaleBooks.Text = "   Sale Books";
            this.btnSaleBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSaleBooks.UseVisualStyleBackColor = false;
            this.btnSaleBooks.Click += new System.EventHandler(this.btnSaleBooks_Click);
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.White;
            this.panelSide.Location = new System.Drawing.Point(3, 123);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(10, 35);
            this.panelSide.TabIndex = 2;
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.Color.CadetBlue;
            this.btnPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPurchase.FlatAppearance.BorderSize = 0;
            this.btnPurchase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchase.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchase.ForeColor = System.Drawing.Color.White;
            this.btnPurchase.Image = global::BookShopManagementSystem.Properties.Resources.icons8_videos_purchased_24px;
            this.btnPurchase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchase.Location = new System.Drawing.Point(19, 248);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(163, 35);
            this.btnPurchase.TabIndex = 5;
            this.btnPurchase.Text = "     Purchase Books";
            this.btnPurchase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPurchase.UseVisualStyleBackColor = false;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.CadetBlue;
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Image = global::BookShopManagementSystem.Properties.Resources.icons8_staff_32px;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(19, 333);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(163, 35);
            this.btnUser.TabIndex = 7;
            this.btnUser.Text = "Users";
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.CadetBlue;
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Image = global::BookShopManagementSystem.Properties.Resources.icons8_eye_32px;
            this.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView.Location = new System.Drawing.Point(19, 205);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(163, 35);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "  View Sold ";
            this.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnExpenses
            // 
            this.btnExpenses.BackColor = System.Drawing.Color.CadetBlue;
            this.btnExpenses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpenses.FlatAppearance.BorderSize = 0;
            this.btnExpenses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpenses.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenses.ForeColor = System.Drawing.Color.White;
            this.btnExpenses.Image = global::BookShopManagementSystem.Properties.Resources.icons8_expensive_price_32px;
            this.btnExpenses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpenses.Location = new System.Drawing.Point(19, 290);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.Size = new System.Drawing.Size(163, 35);
            this.btnExpenses.TabIndex = 6;
            this.btnExpenses.Text = "  Expenses";
            this.btnExpenses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExpenses.UseVisualStyleBackColor = false;
            this.btnExpenses.Click += new System.EventHandler(this.btnExpenses_Click);
            // 
            // panelUp
            // 
            this.panelUp.BackColor = System.Drawing.Color.CadetBlue;
            this.panelUp.Controls.Add(this.panel1);
            this.panelUp.Controls.Add(this.labelTimeData);
            this.panelUp.Controls.Add(this.labelRole);
            this.panelUp.Controls.Add(this.labelWelcome);
            this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp.Location = new System.Drawing.Point(189, 0);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(811, 117);
            this.panelUp.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCloseTwo);
            this.panel1.Controls.Add(this.labelMarker);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 50);
            this.panel1.TabIndex = 6;
            // 
            // btnCloseTwo
            // 
            this.btnCloseTwo.BackColor = System.Drawing.Color.CadetBlue;
            this.btnCloseTwo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseTwo.FlatAppearance.BorderSize = 0;
            this.btnCloseTwo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCloseTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseTwo.Image = global::BookShopManagementSystem.Properties.Resources.icons8_delete_50px;
            this.btnCloseTwo.Location = new System.Drawing.Point(764, 0);
            this.btnCloseTwo.Name = "btnCloseTwo";
            this.btnCloseTwo.Size = new System.Drawing.Size(47, 50);
            this.btnCloseTwo.TabIndex = 3;
            this.btnCloseTwo.UseVisualStyleBackColor = false;
            this.btnCloseTwo.Click += new System.EventHandler(this.btnCloseTwo_Click);
            // 
            // labelMarker
            // 
            this.labelMarker.AutoSize = true;
            this.labelMarker.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarker.ForeColor = System.Drawing.Color.White;
            this.labelMarker.Location = new System.Drawing.Point(366, 3);
            this.labelMarker.Name = "labelMarker";
            this.labelMarker.Size = new System.Drawing.Size(98, 34);
            this.labelMarker.TabIndex = 3;
            this.labelMarker.Text = "Market";
            // 
            // labelTimeData
            // 
            this.labelTimeData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTimeData.AutoSize = true;
            this.labelTimeData.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeData.ForeColor = System.Drawing.Color.White;
            this.labelTimeData.Location = new System.Drawing.Point(597, 75);
            this.labelTimeData.Name = "labelTimeData";
            this.labelTimeData.Size = new System.Drawing.Size(127, 23);
            this.labelTimeData.TabIndex = 5;
            this.labelTimeData.Text = "Time with data";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRole.ForeColor = System.Drawing.Color.White;
            this.labelRole.Location = new System.Drawing.Point(38, 88);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(48, 23);
            this.labelRole.TabIndex = 4;
            this.labelRole.Text = "Role:";
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.White;
            this.labelWelcome.Location = new System.Drawing.Point(6, 53);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(105, 23);
            this.labelWelcome.TabIndex = 2;
            this.labelWelcome.Text = "Welcome:   ";
            // 
            // timerPanelLeft
            // 
            this.timerPanelLeft.Tick += new System.EventHandler(this.timerPanelLeft_Tick);
            // 
            // timerTimes
            // 
            this.timerTimes.Tick += new System.EventHandler(this.timerTimes_Tick);
            // 
            // panelUser
            // 
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUser.Location = new System.Drawing.Point(189, 117);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(811, 383);
            this.panelUser.TabIndex = 3;
            // 
            // dargControl
            // 
            this.dargControl.SelectControl = this.panel1;
            // 
            // DaschBoard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.panelUp);
            this.Controls.Add(this.panelLeft);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DaschBoard";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelUpLeft.ResumeLayout(false);
            this.panelUpLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShoopTwo)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelUp.ResumeLayout(false);
            this.panelUp.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUpLeft;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.PictureBox picShoopTwo;
        private System.Windows.Forms.Label labelShopTwo;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnSaleBooks;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnExpenses;
        private System.Windows.Forms.Label labelMarker;
        private System.Windows.Forms.Timer timerPanelLeft;
        private System.Windows.Forms.Label labelTimeData;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnCloseTwo;
        private System.Windows.Forms.Timer timerTimes;
        private System.Windows.Forms.Panel panelUser;
        private CostumControl.DargControl dargControl;
        private System.Windows.Forms.Label labelCopy;
    }
}