using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection conn;
        MySqlDataAdapter dataAdapter_book;
        MySqlDataAdapter dataAdapter_customer;
        MySqlDataAdapter dataAdapter_orders;
        DataSet dataSet;

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection("server=localhost;port=3305;database=mydb;uid=root;pwd=12345;");
            dataAdapter_book = new MySqlDataAdapter("SELECT * FROM book", conn);
            dataAdapter_book.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            dataAdapter_customer = new MySqlDataAdapter("SELECT * FROM customer", conn);
            dataAdapter_customer.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            dataAdapter_orders = new MySqlDataAdapter("SELECT * FROM orders", conn);
            dataAdapter_orders.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            dataSet = new DataSet();

            dataAdapter_book.Fill(dataSet, "book");
            dataGridView1.DataSource = dataSet.Tables["book"];

            dataAdapter_customer.Fill(dataSet, "customer");
            dataGridView2.DataSource = dataSet.Tables["customer"];

            dataAdapter_orders.Fill(dataSet, "orders");
            dataGridView3.DataSource = dataSet.Tables["orders"];

            SetSearchComboBox();
        }

        private void SetSearchComboBox()
        {
            string sql = "SELECT publisher FROM book";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            try
            {
                // publisher 목록 표시
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())  // 다음 레코드가 있으면 true
                {
                    cmbpublisher.Items.Add(reader.GetString("publisher"));
                }
                reader.Close();

                // custid 목록 표시
                sql = "SELECT distinct custid FROM orders";
                cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())  // 다음 레코드가 있으면 true
                {
                    cmbcustid.Items.Add(reader.GetString("custid"));
                }
                reader.Close();

                // bookid 목록 표시
                sql = "SELECT distinct bookid FROM orders";
                cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())  // 다음 레코드가 있으면 true
                {
                    cmbbookid.Items.Add(reader.GetString("bookid"));
                }
                reader.Close();

                // orderdate 목록 표시
                sql = "SELECT distinct orderdate FROM orders";
                cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                string temp = "";
                while (reader.Read())  // 다음 레코드가 있으면 true
                {
                    temp = reader.GetString("orderdate").Substring(0, 10);
                    cmborderdate.Items.Add(temp);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void bookbtn_select_Click(object sender, EventArgs e)
        {
            string queryStr;
            #region 예제 코드
            string[] conditions = new string[5];
            conditions[0] = (tbbookid.Text != "") ? "bookid=@bookid" : null;
            conditions[1] = (tbbookname.Text != "") ? "bookname=@bookname" : null;
            conditions[2] = (cmbpublisher.Text != "") ? "publisher=@publisher" : null;
            string condition_price;
            if (textBoxMin.Text != "" && textBoxMax.Text != "")
            {
                condition_price = "price>=@min and price<=@max";
            }
            else if (textBoxMin.Text != "" || textBoxMax.Text != "")
            {
                if (textBoxMin.Text != "")
                    condition_price = "price>=@min";
                else
                    condition_price = "price <= @max";
            }
            else
            {
                condition_price = null;
            }
            conditions[3] = condition_price;

            if (conditions[0] != null || conditions[1] != null || conditions[2] != null || conditions[3] != null )
            {
                queryStr = $"SELECT * FROM book WHERE ";
                bool firstCondition = true;
                for (int i = 0; i < conditions.Length; i++)
                {
                    if (conditions[i] != null)
                        if (firstCondition)
                        {
                            queryStr += conditions[i];
                            firstCondition = false;
                        }
                        else
                        {
                            queryStr += " and " + conditions[i];
                        }
                }
            }
            else
            {
                queryStr = "SELECT * FROM book";
            }
            #endregion

            #region SelectCommand 객체 생성 및 Parameters 설정
            dataAdapter_book.SelectCommand = new MySqlCommand(queryStr, conn);
            dataAdapter_book.SelectCommand.Parameters.AddWithValue("@bookid", tbbookid.Text);
            dataAdapter_book.SelectCommand.Parameters.AddWithValue("@bookname", tbbookname.Text);
            dataAdapter_book.SelectCommand.Parameters.AddWithValue("@publisher", cmbpublisher.Text);
            dataAdapter_book.SelectCommand.Parameters.AddWithValue("@min", textBoxMin.Text);
            dataAdapter_book.SelectCommand.Parameters.AddWithValue("@max", textBoxMax.Text);
            #endregion

            try
            {
                conn.Open();
                dataSet.Clear();
                if (dataAdapter_book.Fill(dataSet, "book") > 0)
                    dataGridView1.DataSource = dataSet.Tables["book"];
                else
                    MessageBox.Show("찾는 데이터가 없습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void bookbtn_insert_Click(object sender, EventArgs e)
        {
            Form2 Dig = new Form2();
            Dig.Owner = this;               // 새로운 폼의 부모가 Form1 인스턴스임을 지정
            Dig.ShowDialog();               // 폼 띄우기(Modal)
            Dig.Dispose();
        }

        private void bookbtn_clear_Click(object sender, EventArgs e)
        {
            tbbookid.Clear();
            tbbookname.Clear();
            cmbpublisher.Text = "";
            textBoxMin.Clear();
            textBoxMax.Clear();
        }

        private void bookbtn_delete_Click(object sender, EventArgs e)
        {
            int id;
            string sql = "DELETE FROM book WHERE bookid=@bookid";
            dataAdapter_book.DeleteCommand = new MySqlCommand(sql, conn);
            dataAdapter_book.DeleteCommand.Parameters.Add("@bookid", MySqlDbType.Int32); // dataGridView1에서 선택된 행(row) 정보 가져오기
            id = (int)dataGridView1.SelectedRows[0].Cells["bookid"].Value;
            dataAdapter_book.DeleteCommand.Parameters["@bookid"].Value = id;

            #region DeleteCommand를 이용한 처리
            try
            {
                conn.Open();
                dataAdapter_book.DeleteCommand.ExecuteNonQuery();

                dataSet.Clear();
                dataAdapter_book.Fill(dataSet, "book");
                dataGridView1.DataSource = dataSet.Tables["book"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            #endregion
        }

        public void InsertRow_book(string[] rowDatas)
        {
            string queryStr = "INSERT INTO book (bookname, publisher, price) " +
                "VALUES(@bookname, @publisher, @price)";
            dataAdapter_book.InsertCommand = new MySqlCommand(queryStr, conn);
            dataAdapter_book.InsertCommand.Parameters.Add("@bookname", MySqlDbType.VarChar);
            dataAdapter_book.InsertCommand.Parameters.Add("@publisher", MySqlDbType.VarChar);
            dataAdapter_book.InsertCommand.Parameters.Add("@price", MySqlDbType.Int32);

            #region Parameter를 이용한 처리
            dataAdapter_book.InsertCommand.Parameters["@bookname"].Value = rowDatas[0];
            dataAdapter_book.InsertCommand.Parameters["@publisher"].Value = rowDatas[1];
            dataAdapter_book.InsertCommand.Parameters["@price"].Value = rowDatas[2];

            try
            {
                conn.Open();
                dataAdapter_book.InsertCommand.ExecuteNonQuery();

                dataSet.Clear();                                        // 이전 데이터 지우기
                dataAdapter_book.Fill(dataSet, "book");                      // DB -> DataSet
                dataGridView1.DataSource = dataSet.Tables["book"];      // dataGridView에 테이블 표시                                     // 텍스트 박스 내용 지우기
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            #endregion
        }
        internal void UpdateRow_book(string[] rowDatas)
        {
            string sql = "UPDATE book SET bookname=@bookname, bookname=@bookname, publisher=@publisher, price=@price WHERE bookid=@bookid";
            dataAdapter_book.UpdateCommand = new MySqlCommand(sql, conn);
            dataAdapter_book.UpdateCommand.Parameters.AddWithValue("@bookid", rowDatas[0]);
            dataAdapter_book.UpdateCommand.Parameters.AddWithValue("@bookname", rowDatas[1]);
            dataAdapter_book.UpdateCommand.Parameters.AddWithValue("@publisher", rowDatas[2]);
            dataAdapter_book.UpdateCommand.Parameters.AddWithValue("@price", rowDatas[3]);

            try
            {
                conn.Open();
                dataAdapter_book.UpdateCommand.ExecuteNonQuery();

                dataSet.Clear();  // 이전 데이터 지우기
                dataAdapter_book.Fill(dataSet, "book");
                dataGridView1.DataSource = dataSet.Tables["book"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void custbtn_select_Click(object sender, EventArgs e)
        {
            string queryStr;
            #region 예제 코드
            string[] conditions = new string[5];
            conditions[0] = (tbcustid.Text != "") ? "custid=@custid" : null;
            conditions[1] = (tbname.Text != "") ? "name=@name" : null;
            conditions[2] = (tbaddress.Text != "") ? "address=@address" : null;
            conditions[3] = (tbphone.Text != "") ? "phone=@phone" : null;

            if (conditions[0] != null || conditions[1] != null || conditions[2] != null || conditions[3] != null)
            {
                queryStr = $"SELECT * FROM customer WHERE ";
                bool firstCondition = true;
                for (int i = 0; i < conditions.Length; i++)
                {
                    if (conditions[i] != null)
                        if (firstCondition)
                        {
                            queryStr += conditions[i];
                            firstCondition = false;
                        }
                        else
                        {
                            queryStr += " and " + conditions[i];
                        }
                }
            }
            else
            {
                queryStr = "SELECT * FROM customer";
            }
            #endregion

            #region SelectCommand 객체 생성 및 Parameters 설정
            dataAdapter_customer.SelectCommand = new MySqlCommand(queryStr, conn);
            dataAdapter_customer.SelectCommand.Parameters.AddWithValue("@custid", tbcustid.Text);
            dataAdapter_customer.SelectCommand.Parameters.AddWithValue("@name", tbname.Text);
            dataAdapter_customer.SelectCommand.Parameters.AddWithValue("@address", tbaddress.Text);
            dataAdapter_customer.SelectCommand.Parameters.AddWithValue("@phone", tbphone.Text);
            #endregion

            try
            {
                conn.Open();
                dataSet.Clear();
                if (dataAdapter_customer.Fill(dataSet, "customer") > 0)
                    dataGridView2.DataSource = dataSet.Tables["customer"];
                else
                    MessageBox.Show("찾는 데이터가 없습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void custbtn_insert_Click(object sender, EventArgs e)
        {
            string[] rowDatas = {
                tbname.Text,
                tbaddress.Text,
                tbphone.Text };
            InsertRow_cust(rowDatas);
            this.Close();
        }

        public void InsertRow_cust(string[] rowDatas)
        {
            string queryStr = "INSERT INTO customer (name, address, phone) " +
                "VALUES(@name, @address, @phone)";
            dataAdapter_customer.InsertCommand = new MySqlCommand(queryStr, conn);
            dataAdapter_customer.InsertCommand.Parameters.Add("@name", MySqlDbType.VarChar);
            dataAdapter_customer.InsertCommand.Parameters.Add("@address", MySqlDbType.VarChar);
            dataAdapter_customer.InsertCommand.Parameters.Add("@phone", MySqlDbType.VarChar);
            
            dataAdapter_customer.InsertCommand.Parameters["@name"].Value = rowDatas[0];
            dataAdapter_customer.InsertCommand.Parameters["@address"].Value = rowDatas[1];
            dataAdapter_customer.InsertCommand.Parameters["@phone"].Value = rowDatas[2];

            try
            {
                conn.Open();
                dataAdapter_customer.InsertCommand.ExecuteNonQuery();

                dataSet.Clear();                                        // 이전 데이터 지우기
                dataAdapter_customer.Fill(dataSet, "customer");                      // DB -> DataSet
                dataGridView2.DataSource = dataSet.Tables["customer"];      // dataGridView에 테이블 표시                                     // 텍스트 박스 내용 지우기
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void custbtn_update_Click(object sender, EventArgs e)
        {
            string[] rowDatas = {
                tbcustid.Text,
                tbname.Text,
                tbaddress.Text,
                tbphone.Text };
            UpdateRow_cust(rowDatas);
            this.Close();
        }
        internal void UpdateRow_cust(string[] rowDatas)
        {
            string sql = "UPDATE customer SET name=@name, address=@address, phone=@phone WHERE custid=@custid";
            dataAdapter_customer.UpdateCommand = new MySqlCommand(sql, conn);
            dataAdapter_customer.UpdateCommand.Parameters.AddWithValue("@custid", rowDatas[0]);
            dataAdapter_customer.UpdateCommand.Parameters.AddWithValue("@name", rowDatas[1]);
            dataAdapter_customer.UpdateCommand.Parameters.AddWithValue("@address", rowDatas[2]);
            dataAdapter_customer.UpdateCommand.Parameters.AddWithValue("@phone", rowDatas[3]);

            try
            {
                conn.Open();
                dataAdapter_customer.UpdateCommand.ExecuteNonQuery();

                dataSet.Clear();  // 이전 데이터 지우기
                dataAdapter_customer.Fill(dataSet, "customer");
                dataGridView2.DataSource = dataSet.Tables["customer"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void custbtn_delete_Click(object sender, EventArgs e)
        {
            int id;
            string sql = "DELETE FROM customer WHERE custid=@custid";
            dataAdapter_customer.DeleteCommand = new MySqlCommand(sql, conn);
            dataAdapter_customer.DeleteCommand.Parameters.Add("@custid", MySqlDbType.Int32); // dataGridView1에서 선택된 행(row) 정보 가져오기
            id = (int)dataGridView2.SelectedRows[0].Cells["custid"].Value;
            dataAdapter_customer.DeleteCommand.Parameters["@custid"].Value = id;

            #region DeleteCommand를 이용한 처리
            try
            {
                conn.Open();
                dataAdapter_customer.DeleteCommand.ExecuteNonQuery();

                dataSet.Clear();
                dataAdapter_customer.Fill(dataSet, "customer");
                dataGridView2.DataSource = dataSet.Tables["customer"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            #endregion
        }

        private void custbtn_clear_Click(object sender, EventArgs e)
        {
            tbcustid.Clear();
            tbname.Clear();
            tbaddress.Clear();
            tbphone.Clear();
        }

        private void orderbtn_select_Click(object sender, EventArgs e)
        {
            string queryStr;
            #region 예제 코드
            string[] conditions = new string[5];  
            conditions[0] = (ordertborderid.Text != "") ? "orderid=@orderid" : null;
            conditions[1] = (cmbcustid.Text != "") ? "custid=@custid" : null;
            conditions[2] = (cmbbookid.Text != "") ? "bookid=@bookid" : null;
            conditions[3] = (ordertbsaleprice.Text != "") ? "saleprice=@saleprice" : null;
            conditions[4] = (cmborderdate.Text != "") ? "orderdate=@orderdate" : null;


            if (conditions[0] != null || conditions[1] != null || conditions[2] != null || conditions[3] != null || conditions[4] != null)
            {
                queryStr = $"SELECT * FROM orders WHERE ";
                bool firstCondition = true;
                for (int i = 0; i < conditions.Length; i++)
                {
                    if (conditions[i] != null)
                        if (firstCondition)
                        {
                            queryStr += conditions[i];
                            firstCondition = false;
                        }
                        else
                        {
                            queryStr += " and " + conditions[i];
                        }
                }
            }
            else
            {
                queryStr = "SELECT * FROM orders";
            }
            #endregion

            #region SelectCommand 객체 생성 및 Parameters 설정
            dataAdapter_orders.SelectCommand = new MySqlCommand(queryStr, conn);
            dataAdapter_orders.SelectCommand.Parameters.AddWithValue("@orderid", ordertborderid.Text);
            dataAdapter_orders.SelectCommand.Parameters.AddWithValue("@custid", cmbcustid.Text);
            dataAdapter_orders.SelectCommand.Parameters.AddWithValue("@bookid", cmbbookid.Text);
            dataAdapter_orders.SelectCommand.Parameters.AddWithValue("@saleprice", ordertbsaleprice.Text);
            dataAdapter_orders.SelectCommand.Parameters.AddWithValue("@orderdate", cmborderdate.Text);
            #endregion

            try
            {
                conn.Open();
                dataSet.Clear();
                if (dataAdapter_orders.Fill(dataSet, "orders") > 0)
                    dataGridView3.DataSource = dataSet.Tables["orders"];
                else
                    MessageBox.Show("찾는 데이터가 없습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void orderbtn_insert_Click(object sender, EventArgs e)
        {
            Form3 Dig = new Form3();
            Dig.Owner = this;               // 새로운 폼의 부모가 Form1 인스턴스임을 지정
            Dig.ShowDialog();               // 폼 띄우기(Modal)
            Dig.Dispose();
        }

        public void InsertRow_orders(string[] rowDatas)
        {
            string queryStr = "INSERT INTO orders (custid, bookid, saleprice, orderdate) " +
                "VALUES(@custid, @bookid, @saleprice, @orderdate)";
            dataAdapter_orders.InsertCommand = new MySqlCommand(queryStr, conn);
            dataAdapter_orders.InsertCommand.Parameters.Add("@custid", MySqlDbType.Int32);
            dataAdapter_orders.InsertCommand.Parameters.Add("@bookid", MySqlDbType.Int32);
            dataAdapter_orders.InsertCommand.Parameters.Add("@saleprice", MySqlDbType.Int32);
            dataAdapter_orders.InsertCommand.Parameters.Add("@orderdate", MySqlDbType.VarChar);

            dataAdapter_orders.InsertCommand.Parameters["@custid"].Value = rowDatas[0];
            dataAdapter_orders.InsertCommand.Parameters["@bookid"].Value = rowDatas[1];
            dataAdapter_orders.InsertCommand.Parameters["@saleprice"].Value = rowDatas[2];
            dataAdapter_orders.InsertCommand.Parameters["@orderdate"].Value = rowDatas[3];

            try
            {
                conn.Open();
                dataAdapter_orders.InsertCommand.ExecuteNonQuery();

                dataSet.Clear();                                        // 이전 데이터 지우기
                dataAdapter_orders.Fill(dataSet, "orders");                      // DB -> DataSet
                dataGridView3.DataSource = dataSet.Tables["orders"];      // dataGridView에 테이블 표시                                     // 텍스트 박스 내용 지우기
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        internal void UpdateRow_orders(string[] rowDatas)
        {
            string sql = "UPDATE orders SET custid=@custid, bookid=@bookid, saleprice=@saleprice, orderdate=@orderdate WHERE orderid=@orderid";
            dataAdapter_orders.UpdateCommand = new MySqlCommand(sql, conn);
            dataAdapter_orders.UpdateCommand.Parameters.AddWithValue("@orderid", rowDatas[0]);
            dataAdapter_orders.UpdateCommand.Parameters.AddWithValue("@custid", rowDatas[1]);
            dataAdapter_orders.UpdateCommand.Parameters.AddWithValue("@bookid", rowDatas[2]);
            dataAdapter_orders.UpdateCommand.Parameters.AddWithValue("@saleprice", rowDatas[3]);
            dataAdapter_orders.UpdateCommand.Parameters.AddWithValue("@orderdate", rowDatas[4]);

            try
            {
                conn.Open();
                dataAdapter_orders.UpdateCommand.ExecuteNonQuery();

                dataSet.Clear();  // 이전 데이터 지우기
                dataAdapter_orders.Fill(dataSet, "orders");
                dataGridView3.DataSource = dataSet.Tables["orders"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void orderbtn_delete_Click(object sender, EventArgs e)
        {
            int id;
            string sql = "DELETE FROM orders WHERE orderid=@orderid";
            dataAdapter_orders.DeleteCommand = new MySqlCommand(sql, conn);
            dataAdapter_orders.DeleteCommand.Parameters.Add("@orderid", MySqlDbType.Int32); // dataGridView1에서 선택된 행(row) 정보 가져오기
            id = (int)dataGridView3.SelectedRows[0].Cells["orderid"].Value;
            dataAdapter_orders.DeleteCommand.Parameters["@orderid"].Value = id;

            #region DeleteCommand를 이용한 처리
            try
            {
                conn.Open();
                dataAdapter_orders.DeleteCommand.ExecuteNonQuery();

                dataSet.Clear();
                dataAdapter_orders.Fill(dataSet, "orders");
                dataGridView3.DataSource = dataSet.Tables["orders"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            #endregion
        }

        private void orderbtn_clear_Click(object sender, EventArgs e)
        {
            ordertborderid.Clear();
            cmbcustid.Text = "";
            cmbbookid.Text = "";
            ordertbsaleprice.Clear();
            cmborderdate.Text = "";
        }
    }
}