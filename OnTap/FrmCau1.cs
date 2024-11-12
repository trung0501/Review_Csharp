using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTap
{
    public partial class FrmCau1 : Form
    {
        public FrmCau1()
        {
            InitializeComponent();
        }

        private void câu2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCau2 f = new FrmCau2();
            f.Show();
        }

        private void câu3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCau3 f = new FrmCau3();
            f.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void câu4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCau4 f = new FrmCau4();
            f.Show();
        }
    }
}
