namespace Home_Appliances_Rental_System
{
    partial class AdminViewAppliances
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.mySqlDataAdapter2 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.dgv_table = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Col_brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_dimension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_colour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_energy_consumption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_monthly_fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_appliancesId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_add = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_update = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_delete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_refresh = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txt_brand = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_type = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_model = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_dimension = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_colour = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_energyConsumption = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_monthlyFee = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_appliancesId = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_logout = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).BeginInit();
            this.SuspendLayout();
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // mySqlDataAdapter2
            // 
            this.mySqlDataAdapter2.DeleteCommand = null;
            this.mySqlDataAdapter2.InsertCommand = null;
            this.mySqlDataAdapter2.SelectCommand = null;
            this.mySqlDataAdapter2.UpdateCommand = null;
            // 
            // dgv_table
            // 
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            this.dgv_table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_table.ColumnHeadersHeight = 42;
            this.dgv_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_brand,
            this.Col_type,
            this.Col_model,
            this.Col_dimension,
            this.Col_colour,
            this.Col_energy_consumption,
            this.Col_monthly_fee,
            this.Col_appliancesId});
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.OldLace;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_table.DefaultCellStyle = dataGridViewCellStyle21;
            this.dgv_table.GridColor = System.Drawing.Color.White;
            this.dgv_table.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dgv_table.Location = new System.Drawing.Point(457, 93);
            this.dgv_table.Name = "dgv_table";
            this.dgv_table.RowHeadersVisible = false;
            this.dgv_table.RowHeadersWidth = 51;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dgv_table.RowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dgv_table.RowTemplate.Height = 24;
            this.dgv_table.Size = new System.Drawing.Size(996, 341);
            this.dgv_table.TabIndex = 0;
            this.dgv_table.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_table.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_table.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_table.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_table.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_table.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_table.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dgv_table.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_table.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_table.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_table.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_table.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_table.ThemeStyle.HeaderStyle.Height = 42;
            this.dgv_table.ThemeStyle.ReadOnly = false;
            this.dgv_table.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_table.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_table.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_table.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.OldLace;
            this.dgv_table.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_table.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_table.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_table.UseWaitCursor = true;
            this.dgv_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_table_CellContentClick);
            // 
            // Col_brand
            // 
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Col_brand.DefaultCellStyle = dataGridViewCellStyle14;
            this.Col_brand.HeaderText = "Brand";
            this.Col_brand.MinimumWidth = 6;
            this.Col_brand.Name = "Col_brand";
            // 
            // Col_type
            // 
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Col_type.DefaultCellStyle = dataGridViewCellStyle15;
            this.Col_type.HeaderText = "Type";
            this.Col_type.MinimumWidth = 6;
            this.Col_type.Name = "Col_type";
            // 
            // Col_model
            // 
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Col_model.DefaultCellStyle = dataGridViewCellStyle16;
            this.Col_model.HeaderText = "Model";
            this.Col_model.MinimumWidth = 6;
            this.Col_model.Name = "Col_model";
            // 
            // Col_dimension
            // 
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Col_dimension.DefaultCellStyle = dataGridViewCellStyle17;
            this.Col_dimension.HeaderText = "Dimension";
            this.Col_dimension.MinimumWidth = 6;
            this.Col_dimension.Name = "Col_dimension";
            // 
            // Col_colour
            // 
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Col_colour.DefaultCellStyle = dataGridViewCellStyle18;
            this.Col_colour.HeaderText = "Colour";
            this.Col_colour.MinimumWidth = 6;
            this.Col_colour.Name = "Col_colour";
            // 
            // Col_energy_consumption
            // 
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Col_energy_consumption.DefaultCellStyle = dataGridViewCellStyle19;
            this.Col_energy_consumption.HeaderText = "Energy Consumption";
            this.Col_energy_consumption.MinimumWidth = 6;
            this.Col_energy_consumption.Name = "Col_energy_consumption";
            // 
            // Col_monthly_fee
            // 
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Col_monthly_fee.DefaultCellStyle = dataGridViewCellStyle20;
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
            // btn_add
            // 
            this.btn_add.Animated = true;
            this.btn_add.AutoRoundedCorners = true;
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.BorderRadius = 36;
            this.btn_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add.ForeColor = System.Drawing.Color.LightYellow;
            this.btn_add.IndicateFocus = true;
            this.btn_add.Location = new System.Drawing.Point(506, 462);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(120, 75);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "Add";
            this.btn_add.UseTransparentBackground = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Animated = true;
            this.btn_update.AutoRoundedCorners = true;
            this.btn_update.BackColor = System.Drawing.Color.Transparent;
            this.btn_update.BorderRadius = 36;
            this.btn_update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_update.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_update.ForeColor = System.Drawing.Color.LightYellow;
            this.btn_update.IndicateFocus = true;
            this.btn_update.Location = new System.Drawing.Point(691, 462);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(129, 75);
            this.btn_update.TabIndex = 14;
            this.btn_update.Text = "Update";
            this.btn_update.UseTransparentBackground = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Animated = true;
            this.btn_delete.AutoRoundedCorners = true;
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.BorderRadius = 36;
            this.btn_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_delete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_delete.ForeColor = System.Drawing.Color.LightYellow;
            this.btn_delete.IndicateFocus = true;
            this.btn_delete.Location = new System.Drawing.Point(914, 462);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(129, 75);
            this.btn_delete.TabIndex = 15;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseTransparentBackground = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Animated = true;
            this.btn_refresh.AutoRoundedCorners = true;
            this.btn_refresh.BackColor = System.Drawing.Color.Transparent;
            this.btn_refresh.BorderRadius = 36;
            this.btn_refresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_refresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_refresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_refresh.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_refresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_refresh.ForeColor = System.Drawing.Color.LightYellow;
            this.btn_refresh.IndicateFocus = true;
            this.btn_refresh.Location = new System.Drawing.Point(1126, 462);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(133, 75);
            this.btn_refresh.TabIndex = 16;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseTransparentBackground = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // txt_brand
            // 
            this.txt_brand.Animated = true;
            this.txt_brand.AutoRoundedCorners = true;
            this.txt_brand.BorderColor = System.Drawing.Color.NavajoWhite;
            this.txt_brand.BorderRadius = 14;
            this.txt_brand.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txt_brand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_brand.DefaultText = "";
            this.txt_brand.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_brand.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_brand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_brand.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_brand.FillColor = System.Drawing.Color.MistyRose;
            this.txt_brand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_brand.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_brand.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_brand.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_brand.Location = new System.Drawing.Point(246, 79);
            this.txt_brand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_brand.Name = "txt_brand";
            this.txt_brand.PasswordChar = '\0';
            this.txt_brand.PlaceholderText = "Brand";
            this.txt_brand.SelectedText = "";
            this.txt_brand.Size = new System.Drawing.Size(180, 31);
            this.txt_brand.TabIndex = 17;
            // 
            // txt_type
            // 
            this.txt_type.Animated = true;
            this.txt_type.AutoRoundedCorners = true;
            this.txt_type.BorderColor = System.Drawing.Color.NavajoWhite;
            this.txt_type.BorderRadius = 14;
            this.txt_type.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txt_type.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_type.DefaultText = "";
            this.txt_type.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_type.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_type.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_type.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_type.FillColor = System.Drawing.Color.MistyRose;
            this.txt_type.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_type.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_type.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_type.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_type.Location = new System.Drawing.Point(246, 136);
            this.txt_type.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_type.Name = "txt_type";
            this.txt_type.PasswordChar = '\0';
            this.txt_type.PlaceholderText = "Type";
            this.txt_type.SelectedText = "";
            this.txt_type.Size = new System.Drawing.Size(180, 31);
            this.txt_type.TabIndex = 18;
            // 
            // txt_model
            // 
            this.txt_model.Animated = true;
            this.txt_model.AutoRoundedCorners = true;
            this.txt_model.BorderColor = System.Drawing.Color.NavajoWhite;
            this.txt_model.BorderRadius = 14;
            this.txt_model.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txt_model.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_model.DefaultText = "";
            this.txt_model.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_model.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_model.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_model.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_model.FillColor = System.Drawing.Color.MistyRose;
            this.txt_model.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_model.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_model.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_model.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_model.Location = new System.Drawing.Point(246, 188);
            this.txt_model.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_model.Name = "txt_model";
            this.txt_model.PasswordChar = '\0';
            this.txt_model.PlaceholderText = "Model";
            this.txt_model.SelectedText = "";
            this.txt_model.Size = new System.Drawing.Size(180, 31);
            this.txt_model.TabIndex = 19;
            // 
            // txt_dimension
            // 
            this.txt_dimension.Animated = true;
            this.txt_dimension.AutoRoundedCorners = true;
            this.txt_dimension.BorderColor = System.Drawing.Color.NavajoWhite;
            this.txt_dimension.BorderRadius = 14;
            this.txt_dimension.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txt_dimension.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_dimension.DefaultText = "";
            this.txt_dimension.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_dimension.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_dimension.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_dimension.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_dimension.FillColor = System.Drawing.Color.MistyRose;
            this.txt_dimension.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_dimension.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_dimension.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_dimension.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_dimension.Location = new System.Drawing.Point(246, 246);
            this.txt_dimension.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_dimension.Name = "txt_dimension";
            this.txt_dimension.PasswordChar = '\0';
            this.txt_dimension.PlaceholderText = "Dimension";
            this.txt_dimension.SelectedText = "";
            this.txt_dimension.Size = new System.Drawing.Size(180, 31);
            this.txt_dimension.TabIndex = 20;
            // 
            // txt_colour
            // 
            this.txt_colour.Animated = true;
            this.txt_colour.AutoRoundedCorners = true;
            this.txt_colour.BorderColor = System.Drawing.Color.NavajoWhite;
            this.txt_colour.BorderRadius = 14;
            this.txt_colour.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txt_colour.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_colour.DefaultText = "";
            this.txt_colour.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_colour.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_colour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_colour.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_colour.FillColor = System.Drawing.Color.MistyRose;
            this.txt_colour.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_colour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_colour.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_colour.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_colour.Location = new System.Drawing.Point(246, 302);
            this.txt_colour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_colour.Name = "txt_colour";
            this.txt_colour.PasswordChar = '\0';
            this.txt_colour.PlaceholderText = "Colour";
            this.txt_colour.SelectedText = "";
            this.txt_colour.Size = new System.Drawing.Size(180, 31);
            this.txt_colour.TabIndex = 21;
            // 
            // txt_energyConsumption
            // 
            this.txt_energyConsumption.Animated = true;
            this.txt_energyConsumption.AutoRoundedCorners = true;
            this.txt_energyConsumption.BorderColor = System.Drawing.Color.NavajoWhite;
            this.txt_energyConsumption.BorderRadius = 14;
            this.txt_energyConsumption.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txt_energyConsumption.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_energyConsumption.DefaultText = "";
            this.txt_energyConsumption.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_energyConsumption.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_energyConsumption.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_energyConsumption.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_energyConsumption.FillColor = System.Drawing.Color.MistyRose;
            this.txt_energyConsumption.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_energyConsumption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_energyConsumption.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_energyConsumption.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_energyConsumption.Location = new System.Drawing.Point(246, 361);
            this.txt_energyConsumption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_energyConsumption.Name = "txt_energyConsumption";
            this.txt_energyConsumption.PasswordChar = '\0';
            this.txt_energyConsumption.PlaceholderText = "Energy Consumption";
            this.txt_energyConsumption.SelectedText = "";
            this.txt_energyConsumption.Size = new System.Drawing.Size(180, 31);
            this.txt_energyConsumption.TabIndex = 22;
            // 
            // txt_monthlyFee
            // 
            this.txt_monthlyFee.Animated = true;
            this.txt_monthlyFee.AutoRoundedCorners = true;
            this.txt_monthlyFee.BorderColor = System.Drawing.Color.NavajoWhite;
            this.txt_monthlyFee.BorderRadius = 14;
            this.txt_monthlyFee.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txt_monthlyFee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_monthlyFee.DefaultText = "";
            this.txt_monthlyFee.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_monthlyFee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_monthlyFee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_monthlyFee.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_monthlyFee.FillColor = System.Drawing.Color.MistyRose;
            this.txt_monthlyFee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_monthlyFee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_monthlyFee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_monthlyFee.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_monthlyFee.Location = new System.Drawing.Point(246, 416);
            this.txt_monthlyFee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_monthlyFee.Name = "txt_monthlyFee";
            this.txt_monthlyFee.PasswordChar = '\0';
            this.txt_monthlyFee.PlaceholderText = "Monthly Fee";
            this.txt_monthlyFee.SelectedText = "";
            this.txt_monthlyFee.Size = new System.Drawing.Size(180, 31);
            this.txt_monthlyFee.TabIndex = 23;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.MediumOrchid;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(33, 79);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(120, 34);
            this.guna2HtmlLabel1.TabIndex = 24;
            this.guna2HtmlLabel1.Text = "Brand";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.MediumOrchid;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(33, 136);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(120, 34);
            this.guna2HtmlLabel2.TabIndex = 25;
            this.guna2HtmlLabel2.Text = "Type";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.MediumOrchid;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(33, 188);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(120, 34);
            this.guna2HtmlLabel3.TabIndex = 26;
            this.guna2HtmlLabel3.Text = "Model";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.MediumOrchid;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(33, 246);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(120, 34);
            this.guna2HtmlLabel4.TabIndex = 27;
            this.guna2HtmlLabel4.Text = "Dimension";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.AutoSize = false;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.MediumOrchid;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(33, 299);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(120, 34);
            this.guna2HtmlLabel5.TabIndex = 28;
            this.guna2HtmlLabel5.Text = "Colour";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.AutoSize = false;
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.MediumOrchid;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(33, 358);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(210, 34);
            this.guna2HtmlLabel6.TabIndex = 29;
            this.guna2HtmlLabel6.Text = "Energy Consumption";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.AutoSize = false;
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.MediumOrchid;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(33, 416);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(192, 31);
            this.guna2HtmlLabel7.TabIndex = 30;
            this.guna2HtmlLabel7.Text = "Monthly Fee";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.AutoSize = false;
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.MediumOrchid;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(33, 474);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(192, 31);
            this.guna2HtmlLabel8.TabIndex = 32;
            this.guna2HtmlLabel8.Text = "Appliances ID";
            // 
            // txt_appliancesId
            // 
            this.txt_appliancesId.Animated = true;
            this.txt_appliancesId.AutoRoundedCorners = true;
            this.txt_appliancesId.BorderColor = System.Drawing.Color.NavajoWhite;
            this.txt_appliancesId.BorderRadius = 14;
            this.txt_appliancesId.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txt_appliancesId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_appliancesId.DefaultText = "";
            this.txt_appliancesId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_appliancesId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_appliancesId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_appliancesId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_appliancesId.FillColor = System.Drawing.Color.MistyRose;
            this.txt_appliancesId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_appliancesId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_appliancesId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_appliancesId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_appliancesId.Location = new System.Drawing.Point(246, 474);
            this.txt_appliancesId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_appliancesId.Name = "txt_appliancesId";
            this.txt_appliancesId.PasswordChar = '\0';
            this.txt_appliancesId.PlaceholderText = "Appliances ID";
            this.txt_appliancesId.SelectedText = "";
            this.txt_appliancesId.Size = new System.Drawing.Size(180, 31);
            this.txt_appliancesId.TabIndex = 31;
            // 
            // btn_logout
            // 
            this.btn_logout.Animated = true;
            this.btn_logout.AutoRoundedCorners = true;
            this.btn_logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_logout.BorderRadius = 36;
            this.btn_logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_logout.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_logout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_logout.ForeColor = System.Drawing.Color.LightYellow;
            this.btn_logout.IndicateFocus = true;
            this.btn_logout.Location = new System.Drawing.Point(1307, 462);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(133, 75);
            this.btn_logout.TabIndex = 33;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseTransparentBackground = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.AutoSize = false;
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Verdana", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(468, 12);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(559, 50);
            this.guna2HtmlLabel9.TabIndex = 34;
            this.guna2HtmlLabel9.Text = "Admin View Appliances ";
            // 
            // AdminViewAppliances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1472, 588);
            this.Controls.Add(this.guna2HtmlLabel9);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.txt_appliancesId);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.txt_monthlyFee);
            this.Controls.Add(this.txt_energyConsumption);
            this.Controls.Add(this.txt_colour);
            this.Controls.Add(this.txt_dimension);
            this.Controls.Add(this.txt_model);
            this.Controls.Add(this.txt_type);
            this.Controls.Add(this.txt_brand);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dgv_table);
            this.ForeColor = System.Drawing.Color.OldLace;
            this.Name = "AdminViewAppliances";
            this.Text = "AdminViewAppliances";
            this.Load += new System.EventHandler(this.AdminViewAppliances_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter2;
        private Guna.UI2.WinForms.Guna2GradientButton btn_add;
        private Guna.UI2.WinForms.Guna2GradientButton btn_update;
        private Guna.UI2.WinForms.Guna2GradientButton btn_delete;
        private Guna.UI2.WinForms.Guna2GradientButton btn_refresh;
        private Guna.UI2.WinForms.Guna2TextBox txt_brand;
        private Guna.UI2.WinForms.Guna2TextBox txt_type;
        private Guna.UI2.WinForms.Guna2TextBox txt_model;
        private Guna.UI2.WinForms.Guna2TextBox txt_dimension;
        private Guna.UI2.WinForms.Guna2TextBox txt_colour;
        private Guna.UI2.WinForms.Guna2TextBox txt_energyConsumption;
        private Guna.UI2.WinForms.Guna2TextBox txt_monthlyFee;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2TextBox txt_appliancesId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_dimension;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_colour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_energy_consumption;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_monthly_fee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_appliancesId;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_table;
        private Guna.UI2.WinForms.Guna2GradientButton btn_logout;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
    }
}