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
    public partial class Form2 : Form
    {
        private string bookid;
        private string bookname;
        private string publisher;
        private string price;
        //private int selectedRowIndex;

        public Form2()
        {
            InitializeComponent();
            //this.selectedRowIndex = selectedRowIndex;
            //this.bookid = v1;
            //this.bookname = v2;
            //this.publisher = v3;
            //this.price = v4;
        }

        Form1 mainForm;

        private void Form2_Load(object sender, EventArgs e)
        {
            txt_bookid.Text = bookid;
            txt_bookname.Text = bookname;
            txt_publisher.Text = publisher;
            txt_price.Text = price;

            if (Owner != null)
            {
                mainForm = Owner as Form1;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string[] rowDatas = {
                txt_bookname.Text,
                txt_publisher.Text,
                txt_price.Text };
            mainForm.InsertRow_book(rowDatas);
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string[] rowDatas = {
                txt_bookid.Text,
                txt_bookname.Text,
                txt_publisher.Text,
                txt_price.Text };
            mainForm.UpdateRow_book(rowDatas);
            this.Close();
        }

        private void btnTextBoxClear_Click(object sender, EventArgs e)
        {
            txt_bookid.Clear();
            txt_bookname.Clear();
            txt_publisher.Clear();
            txt_price.Clear();
        }
    }
}
