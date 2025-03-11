namespace MiniProjectLibraryManagementSystem
{
    partial class FrmBookList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBookList));
            this.lsBookList = new System.Windows.Forms.ListView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.HeadLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdISBN = new System.Windows.Forms.RadioButton();
            this.rdBookName = new System.Windows.Forms.RadioButton();
            this.rdBookTypeId = new System.Windows.Forms.RadioButton();
            this.btSearch = new System.Windows.Forms.Button();
            this.btMainMenu = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsBookList
            // 
            this.lsBookList.HideSelection = false;
            this.lsBookList.Location = new System.Drawing.Point(132, 195);
            this.lsBookList.Name = "lsBookList";
            this.lsBookList.Size = new System.Drawing.Size(530, 228);
            this.lsBookList.TabIndex = 0;
            this.lsBookList.UseCompatibleStateImageBehavior = false;
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbSearch.Location = new System.Drawing.Point(132, 163);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(240, 26);
            this.tbSearch.TabIndex = 1;
            // 
            // HeadLabel
            // 
            this.HeadLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.HeadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.HeadLabel.Location = new System.Drawing.Point(133, -3);
            this.HeadLabel.Name = "HeadLabel";
            this.HeadLabel.Size = new System.Drawing.Size(529, 64);
            this.HeadLabel.TabIndex = 2;
            this.HeadLabel.Text = "Book List";
            this.HeadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(129, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search by";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // rdISBN
            // 
            this.rdISBN.AutoSize = true;
            this.rdISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rdISBN.Location = new System.Drawing.Point(132, 87);
            this.rdISBN.Name = "rdISBN";
            this.rdISBN.Size = new System.Drawing.Size(56, 20);
            this.rdISBN.TabIndex = 5;
            this.rdISBN.TabStop = true;
            this.rdISBN.Text = "ISBN";
            this.rdISBN.UseVisualStyleBackColor = true;
            // 
            // rdBookName
            // 
            this.rdBookName.AutoSize = true;
            this.rdBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rdBookName.Location = new System.Drawing.Point(132, 113);
            this.rdBookName.Name = "rdBookName";
            this.rdBookName.Size = new System.Drawing.Size(94, 20);
            this.rdBookName.TabIndex = 6;
            this.rdBookName.TabStop = true;
            this.rdBookName.Text = "Book name";
            this.rdBookName.UseVisualStyleBackColor = true;
            // 
            // rdBookTypeId
            // 
            this.rdBookTypeId.AutoSize = true;
            this.rdBookTypeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rdBookTypeId.Location = new System.Drawing.Point(132, 139);
            this.rdBookTypeId.Name = "rdBookTypeId";
            this.rdBookTypeId.Size = new System.Drawing.Size(102, 20);
            this.rdBookTypeId.TabIndex = 7;
            this.rdBookTypeId.TabStop = true;
            this.rdBookTypeId.Text = "Book type ID";
            this.rdBookTypeId.UseVisualStyleBackColor = true;
            // 
            // btSearch
            // 
            this.btSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btSearch.Location = new System.Drawing.Point(378, 165);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(74, 25);
            this.btSearch.TabIndex = 9;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            // 
            // btMainMenu
            // 
            this.btMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.btMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btMainMenu.Image = global::MiniProjectLibraryManagementSystem.Properties.Resources.MainMenu1;
            this.btMainMenu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btMainMenu.Location = new System.Drawing.Point(694, 348);
            this.btMainMenu.Name = "btMainMenu";
            this.btMainMenu.Size = new System.Drawing.Size(83, 75);
            this.btMainMenu.TabIndex = 8;
            this.btMainMenu.Text = "Main Menu";
            this.btMainMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btMainMenu.UseVisualStyleBackColor = false;
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.Transparent;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btCancel.Image = global::MiniProjectLibraryManagementSystem.Properties.Resources.cancel;
            this.btCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCancel.Location = new System.Drawing.Point(694, 267);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(83, 75);
            this.btCancel.TabIndex = 15;
            this.btCancel.Text = "Cancel";
            this.btCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCancel.UseVisualStyleBackColor = false;
            // 
            // FrmBookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(789, 450);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdBookTypeId);
            this.Controls.Add(this.rdBookName);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.rdISBN);
            this.Controls.Add(this.btMainMenu);
            this.Controls.Add(this.HeadLabel);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lsBookList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmBookList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System - Book list";
            this.Load += new System.EventHandler(this.FrmBookList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsBookList;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label HeadLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdISBN;
        private System.Windows.Forms.RadioButton rdBookName;
        private System.Windows.Forms.RadioButton rdBookTypeId;
        private System.Windows.Forms.Button btMainMenu;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btCancel;
    }
}