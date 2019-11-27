namespace WinFormProject
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_publisher = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_bookname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_bookid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnTextBoxClear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_price);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_publisher);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_bookname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_bookid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 138);
            this.panel1.TabIndex = 0;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(90, 106);
            this.txt_price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(187, 21);
            this.txt_price.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "price";
            // 
            // txt_publisher
            // 
            this.txt_publisher.Location = new System.Drawing.Point(90, 75);
            this.txt_publisher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_publisher.Name = "txt_publisher";
            this.txt_publisher.Size = new System.Drawing.Size(187, 21);
            this.txt_publisher.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "publisher";
            // 
            // txt_bookname
            // 
            this.txt_bookname.Location = new System.Drawing.Point(90, 44);
            this.txt_bookname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_bookname.Name = "txt_bookname";
            this.txt_bookname.Size = new System.Drawing.Size(187, 21);
            this.txt_bookname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "bookname";
            // 
            // txt_bookid
            // 
            this.txt_bookid.Location = new System.Drawing.Point(90, 13);
            this.txt_bookid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_bookid.Name = "txt_bookid";
            this.txt_bookid.Size = new System.Drawing.Size(187, 21);
            this.txt_bookid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "bookid";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(317, 48);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(187, 26);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(317, 82);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(187, 26);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnTextBoxClear
            // 
            this.btnTextBoxClear.Location = new System.Drawing.Point(317, 115);
            this.btnTextBoxClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTextBoxClear.Name = "btnTextBoxClear";
            this.btnTextBoxClear.Size = new System.Drawing.Size(187, 26);
            this.btnTextBoxClear.TabIndex = 6;
            this.btnTextBoxClear.Text = "Clear";
            this.btnTextBoxClear.UseVisualStyleBackColor = true;
            this.btnTextBoxClear.Click += new System.EventHandler(this.btnTextBoxClear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(184, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Insert and Update";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 185);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTextBoxClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_publisher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_bookname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_bookid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnTextBoxClear;
        private System.Windows.Forms.Label label6;
    }
}