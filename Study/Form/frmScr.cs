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
    public partial class frmDel : Form
    {
        public frmDel()
        {
            InitializeComponent();
        }
        int lblX = 8;
        int lblY = 10;

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblCon.Left += lblX;
            lblCon.Top += lblY;
            if (lblCon.Left < 0 || (lblCon.Left + lblCon.Width > Width))
            {
                lblX = -lblX;
            }
            if (lblCon.Top < 0 || (lblCon.Top + lblCon.Height > Height))
            {
                lblY = -lblY;
            }
        }

        private void FrmDel_KeyDown(object sender, KeyEventArgs e)
        {
            Application.Exit();
        }
    }
}
