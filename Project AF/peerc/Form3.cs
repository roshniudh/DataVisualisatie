using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace peerc
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e) //zuidwest
        {
            hide_all_labels();
            pictureBox6.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e) // Leidsche Rijn
        {
            hide_all_labels();
            pictureBox3.Visible = true;

        }


        private void label2_Click_1(object sender, EventArgs e) //Vleuten de Meern
        {
            hide_all_labels();
            pictureBox2.Visible = true;
        }

        public void hide_all_labels()
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            pictureBox1.Visible = false;
            button1.Visible = true;
        }

        private void label6_Click(object sender, EventArgs e)  // West
        {
            hide_all_labels();
            pictureBox4.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e) //zuid
        {
            hide_all_labels();
            pictureBox10.Visible = true;

        }

        private void label4_Click(object sender, EventArgs e) //noordwest
        {
            hide_all_labels();
            pictureBox5.Visible = true;
        }

        private void label8_Click(object sender, EventArgs e) //binnenstad
        {
            hide_all_labels();
            pictureBox11.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e) //overvecht
        {
            pictureBox7.Visible = true;
            hide_all_labels();
        }

        private void label10_Click(object sender, EventArgs e) //noordoost
        {
            pictureBox8.Visible = true;
            hide_all_labels();
        }

        private void label7_Click(object sender, EventArgs e) //oost
        {
            pictureBox9.Visible = true;
            hide_all_labels();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            show_all();
        }

        public void show_all()
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            button1.Visible = false;
        }
    }
}
