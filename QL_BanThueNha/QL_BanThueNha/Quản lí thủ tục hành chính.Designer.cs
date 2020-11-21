namespace QL_BanThueNha
{
    partial class Nhân_viên_thủ_tục_hành_chính
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
            this.tabBranch = new System.Windows.Forms.TabControl();
            this.branch = new System.Windows.Forms.TabPage();
            this.tabAdd = new System.Windows.Forms.TabControl();
            this.View = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labFax = new System.Windows.Forms.Label();
            this.txbFax = new System.Windows.Forms.TextBox();
            this.txbPhoneNum = new System.Windows.Forms.TextBox();
            this.txbCity = new System.Windows.Forms.TextBox();
            this.txbID = new System.Windows.Forms.TextBox();
            this.labPhoneNumber = new System.Windows.Forms.Label();
            this.labCity = new System.Windows.Forms.Label();
            this.labID = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.labAddDistrict = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labAddStreet = new System.Windows.Forms.Label();
            this.labAddEndDate = new System.Windows.Forms.Label();
            this.labAddStartDate = new System.Windows.Forms.Label();
            this.labAddFax = new System.Windows.Forms.Label();
            this.labAddPhoneNum = new System.Windows.Forms.Label();
            this.labAddCity = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.TabPage();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.labEditDistrict = new System.Windows.Forms.Label();
            this.txbEditDistrict = new System.Windows.Forms.TextBox();
            this.txbEditStreet = new System.Windows.Forms.TextBox();
            this.txbEditEndDate = new System.Windows.Forms.TextBox();
            this.txbEditStartDate = new System.Windows.Forms.TextBox();
            this.txbEditFax = new System.Windows.Forms.TextBox();
            this.txbEditPhoneNum = new System.Windows.Forms.TextBox();
            this.txbEditCity = new System.Windows.Forms.TextBox();
            this.txbEditID = new System.Windows.Forms.TextBox();
            this.labEditStreet = new System.Windows.Forms.Label();
            this.labEditEndDate = new System.Windows.Forms.Label();
            this.labEditStartDate = new System.Windows.Forms.Label();
            this.labEditFax = new System.Windows.Forms.Label();
            this.labEditPhoneNum = new System.Windows.Forms.Label();
            this.labEditCity = new System.Windows.Forms.Label();
            this.labEditID = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ApartmentHistory = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabBranch.SuspendLayout();
            this.branch.SuspendLayout();
            this.tabAdd.SuspendLayout();
            this.View.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.Add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.Edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.Delete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.ApartmentHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            this.SuspendLayout();
            // 
            // tabBranch
            // 
            this.tabBranch.Controls.Add(this.branch);
            this.tabBranch.Controls.Add(this.ApartmentHistory);
            this.tabBranch.Location = new System.Drawing.Point(0, 0);
            this.tabBranch.Name = "tabBranch";
            this.tabBranch.SelectedIndex = 0;
            this.tabBranch.Size = new System.Drawing.Size(801, 400);
            this.tabBranch.TabIndex = 0;
            // 
            // branch
            // 
            this.branch.Controls.Add(this.tabAdd);
            this.branch.Location = new System.Drawing.Point(4, 22);
            this.branch.Name = "branch";
            this.branch.Padding = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.branch.Size = new System.Drawing.Size(793, 374);
            this.branch.TabIndex = 0;
            this.branch.Text = "Thông tin chi nhánh";
            this.branch.UseVisualStyleBackColor = true;
            // 
            // tabAdd
            // 
            this.tabAdd.Controls.Add(this.View);
            this.tabAdd.Controls.Add(this.Search);
            this.tabAdd.Controls.Add(this.Add);
            this.tabAdd.Controls.Add(this.Edit);
            this.tabAdd.Controls.Add(this.Delete);
            this.tabAdd.Location = new System.Drawing.Point(3, 3);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.SelectedIndex = 0;
            this.tabAdd.Size = new System.Drawing.Size(669, 360);
            this.tabAdd.TabIndex = 1;
            // 
            // View
            // 
            this.View.Controls.Add(this.dataGridView1);
            this.View.Location = new System.Drawing.Point(4, 22);
            this.View.Name = "View";
            this.View.Padding = new System.Windows.Forms.Padding(3);
            this.View.Size = new System.Drawing.Size(661, 334);
            this.View.TabIndex = 0;
            this.View.Text = "Xem";
            this.View.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(617, 289);
            this.dataGridView1.TabIndex = 0;
            // 
            // Search
            // 
            this.Search.Controls.Add(this.btnSearch);
            this.Search.Controls.Add(this.labFax);
            this.Search.Controls.Add(this.txbFax);
            this.Search.Controls.Add(this.txbPhoneNum);
            this.Search.Controls.Add(this.txbCity);
            this.Search.Controls.Add(this.txbID);
            this.Search.Controls.Add(this.labPhoneNumber);
            this.Search.Controls.Add(this.labCity);
            this.Search.Controls.Add(this.labID);
            this.Search.Controls.Add(this.dataGridView3);
            this.Search.Location = new System.Drawing.Point(4, 22);
            this.Search.Name = "Search";
            this.Search.Padding = new System.Windows.Forms.Padding(3);
            this.Search.Size = new System.Drawing.Size(661, 334);
            this.Search.TabIndex = 1;
            this.Search.Text = "Tìm kiếm";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(169, 213);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // labFax
            // 
            this.labFax.AutoSize = true;
            this.labFax.Location = new System.Drawing.Point(88, 146);
            this.labFax.Name = "labFax";
            this.labFax.Size = new System.Drawing.Size(24, 13);
            this.labFax.TabIndex = 8;
            this.labFax.Text = "Fax";
            // 
            // txbFax
            // 
            this.txbFax.Location = new System.Drawing.Point(144, 146);
            this.txbFax.Name = "txbFax";
            this.txbFax.Size = new System.Drawing.Size(100, 20);
            this.txbFax.TabIndex = 7;
            // 
            // txbPhoneNum
            // 
            this.txbPhoneNum.Location = new System.Drawing.Point(144, 101);
            this.txbPhoneNum.Name = "txbPhoneNum";
            this.txbPhoneNum.Size = new System.Drawing.Size(100, 20);
            this.txbPhoneNum.TabIndex = 5;
            // 
            // txbCity
            // 
            this.txbCity.Location = new System.Drawing.Point(144, 56);
            this.txbCity.Name = "txbCity";
            this.txbCity.Size = new System.Drawing.Size(100, 20);
            this.txbCity.TabIndex = 2;
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(144, 16);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(100, 20);
            this.txbID.TabIndex = 1;
            this.txbID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labPhoneNumber
            // 
            this.labPhoneNumber.AutoSize = true;
            this.labPhoneNumber.Location = new System.Drawing.Point(42, 104);
            this.labPhoneNumber.Name = "labPhoneNumber";
            this.labPhoneNumber.Size = new System.Drawing.Size(70, 13);
            this.labPhoneNumber.TabIndex = 6;
            this.labPhoneNumber.Text = "Số điện thoại";
            // 
            // labCity
            // 
            this.labCity.AutoSize = true;
            this.labCity.Location = new System.Drawing.Point(27, 59);
            this.labCity.Name = "labCity";
            this.labCity.Size = new System.Drawing.Size(85, 13);
            this.labCity.TabIndex = 4;
            this.labCity.Text = "Tỉnh (thành phố)";
            this.labCity.Click += new System.EventHandler(this.label2_Click);
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Location = new System.Drawing.Point(94, 19);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(18, 13);
            this.labID.TabIndex = 3;
            this.labID.Text = "ID";
            this.labID.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(350, 16);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(305, 283);
            this.dataGridView3.TabIndex = 0;
            // 
            // Add
            // 
            this.Add.Controls.Add(this.btnRefresh);
            this.Add.Controls.Add(this.btnAdd);
            this.Add.Controls.Add(this.dataGridView4);
            this.Add.Controls.Add(this.labAddDistrict);
            this.Add.Controls.Add(this.textBox8);
            this.Add.Controls.Add(this.textBox7);
            this.Add.Controls.Add(this.textBox6);
            this.Add.Controls.Add(this.textBox5);
            this.Add.Controls.Add(this.textBox1);
            this.Add.Controls.Add(this.textBox2);
            this.Add.Controls.Add(this.textBox3);
            this.Add.Controls.Add(this.labAddStreet);
            this.Add.Controls.Add(this.labAddEndDate);
            this.Add.Controls.Add(this.labAddStartDate);
            this.Add.Controls.Add(this.labAddFax);
            this.Add.Controls.Add(this.labAddPhoneNum);
            this.Add.Controls.Add(this.labAddCity);
            this.Add.Location = new System.Drawing.Point(4, 22);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(661, 334);
            this.Add.TabIndex = 3;
            this.Add.Text = "Thêm";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(524, 152);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 27;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(413, 152);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(50, 181);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(563, 138);
            this.dataGridView4.TabIndex = 25;
            // 
            // labAddDistrict
            // 
            this.labAddDistrict.AutoSize = true;
            this.labAddDistrict.Location = new System.Drawing.Point(62, 49);
            this.labAddDistrict.Name = "labAddDistrict";
            this.labAddDistrict.Size = new System.Drawing.Size(73, 13);
            this.labAddDistrict.TabIndex = 24;
            this.labAddDistrict.Text = "Quận (Huyện)";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(164, 49);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 23;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(164, 13);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 21;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(513, 96);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 19;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(513, 58);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(513, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(164, 126);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(164, 86);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 10;
            // 
            // labAddStreet
            // 
            this.labAddStreet.AutoSize = true;
            this.labAddStreet.Location = new System.Drawing.Point(96, 13);
            this.labAddStreet.Name = "labAddStreet";
            this.labAddStreet.Size = new System.Drawing.Size(39, 13);
            this.labAddStreet.TabIndex = 22;
            this.labAddStreet.Text = "Đường";
            this.labAddStreet.Click += new System.EventHandler(this.label7_Click);
            // 
            // labAddEndDate
            // 
            this.labAddEndDate.AutoSize = true;
            this.labAddEndDate.Location = new System.Drawing.Point(408, 96);
            this.labAddEndDate.Name = "labAddEndDate";
            this.labAddEndDate.Size = new System.Drawing.Size(74, 13);
            this.labAddEndDate.TabIndex = 20;
            this.labAddEndDate.Text = "Ngày kết thúc";
            // 
            // labAddStartDate
            // 
            this.labAddStartDate.AutoSize = true;
            this.labAddStartDate.Location = new System.Drawing.Point(406, 58);
            this.labAddStartDate.Name = "labAddStartDate";
            this.labAddStartDate.Size = new System.Drawing.Size(72, 13);
            this.labAddStartDate.TabIndex = 18;
            this.labAddStartDate.Text = "Ngày bát đầu";
            // 
            // labAddFax
            // 
            this.labAddFax.AutoSize = true;
            this.labAddFax.Location = new System.Drawing.Point(454, 22);
            this.labAddFax.Name = "labAddFax";
            this.labAddFax.Size = new System.Drawing.Size(24, 13);
            this.labAddFax.TabIndex = 16;
            this.labAddFax.Text = "Fax";
            // 
            // labAddPhoneNum
            // 
            this.labAddPhoneNum.AutoSize = true;
            this.labAddPhoneNum.Location = new System.Drawing.Point(59, 132);
            this.labAddPhoneNum.Name = "labAddPhoneNum";
            this.labAddPhoneNum.Size = new System.Drawing.Size(70, 13);
            this.labAddPhoneNum.TabIndex = 14;
            this.labAddPhoneNum.Text = "Số điện thoại";
            // 
            // labAddCity
            // 
            this.labAddCity.AutoSize = true;
            this.labAddCity.Location = new System.Drawing.Point(50, 90);
            this.labAddCity.Name = "labAddCity";
            this.labAddCity.Size = new System.Drawing.Size(85, 13);
            this.labAddCity.TabIndex = 12;
            this.labAddCity.Text = "Tỉnh( thành phố)";
            this.labAddCity.Click += new System.EventHandler(this.label3_Click);
            // 
            // Edit
            // 
            this.Edit.Controls.Add(this.btnEdit);
            this.Edit.Controls.Add(this.dataGridView5);
            this.Edit.Controls.Add(this.labEditDistrict);
            this.Edit.Controls.Add(this.txbEditDistrict);
            this.Edit.Controls.Add(this.txbEditStreet);
            this.Edit.Controls.Add(this.txbEditEndDate);
            this.Edit.Controls.Add(this.txbEditStartDate);
            this.Edit.Controls.Add(this.txbEditFax);
            this.Edit.Controls.Add(this.txbEditPhoneNum);
            this.Edit.Controls.Add(this.txbEditCity);
            this.Edit.Controls.Add(this.txbEditID);
            this.Edit.Controls.Add(this.labEditStreet);
            this.Edit.Controls.Add(this.labEditEndDate);
            this.Edit.Controls.Add(this.labEditStartDate);
            this.Edit.Controls.Add(this.labEditFax);
            this.Edit.Controls.Add(this.labEditPhoneNum);
            this.Edit.Controls.Add(this.labEditCity);
            this.Edit.Controls.Add(this.labEditID);
            this.Edit.Location = new System.Drawing.Point(4, 22);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(661, 334);
            this.Edit.TabIndex = 2;
            this.Edit.Text = "Chỉnh sửa";
            this.Edit.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(304, 152);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 43;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(50, 181);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(563, 138);
            this.dataGridView5.TabIndex = 42;
            // 
            // labEditDistrict
            // 
            this.labEditDistrict.AutoSize = true;
            this.labEditDistrict.Location = new System.Drawing.Point(59, 81);
            this.labEditDistrict.Name = "labEditDistrict";
            this.labEditDistrict.Size = new System.Drawing.Size(73, 13);
            this.labEditDistrict.TabIndex = 41;
            this.labEditDistrict.Text = "Quận (Huyện)";
            // 
            // txbEditDistrict
            // 
            this.txbEditDistrict.Location = new System.Drawing.Point(161, 81);
            this.txbEditDistrict.Name = "txbEditDistrict";
            this.txbEditDistrict.Size = new System.Drawing.Size(100, 20);
            this.txbEditDistrict.TabIndex = 40;
            // 
            // txbEditStreet
            // 
            this.txbEditStreet.Location = new System.Drawing.Point(161, 45);
            this.txbEditStreet.Name = "txbEditStreet";
            this.txbEditStreet.Size = new System.Drawing.Size(100, 20);
            this.txbEditStreet.TabIndex = 38;
            // 
            // txbEditEndDate
            // 
            this.txbEditEndDate.Location = new System.Drawing.Point(513, 119);
            this.txbEditEndDate.Name = "txbEditEndDate";
            this.txbEditEndDate.Size = new System.Drawing.Size(100, 20);
            this.txbEditEndDate.TabIndex = 36;
            // 
            // txbEditStartDate
            // 
            this.txbEditStartDate.Location = new System.Drawing.Point(513, 81);
            this.txbEditStartDate.Name = "txbEditStartDate";
            this.txbEditStartDate.Size = new System.Drawing.Size(100, 20);
            this.txbEditStartDate.TabIndex = 34;
            // 
            // txbEditFax
            // 
            this.txbEditFax.Location = new System.Drawing.Point(513, 45);
            this.txbEditFax.Name = "txbEditFax";
            this.txbEditFax.Size = new System.Drawing.Size(100, 20);
            this.txbEditFax.TabIndex = 32;
            // 
            // txbEditPhoneNum
            // 
            this.txbEditPhoneNum.Location = new System.Drawing.Point(513, 7);
            this.txbEditPhoneNum.Name = "txbEditPhoneNum";
            this.txbEditPhoneNum.Size = new System.Drawing.Size(100, 20);
            this.txbEditPhoneNum.TabIndex = 30;
            // 
            // txbEditCity
            // 
            this.txbEditCity.Location = new System.Drawing.Point(161, 118);
            this.txbEditCity.Name = "txbEditCity";
            this.txbEditCity.Size = new System.Drawing.Size(100, 20);
            this.txbEditCity.TabIndex = 27;
            // 
            // txbEditID
            // 
            this.txbEditID.Location = new System.Drawing.Point(161, 10);
            this.txbEditID.Name = "txbEditID";
            this.txbEditID.ReadOnly = true;
            this.txbEditID.Size = new System.Drawing.Size(100, 20);
            this.txbEditID.TabIndex = 26;
            // 
            // labEditStreet
            // 
            this.labEditStreet.AutoSize = true;
            this.labEditStreet.Location = new System.Drawing.Point(93, 45);
            this.labEditStreet.Name = "labEditStreet";
            this.labEditStreet.Size = new System.Drawing.Size(39, 13);
            this.labEditStreet.TabIndex = 39;
            this.labEditStreet.Text = "Đường";
            // 
            // labEditEndDate
            // 
            this.labEditEndDate.AutoSize = true;
            this.labEditEndDate.Location = new System.Drawing.Point(406, 121);
            this.labEditEndDate.Name = "labEditEndDate";
            this.labEditEndDate.Size = new System.Drawing.Size(74, 13);
            this.labEditEndDate.TabIndex = 37;
            this.labEditEndDate.Text = "Ngày kết thúc";
            this.labEditEndDate.Click += new System.EventHandler(this.label11_Click);
            // 
            // labEditStartDate
            // 
            this.labEditStartDate.AutoSize = true;
            this.labEditStartDate.Location = new System.Drawing.Point(408, 81);
            this.labEditStartDate.Name = "labEditStartDate";
            this.labEditStartDate.Size = new System.Drawing.Size(72, 13);
            this.labEditStartDate.TabIndex = 35;
            this.labEditStartDate.Text = "Ngày bát đầu";
            this.labEditStartDate.Click += new System.EventHandler(this.label12_Click);
            // 
            // labEditFax
            // 
            this.labEditFax.AutoSize = true;
            this.labEditFax.Location = new System.Drawing.Point(454, 45);
            this.labEditFax.Name = "labEditFax";
            this.labEditFax.Size = new System.Drawing.Size(24, 13);
            this.labEditFax.TabIndex = 33;
            this.labEditFax.Text = "Fax";
            // 
            // labEditPhoneNum
            // 
            this.labEditPhoneNum.AutoSize = true;
            this.labEditPhoneNum.Location = new System.Drawing.Point(408, 13);
            this.labEditPhoneNum.Name = "labEditPhoneNum";
            this.labEditPhoneNum.Size = new System.Drawing.Size(70, 13);
            this.labEditPhoneNum.TabIndex = 31;
            this.labEditPhoneNum.Text = "Số điện thoại";
            // 
            // labEditCity
            // 
            this.labEditCity.AutoSize = true;
            this.labEditCity.Location = new System.Drawing.Point(47, 122);
            this.labEditCity.Name = "labEditCity";
            this.labEditCity.Size = new System.Drawing.Size(85, 13);
            this.labEditCity.TabIndex = 29;
            this.labEditCity.Text = "Tỉnh( thành phố)";
            // 
            // labEditID
            // 
            this.labEditID.AutoSize = true;
            this.labEditID.Location = new System.Drawing.Point(114, 13);
            this.labEditID.Name = "labEditID";
            this.labEditID.Size = new System.Drawing.Size(18, 13);
            this.labEditID.TabIndex = 28;
            this.labEditID.Text = "ID";
            // 
            // Delete
            // 
            this.Delete.Controls.Add(this.btnDelete);
            this.Delete.Controls.Add(this.dataGridView6);
            this.Delete.Controls.Add(this.textBox16);
            this.Delete.Controls.Add(this.label8);
            this.Delete.Location = new System.Drawing.Point(4, 22);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(661, 334);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "Xoá";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(321, 53);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 61;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // dataGridView6
            // 
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(50, 102);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(563, 217);
            this.dataGridView6.TabIndex = 60;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(130, 53);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(100, 20);
            this.textBox16.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(106, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "ID";
            // 
            // ApartmentHistory
            // 
            this.ApartmentHistory.Controls.Add(this.button2);
            this.ApartmentHistory.Controls.Add(this.button1);
            this.ApartmentHistory.Controls.Add(this.textBox11);
            this.ApartmentHistory.Controls.Add(this.textBox12);
            this.ApartmentHistory.Controls.Add(this.dataGridView7);
            this.ApartmentHistory.Controls.Add(this.label3);
            this.ApartmentHistory.Controls.Add(this.label4);
            this.ApartmentHistory.Location = new System.Drawing.Point(4, 22);
            this.ApartmentHistory.Name = "ApartmentHistory";
            this.ApartmentHistory.Padding = new System.Windows.Forms.Padding(3);
            this.ApartmentHistory.Size = new System.Drawing.Size(793, 374);
            this.ApartmentHistory.TabIndex = 1;
            this.ApartmentHistory.Text = "Lịch sử quản lí căn hộ";
            this.ApartmentHistory.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(72, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Xem";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(156, 137);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 2;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(156, 97);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 1;
            // 
            // dataGridView7
            // 
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Location = new System.Drawing.Point(370, 24);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.Size = new System.Drawing.Size(305, 283);
            this.dataGridView7.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã Căn hộ";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã Chi nhánh";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // Nhân_viên_thủ_tục_hành_chính
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 378);
            this.Controls.Add(this.tabBranch);
            this.Name = "Nhân_viên_thủ_tục_hành_chính";
            this.Text = "Nhân_viên_thủ_tục_hành_chính";
            this.tabBranch.ResumeLayout(false);
            this.branch.ResumeLayout(false);
            this.tabAdd.ResumeLayout(false);
            this.View.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Search.ResumeLayout(false);
            this.Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.Add.ResumeLayout(false);
            this.Add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.Edit.ResumeLayout(false);
            this.Edit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.Delete.ResumeLayout(false);
            this.Delete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.ApartmentHistory.ResumeLayout(false);
            this.ApartmentHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabBranch;
        private System.Windows.Forms.TabPage branch;
        private System.Windows.Forms.TabPage ApartmentHistory;
        private System.Windows.Forms.TabControl tabAdd;
        private System.Windows.Forms.TabPage View;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage Search;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labFax;
        private System.Windows.Forms.TextBox txbFax;
        private System.Windows.Forms.TextBox txbPhoneNum;
        private System.Windows.Forms.TextBox txbCity;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label labPhoneNumber;
        private System.Windows.Forms.Label labCity;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage Add;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label labAddDistrict;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labAddStreet;
        private System.Windows.Forms.Label labAddEndDate;
        private System.Windows.Forms.Label labAddStartDate;
        private System.Windows.Forms.Label labAddFax;
        private System.Windows.Forms.Label labAddPhoneNum;
        private System.Windows.Forms.Label labAddCity;
        private System.Windows.Forms.TabPage Edit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Label labEditDistrict;
        private System.Windows.Forms.TextBox txbEditDistrict;
        private System.Windows.Forms.TextBox txbEditStreet;
        private System.Windows.Forms.TextBox txbEditEndDate;
        private System.Windows.Forms.TextBox txbEditStartDate;
        private System.Windows.Forms.TextBox txbEditFax;
        private System.Windows.Forms.TextBox txbEditPhoneNum;
        private System.Windows.Forms.TextBox txbEditCity;
        private System.Windows.Forms.TextBox txbEditID;
        private System.Windows.Forms.Label labEditStreet;
        private System.Windows.Forms.Label labEditEndDate;
        private System.Windows.Forms.Label labEditStartDate;
        private System.Windows.Forms.Label labEditFax;
        private System.Windows.Forms.Label labEditPhoneNum;
        private System.Windows.Forms.Label labEditCity;
        private System.Windows.Forms.Label labEditID;
        private System.Windows.Forms.TabPage Delete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRefresh;
    }
}