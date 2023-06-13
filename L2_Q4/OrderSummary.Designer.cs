namespace L2_Q4
{
    partial class OrderSummary
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblSides = new System.Windows.Forms.Label();
            this.cbSides = new System.Windows.Forms.ComboBox();
            this.btnAddSide = new System.Windows.Forms.Button();
            this.lblSummary = new System.Windows.Forms.Label();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReview = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(70, 63);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 32);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name: ";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(57, 137);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(103, 32);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(259, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(340, 39);
            this.txtName.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(259, 149);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(340, 39);
            this.txtAddress.TabIndex = 3;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCreate.Location = new System.Drawing.Point(733, 87);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(222, 66);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "CREATE PIZZA!";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblSides
            // 
            this.lblSides.AutoSize = true;
            this.lblSides.Location = new System.Drawing.Point(85, 315);
            this.lblSides.Name = "lblSides";
            this.lblSides.Size = new System.Drawing.Size(75, 32);
            this.lblSides.TabIndex = 5;
            this.lblSides.Text = "Sides:";
            // 
            // cbSides
            // 
            this.cbSides.FormattingEnabled = true;
            this.cbSides.Items.AddRange(new object[] {
            "Chicken Nuggets",
            "Garlic Bread",
            "Potato Wedges",
            "Dough Balls",
            "Chicken Strippers",
            "BBQ Wings"});
            this.cbSides.Location = new System.Drawing.Point(259, 315);
            this.cbSides.Name = "cbSides";
            this.cbSides.Size = new System.Drawing.Size(340, 40);
            this.cbSides.TabIndex = 6;
            // 
            // btnAddSide
            // 
            this.btnAddSide.Location = new System.Drawing.Point(733, 315);
            this.btnAddSide.Name = "btnAddSide";
            this.btnAddSide.Size = new System.Drawing.Size(150, 46);
            this.btnAddSide.TabIndex = 7;
            this.btnAddSide.Text = "ADD SIDE";
            this.btnAddSide.UseVisualStyleBackColor = true;
            this.btnAddSide.Click += new System.EventHandler(this.btnAddSide_Click);
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Location = new System.Drawing.Point(330, 461);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(188, 32);
            this.lblSummary.TabIndex = 8;
            this.lblSummary.Text = "Order Summary:";
            // 
            // txtSummary
            // 
            this.txtSummary.BackColor = System.Drawing.SystemColors.Window;
            this.txtSummary.Location = new System.Drawing.Point(57, 496);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.ReadOnly = true;
            this.txtSummary.Size = new System.Drawing.Size(745, 540);
            this.txtSummary.TabIndex = 9;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(880, 535);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(213, 56);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "CLEAR ALL";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnReview
            // 
            this.btnReview.Location = new System.Drawing.Point(855, 705);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(262, 108);
            this.btnReview.TabIndex = 11;
            this.btnReview.Text = "REVIEW ORDER DETAILS";
            this.btnReview.UseVisualStyleBackColor = true;
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(880, 917);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(213, 51);
            this.btnPlaceOrder.TabIndex = 11;
            this.btnPlaceOrder.Text = "PLACE ORDER";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // OrderSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1173, 1048);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnReview);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.btnAddSide);
            this.Controls.Add(this.cbSides);
            this.Controls.Add(this.lblSides);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Name = "OrderSummary";
            this.Text = "Order Summary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblSides;
        private System.Windows.Forms.ComboBox cbSides;
        private System.Windows.Forms.Button btnAddSide;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.TextBox txtSummary;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReview;
        private System.Windows.Forms.Button btnPlaceOrder;
    }
}

