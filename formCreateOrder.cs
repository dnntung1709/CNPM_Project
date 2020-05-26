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

namespace CNPM_Project
{
    public partial class formCreateOrder : Form
    {
        DataTable dtb;
        SqlConnection con;
        SqlDataAdapter adapter;
        SqlCommand command;
        public formCreateOrder()
        {
            InitializeComponent();
        }
        private void formCreateOrder_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-BNGI722;Initial Catalog=CNPM_Project;Integrated Security=True");
            bUpdateOrderItem.Enabled = false;
            bDeleteOrderItem.Enabled = false;
            bCreateOrderItem.Enabled = true;
        }

        private void bCancelOrder_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void bCreateOrderItem_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if (tbProductID.Text!="" & tbQuantity.Text != "")
            {
                if (tbProductName.Text!= "Error! The product cannot be found!" & int.TryParse(tbQuantity.Text, out parsedValue)==true)
                {
                    con.Open();

                    string query = "select product_name,amount from _Product where product_ID='" + tbProductID.Text + "'";
                    adapter = new SqlDataAdapter(query, con);
                    DataTable dtb = new DataTable();

                    adapter.Fill(dtb);
                    dgvItemList.Rows.Add(tbProductID.Text,dtb.Rows[0][0].ToString(),tbQuantity.Text,dtb.Rows[0][1].ToString());

                    lbTotalAmount.Text= (int.Parse(dtb.Rows[0][1].ToString())*int.Parse(tbQuantity.Text)+int.Parse(lbTotalAmount.Text)).ToString();

                    tbProductID.Text = "";
                    tbQuantity.Text = "";
                    tbProductName.Text = "";

                    con.Close();
                }
                else
                {
                    MessageBox.Show("Invalid input!\nPlease try again!","Error");
                }
            }
            else
            {
                MessageBox.Show("You must fill both product ID and quantity!","Error");
            }
        }

        private void dgvItemList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvItemList.SelectedCells[0].RowIndex;

            if (dgvItemList.Rows[i].Cells[0].Value != null)
            {
                bUpdateOrderItem.Enabled = true;
                bDeleteOrderItem.Enabled = true;
                bCreateOrderItem.Enabled = false;

                tbProductID.Text = dgvItemList.Rows[i].Cells[0].Value.ToString();
                tbProductName.Text = dgvItemList.Rows[i].Cells[1].Value.ToString();
                tbQuantity.Text = dgvItemList.Rows[i].Cells[2].Value.ToString();
            }
            else
            {
                bUpdateOrderItem.Enabled = false;
                bDeleteOrderItem.Enabled = false;
                bCreateOrderItem.Enabled = true;

                tbProductID.Text = "";
                tbProductName.Text = "";
                tbQuantity.Text = "";
            }
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            bUpdateOrderItem.Enabled = false;
            bDeleteOrderItem.Enabled = false;
            bCreateOrderItem.Enabled = true;

            dgvItemList.ClearSelection();
            tbProductID.Text = "";
            tbProductName.Text = "";
            tbQuantity.Text = "";
        }

        private void bDeleteOrderItem_Click(object sender, EventArgs e)
        {
            int i = dgvItemList.SelectedCells[0].RowIndex;
            dgvItemList.Rows.RemoveAt(i);

            bUpdateOrderItem.Enabled = false;
            bDeleteOrderItem.Enabled = false;
            bCreateOrderItem.Enabled = true;

            dgvItemList.ClearSelection();
            tbProductID.Text = "";
            tbProductName.Text = "";
            tbQuantity.Text = "";
        }
        private void bCreateOrder_Click(object sender, EventArgs e)
        {
            if (tbCustomerEmail.Text!="" & tbCustomerName.Text!="" & tbCustomerPhone.Text!= "")
            {
                if (int.Parse(lbTotalAmount.Text)>0)
                {
                    con.Open();

                    string query = "insert into _Order(customer_name, customer_email, customer_phone_number,total_amount)";

                    command = new SqlCommand(query + "values('" + tbCustomerName.Text + "','" + tbCustomerEmail.Text + "','" + tbCustomerPhone.Text + "','" + int.Parse(lbTotalAmount.Text) + "')", con);
                    command.ExecuteNonQuery();

                    query = "select max(order_ID) from _Order";
                    adapter = new SqlDataAdapter(query, con);
                    dtb = new DataTable();

                    adapter.Fill(dtb);
                    int order_ID = int.Parse(dtb.Rows[0][0].ToString());

                    try
                    {
                        query = "insert into _OrderItem(order_ID, product_ID, quantity)";

                        for (int i = 0; i < dgvItemList.Rows.Count; i++)
                        {
                            if (dgvItemList.Rows[i].Cells[0].Value != null)
                            {
                                command = new SqlCommand(query + "values(" + order_ID + ",'" + dgvItemList.Rows[i].Cells[0].Value + "'," + dgvItemList.Rows[i].Cells[2].Value + ")", con);
                                command.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("The order was created successfully!","Result");

                        this.Close();
                    }
                    catch
                    {
                        query = "delete from _OrderItem where order_ID="+order_ID;
                        command = new SqlCommand(query, con);
                        command.ExecuteNonQuery();

                        query = "delete from _Order where order_ID=" + order_ID;
                        command = new SqlCommand(query, con);
                        command.ExecuteNonQuery();

                        MessageBox.Show("The order was failed to create!\nCannot have 2 same order items in 1 order!\nPlease check again!", "Result");
                    }

                    con.Close();
                }
            }
        }

        private void bUpdateOrderItem_Click(object sender, EventArgs e)
        {
            int i = dgvItemList.SelectedCells[0].RowIndex;

            int parsedValue,new_total_amount,old_total_amount=int.Parse(dgvItemList.Rows[i].Cells[3].Value.ToString())* int.Parse(dgvItemList.Rows[i].Cells[2].Value.ToString());
            if (tbProductID.Text != "" & tbQuantity.Text != "")
            {
                if (tbProductName.Text != "Error! The product cannot be found!" & int.TryParse(tbQuantity.Text, out parsedValue) == true)
                {
                    con.Open();

                    string query = "select product_name,amount from _Product where product_ID='" + tbProductID.Text + "'";
                    adapter = new SqlDataAdapter(query, con);
                    DataTable dtb = new DataTable();

                    adapter.Fill(dtb);
                    dgvItemList.Rows[i].Cells[0].Value = tbProductID.Text;
                    dgvItemList.Rows[i].Cells[1].Value = dtb.Rows[0][0].ToString();
                    dgvItemList.Rows[i].Cells[2].Value = tbQuantity.Text;
                    dgvItemList.Rows[i].Cells[3].Value = dtb.Rows[0][1].ToString();

                    new_total_amount= int.Parse(dtb.Rows[0][1].ToString()) * int.Parse(tbQuantity.Text);
                    lbTotalAmount.Text = (new_total_amount+int.Parse(lbTotalAmount.Text)-old_total_amount).ToString();

                    tbProductID.Text = "";
                    tbQuantity.Text = "";
                    tbProductName.Text = "";

                    con.Close();
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
    }
}
