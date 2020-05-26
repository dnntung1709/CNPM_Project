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

            bCreateOrderItem.Enabled = true;
            bUpdateOrderItem.Enabled = false;
            bDeleteOrderItem.Enabled = false;

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
            if (tbCustomerEmail.Text != "" & tbCustomerName.Text != "" & tbCustomerPhone.Text != "")
            {
                if (int.Parse(lbTotalAmount.Text) > 0)
                {
                    string query;

                    con.Open();

                    query = "delete from _OrderItem where order_ID=" + order_ID;
                    command = new SqlCommand(query, con);
                    command.ExecuteNonQuery();

                    query = "insert into _OrderItem(order_ID, product_ID, quantity)";

                    for (int i = 0; i < dgvItemList.Rows.Count; i++)
                    {
                        if (dgvItemList.Rows[i].Cells[0].Value != null)
                        {
                            command = new SqlCommand(query + "values(" + order_ID + ",'" + dgvItemList.Rows[i].Cells[0].Value.ToString() + "'," + dgvItemList.Rows[i].Cells[2].Value.ToString() + ")", con);
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("The order was updated successfully!", "Result");

                    con.Close();

                    this.Close();
                }
            }
        }

        private void bCreateOrderItem_Click(object sender, EventArgs e)
        {
            int parsedValue;
            string query;

            if (tbProductID.Text != "" & tbQuantity.Text != "")
            {
                if (tbProductName.Text != "Error! The product cannot be found!" & int.TryParse(tbQuantity.Text, out parsedValue) == true)
                {
                    foreach (DataGridViewRow row in dgvItemList.Rows)
                    {
                        if (row.Cells[0].Value.ToString() == tbProductID.Text)
                        {
                            MessageBox.Show("The product you want to add is already in this list!", "Error");
                            return;
                        }
                    }

                    con.Open();

                    query = "select product_name,amount from _Product where product_ID='" + tbProductID.Text + "'";
                    adapter = new SqlDataAdapter(query, con);
                    DataTable dtb = new DataTable();
                    adapter.Fill(dtb);

                    dtb_orderItem.Rows.Add(tbProductID.Text, dtb.Rows[0][0].ToString(), tbQuantity.Text, dtb.Rows[0][1].ToString());

                    lbTotalAmount.Text = (int.Parse(dtb.Rows[0][1].ToString()) * int.Parse(tbQuantity.Text) + int.Parse(lbTotalAmount.Text)).ToString();

                    con.Close();

                    firstState_OrderItem();
                }
                else
                {
                    MessageBox.Show("Invalid input!\nPlease try again!", "Error");
                }
            }
            else
            {
                MessageBox.Show("You must fill both product ID and quantity!", "Error");
            }
        }

        private void bUpdateOrderItem_Click(object sender, EventArgs e)
        {
            int i = dgvItemList.SelectedCells[0].RowIndex;
            int parsedValue;
            int new_total_amount;
            string query;
            int old_total_amount = int.Parse(dgvItemList.Rows[i].Cells[3].Value.ToString()) * int.Parse(dgvItemList.Rows[i].Cells[2].Value.ToString());

            if (tbProductID.Text != "" & tbQuantity.Text != "")
            {
                if (tbProductName.Text != "Error! The product cannot be found!" & int.TryParse(tbQuantity.Text, out parsedValue) == true)
                {
                    con.Open();

                    query = "select product_name,amount from _Product where product_ID='" + tbProductID.Text + "'";
                    adapter = new SqlDataAdapter(query, con);
                    DataTable dtb = new DataTable();
                    adapter.Fill(dtb);

                    dgvItemList.Rows[i].Cells[0].Value = tbProductID.Text;
                    dgvItemList.Rows[i].Cells[1].Value = dtb.Rows[0][0].ToString();
                    dgvItemList.Rows[i].Cells[2].Value = tbQuantity.Text;
                    dgvItemList.Rows[i].Cells[3].Value = dtb.Rows[0][1].ToString();

                    new_total_amount = int.Parse(dtb.Rows[0][1].ToString()) * int.Parse(tbQuantity.Text);
                    lbTotalAmount.Text = (new_total_amount + int.Parse(lbTotalAmount.Text) - old_total_amount).ToString();

                    con.Close();

                    firstState_OrderItem();
                }
                else
                {
                    MessageBox.Show("Invalid input!\nPlease try again!", "Error");
                }
            }
            else
            {
                MessageBox.Show("You must fill both product ID and quantity!", "Error");
            }
        }

        private void bDeleteOrderItem_Click(object sender, EventArgs e)
        {
            int i = dgvItemList.SelectedCells[0].RowIndex;
            int quantity = int.Parse(dgvItemList.Rows[i].Cells[2].Value.ToString());
            int amount = int.Parse(dgvItemList.Rows[i].Cells[3].Value.ToString());

            dtb_orderItem.Rows.RemoveAt(i);

            lbTotalAmount.Text = (int.Parse(lbTotalAmount.Text) - (quantity * amount)).ToString();

            refreshOrderItemList();
            firstState_OrderItem();
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            refreshOrderItemList();
            firstState_OrderItem();
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

                bCreateOrderItem.Enabled = false;
                bUpdateOrderItem.Enabled = true;
                bDeleteOrderItem.Enabled = true;

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
