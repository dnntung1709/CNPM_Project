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
        public void refreshOrderList()
        {
            con.Open();

            string query = "select name from _ShopUser where username='" + this.username + "'";
            adapter = new SqlDataAdapter(query, con);
            dtb = new DataTable();
            adapter.Fill(dtb);

            lbHelloUser.Text = "Hello, " + dtb.Rows[0]["name"].ToString();

            query = "select * from _Order";
            adapter = new SqlDataAdapter(query, con);
            dtb = new DataTable();
            adapter.Fill(dtb);

            dgvOrder.DataSource = dtb;

            con.Close();
        }
        private void formMain_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-BNGI722;Initial Catalog=CNPM_Project;Integrated Security=True");
            this.refreshOrderList();

            dgvOrder.ClearSelection();
            dgvOrderItem.ClearSelection();

            bCreateOrder.Enabled = true;
            bClear.Enabled = true;
            bDeleteOrder.Enabled = false;
            bUpdateOrder.Enabled = false;
        }
        

        private void bLogout_Click(object sender, EventArgs e)
        {
            formLogin obj = new formLogin();
            
            obj.Show();
        }

        private void bChangePassword_Click(object sender, EventArgs e)
        {
            formChangePassword obj = new formChangePassword(username,this);

            obj.Show();
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();

            int i = dgvOrder.SelectedCells[0].RowIndex;

            if (dgvOrder.Rows[i].Cells[0].Value!=null)
            {
                bUpdateOrder.Enabled = true;
                bDeleteOrder.Enabled = true;
                bCreateOrder.Enabled = false;

                string query = "select * from _OrderItem where order_ID=" + dgvOrder.Rows[i].Cells[0].Value.ToString();
                dtb = new DataTable();
                adapter = new SqlDataAdapter(query, con);
                adapter.Fill(dtb);

                dgvOrderItem.DataSource = dtb;
            }
            else
            {
                bUpdateOrder.Enabled = false;
                bDeleteOrder.Enabled = false;
                bCreateOrder.Enabled = true;
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

        private void bCreateOrder_Click(object sender, EventArgs e)
        {
            formCreateOrder obj = new formCreateOrder(this);

            obj.Show();
        }

        private void Obj_FormClosed(object sender, FormClosedEventArgs e)
        {
            con.Open();

            string query = "select * from _Order";
            adapter = new SqlDataAdapter(query, con);
            dtb = new DataTable();
            adapter.Fill(dtb);

            dgvOrder.DataSource = dtb;

            con.Close();
        }

        private void bDeleteOrder_Click(object sender, EventArgs e)
        {
            con.Open();
        }

        private void bUpdateOrder_Click(object sender, EventArgs e)
        {

        }

        private void bClear_Click(object sender, EventArgs e)
        {
            dtb = new DataTable();
            dgvOrderItem.DataSource = dtb;

            dgvOrder.ClearSelection();
            dgvOrderItem.ClearSelection();

            bCreateOrder.Enabled = true;
            bDeleteOrder.Enabled = false;
            bUpdateOrder.Enabled = false;
        }
    }
}
