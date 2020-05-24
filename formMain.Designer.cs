namespace CNPM_Project
{
    partial class formMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.orderList = new CNPM_Project.orderList();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._OrderTableAdapter = new CNPM_Project.orderListTableAdapters._OrderTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.bLogout = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvOrderItem = new System.Windows.Forms.DataGridView();
            this.bChangePassword = new System.Windows.Forms.Button();
            this.bUpdateOrder = new System.Windows.Forms.Button();
            this.bClearOrder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbHelloUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.orderListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bCreateOrder = new System.Windows.Forms.Button();
            this.bDeleteOrder = new System.Windows.Forms.Button();
            this.tControl = new System.Windows.Forms.TabControl();
            this.tSeller = new System.Windows.Forms.TabPage();
            this.tManager = new System.Windows.Forms.TabPage();
            this.gStock = new System.Windows.Forms.GroupBox();
            this.tbProductStock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bSetStock = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bClearProduct = new System.Windows.Forms.Button();
            this.bUpdateProduct = new System.Windows.Forms.Button();
            this.bDeleteProduct = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bCreateProduct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbProductAmount = new System.Windows.Forms.TextBox();
            this.tbProductWarranty = new System.Windows.Forms.TextBox();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.tbProductID = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.tShopOwner = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.bReport = new System.Windows.Forms.Button();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.bClearAccount = new System.Windows.Forms.Button();
            this.bDeleteAccount = new System.Windows.Forms.Button();
            this.bUpdateAccount = new System.Windows.Forms.Button();
            this.bCreateAccount = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.orderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderListBindingSource)).BeginInit();
            this.tControl.SuspendLayout();
            this.tSeller.SuspendLayout();
            this.tManager.SuspendLayout();
            this.gStock.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.tShopOwner.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderList
            // 
            this.orderList.DataSetName = "orderList";
            this.orderList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "_Order";
            this.orderBindingSource.DataSource = this.orderList;
            // 
            // _OrderTableAdapter
            // 
            this._OrderTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvOrder);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 367);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order List";
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(6, 21);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.Size = new System.Drawing.Size(692, 340);
            this.dgvOrder.TabIndex = 0;
            this.dgvOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellClick);
            // 
            // bLogout
            // 
            this.bLogout.Location = new System.Drawing.Point(958, 180);
            this.bLogout.Name = "bLogout";
            this.bLogout.Size = new System.Drawing.Size(75, 32);
            this.bLogout.TabIndex = 2;
            this.bLogout.Text = "Logout";
            this.bLogout.UseVisualStyleBackColor = true;
            this.bLogout.Click += new System.EventHandler(this.bLogout_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvOrderItem);
            this.groupBox2.Location = new System.Drawing.Point(717, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 231);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item List";
            // 
            // dgvOrderItem
            // 
            this.dgvOrderItem.AllowUserToAddRows = false;
            this.dgvOrderItem.AllowUserToDeleteRows = false;
            this.dgvOrderItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItem.Location = new System.Drawing.Point(6, 21);
            this.dgvOrderItem.Name = "dgvOrderItem";
            this.dgvOrderItem.ReadOnly = true;
            this.dgvOrderItem.RowHeadersWidth = 51;
            this.dgvOrderItem.RowTemplate.Height = 24;
            this.dgvOrderItem.Size = new System.Drawing.Size(281, 204);
            this.dgvOrderItem.TabIndex = 0;
            // 
            // bChangePassword
            // 
            this.bChangePassword.Location = new System.Drawing.Point(806, 180);
            this.bChangePassword.Name = "bChangePassword";
            this.bChangePassword.Size = new System.Drawing.Size(146, 32);
            this.bChangePassword.TabIndex = 4;
            this.bChangePassword.Text = "Change password";
            this.bChangePassword.UseVisualStyleBackColor = true;
            this.bChangePassword.Click += new System.EventHandler(this.bChangePassword_Click);
            // 
            // bUpdateOrder
            // 
            this.bUpdateOrder.Location = new System.Drawing.Point(887, 243);
            this.bUpdateOrder.Name = "bUpdateOrder";
            this.bUpdateOrder.Size = new System.Drawing.Size(123, 35);
            this.bUpdateOrder.TabIndex = 5;
            this.bUpdateOrder.Text = "Update order";
            this.bUpdateOrder.UseVisualStyleBackColor = true;
            this.bUpdateOrder.Click += new System.EventHandler(this.bUpdateOrder_Click);
            // 
            // bClearOrder
            // 
            this.bClearOrder.Location = new System.Drawing.Point(887, 338);
            this.bClearOrder.Name = "bClearOrder";
            this.bClearOrder.Size = new System.Drawing.Size(123, 35);
            this.bClearOrder.TabIndex = 5;
            this.bClearOrder.Text = "Clear selection";
            this.bClearOrder.UseVisualStyleBackColor = true;
            this.bClearOrder.Click += new System.EventHandler(this.bClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(287, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(509, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "COMPUTER SHOP MANAGEMENT SYSTEM";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbHelloUser
            // 
            this.lbHelloUser.AutoSize = true;
            this.lbHelloUser.Location = new System.Drawing.Point(500, 186);
            this.lbHelloUser.MaximumSize = new System.Drawing.Size(200, 0);
            this.lbHelloUser.MinimumSize = new System.Drawing.Size(300, 21);
            this.lbHelloUser.Name = "lbHelloUser";
            this.lbHelloUser.Size = new System.Drawing.Size(300, 21);
            this.lbHelloUser.TabIndex = 9;
            this.lbHelloUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1008, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // orderListBindingSource
            // 
            this.orderListBindingSource.DataSource = this.orderList;
            this.orderListBindingSource.Position = 0;
            // 
            // bCreateOrder
            // 
            this.bCreateOrder.Location = new System.Drawing.Point(717, 243);
            this.bCreateOrder.Name = "bCreateOrder";
            this.bCreateOrder.Size = new System.Drawing.Size(164, 130);
            this.bCreateOrder.TabIndex = 5;
            this.bCreateOrder.Text = "Create Order";
            this.bCreateOrder.UseVisualStyleBackColor = true;
            this.bCreateOrder.Click += new System.EventHandler(this.bCreateOrder_Click);
            // 
            // bDeleteOrder
            // 
            this.bDeleteOrder.Location = new System.Drawing.Point(887, 291);
            this.bDeleteOrder.Name = "bDeleteOrder";
            this.bDeleteOrder.Size = new System.Drawing.Size(123, 35);
            this.bDeleteOrder.TabIndex = 5;
            this.bDeleteOrder.Text = "Delete order";
            this.bDeleteOrder.UseVisualStyleBackColor = true;
            this.bDeleteOrder.Click += new System.EventHandler(this.bDeleteOrder_Click);
            // 
            // tControl
            // 
            this.tControl.Controls.Add(this.tSeller);
            this.tControl.Controls.Add(this.tManager);
            this.tControl.Controls.Add(this.tShopOwner);
            this.tControl.Location = new System.Drawing.Point(12, 200);
            this.tControl.Name = "tControl";
            this.tControl.SelectedIndex = 0;
            this.tControl.Size = new System.Drawing.Size(1024, 408);
            this.tControl.TabIndex = 11;
            // 
            // tSeller
            // 
            this.tSeller.Controls.Add(this.groupBox1);
            this.tSeller.Controls.Add(this.groupBox2);
            this.tSeller.Controls.Add(this.bCreateOrder);
            this.tSeller.Controls.Add(this.bUpdateOrder);
            this.tSeller.Controls.Add(this.bDeleteOrder);
            this.tSeller.Controls.Add(this.bClearOrder);
            this.tSeller.Location = new System.Drawing.Point(4, 25);
            this.tSeller.Name = "tSeller";
            this.tSeller.Padding = new System.Windows.Forms.Padding(3);
            this.tSeller.Size = new System.Drawing.Size(1016, 379);
            this.tSeller.TabIndex = 1;
            this.tSeller.Text = "Seller";
            this.tSeller.UseVisualStyleBackColor = true;
            // 
            // tManager
            // 
            this.tManager.Controls.Add(this.gStock);
            this.tManager.Controls.Add(this.groupBox4);
            this.tManager.Controls.Add(this.groupBox3);
            this.tManager.Location = new System.Drawing.Point(4, 25);
            this.tManager.Name = "tManager";
            this.tManager.Padding = new System.Windows.Forms.Padding(3);
            this.tManager.Size = new System.Drawing.Size(1016, 379);
            this.tManager.TabIndex = 0;
            this.tManager.Text = "Manager";
            this.tManager.UseVisualStyleBackColor = true;
            // 
            // gStock
            // 
            this.gStock.Controls.Add(this.tbProductStock);
            this.gStock.Controls.Add(this.label6);
            this.gStock.Controls.Add(this.bSetStock);
            this.gStock.Location = new System.Drawing.Point(12, 262);
            this.gStock.Name = "gStock";
            this.gStock.Size = new System.Drawing.Size(387, 111);
            this.gStock.TabIndex = 3;
            this.gStock.TabStop = false;
            this.gStock.Text = "Product Stock";
            // 
            // tbProductStock
            // 
            this.tbProductStock.Location = new System.Drawing.Point(183, 21);
            this.tbProductStock.Name = "tbProductStock";
            this.tbProductStock.Size = new System.Drawing.Size(198, 22);
            this.tbProductStock.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Product quantity";
            // 
            // bSetStock
            // 
            this.bSetStock.Location = new System.Drawing.Point(252, 49);
            this.bSetStock.Name = "bSetStock";
            this.bSetStock.Size = new System.Drawing.Size(129, 56);
            this.bSetStock.TabIndex = 2;
            this.bSetStock.Text = "Set stock";
            this.bSetStock.UseVisualStyleBackColor = true;
            this.bSetStock.Click += new System.EventHandler(this.bSetStock_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.bClearProduct);
            this.groupBox4.Controls.Add(this.bUpdateProduct);
            this.groupBox4.Controls.Add(this.bDeleteProduct);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.bCreateProduct);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.tbProductAmount);
            this.groupBox4.Controls.Add(this.tbProductWarranty);
            this.groupBox4.Controls.Add(this.tbProductName);
            this.groupBox4.Controls.Add(this.tbProductID);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(393, 250);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Product Info";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Product Amount";
            // 
            // bClearProduct
            // 
            this.bClearProduct.Location = new System.Drawing.Point(258, 199);
            this.bClearProduct.Name = "bClearProduct";
            this.bClearProduct.Size = new System.Drawing.Size(129, 45);
            this.bClearProduct.TabIndex = 2;
            this.bClearProduct.Text = "Clear Selection";
            this.bClearProduct.UseVisualStyleBackColor = true;
            this.bClearProduct.Click += new System.EventHandler(this.bClearProduct_Click);
            // 
            // bUpdateProduct
            // 
            this.bUpdateProduct.Location = new System.Drawing.Point(258, 147);
            this.bUpdateProduct.Name = "bUpdateProduct";
            this.bUpdateProduct.Size = new System.Drawing.Size(129, 46);
            this.bUpdateProduct.TabIndex = 2;
            this.bUpdateProduct.Text = "Update product";
            this.bUpdateProduct.UseVisualStyleBackColor = true;
            this.bUpdateProduct.Click += new System.EventHandler(this.bUpdateProduct_Click);
            // 
            // bDeleteProduct
            // 
            this.bDeleteProduct.Location = new System.Drawing.Point(126, 199);
            this.bDeleteProduct.Name = "bDeleteProduct";
            this.bDeleteProduct.Size = new System.Drawing.Size(126, 45);
            this.bDeleteProduct.TabIndex = 2;
            this.bDeleteProduct.Text = "Delete product";
            this.bDeleteProduct.UseVisualStyleBackColor = true;
            this.bDeleteProduct.Click += new System.EventHandler(this.bDeleteProduct_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Product Warranty (month)";
            // 
            // bCreateProduct
            // 
            this.bCreateProduct.Location = new System.Drawing.Point(126, 147);
            this.bCreateProduct.Name = "bCreateProduct";
            this.bCreateProduct.Size = new System.Drawing.Size(126, 46);
            this.bCreateProduct.TabIndex = 2;
            this.bCreateProduct.Text = "Create product";
            this.bCreateProduct.UseVisualStyleBackColor = true;
            this.bCreateProduct.Click += new System.EventHandler(this.bCreateProduct_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product ID";
            // 
            // tbProductAmount
            // 
            this.tbProductAmount.Location = new System.Drawing.Point(183, 119);
            this.tbProductAmount.Name = "tbProductAmount";
            this.tbProductAmount.Size = new System.Drawing.Size(204, 22);
            this.tbProductAmount.TabIndex = 0;
            // 
            // tbProductWarranty
            // 
            this.tbProductWarranty.Location = new System.Drawing.Point(183, 88);
            this.tbProductWarranty.Name = "tbProductWarranty";
            this.tbProductWarranty.Size = new System.Drawing.Size(204, 22);
            this.tbProductWarranty.TabIndex = 0;
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(183, 60);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(204, 22);
            this.tbProductName.TabIndex = 0;
            // 
            // tbProductID
            // 
            this.tbProductID.Location = new System.Drawing.Point(183, 32);
            this.tbProductID.Name = "tbProductID";
            this.tbProductID.Size = new System.Drawing.Size(204, 22);
            this.tbProductID.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvProduct);
            this.groupBox3.Location = new System.Drawing.Point(405, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(605, 367);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Product List";
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(6, 21);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.Size = new System.Drawing.Size(593, 340);
            this.dgvProduct.TabIndex = 1;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            // 
            // tShopOwner
            // 
            this.tShopOwner.Controls.Add(this.groupBox6);
            this.tShopOwner.Controls.Add(this.dgvAccount);
            this.tShopOwner.Controls.Add(this.groupBox5);
            this.tShopOwner.Location = new System.Drawing.Point(4, 25);
            this.tShopOwner.Name = "tShopOwner";
            this.tShopOwner.Size = new System.Drawing.Size(1016, 379);
            this.tShopOwner.TabIndex = 2;
            this.tShopOwner.Text = "Shop Owner";
            this.tShopOwner.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.bReport);
            this.groupBox6.Location = new System.Drawing.Point(3, 197);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(369, 179);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Report";
            // 
            // bReport
            // 
            this.bReport.Location = new System.Drawing.Point(96, 53);
            this.bReport.Name = "bReport";
            this.bReport.Size = new System.Drawing.Size(168, 82);
            this.bReport.TabIndex = 4;
            this.bReport.Text = "View Report";
            this.bReport.UseVisualStyleBackColor = true;
            this.bReport.Click += new System.EventHandler(this.bReport_Click);
            // 
            // dgvAccount
            // 
            this.dgvAccount.AllowUserToAddRows = false;
            this.dgvAccount.AllowUserToDeleteRows = false;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(378, 4);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.ReadOnly = true;
            this.dgvAccount.RowHeadersWidth = 51;
            this.dgvAccount.RowTemplate.Height = 24;
            this.dgvAccount.Size = new System.Drawing.Size(635, 372);
            this.dgvAccount.TabIndex = 3;
            this.dgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.bClearAccount);
            this.groupBox5.Controls.Add(this.bDeleteAccount);
            this.groupBox5.Controls.Add(this.bUpdateAccount);
            this.groupBox5.Controls.Add(this.bCreateAccount);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.cbRole);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.tbPassword);
            this.groupBox5.Controls.Add(this.tbUsername);
            this.groupBox5.Location = new System.Drawing.Point(3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(369, 186);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Account";
            // 
            // bClearAccount
            // 
            this.bClearAccount.Location = new System.Drawing.Point(281, 125);
            this.bClearAccount.Name = "bClearAccount";
            this.bClearAccount.Size = new System.Drawing.Size(81, 52);
            this.bClearAccount.TabIndex = 4;
            this.bClearAccount.Text = "Clear Selection";
            this.bClearAccount.UseVisualStyleBackColor = true;
            this.bClearAccount.Click += new System.EventHandler(this.bClearAccount_Click);
            // 
            // bDeleteAccount
            // 
            this.bDeleteAccount.Location = new System.Drawing.Point(194, 125);
            this.bDeleteAccount.Name = "bDeleteAccount";
            this.bDeleteAccount.Size = new System.Drawing.Size(81, 52);
            this.bDeleteAccount.TabIndex = 4;
            this.bDeleteAccount.Text = "Delete account";
            this.bDeleteAccount.UseVisualStyleBackColor = true;
            this.bDeleteAccount.Click += new System.EventHandler(this.bDeleteAccount_Click);
            // 
            // bUpdateAccount
            // 
            this.bUpdateAccount.Location = new System.Drawing.Point(107, 125);
            this.bUpdateAccount.Name = "bUpdateAccount";
            this.bUpdateAccount.Size = new System.Drawing.Size(81, 52);
            this.bUpdateAccount.TabIndex = 4;
            this.bUpdateAccount.Text = "Update account";
            this.bUpdateAccount.UseVisualStyleBackColor = true;
            this.bUpdateAccount.Click += new System.EventHandler(this.bUpdateAccount_Click);
            // 
            // bCreateAccount
            // 
            this.bCreateAccount.Location = new System.Drawing.Point(20, 125);
            this.bCreateAccount.Name = "bCreateAccount";
            this.bCreateAccount.Size = new System.Drawing.Size(81, 52);
            this.bCreateAccount.TabIndex = 4;
            this.bCreateAccount.Text = "Create account";
            this.bCreateAccount.UseVisualStyleBackColor = true;
            this.bCreateAccount.Click += new System.EventHandler(this.bCreateAccount_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Role";
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(112, 95);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(250, 24);
            this.cbRole.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Username";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(112, 67);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(250, 22);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(112, 39);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(250, 22);
            this.tbUsername.TabIndex = 1;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 620);
            this.Controls.Add(this.bLogout);
            this.Controls.Add(this.bChangePassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbHelloUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formMain_FormClosing);
            this.Load += new System.EventHandler(this.formMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderListBindingSource)).EndInit();
            this.tControl.ResumeLayout(false);
            this.tSeller.ResumeLayout(false);
            this.tManager.ResumeLayout(false);
            this.gStock.ResumeLayout(false);
            this.gStock.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.tShopOwner.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private orderList orderList;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private orderListTableAdapters._OrderTableAdapter _OrderTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Button bLogout;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bChangePassword;
        private System.Windows.Forms.DataGridView dgvOrderItem;
        private System.Windows.Forms.Button bUpdateOrder;
        private System.Windows.Forms.Button bClearOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbHelloUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource orderListBindingSource;
        private System.Windows.Forms.Button bCreateOrder;
        private System.Windows.Forms.Button bDeleteOrder;
        private System.Windows.Forms.TabControl tControl;
        private System.Windows.Forms.TabPage tSeller;
        private System.Windows.Forms.TabPage tManager;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabPage tShopOwner;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.GroupBox gStock;
        private System.Windows.Forms.TextBox tbProductStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bClearProduct;
        private System.Windows.Forms.Button bUpdateProduct;
        private System.Windows.Forms.Button bDeleteProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bCreateProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbProductAmount;
        private System.Windows.Forms.TextBox tbProductWarranty;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.TextBox tbProductID;
        private System.Windows.Forms.Button bSetStock;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button bCreateAccount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button bReport;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Button bClearAccount;
        private System.Windows.Forms.Button bDeleteAccount;
        private System.Windows.Forms.Button bUpdateAccount;
    }
}