using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApp7
{
    public partial class Beggining : Form
    {
        SoundPlayer DarkEnergy = new SoundPlayer(@"C:\SHP\Music\DarkEnergy.wav");
        SoundPlayer TheRuler = new SoundPlayer(@"C:\SHP\Music\TheRuler.wav");
        SoundPlayer MartialArts = new SoundPlayer(@"C:\SHP\Music\MartialArts.wav");
        SoundPlayer Illusion = new SoundPlayer(@"C:\SHP\Music\Illusion.wav");
        Timer token1;
        Timer gem1;


        public int reqen = 100;
        public int reqpsi = 100;
        public int reqstr = 100;
        public int tokens = 0;
        public int TotalPower = 3;
        public int Endurance = 1;
        public int Psychic = 1;
        public int Strength = 1;
        public int gems1 = 0;
        public int standartcl = 1;
        public int rankmulti = 1;
        public int multien = 1;
        public int multipsi = 1;
        public int multistr = 1;
        public Beggining()
        {
            
            InitializeComponent();
            gem1 = new Timer();
            gem1.Interval = 30000;
            gem1.Tick += gamegain;
            token1 = new Timer();
            token1.Interval = 5;
            token1.Tick += tokengain;
            gem1.Start();
            token1.Start();
        }

        private void gamegain(object sender, EventArgs e)
        {
            gems1 += 100;
            Gems.Text = $"{gems1}";
        }

        private void tokengain(object sender, EventArgs e)
        {
            tokens+=10;
            Tokens.Text = $"{tokens}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Stats statsr = new Stats();
            Psychic += standartcl * multipsi * rankmulti;
            TotalPower += standartcl * multipsi * rankmulti;
            if (Endurance >= 30 && Strength >= 20 && Psychic >= 30)
            {
                button1.Enabled = true;
            }
            tp.Text = $"{TotalPower}";
            Psy.Text = $"Psychic: {Psychic}";
            DataBlank.Psi1 = Psychic;
            //Psychic Click Action
        }

        private void Menust_Click(object sender, EventArgs e)
        {
            
            DataBlank.Total1 = TotalPower;
            DataBlank.tokens = tokens;
            DataBlank.multien = multien;
            DataBlank.multipsi = multipsi;
            DataBlank.multistr = multistr;
            Console.WriteLine(DataBlank.Total1);
            Console.WriteLine(DataBlank.multien);
            Stats statsr = new Stats();
            statsr.ShowDialog();
            //This sh* doesn't work so i made everything on form1.
        }

        private void Endr_Click(object sender, EventArgs e)
        {
            Endurance += standartcl * multien * rankmulti;
            TotalPower += standartcl * multien * rankmulti;
            tp.Text = $"{TotalPower}";
            if (Endurance >= 30 && Strength >=20 && Psychic >=30 )
            {
                button1.Enabled = true;
            }
            End.Text = $"Endurance: {Endurance}";

            DataBlank.End1 = Endurance;
            //Endurance Click Action
        }

        private void Stren_Click(object sender, EventArgs e)
        {
            Strength += standartcl *multistr *  rankmulti;
            TotalPower += standartcl * multistr * rankmulti;
            tp.Text = $"{TotalPower}";
            if (Endurance >= 30 && Strength >= 20 && Psychic >= 30)
            {
                button1.Enabled = true;
            }
            Str.Text = $"Strength: {Strength} ";
            DataBlank.Str1 = Strength;
            //Strength Click Action

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Upgrades upg = new Upgrades();
            upg.ShowDialog();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Random rnd = new Random();
                int Rand = rnd.Next(1, 5);
                Console.WriteLine(Rand);
                if (Rand == 1) DarkEnergy.Play();
                if (Rand == 2) TheRuler.Play();
                if (Rand == 3) MartialArts.Play();
                if (Rand == 4) Illusion.Play();

            }
            //Random songs
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            DarkEnergy.Stop();
            MartialArts.Stop();
            TheRuler.Stop();
            Illusion.Stop();
           //Stop playing music
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Psy.Text = $"Psychic: {Psychic}";
            Str.Text = $"Strength: {Strength}";
            End.Text = $"Endurance: {Endurance}";
            tp.Text = $"{TotalPower}";
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            //Loading labels correct.
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.ToString() == "S")
            {
                DarkEnergy.Stop();
                MartialArts.Stop();
                TheRuler.Stop();
                Illusion.Stop();
            }
            if (e.KeyValue == (char)Keys.E)
            {
                Random rnd1 = new Random();
                int Rand1 = rnd1.Next(1, 5);
                Console.WriteLine("AS");
                if (Rand1 == 1) DarkEnergy.Play();
                if (Rand1 == 2) TheRuler.Play();
                if (Rand1 == 3) MartialArts.Play();
                if (Rand1 == 4) Illusion.Play();
            }
            //Random song on keys doesn't work! It's not fair.
            
               
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (tokens >= reqen)
            {
                tokens -= reqen;
                Tokens.Text = $"{tokens}";
                multien *= 2;
                reqen *= 2;

                Console.WriteLine(multien);
                Endmulti.Text = $"{multien}x";
            }
            //Endurance multi
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (tokens >= reqstr)
            {
                tokens -= reqstr;
                Tokens.Text = $"{tokens}";
                multistr *= 2;
                reqstr *= 2;

                Console.WriteLine(multistr);
                Strmulti.Text = $"{multistr}x";
            }
            //Strength multi
        }

        private void Upgmultipsi_Click(object sender, EventArgs e)
        {
            if (tokens >= reqpsi)
            {
                tokens -= reqpsi;
                Tokens.Text = $"{tokens}";
                multipsi *= 2;
                reqpsi *= 2;


                Console.WriteLine(multipsi);
                Psimulti.Text = $"{multipsi}x";
            }
            //Psychic multi
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            label3.Text = $"Costs: {reqen}";

        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            label3.Text = $"Costs: {reqstr}";
        }

        private void Upgmultipsi_MouseEnter(object sender, EventArgs e)
        {
            label3.Text = $"Costs: {reqpsi}";
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            label3.Text = $"Costs: 0";
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            label3.Text = $"Costs: 0";
        }

        private void Upgmultipsi_MouseLeave(object sender, EventArgs e)
        {
            label3.Text = $"Costs: 0";
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            DataBlank.Str1 = Strength;
            DataBlank.End1 = Endurance;
            DataBlank.Psi1 = Psychic;
            Stats t = new Stats();
            t.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataBlank.Str1 = Strength;
            DataBlank.End1 = Endurance;
            DataBlank.Psi1 = Psychic;
            Upgrades skill = new Upgrades();
            skill.ShowDialog();
        }

        private void Strmulti_Click(object sender, EventArgs e)
        {

        }
    }
}
