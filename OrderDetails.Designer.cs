namespace Pizza_Order_Project
{
    partial class OrderDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderDetails));
            this.grpCrust = new System.Windows.Forms.GroupBox();
            this.rdbThin = new System.Windows.Forms.RadioButton();
            this.rdbThick = new System.Windows.Forms.RadioButton();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.rdbLarge = new System.Windows.Forms.RadioButton();
            this.rdbMedium = new System.Windows.Forms.RadioButton();
            this.rdbSmall = new System.Windows.Forms.RadioButton();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.chkBoxGreenPepper = new System.Windows.Forms.CheckBox();
            this.chkBoxOnion = new System.Windows.Forms.CheckBox();
            this.chkBoxOlives = new System.Windows.Forms.CheckBox();
            this.chkBoxTomatoes = new System.Windows.Forms.CheckBox();
            this.chkBoxMushrooms = new System.Windows.Forms.CheckBox();
            this.chkBoxExtraCheese = new System.Windows.Forms.CheckBox();
            this.grpPlace = new System.Windows.Forms.GroupBox();
            this.rdbTakeAway = new System.Windows.Forms.RadioButton();
            this.rdbEatIn = new System.Windows.Forms.RadioButton();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
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
            this.grpCrust.SuspendLayout();
            this.grpSize.SuspendLayout();
            this.grpToppings.SuspendLayout();
            this.grpPlace.SuspendLayout();
            this.grpOrderSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCrust
            // 
            this.grpCrust.BackColor = System.Drawing.Color.Transparent;
            this.grpCrust.Controls.Add(this.rdbThin);
            this.grpCrust.Controls.Add(this.rdbThick);
            this.grpCrust.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCrust.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grpCrust.Location = new System.Drawing.Point(136, 27);
            this.grpCrust.Name = "grpCrust";
            this.grpCrust.Size = new System.Drawing.Size(119, 145);
            this.grpCrust.TabIndex = 0;
            this.grpCrust.TabStop = false;
            this.grpCrust.Text = "Crust";
            this.grpCrust.Enter += new System.EventHandler(this.grpCrust_Enter);
            // 
            // rdbThin
            // 
            this.rdbThin.AutoSize = true;
            this.rdbThin.ForeColor = System.Drawing.Color.White;
            this.rdbThin.Location = new System.Drawing.Point(14, 34);
            this.rdbThin.Name = "rdbThin";
            this.rdbThin.Size = new System.Drawing.Size(76, 37);
            this.rdbThin.TabIndex = 3;
            this.rdbThin.Text = "Thin";
            this.rdbThin.UseVisualStyleBackColor = true;
            this.rdbThin.CheckedChanged += new System.EventHandler(this.rdbThin_CheckedChanged);
            // 
            // rdbThick
            // 
            this.rdbThick.AutoSize = true;
            this.rdbThick.ForeColor = System.Drawing.Color.White;
            this.rdbThick.Location = new System.Drawing.Point(14, 72);
            this.rdbThick.Name = "rdbThick";
            this.rdbThick.Size = new System.Drawing.Size(84, 37);
            this.rdbThick.TabIndex = 4;
            this.rdbThick.Text = "Thick";
            this.rdbThick.UseVisualStyleBackColor = true;
            this.rdbThick.CheckedChanged += new System.EventHandler(this.rdbThick_CheckedChanged);
            // 
            // grpSize
            // 
            this.grpSize.BackColor = System.Drawing.Color.Transparent;
            this.grpSize.Controls.Add(this.rdbLarge);
            this.grpSize.Controls.Add(this.rdbMedium);
            this.grpSize.Controls.Add(this.rdbSmall);
            this.grpSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpSize.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grpSize.Location = new System.Drawing.Point(11, 27);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(119, 145);
            this.grpSize.TabIndex = 1;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Size";
            this.grpSize.Enter += new System.EventHandler(this.grpSize_Enter);
            // 
            // rdbLarge
            // 
            this.rdbLarge.AutoSize = true;
            this.rdbLarge.ForeColor = System.Drawing.Color.White;
            this.rdbLarge.Location = new System.Drawing.Point(6, 102);
            this.rdbLarge.Name = "rdbLarge";
            this.rdbLarge.Size = new System.Drawing.Size(87, 37);
            this.rdbLarge.TabIndex = 2;
            this.rdbLarge.Text = "Large";
            this.rdbLarge.UseVisualStyleBackColor = true;
            this.rdbLarge.CheckedChanged += new System.EventHandler(this.rdbLarge_CheckedChanged);
            // 
            // rdbMedium
            // 
            this.rdbMedium.AutoSize = true;
            this.rdbMedium.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMedium.ForeColor = System.Drawing.Color.White;
            this.rdbMedium.Location = new System.Drawing.Point(6, 65);
            this.rdbMedium.Name = "rdbMedium";
            this.rdbMedium.Size = new System.Drawing.Size(112, 37);
            this.rdbMedium.TabIndex = 1;
            this.rdbMedium.Text = "Medium";
            this.rdbMedium.UseVisualStyleBackColor = true;
            this.rdbMedium.CheckedChanged += new System.EventHandler(this.rdbMedium_CheckedChanged);
            // 
            // rdbSmall
            // 
            this.rdbSmall.AutoSize = true;
            this.rdbSmall.ForeColor = System.Drawing.Color.White;
            this.rdbSmall.Location = new System.Drawing.Point(6, 28);
            this.rdbSmall.Name = "rdbSmall";
            this.rdbSmall.Size = new System.Drawing.Size(85, 37);
            this.rdbSmall.TabIndex = 0;
            this.rdbSmall.Text = "Small";
            this.rdbSmall.UseVisualStyleBackColor = true;
            this.rdbSmall.CheckedChanged += new System.EventHandler(this.rdbSmall_CheckedChanged);
            // 
            // grpToppings
            // 
            this.grpToppings.BackColor = System.Drawing.Color.Transparent;
            this.grpToppings.Controls.Add(this.chkBoxGreenPepper);
            this.grpToppings.Controls.Add(this.chkBoxOnion);
            this.grpToppings.Controls.Add(this.chkBoxOlives);
            this.grpToppings.Controls.Add(this.chkBoxTomatoes);
            this.grpToppings.Controls.Add(this.chkBoxMushrooms);
            this.grpToppings.Controls.Add(this.chkBoxExtraCheese);
            this.grpToppings.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpToppings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grpToppings.Location = new System.Drawing.Point(11, 172);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Size = new System.Drawing.Size(398, 120);
            this.grpToppings.TabIndex = 2;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "Toppings";
            this.grpToppings.Enter += new System.EventHandler(this.grpToppings_Enter);
            // 
            // chkBoxGreenPepper
            // 
            this.chkBoxGreenPepper.AutoSize = true;
            this.chkBoxGreenPepper.ForeColor = System.Drawing.Color.White;
            this.chkBoxGreenPepper.Location = new System.Drawing.Point(230, 81);
            this.chkBoxGreenPepper.Name = "chkBoxGreenPepper";
            this.chkBoxGreenPepper.Size = new System.Drawing.Size(175, 37);
            this.chkBoxGreenPepper.TabIndex = 5;
            this.chkBoxGreenPepper.Tag = "5";
            this.chkBoxGreenPepper.Text = "Green Peppers";
            this.chkBoxGreenPepper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBoxGreenPepper.UseVisualStyleBackColor = true;
            this.chkBoxGreenPepper.CheckedChanged += new System.EventHandler(this.chkBoxGreenPepper_CheckedChanged);
            // 
            // chkBoxOnion
            // 
            this.chkBoxOnion.AutoSize = true;
            this.chkBoxOnion.ForeColor = System.Drawing.Color.White;
            this.chkBoxOnion.Location = new System.Drawing.Point(230, 53);
            this.chkBoxOnion.Name = "chkBoxOnion";
            this.chkBoxOnion.Size = new System.Drawing.Size(91, 37);
            this.chkBoxOnion.TabIndex = 4;
            this.chkBoxOnion.Tag = "5";
            this.chkBoxOnion.Text = "Onion";
            this.chkBoxOnion.UseVisualStyleBackColor = true;
            this.chkBoxOnion.CheckedChanged += new System.EventHandler(this.chkBoxOnion_CheckedChanged);
            // 
            // chkBoxOlives
            // 
            this.chkBoxOlives.AutoSize = true;
            this.chkBoxOlives.ForeColor = System.Drawing.Color.White;
            this.chkBoxOlives.Location = new System.Drawing.Point(230, 23);
            this.chkBoxOlives.Name = "chkBoxOlives";
            this.chkBoxOlives.Size = new System.Drawing.Size(87, 37);
            this.chkBoxOlives.TabIndex = 3;
            this.chkBoxOlives.Tag = "5";
            this.chkBoxOlives.Text = "Olives";
            this.chkBoxOlives.UseVisualStyleBackColor = true;
            this.chkBoxOlives.CheckedChanged += new System.EventHandler(this.chkBoxOlives_CheckedChanged);
            // 
            // chkBoxTomatoes
            // 
            this.chkBoxTomatoes.AutoSize = true;
            this.chkBoxTomatoes.ForeColor = System.Drawing.Color.White;
            this.chkBoxTomatoes.Location = new System.Drawing.Point(38, 81);
            this.chkBoxTomatoes.Name = "chkBoxTomatoes";
            this.chkBoxTomatoes.Size = new System.Drawing.Size(126, 37);
            this.chkBoxTomatoes.TabIndex = 2;
            this.chkBoxTomatoes.Tag = "5";
            this.chkBoxTomatoes.Text = "Tomatoes";
            this.chkBoxTomatoes.UseVisualStyleBackColor = true;
            this.chkBoxTomatoes.CheckedChanged += new System.EventHandler(this.chkBoxTomatoes_CheckedChanged);
            // 
            // chkBoxMushrooms
            // 
            this.chkBoxMushrooms.AutoSize = true;
            this.chkBoxMushrooms.ForeColor = System.Drawing.Color.White;
            this.chkBoxMushrooms.Location = new System.Drawing.Point(38, 53);
            this.chkBoxMushrooms.Name = "chkBoxMushrooms";
            this.chkBoxMushrooms.Size = new System.Drawing.Size(143, 37);
            this.chkBoxMushrooms.TabIndex = 1;
            this.chkBoxMushrooms.Tag = "5";
            this.chkBoxMushrooms.Text = "Mushrooms";
            this.chkBoxMushrooms.UseVisualStyleBackColor = true;
            this.chkBoxMushrooms.CheckedChanged += new System.EventHandler(this.chkBoxMushrooms_CheckedChanged);
            // 
            // chkBoxExtraCheese
            // 
            this.chkBoxExtraCheese.AutoSize = true;
            this.chkBoxExtraCheese.ForeColor = System.Drawing.Color.White;
            this.chkBoxExtraCheese.Location = new System.Drawing.Point(38, 23);
            this.chkBoxExtraCheese.Name = "chkBoxExtraCheese";
            this.chkBoxExtraCheese.Size = new System.Drawing.Size(158, 37);
            this.chkBoxExtraCheese.TabIndex = 0;
            this.chkBoxExtraCheese.Tag = "5";
            this.chkBoxExtraCheese.Text = "Extra Cheese";
            this.chkBoxExtraCheese.UseVisualStyleBackColor = true;
            this.chkBoxExtraCheese.CheckedChanged += new System.EventHandler(this.chkBoxExtraCheese_CheckedChanged);
            // 
            // grpPlace
            // 
            this.grpPlace.BackColor = System.Drawing.Color.Transparent;
            this.grpPlace.Controls.Add(this.rdbTakeAway);
            this.grpPlace.Controls.Add(this.rdbEatIn);
            this.grpPlace.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPlace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grpPlace.Location = new System.Drawing.Point(10, 296);
            this.grpPlace.Name = "grpPlace";
            this.grpPlace.Size = new System.Drawing.Size(398, 64);
            this.grpPlace.TabIndex = 2;
            this.grpPlace.TabStop = false;
            this.grpPlace.Text = "Where To Eat ?";
            this.grpPlace.Enter += new System.EventHandler(this.grpPlace_Enter);
            // 
            // rdbTakeAway
            // 
            this.rdbTakeAway.AutoSize = true;
            this.rdbTakeAway.ForeColor = System.Drawing.Color.White;
            this.rdbTakeAway.Location = new System.Drawing.Point(230, 23);
            this.rdbTakeAway.Name = "rdbTakeAway";
            this.rdbTakeAway.Size = new System.Drawing.Size(140, 37);
            this.rdbTakeAway.TabIndex = 2;
            this.rdbTakeAway.Text = "Take Away";
            this.rdbTakeAway.UseVisualStyleBackColor = true;
            this.rdbTakeAway.CheckedChanged += new System.EventHandler(this.rdbTakeAway_CheckedChanged);
            // 
            // rdbEatIn
            // 
            this.rdbEatIn.AutoSize = true;
            this.rdbEatIn.ForeColor = System.Drawing.Color.White;
            this.rdbEatIn.Location = new System.Drawing.Point(38, 23);
            this.rdbEatIn.Name = "rdbEatIn";
            this.rdbEatIn.Size = new System.Drawing.Size(93, 37);
            this.rdbEatIn.TabIndex = 1;
            this.rdbEatIn.Text = "Eat In";
            this.rdbEatIn.UseVisualStyleBackColor = true;
            this.rdbEatIn.CheckedChanged += new System.EventHandler(this.rdbEatIn_CheckedChanged);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOrder.FlatAppearance.BorderSize = 2;
            this.btnOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.Black;
            this.btnOrder.Location = new System.Drawing.Point(17, 367);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(189, 51);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnReset.FlatAppearance.BorderSize = 2;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(212, 367);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(189, 51);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
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
            this.grpOrderSummary.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOrderSummary.ForeColor = System.Drawing.Color.Black;
            this.grpOrderSummary.Location = new System.Drawing.Point(426, 12);
            this.grpOrderSummary.Name = "grpOrderSummary";
            this.grpOrderSummary.Size = new System.Drawing.Size(372, 406);
            this.grpOrderSummary.TabIndex = 5;
            this.grpOrderSummary.TabStop = false;
            this.grpOrderSummary.Text = "Order Summary";
            this.grpOrderSummary.Enter += new System.EventHandler(this.grpOrderSummary_Enter);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblPrice.Location = new System.Drawing.Point(243, 348);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(108, 43);
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
            this.lblTotalPrice.Location = new System.Drawing.Point(243, 287);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(116, 62);
            this.lblTotalPrice.TabIndex = 8;
            this.lblTotalPrice.Text = "Price";
            this.lblTotalPrice.Click += new System.EventHandler(this.lblTotalPrice_Click);
            // 
            // lblPlaceChosen
            // 
            this.lblPlaceChosen.AutoSize = true;
            this.lblPlaceChosen.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaceChosen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblPlaceChosen.Location = new System.Drawing.Point(218, 175);
            this.lblPlaceChosen.Name = "lblPlaceChosen";
            this.lblPlaceChosen.Size = new System.Drawing.Size(40, 36);
            this.lblPlaceChosen.TabIndex = 7;
            this.lblPlaceChosen.Text = ".....";
            this.lblPlaceChosen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlaceChosen.Click += new System.EventHandler(this.lblPlaceChosen_Click);
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlace.Location = new System.Drawing.Point(217, 138);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(78, 37);
            this.lblPlace.TabIndex = 6;
            this.lblPlace.Text = "Place:";
            this.lblPlace.Click += new System.EventHandler(this.lblPlace_Click);
            // 
            // lblCrustTypeChosen
            // 
            this.lblCrustTypeChosen.AutoSize = true;
            this.lblCrustTypeChosen.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustTypeChosen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblCrustTypeChosen.Location = new System.Drawing.Point(233, 102);
            this.lblCrustTypeChosen.Name = "lblCrustTypeChosen";
            this.lblCrustTypeChosen.Size = new System.Drawing.Size(40, 36);
            this.lblCrustTypeChosen.TabIndex = 5;
            this.lblCrustTypeChosen.Text = ".....";
            this.lblCrustTypeChosen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCrustTypeChosen.Click += new System.EventHandler(this.lblCrustTypeChosen_Click);
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustType.Location = new System.Drawing.Point(185, 65);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(140, 37);
            this.lblCrustType.TabIndex = 4;
            this.lblCrustType.Text = "Crust Type:";
            this.lblCrustType.Click += new System.EventHandler(this.lblCrustType_Click);
            // 
            // lblToppingsChosen
            // 
            this.lblToppingsChosen.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppingsChosen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblToppingsChosen.Location = new System.Drawing.Point(14, 175);
            this.lblToppingsChosen.Name = "lblToppingsChosen";
            this.lblToppingsChosen.Size = new System.Drawing.Size(197, 216);
            this.lblToppingsChosen.TabIndex = 3;
            this.lblToppingsChosen.Text = ".....";
            this.lblToppingsChosen.Click += new System.EventHandler(this.lblToppingsChosen_Click);
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.Location = new System.Drawing.Point(6, 138);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(118, 37);
            this.lblToppings.TabIndex = 2;
            this.lblToppings.Text = "Toppings:";
            this.lblToppings.Click += new System.EventHandler(this.lblToppings_Click);
            // 
            // lblSizeChosen
            // 
            this.lblSizeChosen.AutoSize = true;
            this.lblSizeChosen.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSizeChosen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblSizeChosen.Location = new System.Drawing.Point(23, 102);
            this.lblSizeChosen.Name = "lblSizeChosen";
            this.lblSizeChosen.Size = new System.Drawing.Size(40, 36);
            this.lblSizeChosen.TabIndex = 1;
            this.lblSizeChosen.Text = ".....";
            this.lblSizeChosen.Click += new System.EventHandler(this.lblSizeChosen_Click);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(22, 65);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(64, 37);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Size:";
            this.lblSize.Click += new System.EventHandler(this.label1_Click);
            // 
            // OrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpOrderSummary);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.grpPlace);
            this.Controls.Add(this.grpToppings);
            this.Controls.Add(this.grpSize);
            this.Controls.Add(this.grpCrust);
            this.DoubleBuffered = true;
            this.Name = "OrderDetails";
            this.Text = "Order Details";
            this.Load += new System.EventHandler(this.OrderDetails_Load);
            this.grpCrust.ResumeLayout(false);
            this.grpCrust.PerformLayout();
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            this.grpToppings.ResumeLayout(false);
            this.grpToppings.PerformLayout();
            this.grpPlace.ResumeLayout(false);
            this.grpPlace.PerformLayout();
            this.grpOrderSummary.ResumeLayout(false);
            this.grpOrderSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox grpCrust;
        public System.Windows.Forms.GroupBox grpSize;
        public System.Windows.Forms.GroupBox grpToppings;
        public System.Windows.Forms.GroupBox grpPlace;
        private System.Windows.Forms.RadioButton rdbLarge;
        private System.Windows.Forms.RadioButton rdbMedium;
        private System.Windows.Forms.RadioButton rdbSmall;
        private System.Windows.Forms.RadioButton rdbThin;
        private System.Windows.Forms.RadioButton rdbThick;
        private System.Windows.Forms.CheckBox chkBoxGreenPepper;
        private System.Windows.Forms.CheckBox chkBoxOnion;
        private System.Windows.Forms.CheckBox chkBoxOlives;
        private System.Windows.Forms.CheckBox chkBoxTomatoes;
        private System.Windows.Forms.CheckBox chkBoxMushrooms;
        private System.Windows.Forms.CheckBox chkBoxExtraCheese;
        private System.Windows.Forms.RadioButton rdbTakeAway;
        private System.Windows.Forms.RadioButton rdbEatIn;
        public System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grpOrderSummary;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblToppingsChosen;
        private System.Windows.Forms.Label lblCrustTypeChosen;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblPlaceChosen;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Label lblSizeChosen;
    }
}