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
            this.bClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbHelloUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.orderListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bCreateOrder = new System.Windows.Forms.Button();
            this.bDeleteOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderListBindingSource)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(11, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 346);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order List";
            // 
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(6, 21);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.Size = new System.Drawing.Size(692, 319);
            this.dgvOrder.TabIndex = 0;
            this.dgvOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellClick);
            // 
            // bLogout
            // 
            this.bLogout.Location = new System.Drawing.Point(958, 224);
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
            this.groupBox2.Location = new System.Drawing.Point(727, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 223);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item List";
            // 
            // dgvOrderItem
            // 
            this.dgvOrderItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItem.Location = new System.Drawing.Point(6, 21);
            this.dgvOrderItem.Name = "dgvOrderItem";
            this.dgvOrderItem.RowHeadersWidth = 51;
            this.dgvOrderItem.RowTemplate.Height = 24;
            this.dgvOrderItem.Size = new System.Drawing.Size(294, 196);
            this.dgvOrderItem.TabIndex = 0;
            // 
            // bChangePassword
            // 
            this.bChangePassword.Location = new System.Drawing.Point(806, 224);
            this.bChangePassword.Name = "bChangePassword";
            this.bChangePassword.Size = new System.Drawing.Size(146, 32);
            this.bChangePassword.TabIndex = 4;
            this.bChangePassword.Text = "Change password";
            this.bChangePassword.UseVisualStyleBackColor = true;
            this.bChangePassword.Click += new System.EventHandler(this.bChangePassword_Click);
            // 
            // bUpdateOrder
            // 
            this.bUpdateOrder.Location = new System.Drawing.Point(897, 491);
            this.bUpdateOrder.Name = "bUpdateOrder";
            this.bUpdateOrder.Size = new System.Drawing.Size(136, 35);
            this.bUpdateOrder.TabIndex = 5;
            this.bUpdateOrder.Text = "Update order";
            this.bUpdateOrder.UseVisualStyleBackColor = true;
            this.bUpdateOrder.Click += new System.EventHandler(this.bUpdateOrder_Click);
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(897, 573);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(137, 35);
            this.bClear.TabIndex = 5;
            this.bClear.Text = "Clear selection";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(286, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(509, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "COMPUTER SHOP MANAGEMENT SYSTEM";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbHelloUser
            // 
            this.lbHelloUser.AutoSize = true;
            this.lbHelloUser.Location = new System.Drawing.Point(500, 230);
            this.lbHelloUser.MaximumSize = new System.Drawing.Size(200, 0);
            this.lbHelloUser.MinimumSize = new System.Drawing.Size(300, 21);
            this.lbHelloUser.Name = "lbHelloUser";
            this.lbHelloUser.Size = new System.Drawing.Size(300, 21);
            this.lbHelloUser.TabIndex = 9;
            this.lbHelloUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1022, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
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
            this.bCreateOrder.Location = new System.Drawing.Point(727, 491);
            this.bCreateOrder.Name = "bCreateOrder";
            this.bCreateOrder.Size = new System.Drawing.Size(164, 117);
            this.bCreateOrder.TabIndex = 5;
            this.bCreateOrder.Text = "Create Order";
            this.bCreateOrder.UseVisualStyleBackColor = true;
            this.bCreateOrder.Click += new System.EventHandler(this.bCreateOrder_Click);
            // 
            // bDeleteOrder
            // 
            this.bDeleteOrder.Location = new System.Drawing.Point(897, 532);
            this.bDeleteOrder.Name = "bDeleteOrder";
            this.bDeleteOrder.Size = new System.Drawing.Size(137, 35);
            this.bDeleteOrder.TabIndex = 5;
            this.bDeleteOrder.Text = "Delete order";
            this.bDeleteOrder.UseVisualStyleBackColor = true;
            this.bDeleteOrder.Click += new System.EventHandler(this.bDeleteOrder_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 620);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbHelloUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bDeleteOrder);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bCreateOrder);
            this.Controls.Add(this.bUpdateOrder);
            this.Controls.Add(this.bChangePassword);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bLogout);
            this.Controls.Add(this.groupBox1);
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
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbHelloUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource orderListBindingSource;
        private System.Windows.Forms.Button bCreateOrder;
        private System.Windows.Forms.Button bDeleteOrder;
    }
}