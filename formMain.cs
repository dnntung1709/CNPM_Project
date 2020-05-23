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
    public partial class formMain : Form
    {
        string username;
        SqlConnection con;
        SqlDataAdapter adapter;
        DataTable dtb;
        public formMain(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-BNGI722;Initial Catalog=CNPM_Project;Integrated Security=True");
            string query;

            con.Open();

            query = "select name from _ShopUser where username='" + this.username + "'";
            adapter = new SqlDataAdapter(query, con);
            dtb = new DataTable();
            adapter.Fill(dtb);

            lbHelloUser.Text = "Hello, "+dtb.Rows[0]["name"].ToString();

            query = "select * from _Order";
            adapter = new SqlDataAdapter(query,con);
            dtb = new DataTable();
            adapter.Fill(dtb);

            dgvOrder.DataSource = dtb;

            con.Close();
        }
        

        private void bLogout_Click(object sender, EventArgs e)
        {
            formLogin obj = new formLogin();
            
            obj.Show();
        }

        private void bChangePassword_Click(object sender, EventArgs e)
        {
            formChangePassword obj = new formChangePassword(username);

            obj.Show();
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();

            int i = dgvOrder.SelectedCells[0].RowIndex;
            string order_ID = dgvOrder.Rows[i].Cells[0].Value.ToString();
            
            if (order_ID != "")
            {
                string query = "select * from _OrderItem where order_ID=" + order_ID;
                adapter = new SqlDataAdapter(query, con);
                dtb = new DataTable();
                adapter.Fill(dtb);

                dgvOrderItem.DataSource = dtb;
            }

            con.Close();
        }

        private void formMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("This will log out of the system and close the program immediately!\nDo you want to proceed?", "Closing...", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                Environment.Exit(1);
            else
            {
                e.Cancel = true;
            }
        }
    }
}
