using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_Project
{
    public partial class formChangePassword : Form
    {
        string username;
        SqlConnection con;
        SqlDataAdapter adapter;
        SqlCommand command;
        DataTable dtb;
        public formChangePassword(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formChangePassword_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-BNGI722;Initial Catalog=CNPM_Project;Integrated Security=True");
        }

        private void bApply_Click(object sender, EventArgs e)
        {
            if (tbOldPassword.Text!=null & tbNewPassword.Text != null)
            {
                string query;

                con.Open();

                query = "select * from _ShopUser where username='" + username + "'";
                adapter = new SqlDataAdapter(query, con);
                dtb = new DataTable();
                adapter.Fill(dtb);

                if (dtb.Rows[0]["password"].ToString() == tbOldPassword.Text)
                {
                    query = "update _ShopUser set password='" + tbNewPassword.Text + "' where username='" + username + "'";
                    command = new SqlCommand(query, con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("The password has been changed successfully!");

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cannot change the password because the old password is incorrect!");
                }

                con.Close();
            }
            else
            {
                MessageBox.Show("Invalid input! Please retry!");
            }
        }
    }
}
