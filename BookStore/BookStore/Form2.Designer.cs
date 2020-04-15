namespace BookStore
{
	partial class BookStore
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
			this.AuthorBox = new System.Windows.Forms.TextBox();
			this.GenreBox = new System.Windows.Forms.TextBox();
			this.TitleBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SearchBtn = new System.Windows.Forms.Button();
			this.ISBNBox = new System.Windows.Forms.TextBox();
			this.PublisherBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.BookInfoTable = new System.Windows.Forms.DataGridView();
			this.AddCartBtn = new System.Windows.Forms.Button();
			this.BookDBConn = new System.Data.SqlClient.SqlConnection();
			this.BookCart = new System.Windows.Forms.ListBox();
			this.label7 = new System.Windows.Forms.Label();
			this.CopiesNum = new System.Windows.Forms.NumericUpDown();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.totalFee = new System.Windows.Forms.Label();
			this.RemoveCartBtn = new System.Windows.Forms.Button();
			this.CheckoutCartBtn = new System.Windows.Forms.Button();
			this.RemoveCopies = new System.Windows.Forms.NumericUpDown();
			this.label10 = new System.Windows.Forms.Label();
			this.BookDBConn2 = new System.Data.SqlClient.SqlConnection();
			this.UserLabel = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.TrackingBox = new System.Windows.Forms.TextBox();
			this.TrackBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.BookInfoTable)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CopiesNum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RemoveCopies)).BeginInit();
			this.SuspendLayout();
			// 
			// AuthorBox
			// 
			this.AuthorBox.Location = new System.Drawing.Point(147, 84);
			this.AuthorBox.Name = "AuthorBox";
			this.AuthorBox.Size = new System.Drawing.Size(211, 26);
			this.AuthorBox.TabIndex = 0;
			// 
			// GenreBox
			// 
			this.GenreBox.Location = new System.Drawing.Point(147, 195);
			this.GenreBox.Name = "GenreBox";
			this.GenreBox.Size = new System.Drawing.Size(211, 26);
			this.GenreBox.TabIndex = 1;
			// 
			// TitleBox
			// 
			this.TitleBox.Location = new System.Drawing.Point(147, 140);
			this.TitleBox.Name = "TitleBox";
			this.TitleBox.Size = new System.Drawing.Size(211, 26);
			this.TitleBox.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(26, 87);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "Author";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(26, 143);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Title";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(26, 254);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "ISBN";
			// 
			// SearchBtn
			// 
			this.SearchBtn.Location = new System.Drawing.Point(147, 498);
			this.SearchBtn.Name = "SearchBtn";
			this.SearchBtn.Size = new System.Drawing.Size(211, 42);
			this.SearchBtn.TabIndex = 6;
			this.SearchBtn.Text = "Search";
			this.SearchBtn.UseVisualStyleBackColor = true;
			this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
			// 
			// ISBNBox
			// 
			this.ISBNBox.Location = new System.Drawing.Point(147, 254);
			this.ISBNBox.Name = "ISBNBox";
			this.ISBNBox.Size = new System.Drawing.Size(211, 26);
			this.ISBNBox.TabIndex = 7;
			// 
			// PublisherBox
			// 
			this.PublisherBox.Location = new System.Drawing.Point(147, 318);
			this.PublisherBox.Name = "PublisherBox";
			this.PublisherBox.Size = new System.Drawing.Size(211, 26);
			this.PublisherBox.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(26, 198);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 20);
			this.label4.TabIndex = 13;
			this.label4.Text = "Genre";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(26, 324);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(74, 20);
			this.label6.TabIndex = 15;
			this.label6.Text = "Publisher";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(577, 43);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(131, 20);
			this.label5.TabIndex = 18;
			this.label5.Text = "Book Information";
			// 
			// BookInfoTable
			// 
			this.BookInfoTable.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
			this.BookInfoTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.BookInfoTable.Location = new System.Drawing.Point(430, 84);
			this.BookInfoTable.MultiSelect = false;
			this.BookInfoTable.Name = "BookInfoTable";
			this.BookInfoTable.RowTemplate.Height = 28;
			this.BookInfoTable.Size = new System.Drawing.Size(422, 262);
			this.BookInfoTable.TabIndex = 33;
			this.BookInfoTable.SelectionChanged += new System.EventHandler(this.BookInfoTable_SelectionChanged);
			// 
			// AddCartBtn
			// 
			this.AddCartBtn.Location = new System.Drawing.Point(547, 498);
			this.AddCartBtn.Name = "AddCartBtn";
			this.AddCartBtn.Size = new System.Drawing.Size(211, 42);
			this.AddCartBtn.TabIndex = 34;
			this.AddCartBtn.Text = "Add to Cart";
			this.AddCartBtn.UseVisualStyleBackColor = true;
			this.AddCartBtn.Click += new System.EventHandler(this.AddCartBtn_Click);
			// 
			// BookDBConn
			// 
			this.BookDBConn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Ready2Go\\source\\repo" +
    "s\\BookStore\\BookStore\\BookDB.mdf;Integrated Security=True;Connect Timeout=30";
			this.BookDBConn.FireInfoMessageEventOnUserErrors = false;
			// 
			// BookCart
			// 
			this.BookCart.FormattingEnabled = true;
			this.BookCart.HorizontalScrollbar = true;
			this.BookCart.ItemHeight = 20;
			this.BookCart.Location = new System.Drawing.Point(907, 82);
			this.BookCart.Name = "BookCart";
			this.BookCart.Size = new System.Drawing.Size(319, 264);
			this.BookCart.TabIndex = 35;
			this.BookCart.SelectedIndexChanged += new System.EventHandler(this.BookCart_SelectedIndexChanged);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(1004, 43);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(131, 20);
			this.label7.TabIndex = 36;
			this.label7.Text = "Cart";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// CopiesNum
			// 
			this.CopiesNum.Location = new System.Drawing.Point(661, 397);
			this.CopiesNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.CopiesNum.Name = "CopiesNum";
			this.CopiesNum.Size = new System.Drawing.Size(191, 26);
			this.CopiesNum.TabIndex = 37;
			this.CopiesNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.CopiesNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(426, 397);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(172, 26);
			this.label8.TabIndex = 38;
			this.label8.Text = "Copies";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(903, 397);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(159, 26);
			this.label9.TabIndex = 39;
			this.label9.Text = "Total";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// totalFee
			// 
			this.totalFee.Location = new System.Drawing.Point(1068, 396);
			this.totalFee.Name = "totalFee";
			this.totalFee.Size = new System.Drawing.Size(159, 26);
			this.totalFee.TabIndex = 40;
			this.totalFee.Text = "0";
			this.totalFee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// RemoveCartBtn
			// 
			this.RemoveCartBtn.Location = new System.Drawing.Point(955, 498);
			this.RemoveCartBtn.Name = "RemoveCartBtn";
			this.RemoveCartBtn.Size = new System.Drawing.Size(211, 42);
			this.RemoveCartBtn.TabIndex = 41;
			this.RemoveCartBtn.Text = "Remove from Cart";
			this.RemoveCartBtn.UseVisualStyleBackColor = true;
			this.RemoveCartBtn.Click += new System.EventHandler(this.RemoveCartBtn_Click);
			// 
			// CheckoutCartBtn
			// 
			this.CheckoutCartBtn.Location = new System.Drawing.Point(955, 575);
			this.CheckoutCartBtn.Name = "CheckoutCartBtn";
			this.CheckoutCartBtn.Size = new System.Drawing.Size(211, 42);
			this.CheckoutCartBtn.TabIndex = 42;
			this.CheckoutCartBtn.Text = "Checkout";
			this.CheckoutCartBtn.UseVisualStyleBackColor = true;
			this.CheckoutCartBtn.Click += new System.EventHandler(this.CheckoutCartBtn_Click);
			// 
			// RemoveCopies
			// 
			this.RemoveCopies.Location = new System.Drawing.Point(1103, 438);
			this.RemoveCopies.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.RemoveCopies.Name = "RemoveCopies";
			this.RemoveCopies.Size = new System.Drawing.Size(123, 26);
			this.RemoveCopies.TabIndex = 43;
			this.RemoveCopies.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.RemoveCopies.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(903, 437);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(138, 26);
			this.label10.TabIndex = 44;
			this.label10.Text = "Remove Copies";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// BookDBConn2
			// 
			this.BookDBConn2.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Ready2Go\\source\\repo" +
    "s\\BookStore\\BookStore\\BookDB.mdf;Integrated Security=True;Connect Timeout=30";
			this.BookDBConn2.FireInfoMessageEventOnUserErrors = false;
			// 
			// UserLabel
			// 
			this.UserLabel.ForeColor = System.Drawing.Color.Red;
			this.UserLabel.Location = new System.Drawing.Point(26, 23);
			this.UserLabel.Name = "UserLabel";
			this.UserLabel.Size = new System.Drawing.Size(332, 40);
			this.UserLabel.TabIndex = 45;
			this.UserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(26, 583);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(172, 26);
			this.label11.TabIndex = 46;
			this.label11.Text = "Tracking Order";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// TrackingBox
			// 
			this.TrackingBox.Location = new System.Drawing.Point(216, 583);
			this.TrackingBox.Name = "TrackingBox";
			this.TrackingBox.Size = new System.Drawing.Size(293, 26);
			this.TrackingBox.TabIndex = 47;
			// 
			// TrackBtn
			// 
			this.TrackBtn.Location = new System.Drawing.Point(547, 575);
			this.TrackBtn.Name = "TrackBtn";
			this.TrackBtn.Size = new System.Drawing.Size(211, 42);
			this.TrackBtn.TabIndex = 48;
			this.TrackBtn.Text = "Track an Order";
			this.TrackBtn.UseVisualStyleBackColor = true;
			this.TrackBtn.Click += new System.EventHandler(this.TrackBtn_Click);
			// 
			// BookStore
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1272, 640);
			this.Controls.Add(this.TrackBtn);
			this.Controls.Add(this.TrackingBox);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.UserLabel);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.RemoveCopies);
			this.Controls.Add(this.CheckoutCartBtn);
			this.Controls.Add(this.RemoveCartBtn);
			this.Controls.Add(this.totalFee);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.CopiesNum);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.BookCart);
			this.Controls.Add(this.AddCartBtn);
			this.Controls.Add(this.BookInfoTable);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.PublisherBox);
			this.Controls.Add(this.ISBNBox);
			this.Controls.Add(this.SearchBtn);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TitleBox);
			this.Controls.Add(this.GenreBox);
			this.Controls.Add(this.AuthorBox);
			this.Name = "BookStore";
			this.Text = "Book Store";
			this.Load += new System.EventHandler(this.BookStore_Load);
			((System.ComponentModel.ISupportInitialize)(this.BookInfoTable)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CopiesNum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RemoveCopies)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox AuthorBox;
		private System.Windows.Forms.TextBox GenreBox;
		private System.Windows.Forms.TextBox TitleBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button SearchBtn;
		private System.Windows.Forms.TextBox ISBNBox;
		private System.Windows.Forms.TextBox PublisherBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridView BookInfoTable;
		private System.Windows.Forms.Button AddCartBtn;
		private System.Data.SqlClient.SqlConnection BookDBConn;
		private System.Windows.Forms.ListBox BookCart;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown CopiesNum;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label totalFee;
		private System.Windows.Forms.Button RemoveCartBtn;
		private System.Windows.Forms.Button CheckoutCartBtn;
		private System.Windows.Forms.NumericUpDown RemoveCopies;
		private System.Windows.Forms.Label label10;
		private System.Data.SqlClient.SqlConnection BookDBConn2;
		private System.Windows.Forms.Label UserLabel;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox TrackingBox;
		private System.Windows.Forms.Button TrackBtn;
	}
}