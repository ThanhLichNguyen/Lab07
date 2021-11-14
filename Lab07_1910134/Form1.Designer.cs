
namespace Lab07_1910134
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbOrders = new System.Windows.Forms.TabPage();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cbbSwitchTable = new System.Windows.Forms.ComboBox();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.nudDiscount = new System.Windows.Forms.NumericUpDown();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.lvBills = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.nudFood = new System.Windows.Forms.NumericUpDown();
            this.cbbFood = new System.Windows.Forms.ComboBox();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtSearchByName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCatName = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvFoodList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmCalculateQuantity = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddFood = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUpdateFood = new System.Windows.Forms.ToolStripMenuItem();
            this.cbbCategory1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.mtbTell = new System.Windows.Forms.MaskedTextBox();
            this.dtpDateCreated = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnViewBill = new System.Windows.Forms.Button();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.tsmRemoveFood = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tbOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFood)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbOrders);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(648, 403);
            this.tabControl1.TabIndex = 0;
            // 
            // tbOrders
            // 
            this.tbOrders.BackColor = System.Drawing.Color.White;
            this.tbOrders.Controls.Add(this.txtAmount);
            this.tbOrders.Controls.Add(this.cbbSwitchTable);
            this.tbOrders.Controls.Add(this.btnSwitch);
            this.tbOrders.Controls.Add(this.nudDiscount);
            this.tbOrders.Controls.Add(this.btnDiscount);
            this.tbOrders.Controls.Add(this.btnCheckOut);
            this.tbOrders.Controls.Add(this.lvBills);
            this.tbOrders.Controls.Add(this.panel1);
            this.tbOrders.Controls.Add(this.flpTable);
            this.tbOrders.Location = new System.Drawing.Point(4, 24);
            this.tbOrders.Name = "tbOrders";
            this.tbOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tbOrders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbOrders.Size = new System.Drawing.Size(640, 375);
            this.tbOrders.TabIndex = 0;
            this.tbOrders.Text = "Orders";
            // 
            // txtAmount
            // 
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtAmount.Location = new System.Drawing.Point(547, 293);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAmount.Size = new System.Drawing.Size(87, 23);
            this.txtAmount.TabIndex = 8;
            this.txtAmount.Text = "0 vnđ";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbbSwitchTable
            // 
            this.cbbSwitchTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbSwitchTable.FormattingEnabled = true;
            this.cbbSwitchTable.Location = new System.Drawing.Point(314, 346);
            this.cbbSwitchTable.Name = "cbbSwitchTable";
            this.cbbSwitchTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbbSwitchTable.Size = new System.Drawing.Size(82, 23);
            this.cbbSwitchTable.TabIndex = 7;
            // 
            // btnSwitch
            // 
            this.btnSwitch.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnSwitch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSwitch.FlatAppearance.BorderSize = 0;
            this.btnSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitch.Location = new System.Drawing.Point(314, 322);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(82, 25);
            this.btnSwitch.TabIndex = 6;
            this.btnSwitch.Text = "Chuyển bàn";
            this.btnSwitch.UseVisualStyleBackColor = false;
            // 
            // nudDiscount
            // 
            this.nudDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudDiscount.Location = new System.Drawing.Point(405, 347);
            this.nudDiscount.Name = "nudDiscount";
            this.nudDiscount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nudDiscount.Size = new System.Drawing.Size(82, 23);
            this.nudDiscount.TabIndex = 4;
            this.nudDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnDiscount
            // 
            this.btnDiscount.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDiscount.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDiscount.FlatAppearance.BorderSize = 0;
            this.btnDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscount.Location = new System.Drawing.Point(405, 322);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(82, 25);
            this.btnDiscount.TabIndex = 5;
            this.btnDiscount.Text = "Giảm giá";
            this.btnDiscount.UseVisualStyleBackColor = false;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnCheckOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCheckOut.FlatAppearance.BorderSize = 0;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Location = new System.Drawing.Point(547, 322);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(85, 48);
            this.btnCheckOut.TabIndex = 4;
            this.btnCheckOut.Text = "Thanh toán";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            // 
            // lvBills
            // 
            this.lvBills.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvBills.HideSelection = false;
            this.lvBills.Location = new System.Drawing.Point(314, 62);
            this.lvBills.Name = "lvBills";
            this.lvBills.Size = new System.Drawing.Size(320, 225);
            this.lvBills.TabIndex = 2;
            this.lvBills.UseCompatibleStateImageBehavior = false;
            this.lvBills.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 78;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 80;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddFood);
            this.panel1.Controls.Add(this.nudFood);
            this.panel1.Controls.Add(this.cbbFood);
            this.panel1.Controls.Add(this.cbbCategory);
            this.panel1.Location = new System.Drawing.Point(314, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 59);
            this.panel1.TabIndex = 1;
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnAddFood.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddFood.FlatAppearance.BorderSize = 0;
            this.btnAddFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFood.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddFood.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddFood.Location = new System.Drawing.Point(233, 3);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(90, 52);
            this.btnAddFood.TabIndex = 3;
            this.btnAddFood.Text = "Order";
            this.btnAddFood.UseVisualStyleBackColor = false;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // nudFood
            // 
            this.nudFood.Location = new System.Drawing.Point(174, 31);
            this.nudFood.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudFood.Name = "nudFood";
            this.nudFood.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nudFood.Size = new System.Drawing.Size(53, 23);
            this.nudFood.TabIndex = 2;
            this.nudFood.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbbFood
            // 
            this.cbbFood.FormattingEnabled = true;
            this.cbbFood.Location = new System.Drawing.Point(0, 31);
            this.cbbFood.Name = "cbbFood";
            this.cbbFood.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbbFood.Size = new System.Drawing.Size(168, 23);
            this.cbbFood.TabIndex = 1;
            // 
            // cbbCategory
            // 
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(0, 3);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbbCategory.Size = new System.Drawing.Size(227, 23);
            this.cbbCategory.TabIndex = 0;
            this.cbbCategory.SelectedIndexChanged += new System.EventHandler(this.cbbCategory_SelectedIndexChanged);
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.BackColor = System.Drawing.Color.White;
            this.flpTable.Location = new System.Drawing.Point(0, 0);
            this.flpTable.Name = "flpTable";
            this.flpTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flpTable.Size = new System.Drawing.Size(305, 375);
            this.flpTable.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.txtSearchByName);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.lblCatName);
            this.tabPage2.Controls.Add(this.lbl);
            this.tabPage2.Controls.Add(this.lblQuantity);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dgvFoodList);
            this.tabPage2.Controls.Add(this.cbbCategory1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(640, 375);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Food";
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.Location = new System.Drawing.Point(494, 12);
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.Size = new System.Drawing.Size(141, 23);
            this.txtSearchByName.TabIndex = 17;
            this.txtSearchByName.TextChanged += new System.EventHandler(this.txtSearchByName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tìm kiếm theo tên: ";
            // 
            // lblCatName
            // 
            this.lblCatName.AutoSize = true;
            this.lblCatName.Location = new System.Drawing.Point(185, 344);
            this.lblCatName.Name = "lblCatName";
            this.lblCatName.Size = new System.Drawing.Size(16, 15);
            this.lblCatName.TabIndex = 15;
            this.lblCatName.Text = "...";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(71, 344);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(117, 15);
            this.lbl.TabIndex = 14;
            this.lbl.Text = "món ăn thuộc nhóm";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(55, 344);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(16, 15);
            this.lblQuantity.TabIndex = 13;
            this.lblQuantity.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Có tất cả";
            // 
            // dgvFoodList
            // 
            this.dgvFoodList.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvFoodList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFoodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvFoodList.Location = new System.Drawing.Point(0, 41);
            this.dgvFoodList.Name = "dgvFoodList";
            this.dgvFoodList.RowTemplate.Height = 25;
            this.dgvFoodList.Size = new System.Drawing.Size(634, 288);
            this.dgvFoodList.TabIndex = 11;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCalculateQuantity,
            this.tsmAddFood,
            this.tsmUpdateFood,
            this.tsmRemoveFood});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(187, 114);
            // 
            // tsmCalculateQuantity
            // 
            this.tsmCalculateQuantity.Name = "tsmCalculateQuantity";
            this.tsmCalculateQuantity.Size = new System.Drawing.Size(186, 22);
            this.tsmCalculateQuantity.Text = "Tính số lượng đã bán";
            this.tsmCalculateQuantity.Click += new System.EventHandler(this.tsmCalculateQuantity_Click);
            // 
            // tsmAddFood
            // 
            this.tsmAddFood.Name = "tsmAddFood";
            this.tsmAddFood.Size = new System.Drawing.Size(186, 22);
            this.tsmAddFood.Text = "Thêm món ăn";
            this.tsmAddFood.Click += new System.EventHandler(this.tsmAddFood_Click);
            // 
            // tsmUpdateFood
            // 
            this.tsmUpdateFood.Name = "tsmUpdateFood";
            this.tsmUpdateFood.Size = new System.Drawing.Size(186, 22);
            this.tsmUpdateFood.Text = "Cập nhật món ăn";
            this.tsmUpdateFood.Click += new System.EventHandler(this.tsmUpdateFood_Click);
            // 
            // cbbCategory1
            // 
            this.cbbCategory1.FormattingEnabled = true;
            this.cbbCategory1.Location = new System.Drawing.Point(124, 7);
            this.cbbCategory1.Name = "cbbCategory1";
            this.cbbCategory1.Size = new System.Drawing.Size(132, 23);
            this.cbbCategory1.TabIndex = 10;
            this.cbbCategory1.SelectedIndexChanged += new System.EventHandler(this.cbbCategory1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Chọn nhóm món ăn:";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.dgvAccount);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(640, 375);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Account";
            // 
            // dgvAccount
            // 
            this.dgvAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvAccount.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(0, 149);
            this.dgvAccount.MultiSelect = false;
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowTemplate.Height = 25;
            this.dgvAccount.Size = new System.Drawing.Size(637, 226);
            this.dgvAccount.TabIndex = 31;
            this.dgvAccount.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAccount_RowHeaderMouseClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnUpdateAccount);
            this.panel2.Controls.Add(this.btnAddAccount);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtAccountName);
            this.panel2.Controls.Add(this.mtbTell);
            this.panel2.Controls.Add(this.dtpDateCreated);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.txtFullName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 142);
            this.panel2.TabIndex = 32;
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnUpdateAccount.FlatAppearance.BorderSize = 0;
            this.btnUpdateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAccount.Location = new System.Drawing.Point(519, 101);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(88, 28);
            this.btnUpdateAccount.TabIndex = 29;
            this.btnUpdateAccount.Text = "Cập nhật";
            this.btnUpdateAccount.UseVisualStyleBackColor = false;
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnAddAccount.FlatAppearance.BorderSize = 0;
            this.btnAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAccount.Location = new System.Drawing.Point(414, 101);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(96, 28);
            this.btnAddAccount.TabIndex = 30;
            this.btnAddAccount.Text = "Thêm";
            this.btnAddAccount.UseVisualStyleBackColor = false;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Tên tài khoản:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Mật khẩu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Họ và tên:";
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(109, 19);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(203, 23);
            this.txtAccountName.TabIndex = 22;
            // 
            // mtbTell
            // 
            this.mtbTell.Location = new System.Drawing.Point(414, 72);
            this.mtbTell.Mask = "0000.000.000";
            this.mtbTell.Name = "mtbTell";
            this.mtbTell.Size = new System.Drawing.Size(193, 23);
            this.mtbTell.TabIndex = 26;
            // 
            // dtpDateCreated
            // 
            this.dtpDateCreated.CustomFormat = "dd/MM/yyyy";
            this.dtpDateCreated.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateCreated.Location = new System.Drawing.Point(414, 16);
            this.dtpDateCreated.Name = "dtpDateCreated";
            this.dtpDateCreated.Size = new System.Drawing.Size(193, 23);
            this.dtpDateCreated.TabIndex = 27;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(414, 44);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(193, 23);
            this.txtEmail.TabIndex = 25;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(109, 48);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(203, 23);
            this.txtPassword.TabIndex = 23;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(109, 77);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(203, 23);
            this.txtFullName.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Ngày lập tk:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Số điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Email:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnViewBill);
            this.tabPage3.Controls.Add(this.dgvBill);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.dtpToDate);
            this.tabPage3.Controls.Add(this.dtpFromDate);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(640, 375);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Doanh thu";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnViewBill
            // 
            this.btnViewBill.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnViewBill.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnViewBill.FlatAppearance.BorderSize = 0;
            this.btnViewBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewBill.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnViewBill.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnViewBill.Location = new System.Drawing.Point(542, 3);
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.Size = new System.Drawing.Size(90, 52);
            this.btnViewBill.TabIndex = 5;
            this.btnViewBill.Text = "Xem";
            this.btnViewBill.UseVisualStyleBackColor = false;
            this.btnViewBill.Click += new System.EventHandler(this.btnViewBill_Click);
            // 
            // dgvBill
            // 
            this.dgvBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Location = new System.Drawing.Point(0, 61);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowTemplate.Height = 25;
            this.dgvBill.Size = new System.Drawing.Size(640, 318);
            this.dgvBill.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(357, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "Đến ngày:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(364, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Từ ngày:";
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd/MM/yyyy";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(423, 32);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(113, 23);
            this.dtpToDate.TabIndex = 1;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd/MM/yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(423, 3);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(113, 23);
            this.dtpFromDate.TabIndex = 0;
            // 
            // tsmRemoveFood
            // 
            this.tsmRemoveFood.Name = "tsmRemoveFood";
            this.tsmRemoveFood.Size = new System.Drawing.Size(186, 22);
            this.tsmRemoveFood.Text = "Xóa món ăn";
            this.tsmRemoveFood.Click += new System.EventHandler(this.tsmRemoveFood_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(646, 405);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbOrders.ResumeLayout(false);
            this.tbOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudFood)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbOrders;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.NumericUpDown nudDiscount;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.ListView lvBills;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.NumericUpDown nudFood;
        private System.Windows.Forms.ComboBox cbbFood;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.ComboBox cbbSwitchTable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtSearchByName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCatName;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvFoodList;
        private System.Windows.Forms.ComboBox cbbCategory1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmCalculateQuantity;
        private System.Windows.Forms.ToolStripMenuItem tsmAddFood;
        private System.Windows.Forms.ToolStripMenuItem tsmUpdateFood;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Button btnUpdateAccount;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.MaskedTextBox mtbTell;
        private System.Windows.Forms.DateTimePicker dtpDateCreated;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnViewBill;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.ToolStripMenuItem tsmRemoveFood;
    }
}

