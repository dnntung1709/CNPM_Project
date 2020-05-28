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
        formUpdateOrder updateOrder;
        formAccount account;
        formReport report;
        formLogin login;
        formCreateOrder createOrder;

        string role;
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
        private void firstState_Order()
        {
            refreshOrderList();
            dgvOrderItem.DataSource = null;

            dgvOrder.ClearSelection();
            dgvOrderItem.ClearSelection();

            bCreateOrder.Enabled = true;
            bUpdateOrder.Enabled = false;
            bDeleteOrder.Enabled = false;
        }

        private void firstState_Product()
        {
            refreshProductList();

            dgvProduct.ClearSelection();

            bCreateProduct.Enabled = true;
            bUpdateProduct.Enabled = false;
            bDeleteProduct.Enabled = false;
            bSetStock.Enabled = false;

            tbProductID.Text = "";
            tbProductName.Text = "";
            tbProductWarranty.Text = "";
            tbProductAmount.Text = "";
            tbProductStock.Text = "";
        }

        private void firstState_Account()
        {
            refreshAccountList();

            dgvAccount.ClearSelection();

            bCreateAccount.Enabled = true;
            bUpdateAccount.Enabled = false;
            bDeleteAccount.Enabled = false;

            tbUsername.Text = "";
            tbPassword.Text = "";
            cbRole.Text = "Select a role";
        }
        private void refreshOrderList()
        {
            con.Open();

            string query = "select order_ID as 'Order ID'," +
                                " customer_name as 'Customer Name'," +
                                " customer_email as 'Customer Email'," +
                                " customer_phone_number as 'Customer Phone Number'," +
                                " total_amount as 'Total amount' from _Order";
            adapter = new SqlDataAdapter(query, con);
            dtb = new DataTable();
            adapter.Fill(dtb);

            dgvOrder.DataSource = dtb;

            con.Close();
        }
        private void formMain_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-BNGI722;Initial Catalog=CNPM_Project;Integrated Security=True");

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

            firstState_Order();
            firstState_Product();
            firstState_Account();

            cbRole.Items.Add("ShopOwner");
            cbRole.Items.Add("Manager");
            cbRole.Items.Add("Seller");

            userWelcome();
        }
        private void userWelcome()
        {
            string query;

            con.Open();

            query= "select name from _ShopUser where username='"+username+"'";
            adapter = new SqlDataAdapter(query, con);
            dtb = new DataTable();
            adapter.Fill(dtb);

            string name = dtb.Rows[0][0].ToString();

            if (name == "New User")
            {
                MessageBox.Show("New user, please fill your account information by click on 'Account' and follow the instruction!","Announcement");
            }

            lbHelloUser.Text = "Welcome "+name;

            con.Close();
        }

        private void bLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrder.SelectedCells.Count > 0)
            {
                int i = dgvOrder.SelectedCells[0].RowIndex;
                string query;

                con.Open();

                query = "select _OrderItem.product_ID as 'Product ID'," +
                            " _Product.product_name as 'Product name'," +
                            " _OrderItem.quantity as 'Quantity' from _OrderItem, _Product where _Product.product_ID=_OrderItem.product_ID and _OrderItem.order_ID=" + dgvOrder.Rows[i].Cells[0].Value.ToString();
                dtb = new DataTable();
                adapter = new SqlDataAdapter(query, con);
                adapter.Fill(dtb);
                dgvOrderItem.DataSource = dtb;

                con.Close();

                bUpdateOrder.Enabled = true;
                bDeleteOrder.Enabled = true;
                bCreateOrder.Enabled = false;
            }
        }

        private void formMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("This will log out of the system immediately!\nDo you want to proceed?", "Logging out...", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        private void formMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.Show();
        }

        private void bCreateOrder_Click(object sender, EventArgs e)
        {
            createOrder = new formCreateOrder();

            createOrder.ShowDialog();

            firstState_Account();
            firstState_Order();
            firstState_Product();
        }
        
        private void bDeleteOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this order and its items?\nIt can't be restore once it's deleted","Confirm",MessageBoxButtons.YesNo, MessageBoxIcon.Information) ==DialogResult.Yes)
            {
                int i = dgvOrder.SelectedCells[0].RowIndex;
                int order_ID = int.Parse(dgvOrder.Rows[i].Cells[0].Value.ToString());
                string query;

                con.Open();

                query = "delete from _OrderItem where order_ID=" + order_ID;
                command = new SqlCommand(query, con);
                command.ExecuteNonQuery();

                query = "delete from _Order where order_ID=" + order_ID;
                command = new SqlCommand(query, con);
                command.ExecuteNonQuery();

                con.Close();

                firstState_Order();
            }
        }

        private void bUpdateOrder_Click(object sender, EventArgs e)
        {
            int i = dgvOrder.SelectedCells[0].RowIndex;

            updateOrder = new formUpdateOrder(dgvOrder.Rows[i].Cells[0].Value.ToString());

            updateOrder.ShowDialog();

            firstState_Order();
            firstState_Product();
            firstState_Account();
        }

        private void bClearOrder_Click(object sender, EventArgs e)
        {
            firstState_Order();
        }
        private void refreshProductList()
        {
            string query;
            con.Open();

            query = "select product_ID as 'Product ID'," +
                            " product_name as 'Product Name'," +
                            " product_warranty as 'Product Warranty'," +
                            " amount as 'Product Amount'," +
                            " product_quantity as 'Stock' from _Product";
            adapter = new SqlDataAdapter(query, con);
            dtb = new DataTable();
            adapter.Fill(dtb);
            dgvProduct.DataSource = dtb;

            con.Close();
        }
        private void bCreateProduct_Click(object sender, EventArgs e)
        {
            string query;

            if (tbProductID.Text!="" & tbProductName.Text!="" & tbProductWarranty.Text != "" & tbProductAmount.Text!="")
            {
                try
                {
                    con.Open();

                    query = "insert into _Product(product_ID, product_name,product_warranty,amount, product_quantity)";
                    query += " values('" + tbProductID.Text + "','" + tbProductName.Text + "'," + tbProductWarranty.Text + "," + tbProductAmount.Text + "," + "0" + ")";
                    command = new SqlCommand(query, con);
                    command.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("The product has been created successfully!", "Result");
                    firstState_Product();
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
            if (dgvProduct.SelectedCells.Count > 0)
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
        }

        private void bClearProduct_Click(object sender, EventArgs e)
        {
            firstState_Product();
        }

        private void bSetStock_Click(object sender, EventArgs e)
        {
            string query;
            int i = dgvProduct.SelectedCells[0].RowIndex;
            string product_ID = dgvProduct.Rows[i].Cells[0].Value.ToString();

            if (tbProductStock.Text != "")
            {
                if (MessageBox.Show("Do you want to change the product's quantity in stock?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
                {
                    try
                    {
                        con.Open();

                        query = "update _Product set product_quantity=" + tbProductStock.Text + " where product_ID='" + product_ID + "'";
                        command = new SqlCommand(query, con);
                        command.ExecuteNonQuery();

                        con.Close();

                        MessageBox.Show("The product has been set successfully!", "Result");

                        firstState_Product();
                    }
                    catch
                    {
                        MessageBox.Show("Invalid input, please retry!", "Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("You must fill the quantity number!\nIt's empty", "Error");
            }
        }

        private void bDeleteProduct_Click(object sender, EventArgs e)
        {
            int i = dgvProduct.SelectedCells[0].RowIndex;
            string product_ID = dgvProduct.Rows[i].Cells[0].Value.ToString();
            string query;

            con.Open();

            query = "delete from _Product where product_ID='" + product_ID + "'";
            command = new SqlCommand(query, con);
            command.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("The product has been deleted successfully!", "Result");

            firstState_Product();
        }

        private void bUpdateProduct_Click(object sender, EventArgs e)
        {
            int i = dgvProduct.SelectedCells[0].RowIndex;
            string product_ID = dgvProduct.Rows[i].Cells[0].Value.ToString();
            string query;

            if (tbProductID.Text != "" & tbProductName.Text != "" & tbProductWarranty.Text != "" & tbProductAmount.Text != "")
            {
                try
                {
                    con.Open();

                    query = "update _Product set product_ID='" + tbProductID.Text + "', product_name='" + tbProductName.Text + "',product_warranty=" + tbProductWarranty.Text + ",amount=" + tbProductAmount.Text + " where product_ID='" + product_ID + "'";
                    command = new SqlCommand(query, con);
                    command.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("The product has been updated successfully!", "Result");

                    firstState_Product();
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
        private void refreshAccountList()
        {
            con.Open();

            string query = "select username as 'Username'," +
                                " password as 'Password'," +
                                " name as 'Account name'," +
                                " date_of_birth as 'Date of birth'," +
                                " gender as 'Gender'," +
                                " email as 'Account email'," +
                                " phone_number as 'Account phone number'," +
                                " personal_ID as 'Account Personal ID' from _ShopUser";
            adapter = new SqlDataAdapter(query, con);
            dtb = new DataTable();
            adapter.Fill(dtb);

            dgvAccount.DataSource = dtb;

            con.Close();
        }
        private void bClearAccount_Click(object sender, EventArgs e)
        {
            firstState_Account();
        }

        private void bCreateAccount_Click(object sender, EventArgs e)
        {
            string query;

            if (tbUsername.Text!= "" & tbPassword.Text != "" & cbRole.SelectedItem.ToString()!="")
            {
                if (tbUsername.Text.Length<=10 & tbPassword.Text.Length <= 20)
                {
                    try
                    {
                        con.Open();

                        query= "insert into _ShopUser(username, password, name)";
                        query += " values('" + tbUsername.Text + "','" + tbPassword.Text + "','"+"New User"+"')";
                        command = new SqlCommand(query, con);
                        command.ExecuteNonQuery();

                        query = "insert into _" + cbRole.SelectedItem.ToString() + "(username)";
                        query += " values('" + tbUsername.Text + "')";
                        command = new SqlCommand(query, con);
                        command.ExecuteNonQuery();

                        con.Close();

                        MessageBox.Show("The account has been created successfully!", "Result");

                        firstState_Account();
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
            int i = dgvAccount.SelectedCells[0].RowIndex;
            string username = dgvAccount.Rows[i].Cells[0].Value.ToString();
            string query;

            if (tbUsername.Text != "" & tbPassword.Text != "" & cbRole.SelectedItem.ToString() != "")
            {
                if (tbUsername.Text.Length <= 10 & tbPassword.Text.Length <= 20)
                {
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

                        firstState_Account();
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
            int i = dgvAccount.SelectedCells[0].RowIndex;
            string username = dgvAccount.Rows[i].Cells[0].Value.ToString();
            string query;
            
            if (username!= this.username)
            {
                con.Open();

                query = "delete from _" + cbRole.Text + " where username='" + username + "'";
                command = new SqlCommand(query, con);
                command.ExecuteNonQuery();

                query = "delete from _ShopUser where username='" + username + "'";
                command = new SqlCommand(query, con);
                command.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("The account has been deleted successfully!", "Result");

                firstState_Account();
            }
            else
            {
                MessageBox.Show("You cannot delete your recent account which you are using!\nPlease try to delete other accounts", "Error");
            }
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAccount.SelectedCells.Count > 0)
            {
                int i = dgvAccount.SelectedCells[0].RowIndex;
                string query;

                con.Open();

                tbUsername.Text = dgvAccount.Rows[i].Cells[0].Value.ToString();
                tbPassword.Text = dgvAccount.Rows[i].Cells[1].Value.ToString();

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
        }

        private void bReport_Click(object sender, EventArgs e)
        {
            report = new formReport();

            report.ShowDialog();

            firstState_Account();
            firstState_Order();
            firstState_Product();
        }

        private void bAccount_Click(object sender, EventArgs e)
        {
            account = new formAccount(this.username);

            account.ShowDialog();

            firstState_Account();
            firstState_Order();
            firstState_Product();
        }
    }
}
