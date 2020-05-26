using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace CNPM_Project
{
    public partial class formLogin : Form
    {
        formMain main;

        SqlConnection con;
        SqlDataAdapter adapter;
        DataTable dtb;
        public formLogin()
        {
            InitializeComponent();
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-BNGI722;Initial Catalog=CNPM_Project;Integrated Security=True");
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            string query;

            con.Open();

            query= "select * from _ShopUser where username='"+tbUsername.Text+"' and password='"+tbPassword.Text+"'";
            adapter = new SqlDataAdapter(query,con);
            dtb = new DataTable();
            adapter.Fill(dtb);

            if (dtb.Rows.Count > 0)
            {
                query = "select * from _ShopOwner where username='" + tbUsername.Text + "'";
                adapter = new SqlDataAdapter(query, con);
                dtb = new DataTable();
                adapter.Fill(dtb);

                if (dtb.Rows.Count > 0)
                {
                    main = new formMain(tbUsername.Text,"ShopOwner", this);

                    con.Close();

                    this.Hide();
                    main.ShowDialog();
                }
                else
                {
                    query = "select * from _Manager where username='" + tbUsername.Text + "'";
                    adapter = new SqlDataAdapter(query, con);
                    dtb = new DataTable();
                    adapter.Fill(dtb);

                    if (dtb.Rows.Count > 0)
                    {
                        main = new formMain(tbUsername.Text, "Manager", this);
                        con.Close();

                        this.Hide();
                        main.ShowDialog();
                    }
                    else
                    {
                        query = "select * from _Seller where username='" + tbUsername.Text + "'";
                        adapter = new SqlDataAdapter(query, con);
                        dtb = new DataTable();
                        adapter.Fill(dtb);

                        if (dtb.Rows.Count > 0)
                        {
                            main = new formMain(tbUsername.Text, "Seller", this);
                            con.Close();

                            this.Hide();
                            main.ShowDialog();
                        }
                    }
                }     
            }
            else
            {
                MessageBox.Show("Invalid username or password, please retry!");
            }

            con.Close();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please contact shop owner to reset your password, cheer <3");
        }
    }
}
