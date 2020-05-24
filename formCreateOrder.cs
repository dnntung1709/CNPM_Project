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
        SqlConnection con;
        SqlDataAdapter adapter;
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

                    MessageBox.Show(tbQuantity.Text);
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

        private void formCreateOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dgvItemList.Rows.Count>1)
            {
                if (MessageBox.Show("This will erase all of your recent order's data!\nDo you want to proceed?", "Closing...", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
            
        }

        private void dgvItemList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvItemList.SelectedCells[0].RowIndex;

            if (dgvItemList.Rows[i].Cells[0].Value != null & dgvItemList.Rows[i].Cells[1].Value != null & dgvItemList.Rows[i].Cells[2].Value != null)
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
    }
}
