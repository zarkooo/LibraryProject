namespace PresentationLayer.UserControls
{
    partial class Books
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelIsbn = new System.Windows.Forms.Label();
            this.labelAuthorName = new System.Windows.Forms.Label();
            this.labelYearOfIssue = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.textBoxAuthorName = new System.Windows.Forms.TextBox();
            this.textBoxYearOfIssue = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDeleteBooks = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAddBooks = new System.Windows.Forms.Button();
            this.buttonUpdateBooks = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelSearchBooks = new System.Windows.Forms.TableLayoutPanel();
            this.labelSearchBooks = new System.Windows.Forms.Label();
            this.textBoxSearchBooks = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxSortByBooks = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanelSearchBooks.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(770, 398);
            this.splitContainer1.SplitterDistance = 263;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 398);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Controls.Add(this.labelTitle, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.labelIsbn, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.labelAuthorName, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.labelYearOfIssue, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.labelQuantity, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.textBoxTitle, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.textBoxISBN, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.textBoxAuthorName, 2, 3);
            this.tableLayoutPanel4.Controls.Add(this.textBoxYearOfIssue, 2, 4);
            this.tableLayoutPanel4.Controls.Add(this.textBoxQuantity, 2, 5);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 6);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 2, 6);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 9;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.13586F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.13586F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.13586F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.13586F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.13586F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.13586F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.28842F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.76058F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.13586F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(263, 398);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(71, 59);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(30, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title:";
            // 
            // labelIsbn
            // 
            this.labelIsbn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelIsbn.AutoSize = true;
            this.labelIsbn.Location = new System.Drawing.Point(66, 103);
            this.labelIsbn.Name = "labelIsbn";
            this.labelIsbn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelIsbn.Size = new System.Drawing.Size(35, 13);
            this.labelIsbn.TabIndex = 1;
            this.labelIsbn.Text = "ISBN:";
            // 
            // labelAuthorName
            // 
            this.labelAuthorName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelAuthorName.AutoSize = true;
            this.labelAuthorName.Location = new System.Drawing.Point(31, 147);
            this.labelAuthorName.Name = "labelAuthorName";
            this.labelAuthorName.Size = new System.Drawing.Size(70, 13);
            this.labelAuthorName.TabIndex = 2;
            this.labelAuthorName.Text = "Author name:";
            // 
            // labelYearOfIssue
            // 
            this.labelYearOfIssue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelYearOfIssue.AutoSize = true;
            this.labelYearOfIssue.Location = new System.Drawing.Point(55, 185);
            this.labelYearOfIssue.Name = "labelYearOfIssue";
            this.labelYearOfIssue.Size = new System.Drawing.Size(46, 26);
            this.labelYearOfIssue.TabIndex = 3;
            this.labelYearOfIssue.Text = "Year Of Issue:";
            // 
            // labelQuantity
            // 
            this.labelQuantity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(52, 235);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(49, 13);
            this.labelQuantity.TabIndex = 4;
            this.labelQuantity.Text = "Quantity:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTitle.Location = new System.Drawing.Point(107, 56);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(99, 20);
            this.textBoxTitle.TabIndex = 5;
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxISBN.Location = new System.Drawing.Point(107, 100);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(99, 20);
            this.textBoxISBN.TabIndex = 6;
            // 
            // textBoxAuthorName
            // 
            this.textBoxAuthorName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAuthorName.Location = new System.Drawing.Point(107, 144);
            this.textBoxAuthorName.Name = "textBoxAuthorName";
            this.textBoxAuthorName.Size = new System.Drawing.Size(99, 20);
            this.textBoxAuthorName.TabIndex = 7;
            // 
            // textBoxYearOfIssue
            // 
            this.textBoxYearOfIssue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxYearOfIssue.Location = new System.Drawing.Point(107, 188);
            this.textBoxYearOfIssue.Name = "textBoxYearOfIssue";
            this.textBoxYearOfIssue.Size = new System.Drawing.Size(99, 20);
            this.textBoxYearOfIssue.TabIndex = 8;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxQuantity.Location = new System.Drawing.Point(107, 232);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(99, 20);
            this.textBoxQuantity.TabIndex = 9;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.buttonDeleteBooks, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(29, 267);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(72, 62);
            this.tableLayoutPanel5.TabIndex = 10;
            // 
            // buttonDeleteBooks
            // 
            this.buttonDeleteBooks.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonDeleteBooks.Location = new System.Drawing.Point(3, 4);
            this.buttonDeleteBooks.Name = "buttonDeleteBooks";
            this.buttonDeleteBooks.Size = new System.Drawing.Size(66, 23);
            this.buttonDeleteBooks.TabIndex = 0;
            this.buttonDeleteBooks.Text = "Delete";
            this.buttonDeleteBooks.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.buttonAddBooks, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.buttonUpdateBooks, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(107, 267);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(99, 62);
            this.tableLayoutPanel6.TabIndex = 11;
            // 
            // buttonAddBooks
            // 
            this.buttonAddBooks.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonAddBooks.Location = new System.Drawing.Point(21, 4);
            this.buttonAddBooks.Name = "buttonAddBooks";
            this.buttonAddBooks.Size = new System.Drawing.Size(75, 23);
            this.buttonAddBooks.TabIndex = 0;
            this.buttonAddBooks.Text = "Add";
            this.buttonAddBooks.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateBooks
            // 
            this.buttonUpdateBooks.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonUpdateBooks.Location = new System.Drawing.Point(21, 35);
            this.buttonUpdateBooks.Name = "buttonUpdateBooks";
            this.buttonUpdateBooks.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateBooks.TabIndex = 1;
            this.buttonUpdateBooks.Text = "Update";
            this.buttonUpdateBooks.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(503, 398);
            this.panel2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.81188F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.18812F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(503, 398);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(497, 342);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(497, 44);
            this.panel3.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.52209F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.47791F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanelSearchBooks, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(497, 44);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanelSearchBooks
            // 
            this.tableLayoutPanelSearchBooks.ColumnCount = 2;
            this.tableLayoutPanelSearchBooks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.88235F));
            this.tableLayoutPanelSearchBooks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.11765F));
            this.tableLayoutPanelSearchBooks.Controls.Add(this.labelSearchBooks, 0, 0);
            this.tableLayoutPanelSearchBooks.Controls.Add(this.textBoxSearchBooks, 1, 0);
            this.tableLayoutPanelSearchBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSearchBooks.Location = new System.Drawing.Point(154, 3);
            this.tableLayoutPanelSearchBooks.Name = "tableLayoutPanelSearchBooks";
            this.tableLayoutPanelSearchBooks.RowCount = 1;
            this.tableLayoutPanelSearchBooks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSearchBooks.Size = new System.Drawing.Size(340, 38);
            this.tableLayoutPanelSearchBooks.TabIndex = 1;
            // 
            // labelSearchBooks
            // 
            this.labelSearchBooks.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSearchBooks.AutoSize = true;
            this.labelSearchBooks.Location = new System.Drawing.Point(23, 12);
            this.labelSearchBooks.Name = "labelSearchBooks";
            this.labelSearchBooks.Size = new System.Drawing.Size(44, 13);
            this.labelSearchBooks.TabIndex = 0;
            this.labelSearchBooks.Text = "Search:";
            // 
            // textBoxSearchBooks
            // 
            this.textBoxSearchBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearchBooks.Location = new System.Drawing.Point(73, 9);
            this.textBoxSearchBooks.Name = "textBoxSearchBooks";
            this.textBoxSearchBooks.Size = new System.Drawing.Size(264, 20);
            this.textBoxSearchBooks.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoScroll = true;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.comboBoxSortByBooks, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(145, 38);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // comboBoxSortByBooks
            // 
            this.comboBoxSortByBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSortByBooks.FormattingEnabled = true;
            this.comboBoxSortByBooks.Location = new System.Drawing.Point(3, 8);
            this.comboBoxSortByBooks.Name = "comboBoxSortByBooks";
            this.comboBoxSortByBooks.Size = new System.Drawing.Size(139, 21);
            this.comboBoxSortByBooks.TabIndex = 0;
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.splitContainer1);
            this.Name = "Books";
            this.Size = new System.Drawing.Size(770, 398);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanelSearchBooks.ResumeLayout(false);
            this.tableLayoutPanelSearchBooks.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSearchBooks;
        private System.Windows.Forms.Label labelSearchBooks;
        private System.Windows.Forms.TextBox textBoxSearchBooks;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelIsbn;
        private System.Windows.Forms.Label labelAuthorName;
        private System.Windows.Forms.Label labelYearOfIssue;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.TextBox textBoxAuthorName;
        private System.Windows.Forms.TextBox textBoxYearOfIssue;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button buttonDeleteBooks;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button buttonAddBooks;
        private System.Windows.Forms.Button buttonUpdateBooks;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox comboBoxSortByBooks;
    }
}
