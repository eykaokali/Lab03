using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnAddTV_Click(object sender, EventArgs e)
        {
            TV tv = new TV();
            fTV ftv = new fTV(tv);
            if (ftv.ShowDialog()== DialogResult.OK)
            {
                tbTVInfo.Text +=
                    string.Format("{0}, {1}, {2}, {3}, {4}, {5}грн, {6}, Площа екрану{7}.", tv.model, tv.brand, tv.screenSize, tv.resolution,
                    tv.color, tv.price, tv.isSmart ? "Є смарт" : "Не має смарту", tv.area);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?", "Припинити роботу",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }
    }
}
