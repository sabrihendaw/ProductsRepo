using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace products.PL
{
    public partial class F_LOGIN : Form
    {
        BL.CLS_LOGIN Log = new BL.CLS_LOGIN();
        public F_LOGIN()
        {
            InitializeComponent();
        }

        private void B_CLOSE_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void B_LOGIN_Click(object sender, EventArgs e)
        {

            DataTable DT = Log.LOGIN(T_ID.Text, T_PWD.Text);
            if(DT.Rows.Count>0)
            {
               // MessageBox.Show("Login success!");
                F_Main.getMainForm.المنتوجاتToolStripMenuItem.Enabled = true;
                F_Main.getMainForm.المستخدمونToolStripMenuItem.Enabled = true;
                F_Main.getMainForm.العملاءToolStripMenuItem.Enabled = true;
                F_Main.getMainForm.انشاءنسخةاحتياطيةToolStripMenuItem.Enabled = true;
                F_Main.getMainForm.استعادةنسخةاحتياطيةToolStripMenuItem.Enabled = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Login failed!");
            } 
        }
    }
}
