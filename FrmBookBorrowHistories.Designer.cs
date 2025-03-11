namespace MiniProjectLibraryManagementSystem
{
    partial class FrmBookBorrowHistories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBookBorrowHistories));
            this.HeadLabel = new System.Windows.Forms.Label();
            this.dtpBorrow = new System.Windows.Forms.DateTimePicker();
            this.tbUserId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lsBookBorrow = new System.Windows.Forms.ListView();
            this.btSearch = new System.Windows.Forms.Button();
            this.btMainMenu = new System.Windows.Forms.Button();
            this.cbUserId = new System.Windows.Forms.CheckBox();
            this.cbdtpBorrow = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // HeadLabel
            // 
            this.HeadLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.HeadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.HeadLabel.Location = new System.Drawing.Point(142, 9);
            this.HeadLabel.Name = "HeadLabel";
            this.HeadLabel.Size = new System.Drawing.Size(529, 64);
            this.HeadLabel.TabIndex = 3;
            this.HeadLabel.Text = "Book Borrow Histories";
            this.HeadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpBorrow
            // 
            this.dtpBorrow.CustomFormat = "yyyy - mm";
            this.dtpBorrow.Enabled = false;
            this.dtpBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dtpBorrow.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBorrow.Location = new System.Drawing.Point(219, 150);
            this.dtpBorrow.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dtpBorrow.Name = "dtpBorrow";
            this.dtpBorrow.Size = new System.Drawing.Size(100, 22);
            this.dtpBorrow.TabIndex = 4;
            // 
            // tbUserId
            // 
            this.tbUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbUserId.Location = new System.Drawing.Point(219, 111);
            this.tbUserId.Name = "tbUserId";
            this.tbUserId.Size = new System.Drawing.Size(100, 22);
            this.tbUserId.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(161, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "User ID";
            // 
            // lsBookBorrow
            // 
            this.lsBookBorrow.HideSelection = false;
            this.lsBookBorrow.Location = new System.Drawing.Point(141, 179);
            this.lsBookBorrow.Name = "lsBookBorrow";
            this.lsBookBorrow.Size = new System.Drawing.Size(530, 245);
            this.lsBookBorrow.TabIndex = 7;
            this.lsBookBorrow.UseCompatibleStateImageBehavior = false;
            // 
            // btSearch
            // 
            this.btSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btSearch.Location = new System.Drawing.Point(337, 150);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(74, 25);
            this.btSearch.TabIndex = 10;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            // 
            // btMainMenu
            // 
            this.btMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.btMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btMainMenu.Image = global::MiniProjectLibraryManagementSystem.Properties.Resources.MainMenu1;
            this.btMainMenu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btMainMenu.Location = new System.Drawing.Point(695, 349);
            this.btMainMenu.Name = "btMainMenu";
            this.btMainMenu.Size = new System.Drawing.Size(83, 75);
            this.btMainMenu.TabIndex = 11;
            this.btMainMenu.Text = "Main Menu";
            this.btMainMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btMainMenu.UseVisualStyleBackColor = false;
            // 
            // cbUserId
            // 
            this.cbUserId.AutoSize = true;
            this.cbUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbUserId.Location = new System.Drawing.Point(140, 116);
            this.cbUserId.Name = "cbUserId";
            this.cbUserId.Size = new System.Drawing.Size(15, 14);
            this.cbUserId.TabIndex = 12;
            this.cbUserId.UseVisualStyleBackColor = true;
            // 
            // cbdtpBorrow
            // 
            this.cbdtpBorrow.AutoSize = true;
            this.cbdtpBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbdtpBorrow.Location = new System.Drawing.Point(141, 157);
            this.cbdtpBorrow.Name = "cbdtpBorrow";
            this.cbdtpBorrow.Size = new System.Drawing.Size(15, 14);
            this.cbdtpBorrow.TabIndex = 13;
            this.cbdtpBorrow.UseVisualStyleBackColor = true;
            // 
            // FrmBookBorrowHistories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbdtpBorrow);
            this.Controls.Add(this.cbUserId);
            this.Controls.Add(this.btMainMenu);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.lsBookBorrow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUserId);
            this.Controls.Add(this.dtpBorrow);
            this.Controls.Add(this.HeadLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmBookBorrowHistories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System - Book Borrow Histories";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeadLabel;
        private System.Windows.Forms.DateTimePicker dtpBorrow;
        private System.Windows.Forms.TextBox tbUserId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lsBookBorrow;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btMainMenu;
        private System.Windows.Forms.CheckBox cbUserId;
        private System.Windows.Forms.CheckBox cbdtpBorrow;
    }
}