using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CNPM_Project
{
    public partial class formUpdateOrder : Form
    {
        SqlConnection con;
        string order_ID;
        SqlCommand command;
        SqlDataAdapter adapter;
        DataTable dtb_orderItem;

        public formUpdateOrder(string order_ID)
        {
            InitializeComponent();

            this.order_ID = order_ID;
        }

        private void refreshOrderItemList()
        {
            string query;

            con.Open();

            query = "select _OrderItem.product_ID as 'Product ID', product_name as 'Product name', quantity as 'Quantity', amount as 'Amount' from _OrderItem, _Product ";
            query += "where _OrderItem.product_ID=_Product.product_ID and _OrderItem.order_ID=" + order_ID;
            dtb_orderItem = new DataTable();
            adapter = new SqlDataAdapter(query,con);
            adapter.Fill(dtb_orderItem);
            dgvItemList.DataSource = dtb_orderItem;

            con.Close();
        }
        private void firstState_OrderItem()
        {
            dgvItemList.ClearSelection();

            tbProductID.Text = "";
            tbProductName.Text = "";
            tbQuantity.Text = "";
        }
        private void bCancelOrder_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bUpdateOrder_Click(object sender, EventArgs e)
        {
            string query;
            if (tbCustomerEmail.Text != "" & tbCustomerName.Text != "" & tbCustomerPhone.Text != "")
            {
                con.Open();

                query = "update _Order set customer_name='"+tbCustomerName.Text+"', customer_email='"+tbCustomerEmail.Text+"', customer_phone_number='"+tbCustomerPhone.Text+"' where order_ID=" + order_ID;
                command = new SqlCommand(query, con);
                command.ExecuteNonQuery();

                MessageBox.Show("The order was updated successfully!", "Result");

                con.Close();

                this.Close();
            }
            else
            {
                MessageBox.Show("You must fill all the information if you want to update the order!", "Error");
            }
        }

        private void formUpdateOrder_Load(object sender, EventArgs e)
        {
            string query;
            con = new SqlConnection(@"Data Source=DESKTOP-BNGI722;Initial Catalog=CNPM_Project;Integrated Security=True");

            con.Open();

            query = "select * from _Order where order_ID=" + order_ID;
            adapter = new SqlDataAdapter(query, con);
            DataTable dtb = new DataTable();
            adapter.Fill(dtb);

            tbCustomerName.Text = dtb.Rows[0][1].ToString();
            tbCustomerEmail.Text = dtb.Rows[0][2].ToString();
            tbCustomerPhone.Text = dtb.Rows[0][3].ToString();

            lbTotalAmount.Text = dtb.Rows[0][4].ToString();

            con.Close();

            refreshOrderItemList();
            firstState_OrderItem();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvItemList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvItemList.SelectedCells.Count > 0)
            {
                int i = dgvItemList.SelectedCells[0].RowIndex;

                tbProductID.Text = dgvItemList.Rows[i].Cells[0].Value.ToString();
                tbProductName.Text = dgvItemList.Rows[i].Cells[1].Value.ToString();
                tbQuantity.Text = dgvItemList.Rows[i].Cells[2].Value.ToString();
            }
        }

        private void tbProductID_TextChanged(object sender, EventArgs e)
        {
            if (tbProductID.Text != "")
            {
                con.Open();

                string query = "select product_name from _Product where product_ID='" + tbProductID.Text + "'";
                adapter = new SqlDataAdapter(query, con);
                DataTable dtb = new DataTable();
                adapter.Fill(dtb);

                if (dtb.Rows.Count == 1)
                {
                    tbProductName.Text = dtb.Rows[0][0].ToString();
                }
                else
                {
                    tbProductName.Text = "Error! The product cannot be found! ";
                }

                con.Close();
            }
            else
            {
                tbProductName.Text = "";
            }
        }
    }
}
