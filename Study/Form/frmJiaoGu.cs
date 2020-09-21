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
    /// 角谷猜想 （循环）
    /// 任何一个数进行以下运算都会变成1
    /// 如果是奇数 *3+1
    /// 如果是偶数 /2
    /// </summary>
    public partial class frmJiaoGu : Form
    {
        public frmJiaoGu()
        {
            InitializeComponent();
        }

        private void FrmJiaoGu_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= 100; i++)
            {
                string result = "NO:"+i.ToString()+"==>";
                int m = i;
                while (m != 1)
                {
                    result = result + " " + m.ToString();
                    if (m % 2 == 0)
                    {
                        m /= 2;
                    }
                    else
                    {
                        m = m * 3 + 1;
                    }
                }
                result = result + " " + m.ToString() + "\r\n";
                sb.AppendLine(result);
            }
            txtResult.Text = sb.ToString();
        }
    }
}
