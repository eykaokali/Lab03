using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Lab03
{
    public partial class fTV : Form
    {
        public TV TheTV;
        private object chbIsSmart;

        public fTV(TV t)
        {
            TheTV = t;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            TheTV.model = tbModel.Text.Trim();
            TheTV.brand = tbBrand.Text.Trim();
            TheTV.screenSize = int.Parse(tbSize.Text.Trim());
            TheTV.resolution = tbResolution.Text.Trim();
            TheTV.isSmart = rbYes.Checked;
            TheTV.color = tbColor.Text.Trim();
            TheTV.price = float.Parse(tbPrice.Text.Trim());

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void fTV_Load_1(object sender, EventArgs e)
        {
             if (TheTV != null)
            {
                tbModel.Text = TheTV.model;
                tbBrand.Text = TheTV.brand;
                tbSize.Text = TheTV.screenSize.ToString();
                tbResolution.Text = TheTV.resolution;
                tbColor.Text = TheTV.color;
                tbPrice.Text = TheTV.price.ToString("0.00");
                if (TheTV.isSmart) {rbYes.Checked = true;}
                else {rbNo.Checked = true;}
            }
        }
    }
}
