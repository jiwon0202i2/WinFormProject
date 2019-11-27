namespace WinFormProject
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookbtn_clear = new System.Windows.Forms.Button();
            this.bookbtn_delete = new System.Windows.Forms.Button();
            this.bookbtn_insert = new System.Windows.Forms.Button();
            this.bookbtn_select = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbpublisher = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbbookname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbbookid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.custbtn_update = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.custbtn_clear = new System.Windows.Forms.Button();
            this.custbtn_delete = new System.Windows.Forms.Button();
            this.custbtn_insert = new System.Windows.Forms.Button();
            this.custbtn_select = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbphone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbaddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbcustid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.orderbtn_clear = new System.Windows.Forms.Button();
            this.orderbtn_delete = new System.Windows.Forms.Button();
            this.orderbtn_insert = new System.Windows.Forms.Button();
            this.orderbtn_select = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ordertbsaleprice = new System.Windows.Forms.TextBox();
            this.cmborderdate = new System.Windows.Forms.ComboBox();
            this.cmbbookid = new System.Windows.Forms.ComboBox();
            this.cmbcustid = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ordertborderid = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(28, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Movie";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(744, 601);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.bookbtn_clear);
            this.tabPage1.Controls.Add(this.bookbtn_delete);
            this.tabPage1.Controls.Add(this.bookbtn_insert);
            this.tabPage1.Controls.Add(this.bookbtn_select);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(736, 575);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "book";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(709, 327);
            this.dataGridView1.TabIndex = 14;
            // 
            // bookbtn_clear
            // 
            this.bookbtn_clear.Location = new System.Drawing.Point(495, 179);
            this.bookbtn_clear.Name = "bookbtn_clear";
            this.bookbtn_clear.Size = new System.Drawing.Size(221, 33);
            this.bookbtn_clear.TabIndex = 13;
            this.bookbtn_clear.Text = "Clear";
            this.bookbtn_clear.UseVisualStyleBackColor = true;
            this.bookbtn_clear.Click += new System.EventHandler(this.bookbtn_clear_Click);
            // 
            // bookbtn_delete
            // 
            this.bookbtn_delete.Location = new System.Drawing.Point(495, 137);
            this.bookbtn_delete.Name = "bookbtn_delete";
            this.bookbtn_delete.Size = new System.Drawing.Size(221, 33);
            this.bookbtn_delete.TabIndex = 12;
            this.bookbtn_delete.Text = "DELETE";
            this.bookbtn_delete.UseVisualStyleBackColor = true;
            this.bookbtn_delete.Click += new System.EventHandler(this.bookbtn_delete_Click);
            // 
            // bookbtn_insert
            // 
            this.bookbtn_insert.Location = new System.Drawing.Point(495, 92);
            this.bookbtn_insert.Name = "bookbtn_insert";
            this.bookbtn_insert.Size = new System.Drawing.Size(221, 33);
            this.bookbtn_insert.TabIndex = 10;
            this.bookbtn_insert.Text = "INSERT and UPDATE";
            this.bookbtn_insert.UseVisualStyleBackColor = true;
            this.bookbtn_insert.Click += new System.EventHandler(this.bookbtn_insert_Click);
            // 
            // bookbtn_select
            // 
            this.bookbtn_select.Location = new System.Drawing.Point(495, 50);
            this.bookbtn_select.Name = "bookbtn_select";
            this.bookbtn_select.Size = new System.Drawing.Size(221, 33);
            this.bookbtn_select.TabIndex = 9;
            this.bookbtn_select.Text = "SELECT";
            this.bookbtn_select.UseVisualStyleBackColor = true;
            this.bookbtn_select.Click += new System.EventHandler(this.bookbtn_select_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbpublisher);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.textBoxMax);
            this.panel1.Controls.Add(this.textBoxMin);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbbookname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbbookid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 193);
            this.panel1.TabIndex = 1;
            // 
            // cmbpublisher
            // 
            this.cmbpublisher.FormattingEnabled = true;
            this.cmbpublisher.Location = new System.Drawing.Point(121, 108);
            this.cmbpublisher.Name = "cmbpublisher";
            this.cmbpublisher.Size = new System.Drawing.Size(284, 20);
            this.cmbpublisher.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(257, 148);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 12);
            this.label15.TabIndex = 9;
            this.label15.Text = "~";
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(277, 145);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(128, 21);
            this.textBoxMax.TabIndex = 8;
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(121, 145);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(130, 21);
            this.textBoxMin.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "publisher";
            // 
            // tbbookname
            // 
            this.tbbookname.Location = new System.Drawing.Point(121, 70);
            this.tbbookname.Name = "tbbookname";
            this.tbbookname.Size = new System.Drawing.Size(284, 21);
            this.tbbookname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "bookname";
            // 
            // tbbookid
            // 
            this.tbbookid.Location = new System.Drawing.Point(121, 33);
            this.tbbookid.Name = "tbbookid";
            this.tbbookid.Size = new System.Drawing.Size(284, 21);
            this.tbbookid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "book_id";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.custbtn_update);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.custbtn_clear);
            this.tabPage2.Controls.Add(this.custbtn_delete);
            this.tabPage2.Controls.Add(this.custbtn_insert);
            this.tabPage2.Controls.Add(this.custbtn_select);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(736, 575);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "customer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // custbtn_update
            // 
            this.custbtn_update.Location = new System.Drawing.Point(495, 111);
            this.custbtn_update.Name = "custbtn_update";
            this.custbtn_update.Size = new System.Drawing.Size(221, 33);
            this.custbtn_update.TabIndex = 22;
            this.custbtn_update.Text = "UPDATE";
            this.custbtn_update.UseVisualStyleBackColor = true;
            this.custbtn_update.Click += new System.EventHandler(this.custbtn_update_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(16, 229);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(709, 327);
            this.dataGridView2.TabIndex = 21;
            // 
            // custbtn_clear
            // 
            this.custbtn_clear.Location = new System.Drawing.Point(495, 189);
            this.custbtn_clear.Name = "custbtn_clear";
            this.custbtn_clear.Size = new System.Drawing.Size(221, 33);
            this.custbtn_clear.TabIndex = 20;
            this.custbtn_clear.Text = "Clear";
            this.custbtn_clear.UseVisualStyleBackColor = true;
            this.custbtn_clear.Click += new System.EventHandler(this.custbtn_clear_Click);
            // 
            // custbtn_delete
            // 
            this.custbtn_delete.Location = new System.Drawing.Point(495, 150);
            this.custbtn_delete.Name = "custbtn_delete";
            this.custbtn_delete.Size = new System.Drawing.Size(221, 33);
            this.custbtn_delete.TabIndex = 19;
            this.custbtn_delete.Text = "DELETE";
            this.custbtn_delete.UseVisualStyleBackColor = true;
            this.custbtn_delete.Click += new System.EventHandler(this.custbtn_delete_Click);
            // 
            // custbtn_insert
            // 
            this.custbtn_insert.Location = new System.Drawing.Point(495, 72);
            this.custbtn_insert.Name = "custbtn_insert";
            this.custbtn_insert.Size = new System.Drawing.Size(221, 33);
            this.custbtn_insert.TabIndex = 17;
            this.custbtn_insert.Text = "INSERT";
            this.custbtn_insert.UseVisualStyleBackColor = true;
            this.custbtn_insert.Click += new System.EventHandler(this.custbtn_insert_Click);
            // 
            // custbtn_select
            // 
            this.custbtn_select.Location = new System.Drawing.Point(495, 33);
            this.custbtn_select.Name = "custbtn_select";
            this.custbtn_select.Size = new System.Drawing.Size(221, 33);
            this.custbtn_select.TabIndex = 16;
            this.custbtn_select.Text = "SELECT";
            this.custbtn_select.UseVisualStyleBackColor = true;
            this.custbtn_select.Click += new System.EventHandler(this.custbtn_select_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbphone);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tbaddress);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tbname);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.tbcustid);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(16, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(446, 193);
            this.panel2.TabIndex = 15;
            // 
            // tbphone
            // 
            this.tbphone.Location = new System.Drawing.Point(121, 145);
            this.tbphone.Name = "tbphone";
            this.tbphone.Size = new System.Drawing.Size(284, 21);
            this.tbphone.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "phone";
            // 
            // tbaddress
            // 
            this.tbaddress.Location = new System.Drawing.Point(121, 108);
            this.tbaddress.Name = "tbaddress";
            this.tbaddress.Size = new System.Drawing.Size(284, 21);
            this.tbaddress.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "address";
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(121, 70);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(284, 21);
            this.tbname.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "name";
            // 
            // tbcustid
            // 
            this.tbcustid.Location = new System.Drawing.Point(121, 33);
            this.tbcustid.Name = "tbcustid";
            this.tbcustid.Size = new System.Drawing.Size(284, 21);
            this.tbcustid.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(76, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "custid";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Controls.Add(this.orderbtn_clear);
            this.tabPage3.Controls.Add(this.orderbtn_delete);
            this.tabPage3.Controls.Add(this.orderbtn_insert);
            this.tabPage3.Controls.Add(this.orderbtn_select);
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(736, 575);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "order";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(16, 229);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(709, 327);
            this.dataGridView3.TabIndex = 28;
            // 
            // orderbtn_clear
            // 
            this.orderbtn_clear.Location = new System.Drawing.Point(495, 179);
            this.orderbtn_clear.Name = "orderbtn_clear";
            this.orderbtn_clear.Size = new System.Drawing.Size(221, 33);
            this.orderbtn_clear.TabIndex = 27;
            this.orderbtn_clear.Text = "Clear";
            this.orderbtn_clear.UseVisualStyleBackColor = true;
            this.orderbtn_clear.Click += new System.EventHandler(this.orderbtn_clear_Click);
            // 
            // orderbtn_delete
            // 
            this.orderbtn_delete.Location = new System.Drawing.Point(495, 137);
            this.orderbtn_delete.Name = "orderbtn_delete";
            this.orderbtn_delete.Size = new System.Drawing.Size(221, 33);
            this.orderbtn_delete.TabIndex = 26;
            this.orderbtn_delete.Text = "DELETE";
            this.orderbtn_delete.UseVisualStyleBackColor = true;
            this.orderbtn_delete.Click += new System.EventHandler(this.orderbtn_delete_Click);
            // 
            // orderbtn_insert
            // 
            this.orderbtn_insert.Location = new System.Drawing.Point(495, 92);
            this.orderbtn_insert.Name = "orderbtn_insert";
            this.orderbtn_insert.Size = new System.Drawing.Size(221, 33);
            this.orderbtn_insert.TabIndex = 24;
            this.orderbtn_insert.Text = "INSERT and UPDATE";
            this.orderbtn_insert.UseVisualStyleBackColor = true;
            this.orderbtn_insert.Click += new System.EventHandler(this.orderbtn_insert_Click);
            // 
            // orderbtn_select
            // 
            this.orderbtn_select.Location = new System.Drawing.Point(495, 50);
            this.orderbtn_select.Name = "orderbtn_select";
            this.orderbtn_select.Size = new System.Drawing.Size(221, 33);
            this.orderbtn_select.TabIndex = 23;
            this.orderbtn_select.Text = "SELECT";
            this.orderbtn_select.UseVisualStyleBackColor = true;
            this.orderbtn_select.Click += new System.EventHandler(this.orderbtn_select_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ordertbsaleprice);
            this.panel3.Controls.Add(this.cmborderdate);
            this.panel3.Controls.Add(this.cmbbookid);
            this.panel3.Controls.Add(this.cmbcustid);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.ordertborderid);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(16, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(446, 193);
            this.panel3.TabIndex = 22;
            // 
            // ordertbsaleprice
            // 
            this.ordertbsaleprice.Location = new System.Drawing.Point(121, 125);
            this.ordertbsaleprice.Name = "ordertbsaleprice";
            this.ordertbsaleprice.Size = new System.Drawing.Size(284, 21);
            this.ordertbsaleprice.TabIndex = 13;
            // 
            // cmborderdate
            // 
            this.cmborderdate.FormattingEnabled = true;
            this.cmborderdate.Location = new System.Drawing.Point(121, 160);
            this.cmborderdate.Name = "cmborderdate";
            this.cmborderdate.Size = new System.Drawing.Size(284, 20);
            this.cmborderdate.TabIndex = 12;
            // 
            // cmbbookid
            // 
            this.cmbbookid.FormattingEnabled = true;
            this.cmbbookid.Location = new System.Drawing.Point(121, 88);
            this.cmbbookid.Name = "cmbbookid";
            this.cmbbookid.Size = new System.Drawing.Size(284, 20);
            this.cmbbookid.TabIndex = 11;
            // 
            // cmbcustid
            // 
            this.cmbcustid.FormattingEnabled = true;
            this.cmbcustid.Location = new System.Drawing.Point(121, 50);
            this.cmbcustid.Name = "cmbcustid";
            this.cmbcustid.Size = new System.Drawing.Size(284, 20);
            this.cmbcustid.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(57, 164);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 12);
            this.label14.TabIndex = 8;
            this.label14.Text = "orderdate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(58, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 12);
            this.label10.TabIndex = 6;
            this.label10.Text = "saleprice";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(73, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 12);
            this.label11.TabIndex = 4;
            this.label11.Text = "bookid";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(76, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 12);
            this.label12.TabIndex = 2;
            this.label12.Text = "custid";
            // 
            // ordertborderid
            // 
            this.ordertborderid.Location = new System.Drawing.Point(121, 13);
            this.ordertborderid.Name = "ordertborderid";
            this.ordertborderid.Size = new System.Drawing.Size(284, 21);
            this.ordertborderid.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(71, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "orderid";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 607);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bookbtn_clear;
        private System.Windows.Forms.Button bookbtn_delete;
        private System.Windows.Forms.Button bookbtn_insert;
        private System.Windows.Forms.Button bookbtn_select;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbbookname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbbookid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button custbtn_clear;
        private System.Windows.Forms.Button custbtn_delete;
        private System.Windows.Forms.Button custbtn_insert;
        private System.Windows.Forms.Button custbtn_select;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbphone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbaddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbcustid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button orderbtn_clear;
        private System.Windows.Forms.Button orderbtn_delete;
        private System.Windows.Forms.Button orderbtn_insert;
        private System.Windows.Forms.Button orderbtn_select;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ordertborderid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.ComboBox cmbpublisher;
        private System.Windows.Forms.Button custbtn_update;
        private System.Windows.Forms.ComboBox cmborderdate;
        private System.Windows.Forms.ComboBox cmbbookid;
        private System.Windows.Forms.ComboBox cmbcustid;
        private System.Windows.Forms.TextBox ordertbsaleprice;
    }
}

