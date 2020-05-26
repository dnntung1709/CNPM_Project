﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_Project
{
    public partial class formAccount : Form
    {
        formChangePassword changePassword;
        formMain main;
        public formAccount(formMain main)
        {
            InitializeComponent();

            this.main = main;
        }

        private void bChangePassword_Click(object sender, EventArgs e)
        {
            changePassword = new formChangePassword(main.username, this);

            changePassword.ShowDialog();
        }

        private void formAccount_Load(object sender, EventArgs e)
        {
            tbUsername.Text = main.username;
            tbUsername.Enabled = false;
        }
    }
}
