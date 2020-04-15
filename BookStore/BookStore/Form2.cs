using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace BookStore
{
	public partial class BookStore : Form
	{
		List<String> Titles;
		List<String> Authors;
		List<String> ISBNs;
		List<int> Prices;
		List<int> Copies;
		List<String> Cities;
		String ID;

		public BookStore(String User)
		{
			InitializeComponent();
			Titles = new List<String>();
			Authors = new List<String>();
			ISBNs = new List<String>();
			Prices = new List<int>();
			Copies = new List<int>();
			Cities = new List<string>();
			ID = User;
			UserLabel.Text = "Welcome " + User + ", you can search or purchase books here.";
			Cities.Add("Toronto");
			Cities.Add("Montreal");
			Cities.Add("Ottawa ");
			Cities.Add("Calgary");
			Cities.Add("Vancouver");
			Cities.Add("Halifax ");
		}

		private void SearchBtn_Click(object sender, EventArgs e)
		{
			SqlDataAdapter sda;
			String query;
			bool sw = false;
			DataTable bookTable = new DataTable();

			query = "Select Title, Author, Genre, Publisher, ISBN, NumberOfPages, Price, Copies From Book Where ";

			if (AuthorBox.Text != "")
			{
				if (sw) query += "and "; 
				sw = true;
				query += "Author = '" + AuthorBox.Text + "'";
			}

			if (TitleBox.Text != "")
			{
				if (sw) query += "and ";
				sw = true;
				query += "Title = '" + TitleBox.Text + "'";
			}

			if (GenreBox.Text != "")
			{
				if (sw) query += "and ";
				sw = true;
				query += "Genre = '" + GenreBox.Text + "'";
			}

			if (ISBNBox.Text != "")
			{
				if (sw) query += "and ";
				sw = true;
				query += "ISBN = '" + ISBNBox.Text + "'";
			}

			if (PublisherBox.Text != "")
			{
				if (sw) query += "and ";
				sw = true;
				query += "Publisher = '" + PublisherBox.Text + "'";
			}

			if (!sw)
			{
				MessageBox.Show("Please enter at least one field for search!", "Nothing to be searched", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return;
			}

			BookDBConn.Open();
			sda = new SqlDataAdapter(query, BookDBConn);
			sda.Fill(bookTable);
			BookInfoTable.DataSource = bookTable;
			BookDBConn.Close();

		}

		private void BookStore_Load(object sender, EventArgs e)
		{
			SqlDataAdapter sda;
			String query;
			DataTable bookTable = new DataTable();

			query = "Select Title, Author, Genre, Publisher, ISBN, NumberOfPages, Price, Copies From Book";

			BookDBConn.Open();
			sda = new SqlDataAdapter(query, BookDBConn);
			sda.Fill(bookTable);
			BookInfoTable.DataSource = bookTable;
			BookDBConn.Close();
		}

		private void UpdateReceiept()
		{
			BookCart.Items.Clear();

			int i, totalPrice = 0;

			for(i = 0; i < Titles.Count; ++i)
			{
				String bookItem;
				int price = Prices[i] * Copies[i];
				bookItem = Titles[i] + " by " + Authors[i] + "---" + Copies[i] + "---" + " Copies --- " + price.ToString();
				totalPrice += price;
				BookCart.Items.Add(bookItem);
			}

			totalFee.Text = totalPrice.ToString();
		}

		private void BookInfoTable_SelectionChanged(object sender, EventArgs e)
		{
			if (BookInfoTable.SelectedRows.Count != 0)
			{
				String ISBN = BookInfoTable.SelectedRows[0].Cells[4].Value.ToString();
				int total = Convert.ToInt32(BookInfoTable.SelectedRows[0].Cells[7].Value);

				int i, val;
				bool sw = false;

				for (i = 0; i < ISBNs.Count; ++i)
				{
					if (ISBNs[i] == ISBN)
					{
						sw = true;
						break;
					}
				}

				if (sw)
					val = total - Copies[i];
				else
					val = total;

				if (val == 0)
					CopiesNum.Minimum = CopiesNum.Maximum = 0;
				else 
					CopiesNum.Maximum = val;
			}
		}

		private void AddCartBtn_Click(object sender, EventArgs e)
		{
			if (BookInfoTable.SelectedRows.Count == 0)
			{
				MessageBox.Show("No book is selected to be added to the cart!", "Please select a book!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			String ISBN = BookInfoTable.SelectedRows[0].Cells[4].Value.ToString();
			//int total = Convert.ToInt32(BookInfoTable.SelectedRows[0].Cells[7].Value);

			int i;
			bool sw = false;

			for (i = 0; i < ISBNs.Count; ++i)
			{
				if (ISBNs[i] == ISBN)
				{
					sw = true;
					break;
				}
			}

			if (sw)
				Copies[i] += Convert.ToInt32(CopiesNum.Value);
			else
			{
				Titles.Add(BookInfoTable.SelectedRows[0].Cells[0].Value.ToString());
				Authors.Add(BookInfoTable.SelectedRows[0].Cells[1].Value.ToString());
				ISBNs.Add(BookInfoTable.SelectedRows[0].Cells[4].Value.ToString());
				Prices.Add(Convert.ToInt32(BookInfoTable.SelectedRows[0].Cells[6].Value));
				Copies.Add(Convert.ToInt32(CopiesNum.Value));
			}

			UpdateReceiept();
		}

		private void BookCart_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (BookCart.SelectedIndex != -1)
				RemoveCopies.Maximum = Copies[BookCart.SelectedIndex];

		}

		private void RemoveCartBtn_Click(object sender, EventArgs e)
		{
			if (BookCart.SelectedIndex == -1)
			{
				MessageBox.Show("No book is selected to be removed from the cart!", "Please select a book!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Copies[BookCart.SelectedIndex] -= Convert.ToInt32(RemoveCopies.Value);

			if (Copies[BookCart.SelectedIndex] == 0)
			{
				Titles.RemoveAt(BookCart.SelectedIndex);
				Authors.RemoveAt(BookCart.SelectedIndex);
				ISBNs.RemoveAt(BookCart.SelectedIndex);
				Prices.RemoveAt(BookCart.SelectedIndex);
				Copies.RemoveAt(BookCart.SelectedIndex);
			}

			UpdateReceiept();
		}

		private void CheckoutCartBtn_Click(object sender, EventArgs e)
		{
			DialogResult d = MessageBox.Show("Ready to go to checkout?", "Placing the order", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
			
			if (d == DialogResult.Yes)
			{
				int i;
				bool sw = true;
				String query;

				Form3 addinfo = new Form3();
				this.Hide();
				addinfo.ShowDialog();
				this.Show();

				BookCart.Items.Clear();

				SqlCommand command1;
				SqlCommand command2;
				SqlDataReader dataReader;
				String trackingNum = "";

				while (sw)
				{
					Random rand = new Random();
					trackingNum = "";

					for (i = 0; i < 10; ++i)
						trackingNum += rand.Next(10).ToString();

					BookDBConn.Open();
					query = "Select * From Sales Where TrackingID = '" + trackingNum + "'";
					command1 = new SqlCommand(query, BookDBConn);
					dataReader = command1.ExecuteReader();
					if (!dataReader.Read())
						sw = false;
					BookDBConn.Close();
				}

				for (i = 0; i < ISBNs.Count; ++i)
				{
					BookDBConn.Open();
					query = "Select BookID, SoldCopies, Copies, WaitingTransfer From Book Where ISBN = '" + ISBNs[i] + "'";
					command1 = new SqlCommand(query, BookDBConn);
					dataReader = command1.ExecuteReader();

					if (dataReader.Read())
					{
						int nsc, nc, tc;
						String bID;

						bID = dataReader.GetValue(0).ToString();
						nsc = Convert.ToInt32(dataReader.GetValue(1));
						nc = Convert.ToInt32(dataReader.GetValue(2));
						tc = Convert.ToInt32(dataReader.GetValue(3));

						nsc += Copies[i];
						tc += Copies[i];
						nc -= Copies[i];

						if (nc < 10)
						{
							MessageBox.Show("An order placed for book titled " + Titles[i] + " with ISBN = " + ISBNs[i], "Low on stock, placing order", MessageBoxButtons.OK, MessageBoxIcon.Information);
							nc += 50;
						}

						String upd, ins;

						BookDBConn2.Open();
						upd = "UPDATE Book SET SoldCopies = " + nsc.ToString() + ", Copies = " + nc.ToString() + ", WaitingTransfer = " + tc.ToString() + " Where ISBN = '" + ISBNs[i] + "'";
						command2 = new SqlCommand(upd, BookDBConn2);
						command2.ExecuteNonQuery();
						BookDBConn2.Close();

						BookDBConn2.Open();
						ins = "INSERT INTO Sales (BookID, Copies, TrackingID, UserID) VALUES ('" + bID + "', " + Copies[i].ToString() + ", '" + trackingNum + "', '" + ID + "');";
						command2 = new SqlCommand(ins, BookDBConn2);
						command2.ExecuteNonQuery();
						BookDBConn2.Close();
					}

					BookDBConn.Close();
				}


				MessageBox.Show("Your order has been placed, you can keep track of your order using this tracking number " + trackingNum, "Checkout was successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

				SqlDataAdapter sda;
				DataTable bookTable = new DataTable();

				BookDBConn.Open();

				query = "Select Title, Author, Genre, Publisher, ISBN, NumberOfPages, Price, Copies From Book";

				sda = new SqlDataAdapter(query, BookDBConn);
				sda.Fill(bookTable);
				BookInfoTable.DataSource = bookTable;
				BookDBConn.Close();
			}
		}

		private void TrackBtn_Click(object sender, EventArgs e)
		{
			String q;
			SqlCommand command;
			SqlDataReader sdr;

			if (TrackBtn.Text == "")
			{
				MessageBox.Show("Please enter a tracking number!", "No Tracking Number Entered!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			BookDBConn.Open();
			q = "Select TrackingID From Sales Where TrackingID = '" + TrackingBox.Text + "'";
			command = new SqlCommand(q, BookDBConn);
			sdr = command.ExecuteReader();
			if (!sdr.Read())
			{
				MessageBox.Show("The tracking number is invalid", TrackingBox.Text + " does not exists!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				BookDBConn.Close();
				return;
			}

			BookDBConn.Close();

			Random rand = new Random();
			int ind = rand.Next(6);

			if (Cities[ind] == "Toronto")
				MessageBox.Show("The order has placed but not shipped yet", "Your order is at our warehouse in Toronto", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else if (Cities[ind] == "Ottawa")
				MessageBox.Show("The order is already delivered, contact us if you haven't received it", "Your order is completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else
				MessageBox.Show("The order is on the way, it is in " + Cities[ind] + " now", "Your order is shipped", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
