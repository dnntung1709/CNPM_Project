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

    public partial class formReport : Form
    {
        formMain main;
        SqlConnection con;
        SqlDataAdapter adapter;
        DataTable dtb;
        public formReport(formMain main)
        {
            InitializeComponent();
            this.main = main;
            con = new SqlConnection(@"Data Source=DESKTOP-BNGI722;Initial Catalog=CNPM_Project;Integrated Security=True");
        }

        private void formReport_Load(object sender, EventArgs e)
        {
            con.Open();

            string query = "select * from _Order";
            adapter = new SqlDataAdapter(query, con);
            dtb = new DataTable();
            
            adapter.Fill(dtb);

            lbOrderAmount.Text = dtb.Rows.Count.ToString();

            query = "select sum(quantity) from _OrderItem";
            adapter = new SqlDataAdapter(query, con);
            dtb = new DataTable();

            adapter.Fill(dtb);

            lbTotalSoldProducts.Text = dtb.Rows[0][0].ToString();

            query = "select sum(total_amount) from _Order";
            adapter = new SqlDataAdapter(query, con);
            dtb = new DataTable();

            adapter.Fill(dtb);

            lbTotalRevenue.Text = dtb.Rows[0][0].ToString();
        }

        private void formReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
    }
}
