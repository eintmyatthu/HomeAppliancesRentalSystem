namespace Home_Appliances_Rental_System
{
    partial class RentalAppliances
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_customerView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Col_brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_dimension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_colour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_energy_consumption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_monthly_fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_appliancesId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.cmbo_type = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_search = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_orderByConsumption = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_orderByFee = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_addShopping = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dgv_shoppingCart = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_logout = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btn_remove = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customerView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_shoppingCart)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_customerView
            // 
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            this.dgv_customerView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle20;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_customerView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgv_customerView.ColumnHeadersHeight = 42;
            this.dgv_customerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_customerView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_brand,
            this.Col_type,
            this.Col_model,
            this.Col_dimension,
            this.Col_colour,
            this.Col_energy_consumption,
            this.Col_monthly_fee,
            this.Col_appliancesId});
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.OldLace;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_customerView.DefaultCellStyle = dataGridViewCellStyle29;
            this.dgv_customerView.GridColor = System.Drawing.Color.White;
            this.dgv_customerView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dgv_customerView.Location = new System.Drawing.Point(590, 91);
            this.dgv_customerView.Name = "dgv_customerView";
            this.dgv_customerView.RowHeadersVisible = false;
            this.dgv_customerView.RowHeadersWidth = 51;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dgv_customerView.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.dgv_customerView.RowTemplate.Height = 24;
            this.dgv_customerView.Size = new System.Drawing.Size(908, 349);
            this.dgv_customerView.TabIndex = 1;
            this.dgv_customerView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_customerView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_customerView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_customerView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_customerView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_customerView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_customerView.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dgv_customerView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_customerView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_customerView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_customerView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_customerView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_customerView.ThemeStyle.HeaderStyle.Height = 42;
            this.dgv_customerView.ThemeStyle.ReadOnly = false;
            this.dgv_customerView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_customerView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_customerView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_customerView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.OldLace;
            this.dgv_customerView.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_customerView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_customerView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_customerView.UseWaitCursor = true;
            // 
            // Col_brand
            // 
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Col_brand.DefaultCellStyle = dataGridViewCellStyle22;
            this.Col_brand.HeaderText = "Brand";
            this.Col_brand.MinimumWidth = 6;
            this.Col_brand.Name = "Col_brand";
            // 
            // Col_type
            // 
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Col_type.DefaultCellStyle = dataGridViewCellStyle23;
            this.Col_type.HeaderText = "Type";
            this.Col_type.MinimumWidth = 6;
            this.Col_type.Name = "Col_type";
            // 
            // Col_model
            // 
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Col_model.DefaultCellStyle = dataGridViewCellStyle24;
            this.Col_model.HeaderText = "Model";
            this.Col_model.MinimumWidth = 6;
            this.Col_model.Name = "Col_model";
            // 
            // Col_dimension
            // 
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Col_dimension.DefaultCellStyle = dataGridViewCellStyle25;
            this.Col_dimension.HeaderText = "Dimension";
            this.Col_dimension.MinimumWidth = 6;
            this.Col_dimension.Name = "Col_dimension";
            // 
            // Col_colour
            // 
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Col_colour.DefaultCellStyle = dataGridViewCellStyle26;
            this.Col_colour.HeaderText = "Colour";
            this.Col_colour.MinimumWidth = 6;
            this.Col_colour.Name = "Col_colour";
            // 
            // Col_energy_consumption
            // 
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Col_energy_consumption.DefaultCellStyle = dataGridViewCellStyle27;
            this.Col_energy_consumption.HeaderText = "Energy Consumption";
            this.Col_energy_consumption.MinimumWidth = 6;
            this.Col_energy_consumption.Name = "Col_energy_consumption";
            // 
            // Col_monthly_fee
            // 
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Col_monthly_fee.DefaultCellStyle = dataGridViewCellStyle28;
            this.Col_monthly_fee.HeaderText = "Monthly Fee";
            this.Col_monthly_fee.MinimumWidth = 6;
            this.Col_monthly_fee.Name = "Col_monthly_fee";
            // 
            // Col_appliancesId
            // 
            this.Col_appliancesId.HeaderText = "Appliances ID";
            this.Col_appliancesId.MinimumWidth = 6;
            this.Col_appliancesId.Name = "Col_appliancesId";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // cmbo_type
            // 
            this.cmbo_type.AutoRoundedCorners = true;
            this.cmbo_type.BackColor = System.Drawing.Color.Transparent;
            this.cmbo_type.BorderColor = System.Drawing.Color.NavajoWhite;
            this.cmbo_type.BorderRadius = 17;
            this.cmbo_type.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.cmbo_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbo_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbo_type.FillColor = System.Drawing.Color.MistyRose;
            this.cmbo_type.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbo_type.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbo_type.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbo_type.ForeColor = System.Drawing.Color.MediumOrchid;
            this.cmbo_type.IntegralHeight = false;
            this.cmbo_type.ItemHeight = 30;
            this.cmbo_type.Items.AddRange(new object[] {
            "Smart TV",
            "Refrigerator",
            "Washing Machine",
            "Dishwasher",
            "Microwave"});
            this.cmbo_type.Location = new System.Drawing.Point(12, 108);
            this.cmbo_type.Name = "cmbo_type";
            this.cmbo_type.Size = new System.Drawing.Size(341, 36);
            this.cmbo_type.TabIndex = 28;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Verdana", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(421, 12);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(797, 44);
            this.guna2HtmlLabel3.TabIndex = 29;
            this.guna2HtmlLabel3.Text = "Welcome From Home Appliances Rental!";
            this.guna2HtmlLabel3.Click += new System.EventHandler(this.guna2HtmlLabel3_Click);
            // 
            // btn_search
            // 
            this.btn_search.Animated = true;
            this.btn_search.AutoRoundedCorners = true;
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.BorderRadius = 34;
            this.btn_search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_search.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_search.ForeColor = System.Drawing.Color.LightYellow;
            this.btn_search.IndicateFocus = true;
            this.btn_search.Location = new System.Drawing.Point(386, 91);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(185, 71);
            this.btn_search.TabIndex = 31;
            this.btn_search.Text = "Search";
            this.btn_search.UseTransparentBackground = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_orderByConsumption
            // 
            this.btn_orderByConsumption.Animated = true;
            this.btn_orderByConsumption.AutoRoundedCorners = true;
            this.btn_orderByConsumption.BackColor = System.Drawing.Color.Transparent;
            this.btn_orderByConsumption.BorderRadius = 34;
            this.btn_orderByConsumption.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_orderByConsumption.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_orderByConsumption.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_orderByConsumption.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_orderByConsumption.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_orderByConsumption.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_orderByConsumption.ForeColor = System.Drawing.Color.LightYellow;
            this.btn_orderByConsumption.IndicateFocus = true;
            this.btn_orderByConsumption.Location = new System.Drawing.Point(1227, 498);
            this.btn_orderByConsumption.Name = "btn_orderByConsumption";
            this.btn_orderByConsumption.Size = new System.Drawing.Size(185, 71);
            this.btn_orderByConsumption.TabIndex = 34;
            this.btn_orderByConsumption.Text = "Sort by Consumption";
            this.btn_orderByConsumption.UseTransparentBackground = true;
            this.btn_orderByConsumption.Click += new System.EventHandler(this.btn_orderByConsumption_Click);
            // 
            // btn_orderByFee
            // 
            this.btn_orderByFee.Animated = true;
            this.btn_orderByFee.AutoRoundedCorners = true;
            this.btn_orderByFee.BackColor = System.Drawing.Color.Transparent;
            this.btn_orderByFee.BorderRadius = 34;
            this.btn_orderByFee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_orderByFee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_orderByFee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_orderByFee.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_orderByFee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_orderByFee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_orderByFee.ForeColor = System.Drawing.Color.LightYellow;
            this.btn_orderByFee.IndicateFocus = true;
            this.btn_orderByFee.Location = new System.Drawing.Point(789, 498);
            this.btn_orderByFee.Name = "btn_orderByFee";
            this.btn_orderByFee.Size = new System.Drawing.Size(185, 71);
            this.btn_orderByFee.TabIndex = 35;
            this.btn_orderByFee.Text = "Sort by Monthly Fee";
            this.btn_orderByFee.UseTransparentBackground = true;
            this.btn_orderByFee.Click += new System.EventHandler(this.btn_orderByFee_Click);
            // 
            // btn_addShopping
            // 
            this.btn_addShopping.Animated = true;
            this.btn_addShopping.AutoRoundedCorners = true;
            this.btn_addShopping.BackColor = System.Drawing.Color.Transparent;
            this.btn_addShopping.BorderRadius = 33;
            this.btn_addShopping.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_addShopping.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_addShopping.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_addShopping.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_addShopping.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_addShopping.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_addShopping.ForeColor = System.Drawing.Color.LightYellow;
            this.btn_addShopping.IndicateFocus = true;
            this.btn_addShopping.Location = new System.Drawing.Point(15, 279);
            this.btn_addShopping.Name = "btn_addShopping";
            this.btn_addShopping.Size = new System.Drawing.Size(299, 68);
            this.btn_addShopping.TabIndex = 36;
            this.btn_addShopping.Text = "Add to Shopping Cart";
            this.btn_addShopping.UseTransparentBackground = true;
            this.btn_addShopping.Click += new System.EventHandler(this.btn_addShopping_Click);
            // 
            // dgv_shoppingCart
            // 
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.White;
            this.dgv_shoppingCart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_shoppingCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.dgv_shoppingCart.ColumnHeadersHeight = 42;
            this.dgv_shoppingCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_shoppingCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn7,
            this.Col_quantity,
            this.Col_total});
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_shoppingCart.DefaultCellStyle = dataGridViewCellStyle37;
            this.dgv_shoppingCart.GridColor = System.Drawing.Color.White;
            this.dgv_shoppingCart.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dgv_shoppingCart.Location = new System.Drawing.Point(15, 54);
            this.dgv_shoppingCart.Name = "dgv_shoppingCart";
            this.dgv_shoppingCart.RowHeadersVisible = false;
            this.dgv_shoppingCart.RowHeadersWidth = 51;
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dgv_shoppingCart.RowsDefaultCellStyle = dataGridViewCellStyle38;
            this.dgv_shoppingCart.RowTemplate.Height = 24;
            this.dgv_shoppingCart.Size = new System.Drawing.Size(521, 180);
            this.dgv_shoppingCart.TabIndex = 37;
            this.dgv_shoppingCart.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_shoppingCart.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_shoppingCart.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_shoppingCart.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_shoppingCart.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_shoppingCart.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_shoppingCart.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dgv_shoppingCart.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_shoppingCart.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_shoppingCart.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_shoppingCart.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_shoppingCart.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_shoppingCart.ThemeStyle.HeaderStyle.Height = 42;
            this.dgv_shoppingCart.ThemeStyle.ReadOnly = false;
            this.dgv_shoppingCart.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_shoppingCart.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_shoppingCart.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_shoppingCart.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.OldLace;
            this.dgv_shoppingCart.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_shoppingCart.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_shoppingCart.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_shoppingCart.UseWaitCursor = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle33;
            this.dataGridViewTextBoxColumn1.HeaderText = "Brand";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle34;
            this.dataGridViewTextBoxColumn2.HeaderText = "Type";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle35;
            this.dataGridViewTextBoxColumn3.HeaderText = "Model";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle36;
            this.dataGridViewTextBoxColumn7.HeaderText = "Monthly Fee";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // Col_quantity
            // 
            this.Col_quantity.HeaderText = "Quantity";
            this.Col_quantity.MinimumWidth = 6;
            this.Col_quantity.Name = "Col_quantity";
            // 
            // Col_total
            // 
            this.Col_total.HeaderText = "Total";
            this.Col_total.MinimumWidth = 6;
            this.Col_total.Name = "Col_total";
            // 
            // btn_logout
            // 
            this.btn_logout.Animated = true;
            this.btn_logout.AutoRoundedCorners = true;
            this.btn_logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_logout.BorderRadius = 27;
            this.btn_logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_logout.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_logout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_logout.ForeColor = System.Drawing.Color.LightYellow;
            this.btn_logout.IndicateFocus = true;
            this.btn_logout.Location = new System.Drawing.Point(1321, 12);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(121, 56);
            this.btn_logout.TabIndex = 38;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseTransparentBackground = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.btn_remove);
            this.guna2GroupBox1.Controls.Add(this.dgv_shoppingCart);
            this.guna2GroupBox1.Controls.Add(this.btn_addShopping);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 251);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(559, 350);
            this.guna2GroupBox1.TabIndex = 40;
            this.guna2GroupBox1.Text = "Shopping Lists View";
            // 
            // btn_remove
            // 
            this.btn_remove.Animated = true;
            this.btn_remove.AutoRoundedCorners = true;
            this.btn_remove.BackColor = System.Drawing.Color.Transparent;
            this.btn_remove.BorderRadius = 33;
            this.btn_remove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_remove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_remove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_remove.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_remove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_remove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_remove.ForeColor = System.Drawing.Color.LightYellow;
            this.btn_remove.IndicateFocus = true;
            this.btn_remove.Location = new System.Drawing.Point(368, 279);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(148, 68);
            this.btn_remove.TabIndex = 38;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseTransparentBackground = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // RentalAppliances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1507, 615);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_orderByFee);
            this.Controls.Add(this.btn_orderByConsumption);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.cmbo_type);
            this.Controls.Add(this.dgv_customerView);
            this.ForeColor = System.Drawing.Color.OldLace;
            this.Name = "RentalAppliances";
            this.Text = "RentalAppliances";
            this.Load += new System.EventHandler(this.RentalAppliances_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customerView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_shoppingCart)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgv_customerView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_dimension;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_colour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_energy_consumption;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_monthly_fee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_appliancesId;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbo_type;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2GradientButton btn_search;
        private Guna.UI2.WinForms.Guna2GradientButton btn_orderByConsumption;
        private Guna.UI2.WinForms.Guna2GradientButton btn_orderByFee;
        private Guna.UI2.WinForms.Guna2GradientButton btn_addShopping;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_shoppingCart;
        private Guna.UI2.WinForms.Guna2GradientButton btn_logout;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_remove;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_total;
    }
}