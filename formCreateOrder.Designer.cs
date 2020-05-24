namespace CNPM_Project
{
    partial class formCreateOrder
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
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.tbCustomerEmail = new System.Windows.Forms.TextBox();
            this.tbCustomerPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvItemList = new System.Windows.Forms.DataGridView();
            this.lbProductID = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.bUpdateOrderItem = new System.Windows.Forms.Button();
            this.tbProductID = new System.Windows.Forms.TextBox();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.lbProductName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bCreateOrder = new System.Windows.Forms.Button();
            this.bCancelOrder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTotalAmount = new System.Windows.Forms.Label();
            this.product_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDeleteOrderItem = new System.Windows.Forms.Button();
            this.bCreateOrderItem = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(116, 24);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(366, 22);
            this.tbCustomerName.TabIndex = 0;
            // 
            // tbCustomerEmail
            // 
            this.tbCustomerEmail.Location = new System.Drawing.Point(116, 52);
            this.tbCustomerEmail.Name = "tbCustomerEmail";
            this.tbCustomerEmail.Size = new System.Drawing.Size(366, 22);
            this.tbCustomerEmail.TabIndex = 0;
            // 
            // tbCustomerPhone
            // 
            this.tbCustomerPhone.Location = new System.Drawing.Point(116, 80);
            this.tbCustomerPhone.Name = "tbCustomerPhone";
            this.tbCustomerPhone.Size = new System.Drawing.Size(366, 22);
            this.tbCustomerPhone.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Phone Number";
            // 
            // dgvItemList
            // 
            this.dgvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_ID,
            this.product_name,
            this.quantity,
            this.amount});
            this.dgvItemList.Location = new System.Drawing.Point(6, 86);
            this.dgvItemList.Name = "dgvItemList";
            this.dgvItemList.ReadOnly = true;
            this.dgvItemList.RowHeadersWidth = 51;
            this.dgvItemList.RowTemplate.Height = 24;
            this.dgvItemList.Size = new System.Drawing.Size(482, 147);
            this.dgvItemList.TabIndex = 2;
            this.dgvItemList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemList_CellClick);
            // 
            // lbProductID
            // 
            this.lbProductID.AutoSize = true;
            this.lbProductID.Location = new System.Drawing.Point(7, 32);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(74, 17);
            this.lbProductID.TabIndex = 1;
            this.lbProductID.Text = "Product ID";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(344, 32);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(61, 17);
            this.lbQuantity.TabIndex = 1;
            this.lbQuantity.Text = "Quantity";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(411, 29);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(77, 22);
            this.tbQuantity.TabIndex = 3;
            // 
            // bUpdateOrderItem
            // 
            this.bUpdateOrderItem.Location = new System.Drawing.Point(494, 86);
            this.bUpdateOrderItem.Name = "bUpdateOrderItem";
            this.bUpdateOrderItem.Size = new System.Drawing.Size(143, 45);
            this.bUpdateOrderItem.TabIndex = 4;
            this.bUpdateOrderItem.Text = "Update item from the order";
            this.bUpdateOrderItem.UseVisualStyleBackColor = true;
            this.bUpdateOrderItem.Click += new System.EventHandler(this.bUpdateOrderItem_Click);
            // 
            // tbProductID
            // 
            this.tbProductID.Location = new System.Drawing.Point(109, 29);
            this.tbProductID.Name = "tbProductID";
            this.tbProductID.Size = new System.Drawing.Size(216, 22);
            this.tbProductID.TabIndex = 3;
            this.tbProductID.TextChanged += new System.EventHandler(this.tbProductID_TextChanged);
            // 
            // tbProductName
            // 
            this.tbProductName.Enabled = false;
            this.tbProductName.Location = new System.Drawing.Point(109, 58);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(379, 22);
            this.tbProductName.TabIndex = 3;
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(7, 61);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(96, 17);
            this.lbProductName.TabIndex = 1;
            this.lbProductName.Text = "Product name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bClear);
            this.groupBox1.Controls.Add(this.bDeleteOrderItem);
            this.groupBox1.Controls.Add(this.bCreateOrderItem);
            this.groupBox1.Controls.Add(this.bUpdateOrderItem);
            this.groupBox1.Controls.Add(this.tbProductName);
            this.groupBox1.Controls.Add(this.tbProductID);
            this.groupBox1.Controls.Add(this.tbQuantity);
            this.groupBox1.Controls.Add(this.dgvItemList);
            this.groupBox1.Controls.Add(this.lbQuantity);
            this.groupBox1.Controls.Add(this.lbProductName);
            this.groupBox1.Controls.Add(this.lbProductID);
            this.groupBox1.Location = new System.Drawing.Point(12, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 241);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Item";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbCustomerPhone);
            this.groupBox2.Controls.Add(this.tbCustomerEmail);
            this.groupBox2.Controls.Add(this.tbCustomerName);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 112);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer info";
            // 
            // bCreateOrder
            // 
            this.bCreateOrder.Location = new System.Drawing.Point(506, 12);
            this.bCreateOrder.Name = "bCreateOrder";
            this.bCreateOrder.Size = new System.Drawing.Size(143, 67);
            this.bCreateOrder.TabIndex = 7;
            this.bCreateOrder.Text = "Create Order";
            this.bCreateOrder.UseVisualStyleBackColor = true;
            this.bCreateOrder.Click += new System.EventHandler(this.bCreateOrder_Click);
            // 
            // bCancelOrder
            // 
            this.bCancelOrder.Location = new System.Drawing.Point(506, 85);
            this.bCancelOrder.Name = "bCancelOrder";
            this.bCancelOrder.Size = new System.Drawing.Size(143, 39);
            this.bCancelOrder.TabIndex = 7;
            this.bCancelOrder.Text = "Cancel";
            this.bCancelOrder.UseVisualStyleBackColor = true;
            this.bCancelOrder.Click += new System.EventHandler(this.bCancelOrder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(564, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total amount";
            // 
            // lbTotalAmount
            // 
            this.lbTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalAmount.Location = new System.Drawing.Point(355, 399);
            this.lbTotalAmount.MinimumSize = new System.Drawing.Size(300, 40);
            this.lbTotalAmount.Name = "lbTotalAmount";
            this.lbTotalAmount.Size = new System.Drawing.Size(300, 40);
            this.lbTotalAmount.TabIndex = 8;
            this.lbTotalAmount.Text = "0";
            this.lbTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbTotalAmount.UseMnemonic = false;
            // 
            // product_ID
            // 
            this.product_ID.HeaderText = "Product ID";
            this.product_ID.MinimumWidth = 6;
            this.product_ID.Name = "product_ID";
            this.product_ID.ReadOnly = true;
            this.product_ID.Width = 125;
            // 
            // product_name
            // 
            this.product_name.HeaderText = "Product name";
            this.product_name.MinimumWidth = 6;
            this.product_name.Name = "product_name";
            this.product_name.ReadOnly = true;
            this.product_name.Width = 125;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 125;
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.Width = 125;
            // 
            // bDeleteOrderItem
            // 
            this.bDeleteOrderItem.Location = new System.Drawing.Point(494, 137);
            this.bDeleteOrderItem.Name = "bDeleteOrderItem";
            this.bDeleteOrderItem.Size = new System.Drawing.Size(143, 44);
            this.bDeleteOrderItem.TabIndex = 4;
            this.bDeleteOrderItem.Text = "Delete item from the order";
            this.bDeleteOrderItem.UseVisualStyleBackColor = true;
            this.bDeleteOrderItem.Click += new System.EventHandler(this.bDeleteOrderItem_Click);
            // 
            // bCreateOrderItem
            // 
            this.bCreateOrderItem.Location = new System.Drawing.Point(494, 29);
            this.bCreateOrderItem.Name = "bCreateOrderItem";
            this.bCreateOrderItem.Size = new System.Drawing.Size(143, 51);
            this.bCreateOrderItem.TabIndex = 4;
            this.bCreateOrderItem.Text = "Add item to the order";
            this.bCreateOrderItem.UseVisualStyleBackColor = true;
            this.bCreateOrderItem.Click += new System.EventHandler(this.bCreateOrderItem_Click);
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(494, 187);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(143, 44);
            this.bClear.TabIndex = 4;
            this.bClear.Text = "Clear selection";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // formCreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 448);
            this.Controls.Add(this.lbTotalAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bCancelOrder);
            this.Controls.Add(this.bCreateOrder);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formCreateOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create order";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formCreateOrder_FormClosed);
            this.Load += new System.EventHandler(this.formCreateOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.TextBox tbCustomerEmail;
        private System.Windows.Forms.TextBox tbCustomerPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvItemList;
        private System.Windows.Forms.Label lbProductID;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Button bUpdateOrderItem;
        private System.Windows.Forms.TextBox tbProductID;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bCreateOrder;
        private System.Windows.Forms.Button bCancelOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.Button bDeleteOrderItem;
        private System.Windows.Forms.Button bCreateOrderItem;
        private System.Windows.Forms.Button bClear;
    }
}