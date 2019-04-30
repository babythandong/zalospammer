using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZaloSpammer
{
    public partial class ZaloForm : Form
    {
        public ZaloForm()
        {
            InitializeComponent();
        }
        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.pnContent.Controls.Count > 0)
                this.pnContent.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnContent.Controls.Add(fh);
            this.pnContent.Tag = fh;
            fh.Show();
        }

        private void BtnKetbanMenu_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new KetBanZalo());
        }

        private void BtnSpamMenu_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new SpamZalo());
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn chắc chắn muốn thoát chương trình ??",
                                     "Confirm Close!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

       
    }
}
