using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class UpgradeRank : Form
    {
        int rankcount = 1;

        public UpgradeRank()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rankcount++;
            if(rankcount == 2) DataBlank.rankmulti *= rankcount;
            if (rankcount == 3) DataBlank.rankmulti *= 10;


        }

        private void UpgradeRank_Load(object sender, EventArgs e)
        {
            if (rankcount == 1)
            {
                xtokens.Text = $"{rankcount}x tokens";
                xpower.Text = $"{rankcount}x power";
            }
            this.Close();
        }
    }
}
