namespace CNPM_Project
{
    partial class formReport
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTotalRevenue = new System.Windows.Forms.Label();
            this.lbOrderAmount = new System.Windows.Forms.Label();
            this.lbTotalSoldProducts = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbTotalSoldProducts);
            this.groupBox1.Controls.Add(this.lbOrderAmount);
            this.groupBox1.Controls.Add(this.lbTotalRevenue);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 225);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Revenue";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total revenue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total sold products";
            // 
            // lbTotalRevenue
            // 
            this.lbTotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalRevenue.Location = new System.Drawing.Point(9, 35);
            this.lbTotalRevenue.MinimumSize = new System.Drawing.Size(200, 30);
            this.lbTotalRevenue.Name = "lbTotalRevenue";
            this.lbTotalRevenue.Size = new System.Drawing.Size(338, 43);
            this.lbTotalRevenue.TabIndex = 1;
            this.lbTotalRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbOrderAmount
            // 
            this.lbOrderAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderAmount.Location = new System.Drawing.Point(9, 116);
            this.lbOrderAmount.Name = "lbOrderAmount";
            this.lbOrderAmount.Size = new System.Drawing.Size(126, 43);
            this.lbOrderAmount.TabIndex = 1;
            this.lbOrderAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTotalSoldProducts
            // 
            this.lbTotalSoldProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalSoldProducts.Location = new System.Drawing.Point(204, 116);
            this.lbTotalSoldProducts.Name = "lbTotalSoldProducts";
            this.lbTotalSoldProducts.Size = new System.Drawing.Size(143, 43);
            this.lbTotalSoldProducts.TabIndex = 1;
            this.lbTotalSoldProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // formReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 251);
            this.Controls.Add(this.groupBox1);
            this.Name = "formReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.formReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbTotalSoldProducts;
        private System.Windows.Forms.Label lbOrderAmount;
        private System.Windows.Forms.Label lbTotalRevenue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}