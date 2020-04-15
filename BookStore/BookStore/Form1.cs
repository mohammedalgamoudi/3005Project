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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

		private void EnterUserBtn_Click(object sender, EventArgs e)
		{
			SqlCommand command;
			SqlDataReader dataReader;
			String query;

			query = "Select * From LoginTable Where Username = '" + UsernameText.Text + "' and Password = '" + PasswordText.Text + "' and Type = 'User'";

			BookDBConn.Open();

			command = new SqlCommand(query, BookDBConn);
			dataReader = command.ExecuteReader();

			if (dataReader.Read())
			{
				//Add welcome later
				BookStore UserAccess = new BookStore(UsernameText.Text);
				this.Hide();
				UserAccess.ShowDialog();
				this.Show();
			}
			else
				MessageBox.Show("Username or Password are not valid!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			

			BookDBConn.Close();


		}

		private void EnterOwnerBtn_Click(object sender, EventArgs e)
		{
			SqlCommand command;
			SqlDataReader dataReader;
			String query;

			query = "Select * From LoginTable Where Username = '" + UsernameText.Text + "' and Password = '" + PasswordText.Text + "' and Type = 'Owner'";

			BookDBConn.Open();

			command = new SqlCommand(query, BookDBConn);
			dataReader = command.ExecuteReader();

			if (dataReader.Read())
			{
				OwnerPage UserAccess = new OwnerPage();
				this.Hide();
				UserAccess.ShowDialog();
				this.Show();
			}
			else
				MessageBox.Show("Username or Password are not valid!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);


			BookDBConn.Close();

		}

		private void RegisterBtn_Click(object sender, EventArgs e)
		{
			RegisterForm rgf = new RegisterForm();
			this.Hide();
			rgf.ShowDialog();
			this.Show();
		}

		private void Login_Load(object sender, EventArgs e)
		{

		}
	}
}
