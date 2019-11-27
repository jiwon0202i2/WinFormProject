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
    public partial class Form3 : Form
    {
        private string orderid;
        private string custid;
        private string bookid;
        private string saleprice;
        private string orderdate;

        public Form3()
        {
            InitializeComponent();
        }

        Form1 mainForm;

        private void Form3_Load(object sender, EventArgs e)
        {
            txt_orderid.Text = orderid;
            txt_custid.Text = custid;
            txt_bookid.Text = bookid;
            txt_saleprice.Text = saleprice;
            txt_orderdate.Text = orderdate;

            if (Owner != null)
            {
                mainForm = Owner as Form1;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string[] rowDatas = {
                txt_custid.Text,
                txt_bookid.Text,
                txt_saleprice.Text,
                txt_orderdate.Text};
            mainForm.InsertRow_orders(rowDatas);
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string[] rowDatas = {
                txt_orderid.Text,
                txt_custid.Text,
                txt_bookid.Text,
                txt_saleprice.Text,
                txt_orderdate.Text};
            mainForm.UpdateRow_orders(rowDatas);
            this.Close();
        }

        private void btnTextBoxClear_Click(object sender, EventArgs e)
        {
            txt_orderid.Clear();
            txt_custid.Clear();
            txt_bookid.Clear();
            txt_saleprice.Clear();
            txt_orderdate.Clear();
        }
    }
}
