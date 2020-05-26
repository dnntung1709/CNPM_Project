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
    public partial class formAccount : Form
    {
        formChangePassword changePassword;
        string username;
        SqlConnection con;
        DataTable dtb;
        SqlCommand command;
        SqlDataAdapter adapter;

        public formAccount(string username)
        {
            InitializeComponent();

            this.username = username;
        }

        private void bChangePassword_Click(object sender, EventArgs e)
        {
            changePassword = new formChangePassword(username);

            changePassword.ShowDialog();
        }

        private void formAccount_Load(object sender, EventArgs e)
        {
            string query;
            con = new SqlConnection(@"Data Source=DESKTOP-BNGI722;Initial Catalog=CNPM_Project;Integrated Security=True");

            tbUsername.Enabled = false;
            tbUsername.Text = username;

            query = "select name,date_of_birth,gender,email,phone_number,personal_ID from _ShopUser where username='" + tbUsername.Text + "'";
            dtb = new DataTable();
            adapter = new SqlDataAdapter(query, con);
            adapter.Fill(dtb);

            tbName.Text = dtb.Rows[0][0].ToString();
            tbEmail.Text = dtb.Rows[0][3].ToString();
            tbPhoneNumber.Text = dtb.Rows[0][4].ToString();
            tbPersonalID.Text = dtb.Rows[0][5].ToString();

            if (dtb.Rows[0][1].ToString() != "")
            {
                dtpBirth.Value = DateTime.Parse(dtb.Rows[0][1].ToString());
            }
            else
            {
                dtpBirth.Value = DateTime.Now;
            }

            if (dtb.Rows[0][2].ToString() == "Male")
            {
                rbMale.Checked = true;
            }
            else if (dtb.Rows[0][2].ToString() == "Female")
            {
                rbFemale.Checked = true;
            }

            con.Close();
        }

        private void bUpdateInformation_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" | tbEmail.Text == "" | tbPersonalID.Text == "" | tbEmail.Text == "" | (rbFemale.Checked == false & rbMale.Checked == false))
            {
                MessageBox.Show("Please fill all the information before update!", "Error");
            }
            else
            {
                string query = "update _ShopUser set ";
                string name = tbName.Text;
                string email = tbEmail.Text;
                string phone_number = tbPhoneNumber.Text;
                string personalID = tbPersonalID.Text;
                string gender = rbFemale.Checked == true ? "Female" : "Male";
                string date_of_birth = dtpBirth.Value.ToString("yyyy-MM-dd");

                try
                {
                    con.Open();

                    query += "name='" + name + "',";
                    query += "email='" + email + "',";
                    query += "phone_number='" + phone_number + "',";
                    query += "personal_ID='" + personalID + "',";
                    query += "gender='" + gender + "',";
                    query += "date_of_birth='" + date_of_birth + "'";

                    query += "where username='" + username + "'";
                    command = new SqlCommand(query, con);
                    command.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("The account information has been updated successfully!", "Result");
                }
                catch
                {
                    MessageBox.Show("Invalid information! Please check it and retry!", "Error");
                }
            }
        }
    }
}
