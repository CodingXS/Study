using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Study
{
    /// <summary>
    /// 自动出题，练习SWITCH CASE
    /// </summary>
    public partial class frmAuto : Form
    {
        double result;//运算结果
        
        public frmAuto()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblNum1.Visible = false;
            lblNum2.Visible = false;
            lblOp.Visible = false;
        }
        /// <summary>
        /// 点击按钮生成随机数,以及随机的运算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnQuestion_Click(object sender, EventArgs e)
        {
            lblNum1.Visible = true;
            lblNum2.Visible = true;
            lblOp.Visible = true;
            Random rb = new Random();
            int num1 = rb.Next(9) + 1;//1到9的数
            int num2 = rb.Next(9) + 1;//1到9的数
            int op = rb.Next(4);
            lblNum1.Text = num1.ToString();
            lblNum2.Text = num2.ToString();
            switch (op)
            {
                case 0:
                    lblOp.Text = "+";
                    result = num1 + num2;
                    break;
                case 1:
                    lblOp.Text = "-";
                    result = num1 - num2;
                    break;
                case 2:
                    lblOp.Text = "*";
                    result = num1 * num2;
                    break;
                case 3:
                    lblOp.Text = "/";
                    result = num1 / num2;
                    break;
            }
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtResult.Text))
            {
                MessageBox.Show("请输入答案！！", "提示", MessageBoxButtons.OK);
                return;
            }
            string strJudge = "";
            double res = double.Parse(txtResult.Text);
            string str = lblNum1.Text + lblOp.Text + lblNum2.Text + "="+txtResult.Text;
            strJudge = res == result ? str +" √" : str+ "×";
            lsbResult.Items.Add(strJudge);
        }
    }
}
