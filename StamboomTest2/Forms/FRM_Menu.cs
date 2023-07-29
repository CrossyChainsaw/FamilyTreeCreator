using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StamboomTest2.Forms
{
    public partial class FRM_Menu : Form
    {
        public FRM_Menu()
        {
            InitializeComponent();
        }

        private void BTN_Create_Click(object sender, EventArgs e)
        {
            FRM_Create frm = new FRM_Create();
            frm.Show();
        }

        private void FRM_View_Click(object sender, EventArgs e)
        {
            FRM_View frm = new FRM_View();
            frm.Show();
        }

        private void BTN_Edit_Click(object sender, EventArgs e)
        {
            FRM_Edit frm = new FRM_Edit();
            frm.Show();
        }
    }
}
