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
        string role;
        formReport report;
        formLogin login;
        formChangePassword changePassword;
        formCreateOrder createOrder;

        string username;
        SqlConnection con;
        SqlCommand command;
        SqlDataAdapter adapter;
        DataTable dtb;
        public formMain(string username,string role,formLogin login)
        {
            InitializeComponent();
            this.username = username;
            this.role = role;
            this.login = login;
        }
        public void refreshOrderList()
        {
            con.Open();

            string query = "select * from _Order";
            adapter = new SqlDataAdapter(query, con);
            dtb = new DataTable();
            adapter.Fill(dtb);

            dgvOrder.DataSource = dtb;

            con.Close();
        }
        private void formMain_Load(object sender, EventArgs e)
        {
            MessageBox.Show(role);
            switch (this.role)
            {
                case "ShopOwner":
                    {
                        break;
                    }
                case "Seller":
                    {
                        tControl.TabPages.Remove(tShopOwner);
                        tControl.TabPages.Remove(tManager);
                        break;
                    }
                case "Manager":
                    {
                        tControl.TabPages.Remove(tSeller);
                        tControl.TabPages.Remove(tShopOwner);
                        break;
                    }

            }
            con = new SqlConnection(@"Data Source=DESKTOP-BNGI722;Initial Catalog=CNPM_Project;Integrated Security=True");
            refreshOrderList();
            refreshProductList();
            refreshAccountList();

            dgvOrder.ClearSelection();
            dgvOrderItem.ClearSelection();
            dgvProduct.ClearSelection();
            dgvAccount.ClearSelection();

            bCreateOrder.Enabled = true;
            bClearOrder.Enabled = true;
            bDeleteOrder.Enabled = false;
            bUpdateOrder.Enabled = false;

            bUpdateProduct.Enabled = false;
            bDeleteProduct.Enabled = false;
            bCreateProduct.Enabled = true;
            bSetStock.Enabled = false;

            cbRole.Items.Add("ShopOwner");
            cbRole.Items.Add("Manager");
            cbRole.Items.Add("Seller");

            bCreateAccount.Enabled = true;
            bDeleteAccount.Enabled = false;
            bUpdateAccount.Enabled = false;
        }
        

        private void bLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bChangePassword_Click(object sender, EventArgs e)
        {
                changePassword = new formChangePassword(username, this);

                changePassword.Show();
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();

            int i = dgvOrder.SelectedCells[0].RowIndex;

            bUpdateOrder.Enabled = true;
            bDeleteOrder.Enabled = true;
            bCreateOrder.Enabled = false;

            string query = "select * from _OrderItem where order_ID=" + dgvOrder.Rows[i].Cells[0].Value.ToString();
            dtb = new DataTable();
            adapter = new SqlDataAdapter(query, con);
            adapter.Fill(dtb);

            dgvOrderItem.DataSource = dtb;

            con.Close();
        }

        private void formMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("This will log out of the system immediately!\nDo you want to proceed?", "Logging out...", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) != DialogResult.OK)
            {
                e.Cancel = true;
            }
            else
            {
                login.Show();
                if (changePassword != null)
                {
                    changePassword.Close();
                } 
                if (createOrder!= null)
                {
                    createOrder.Close();
                }
                if (report != null)
                {
                    report.Close();
                } 
            }
        }

        private void bCreateOrder_Click(object sender, EventArgs e)
        {
                createOrder = new formCreateOrder(this);

                createOrder.Show();
        }
        
        private void bDeleteOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this order and its items?\nIt can't be restore once it's deleted","Confirm",MessageBoxButtons.YesNo, MessageBoxIcon.Information) ==DialogResult.Yes)
            {
                con.Open();

                int i = dgvOrder.SelectedCells[0].RowIndex;

                int order_ID = int.Parse(dgvOrder.Rows[i].Cells[0].Value.ToString());
                string query = "delete from _OrderItem where order_ID=" + order_ID;
                command = new SqlCommand(query, con);

                command.ExecuteNonQuery();

                query = "delete from _Order where order_ID=" + order_ID;
                command = new SqlCommand(query, con);

                command.ExecuteNonQuery();

                con.Close();

                refreshOrderList();

                dtb = new DataTable();
                dgvOrderItem.DataSource = dtb;

                dgvOrder.ClearSelection();
                dgvOrderItem.ClearSelection();

                bCreateOrder.Enabled = true;
                bDeleteOrder.Enabled = false;
                bUpdateOrder.Enabled = false;
            }
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
        public void refreshProductList()
        {
            con.Open();

            string query = "select * from _Product";
            adapter = new SqlDataAdapter(query, con);
            dtb = new DataTable();
            adapter.Fill(dtb);

            dgvProduct.DataSource = dtb;

            con.Close();
        }
        private void bCreateProduct_Click(object sender, EventArgs e)
        {
            if (tbProductID.Text!="" & tbProductName.Text!="" & tbProductWarranty.Text != "" & tbProductAmount.Text!="")
            {
                try
                {
                    con.Open();

                    string query = "insert into _Product(product_ID, product_name,product_warranty,amount, product_quantity)";
                    query += " values('" + tbProductID.Text + "','" + tbProductName.Text + "'," + tbProductWarranty.Text + "," + tbProductAmount.Text + "," + "0" + ")";

                    command = new SqlCommand(query, con);
                    command.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("The product has been created successfully!", "Result");

                    refreshProductList();

                    dgvProduct.ClearSelection();

                    tbProductID.Text = "";
                    tbProductName.Text = "";
                    tbProductWarranty.Text = "";
                    tbProductStock.Text = "";
                    tbProductAmount.Text = "";
                }
                catch
                {
                    MessageBox.Show("Cannot create product!\nThe product has already been in the database", "Error");
                }
            }
            else
            {
                MessageBox.Show("The information can not be blank!\nPlease fill it and retry!","Error");
            }
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvProduct.SelectedCells[0].RowIndex;

            tbProductID.Text = dgvProduct.Rows[i].Cells[0].Value.ToString();
            tbProductName.Text = dgvProduct.Rows[i].Cells[1].Value.ToString();
            tbProductWarranty.Text = dgvProduct.Rows[i].Cells[2].Value.ToString();
            tbProductAmount.Text = dgvProduct.Rows[i].Cells[3].Value.ToString();
            tbProductStock.Text = dgvProduct.Rows[i].Cells[4].Value.ToString();

            bUpdateProduct.Enabled = true;
            bDeleteProduct.Enabled = true;
            bCreateProduct.Enabled = false;
            bSetStock.Enabled = true;
        }

        private void bClearProduct_Click(object sender, EventArgs e)
        {
            dgvProduct.ClearSelection();

            tbProductID.Text = "";
            tbProductName.Text = "";
            tbProductWarranty.Text = "";
            tbProductStock.Text = "";
            tbProductAmount.Text = "";

            bCreateProduct.Enabled = true;
            bDeleteProduct.Enabled = false;
            bUpdateProduct.Enabled = false;
            bSetStock.Enabled = false;
        }

        private void bSetStock_Click(object sender, EventArgs e)
        {
            if (tbProductStock.Text != "")
            {
                int i = dgvProduct.SelectedCells[0].RowIndex;
                string product_ID = dgvProduct.Rows[i].Cells[0].Value.ToString();

                try
                {
                    con.Open();

                    string query="update _Product set product_quantity="+tbProductStock.Text+" where product_ID='"+product_ID+"'";
                    command = new SqlCommand(query, con);

                    command.ExecuteNonQuery();

                    MessageBox.Show("The product has been set successfully!", "Result");

                    con.Close();

                    refreshProductList();

                    dgvProduct.ClearSelection();

                    tbProductID.Text = "";
                    tbProductName.Text = "";
                    tbProductWarranty.Text = "";
                    tbProductStock.Text = "";
                    tbProductAmount.Text = "";

                    bCreateProduct.Enabled = true;
                    bDeleteProduct.Enabled = false;
                    bUpdateProduct.Enabled = false;
                    bSetStock.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Invalid input, please retry!", "Error");
                }
            }
            else
            {
                MessageBox.Show("You must fill the quantity number!\nIt's empty", "Error");
            }
        }

        private void bDeleteProduct_Click(object sender, EventArgs e)
        {
            con.Open();

            int i = dgvProduct.SelectedCells[0].RowIndex;
            string product_ID = dgvProduct.Rows[i].Cells[0].Value.ToString();

            string query = "delete from _Product where product_ID='"+product_ID+"'";
            command = new SqlCommand(query, con);

            command.ExecuteNonQuery();

            MessageBox.Show("The product has been deleted successfully!", "Result");

            con.Close();

            refreshProductList();
        }

        private void bUpdateProduct_Click(object sender, EventArgs e)
        {
            if (tbProductID.Text != "" & tbProductName.Text != "" & tbProductWarranty.Text != "" & tbProductAmount.Text != "")
            {
                try
                {
                    con.Open();

                    int i = dgvProduct.SelectedCells[0].RowIndex;
                    string product_ID = dgvProduct.Rows[i].Cells[0].Value.ToString();

                    string query = "update _Product set product_ID='"+tbProductID.Text+"', product_name='"+tbProductName.Text+"',product_warranty="+tbProductWarranty.Text+",amount="+tbProductAmount.Text+" where product_ID='"+product_ID+"'";

                    command = new SqlCommand(query, con);
                    command.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("The product has been updated successfully!", "Result");

                    refreshProductList();
                }
                catch
                {
                    MessageBox.Show("Update failed! The product id had already existed", "Error");
                }

            }
            else
            {
                MessageBox.Show("The information can not be blank!\nPlease fill it and retry!", "Error");
            }
        }
        public void refreshAccountList()
        {
            con.Open();

            string query = "select * from _ShopUser";
            adapter = new SqlDataAdapter(query, con);
            dtb = new DataTable();
            adapter.Fill(dtb);

            dgvAccount.DataSource = dtb;

            con.Close();
        }
        private void bClearAccount_Click(object sender, EventArgs e)
        {
            dgvProduct.ClearSelection();

            tbUsername.Text = "";
            tbPassword.Text = "";
            cbRole.Text = "";

            bCreateAccount.Enabled = true;
            bDeleteAccount.Enabled = false;
            bUpdateAccount.Enabled = false;
        }

        private void bCreateAccount_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text!= "" & tbPassword.Text != "" & cbRole.SelectedItem.ToString()!="")
            {
                if (tbUsername.Text.Length<=10 & tbPassword.Text.Length <= 20)
                {
                    try
                    {
                        con.Open();

                        string query = "insert into _ShopUser(username, password)";
                        query += " values('" + tbUsername.Text + "','" + tbPassword.Text + "')";

                        command = new SqlCommand(query, con);
                        command.ExecuteNonQuery();

                        query = "insert into _" + cbRole.SelectedItem.ToString() + "(username)";
                        query += " values('" + tbUsername.Text + "')";

                        command = new SqlCommand(query, con);
                        command.ExecuteNonQuery();

                        con.Close();

                        MessageBox.Show("The account has been created successfully!", "Result");

                        refreshAccountList();

                        dgvAccount.ClearSelection();

                        tbUsername.Text = "";
                        tbPassword.Text = "";
                        cbRole.Text = "";

                    }
                    catch
                    {
                        MessageBox.Show("Cannot create account!\nThe account has already been in the database", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid information!\nPlease retry!", "Error");

                }
            }
            else
            {
                MessageBox.Show("The information can not be blank!\nPlease fill it and retry!", "Error");
            }
        }

        private void bUpdateAccount_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text != "" & tbPassword.Text != "" & cbRole.SelectedItem.ToString() != "")
            {
                if (tbUsername.Text.Length <= 10 & tbPassword.Text.Length <= 20)
                {
                    int i = dgvAccount.SelectedCells[0].RowIndex;
                    string username = dgvAccount.Rows[i].Cells[0].Value.ToString();
                    string query;
                    try
                    {
                        con.Open();

                        for (int j = 0; j < cbRole.Items.Count; j++)
                        {
                            query = "delete from _" + cbRole.Items[j].ToString() + " where username='" + username + "'";
                            command = new SqlCommand(query, con);

                            command.ExecuteNonQuery();
                        }

                        query = "update _ShopUser";
                        query += " set username='" + tbUsername.Text + "', password='" + tbPassword.Text + "' where username='" + username + "'";

                        command = new SqlCommand(query, con);
                        command.ExecuteNonQuery();

                        query = "insert into _" + cbRole.SelectedItem.ToString() + "(username)";
                        query += " values('" + tbUsername.Text + "')";

                        command = new SqlCommand(query, con);
                        command.ExecuteNonQuery();

                        con.Close();

                        MessageBox.Show("The account has been updated successfully!", "Result");

                        refreshAccountList();

                        dgvAccount.ClearSelection();

                        tbUsername.Text = "";
                        tbPassword.Text = "";
                        cbRole.Text = "";

                        bCreateAccount.Enabled = true;
                        bDeleteAccount.Enabled = false;
                        bUpdateAccount.Enabled = false;
                    }
                    catch
                    {
                        MessageBox.Show("Update failed!\nThe account's username had already existed!", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid information!\nPlease retry!", "Error");

                }
            }
            else
            {
                MessageBox.Show("The information can not be blank!\nPlease fill it and retry!", "Error");
            }
        }

        private void bDeleteAccount_Click(object sender, EventArgs e)
        {
            con.Open();

            int i = dgvAccount.SelectedCells[0].RowIndex;
            string username = dgvAccount.Rows[i].Cells[0].Value.ToString();

            string query = "delete from _" + cbRole.Text + " where username='" + username + "'";
            command = new SqlCommand(query, con);

            command.ExecuteNonQuery();
            

            query = "delete from _ShopUser where username='" + username + "'";
            command = new SqlCommand(query, con);

            command.ExecuteNonQuery();

            MessageBox.Show("The account has been deleted successfully!", "Result");

            con.Close();

            refreshAccountList();
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvAccount.SelectedCells[0].RowIndex;

            con.Open();

            tbUsername.Text = dgvAccount.Rows[i].Cells[0].Value.ToString();
            tbPassword.Text = dgvAccount.Rows[i].Cells[1].Value.ToString();

            string query;
            for (int j = 0; j < cbRole.Items.Count; j++)
            {
                query = "select * from _" + cbRole.Items[j].ToString() + " where username='" + tbUsername.Text + "'";
                adapter = new SqlDataAdapter(query, con);
                dtb = new DataTable();

                adapter.Fill(dtb);
                    
                if (dtb.Rows.Count > 0)
                {
                    cbRole.Text = cbRole.Items[j].ToString();
                }
            }
            con.Close();

            bUpdateAccount.Enabled = true;
            bDeleteAccount.Enabled = true;
            bCreateAccount.Enabled = false;
        }

        private void bReport_Click(object sender, EventArgs e)
        {
                report = new formReport(this);

                report.Show();
            
        }
    }
}
