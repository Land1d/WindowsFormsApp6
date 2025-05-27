using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp7.Properties;
using System.Drawing;
namespace WindowsFormsApp7
{
    public partial class Stats : Form
    {
        public int reqen = 100;
        public int wave = 1;
        public int reqstr = 100;
        public int reqpsi = 100;
        public double hpm = 100;
        public double hpm1 = 100;
        public int attackm = 15;
        public int psym = 80;
        public int attackmm = 1;
        public int attackp = DataBlank.Str1;
        public int hpp = DataBlank.End1;
        public int psyp = DataBlank.Psi1;
        public bool skillL = false;
        public int monstercount = 0;
        string Ancient1 = "Holy sword! (Double attack)";
        string Ancient2 = "Devil Shield! (Double hp) ";
        string Ancient3 = "Pre-historical Armour! (Triple hp";
        string Ancient4 = "Ring of eternity! (Double psychic powers)";
        string Ancient5 = "New skill: 'Laser of destruction'";

        public Stats()
        {
            InitializeComponent();

        }

        private void Str_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Stats_Load(object sender, EventArgs e)
        {
            label3.Text = $"{hpp}";
            label4.Text = $"{hpm}";
            label6.Text = $"{psyp}";
            label9.Text = $"{attackp}";
            label10.Text = $"Wave: {wave}";
        }

        private void Upgmultien_Click(object sender, EventArgs e)
        {
            if (DataBlank.tokens >= reqen)
            {

                StatsMulti fk = new StatsMulti();
                fk.ShowDialog();
            }
        }


        private void Stats_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.ToString() == "R" && hpm > 0)
            {
                hpm -= attackp;
                if (hpm > 0)
                {
                    Random rnd1 = new Random();
                    int r = rnd1.Next(1, 3);
                    Random rnd12 = new Random();
                    int r1 = rnd12.Next(1, 3);
                    if (r1 == 1) 
                    {
                        hpp -= r * attackmm;

                        label3.Text = $"{hpp}";
                        
                        Mdeal.Text = $"Monster damaged you on: {r * attackmm} hp";
                    }
                    if (r1 == 2)
                    {
                        psyp -= r;
                        
                        label6.Text = $"{psyp}";
                       
                        Mdeal.Text = $"Monster damaged you on: {r} Psychic";
                    }

                    
                }

                
                
                label3.Text = $"{hpp}";
                label4.Text = $"{hpm}";
                
                if (hpp <= 0 || psyp <= 0)
                {               
                    this.Close();
                }


                if (hpm <= 0)
                {
                    button1.Enabled = true;
                    monstercount++;
                    attackmm *= 2;
                    Random an1 = new Random();
                    int ancient1 = an1.Next(1, 4);
                    label4.Text = "0";


                    if (ancient1 == 3)
                    {
                        Random an = new Random();
                        int ancient = 5;
                        pictureBox1.Visible = false;
                        label5.Visible = true;
                        label7.Visible = true;
                        if (ancient == 1)
                        {
                            label7.Text = $"{Ancient1}";
                            attackp *= 2;
                        }
                        if (ancient == 2)
                        {
                            label7.Text = $"{Ancient2}";
                            hpp *= 2;
                        }
                        if (ancient == 3)
                        {
                            label7.Text = $"{Ancient3}";
                            hpp *= 3;
                        }
                        if (ancient == 4)
                        {
                            label7.Text = $"{Ancient4}";
                            psyp *= 2;
                        }
                        if (ancient == 5)
                        {
                            if (skillL == false)
                            {
                                label7.Text = $"{Ancient5}";
                                skillL = true;
                                DataBlank.laser = skillL;
                            }

                        }


                    }
                }

            }
                 

            if (e.KeyData.ToString() == "G" && hpm > 0)
            {
                if (hpm > 0)
                {
                    Random rnd1 = new Random();
                    int r = rnd1.Next(1, 3);
                    Random rnd12 = new Random();
                    int r1 = rnd12.Next(1, 3);
                    if (r1 == 1)
                    {
                        hpp -= r * attackmm;

                        label3.Text = $"{hpp}";

                        Mdeal.Text = $"Monster damaged you on: {r * attackmm} hp";
                    }
                    if (r1 == 2)
                    {
                        psyp -= r;

                        label6.Text = $"{psyp}";

                        Mdeal.Text = $"Monster damaged you on: {r} Psychic";
                    }


                }

                hpm -= (int)((float)attackp * 1.5);

                label3.Text = $"{hpp}";
                label4.Text = $"{hpm}";

                if (hpp <= 0 || psyp <= 0)
                {
                    Console.WriteLine("You died");
                    this.Close();
                }




            }
            if (hpm <= 0)
            {
                button1.Enabled = true;
                monstercount++;
                Random rndStr = new Random();
                int r1 = rndStr.Next(2, 5);
                attackmm *= r1;
           
                Random an1 = new Random();
                int ancient1 = an1.Next(1, 7);
                label4.Text = "0";


                if (ancient1 == 3)
                {
                    Random an = new Random();
                    int ancient = an.Next(1,5);
                    pictureBox1.Visible = false;
                    label5.Visible = true;
                    label7.Visible = true;
                    if (ancient == 1)
                    {
                        label7.Text = $"{Ancient1}";
                        attackp *= 2;
                    }
                    if (ancient == 2)
                    {
                        label7.Text = $"{Ancient2}";
                        hpp *= 2;
                    }
                    if (ancient == 3)
                    {
                        label7.Text = $"{Ancient3}";
                        hpp *= 3;
                    }
                    if (ancient == 4)
                    {
                        label7.Text = $"{Ancient4}";
                        psyp *= 2;
                    }

                }
            }
         }

        private void button1_Click(object sender, EventArgs e)
        {
            if (hpm <= 0)
            {

                wave++;

                var rnd3 = new Random();

                // float on [0.0f, 1.0f)
                float frac = (float)rnd3.NextDouble();

                // float on [min, max)
                float min = 1.2f, max = 2f;
                float value = (float)(rnd3.NextDouble() * (max - min) + min);


              

                hpm1 *= value;
                hpm1 = (int)Math.Round(hpm1);
                hpm = hpm1;

                Random ran = new Random();
                int ras = ran.Next(2, 4);
                pictureBox1.Visible = true;
                if (monstercount == 1)
                {
                    pictureBox1.Image = Resources.worm_attack;
                }
                if(ras == 2 && monstercount!=1)
                {
                   
                }
                if (ras == 3 && monstercount != 1)
                {
                    pictureBox1.Image = Resources.StSL;
                }
                label3.Text = $"{hpp}";
                label4.Text = $"{hpm}";
                label6.Text = $"{psyp}";
                label9.Text = $"{attackp}";
                label10.Text = $"Wave: {wave}";

                label5.Visible = false;
                label7.Visible = false;
                button1.Enabled = false;
            }
            //yay
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }

