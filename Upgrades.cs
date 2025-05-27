using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using WindowsFormsApp7.Properties;
namespace WindowsFormsApp7
{
    public partial class Upgrades : Form
    {
        int req = 10;
        int sum1 = 1;
        public int MultiRan = 1;
        public int TokenM = 1;

        public Upgrades()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void promotebt_Click(object sender, EventArgs e)
        {
            
        }

        private void Upgrades_Load(object sender, EventArgs e)
        {
            if(DataBlank.Str1 >= 20)
            {
                groupBox1.Visible = true;
                label6.Visible = false;
            }
            if (DataBlank.laser)
            {
                groupBox2.Visible = true;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
