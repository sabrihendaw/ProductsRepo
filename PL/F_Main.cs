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
    public partial class F_Main : Form
    {
        private static F_Main frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static F_Main getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new F_Main();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;  
            }
           
        }
        public F_Main()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.العملاءToolStripMenuItem.Enabled = false;
            this.المنتوجاتToolStripMenuItem.Enabled = false;
            this.المستخدمونToolStripMenuItem.Enabled = false;
            this.انشاءنسخةاحتياطيةToolStripMenuItem.Enabled = false;
            this.استعادةنسخةاحتياطيةToolStripMenuItem.Enabled = false;
   


        }

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_LOGIN frm = new F_LOGIN();
            frm.ShowDialog();
        }

        private void اضافةمنتوججديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            F_Add_Product frm = new F_Add_Product();
            frm.ShowDialog();
        }
         
        private void F_Main_Load(object sender, EventArgs e)
        {

        }
    }
}
