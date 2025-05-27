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
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 12;
            if (panel2.Width >= panel1.Width)
            {
                
                timer1.Stop();
                Beggining frm1 = new Beggining();
                this.Hide();
                frm1.ShowDialog();
                this.Close();



            }
        }

        private void Loading_Load(object sender, EventArgs e)
        {

        }
    }
}
