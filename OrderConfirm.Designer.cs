namespace Pizza_Order_Project
{
    partial class OrderConfirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderConfirm));
            this.grpOrderSummary = new System.Windows.Forms.GroupBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblPlaceChosen = new System.Windows.Forms.Label();
            this.lblPlace = new System.Windows.Forms.Label();
            this.lblCrustTypeChosen = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.lblToppingsChosen = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblSizeChosen = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grpOrderSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOrderSummary
            // 
            this.grpOrderSummary.BackColor = System.Drawing.Color.Transparent;
            this.grpOrderSummary.Controls.Add(this.lblPrice);
            this.grpOrderSummary.Controls.Add(this.lblTotalPrice);
            this.grpOrderSummary.Controls.Add(this.lblPlaceChosen);
            this.grpOrderSummary.Controls.Add(this.lblPlace);
            this.grpOrderSummary.Controls.Add(this.lblCrustTypeChosen);
            this.grpOrderSummary.Controls.Add(this.lblCrustType);
            this.grpOrderSummary.Controls.Add(this.lblToppingsChosen);
            this.grpOrderSummary.Controls.Add(this.lblToppings);
            this.grpOrderSummary.Controls.Add(this.lblSizeChosen);
            this.grpOrderSummary.Controls.Add(this.lblSize);
            this.grpOrderSummary.Font = new System.Drawing.Font("Papyrus", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOrderSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.grpOrderSummary.Location = new System.Drawing.Point(31, 162);
            this.grpOrderSummary.Name = "grpOrderSummary";
            this.grpOrderSummary.Size = new System.Drawing.Size(287, 333);
            this.grpOrderSummary.TabIndex = 6;
            this.grpOrderSummary.TabStop = false;
            this.grpOrderSummary.Text = "Order Summary";
            this.grpOrderSummary.Enter += new System.EventHandler(this.grpOrderSummary_Enter);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblPrice.Location = new System.Drawing.Point(126, 255);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(133, 62);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Tag = "0";
            this.lblPrice.Text = "$0.00";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPrice.Location = new System.Drawing.Point(5, 255);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(126, 62);
            this.lblTotalPrice.TabIndex = 8;
            this.lblTotalPrice.Text = "Price:";
            this.lblTotalPrice.Click += new System.EventHandler(this.lblTotalPrice_Click);
            // 
            // lblPlaceChosen
            // 
            this.lblPlaceChosen.AutoSize = true;
            this.lblPlaceChosen.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaceChosen.ForeColor = System.Drawing.Color.White;
            this.lblPlaceChosen.Location = new System.Drawing.Point(163, 129);
            this.lblPlaceChosen.Name = "lblPlaceChosen";
            this.lblPlaceChosen.Size = new System.Drawing.Size(27, 25);
            this.lblPlaceChosen.TabIndex = 7;
            this.lblPlaceChosen.Text = ".....";
            this.lblPlaceChosen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblPlace.Location = new System.Drawing.Point(163, 105);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(66, 30);
            this.lblPlace.TabIndex = 6;
            this.lblPlace.Text = "Place:";
            this.lblPlace.Click += new System.EventHandler(this.lblPlace_Click);
            // 
            // lblCrustTypeChosen
            // 
            this.lblCrustTypeChosen.AutoSize = true;
            this.lblCrustTypeChosen.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustTypeChosen.ForeColor = System.Drawing.Color.White;
            this.lblCrustTypeChosen.Location = new System.Drawing.Point(191, 75);
            this.lblCrustTypeChosen.Name = "lblCrustTypeChosen";
            this.lblCrustTypeChosen.Size = new System.Drawing.Size(27, 25);
            this.lblCrustTypeChosen.TabIndex = 5;
            this.lblCrustTypeChosen.Text = ".....";
            this.lblCrustTypeChosen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCrustTypeChosen.Click += new System.EventHandler(this.lblCrustTypeChosen_Click);
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblCrustType.Location = new System.Drawing.Point(158, 51);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(130, 30);
            this.lblCrustType.TabIndex = 4;
            this.lblCrustType.Text = "Crust Type:";
            this.lblCrustType.Click += new System.EventHandler(this.lblCrustType_Click);
            // 
            // lblToppingsChosen
            // 
            this.lblToppingsChosen.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppingsChosen.ForeColor = System.Drawing.Color.White;
            this.lblToppingsChosen.Location = new System.Drawing.Point(12, 129);
            this.lblToppingsChosen.Name = "lblToppingsChosen";
            this.lblToppingsChosen.Size = new System.Drawing.Size(145, 135);
            this.lblToppingsChosen.TabIndex = 3;
            this.lblToppingsChosen.Text = ".....";
            this.lblToppingsChosen.Click += new System.EventHandler(this.lblToppingsChosen_Click);
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblToppings.Location = new System.Drawing.Point(6, 105);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(109, 30);
            this.lblToppings.TabIndex = 2;
            this.lblToppings.Text = "Toppings:";
            this.lblToppings.Click += new System.EventHandler(this.lblToppings_Click);
            // 
            // lblSizeChosen
            // 
            this.lblSizeChosen.AutoSize = true;
            this.lblSizeChosen.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSizeChosen.ForeColor = System.Drawing.Color.White;
            this.lblSizeChosen.Location = new System.Drawing.Point(12, 75);
            this.lblSizeChosen.Name = "lblSizeChosen";
            this.lblSizeChosen.Size = new System.Drawing.Size(27, 25);
            this.lblSizeChosen.TabIndex = 1;
            this.lblSizeChosen.Text = ".....";
            this.lblSizeChosen.Click += new System.EventHandler(this.lblSizeChosen_Click);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblSize.Location = new System.Drawing.Point(6, 51);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(61, 30);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Size:";
            this.lblSize.Click += new System.EventHandler(this.lblSize_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnOrder.Location = new System.Drawing.Point(47, 475);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(113, 51);
            this.btnOrder.TabIndex = 7;
            this.btnOrder.Text = "Confirm";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(177, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 51);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OrderConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(514, 535);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.grpOrderSummary);
            this.DoubleBuffered = true;
            this.Name = "OrderConfirm";
            this.Text = "Order Confirm";
            this.Load += new System.EventHandler(this.OrderConfirm_Load);
            this.grpOrderSummary.ResumeLayout(false);
            this.grpOrderSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOrderSummary;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblPlaceChosen;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Label lblCrustTypeChosen;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label lblToppingsChosen;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblSizeChosen;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button button1;
    }
}