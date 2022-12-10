using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final
{
    public partial class CRfrm : Form
    {
        public CRfrm()
        {
            InitializeComponent();
        }

        private void CRfrm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void IDatepicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Clbtn_Click(object sender, EventArgs e)
        {
            DNtb.Clear();
            IDatepicker.Refresh();
            WNtb.Clear();
            IDtb.Clear();
            GNtb.Clear();
            Qtb.Clear();
            UPtb.Clear();
            IMtb.Clear();

        }
    }
}
