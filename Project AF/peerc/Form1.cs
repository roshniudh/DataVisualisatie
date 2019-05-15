using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace peerc
{
    public partial class Geweld_Diagram : Form
    {
        public Geweld_Diagram()
        {
            InitializeComponent();
        }

        int poepjes = 1;
        int scheetjes = 1;

        private void Form1_Load(object sender, EventArgs e)
        {   //Wijk knop
            chart1.Titles.Add("Geweld");
            chart2.Titles.Add("Pie Chart");
            sql("Select wijk,geweld_totaal from wijkgeweld", "wijk", "geweld_totaal");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // refresh knop
            poepjes = 1;
            sql("Select wijk,geweld_totaal from wijkgeweld", "wijk", "geweld_totaal");
            chart1.Series["Geweld"].Points.Clear();
            chart2.Series["Geweld"].Points.Clear();
        }
    
        private void button2_Click(object sender, EventArgs e)
        {
            //Clear Knop
            poepjes = 0;
            chart1.Series["Geweld"].Points.Clear();
            chart2.Series["Geweld"].Points.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Test Knop
            //Buurt wijken
            poepjes = 3;
            sql("Select buurt, geweld_totaal from buurtgeweld WHERE (geweld_totaal > 50)", "buurt", "geweld_totaal");
            chart1.Series["Geweld"].Points.Clear();
            chart2.Series["Geweld"].Points.Clear();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // sub wijk
            poepjes = 2;
            sql("Select subwijk, geweld_totaal from subwijkgeweld WHERE (geweld_totaal > 70) ", "subwijk", "geweld_totaal");
            chart1.Series["Geweld"].Points.Clear();
            chart2.Series["Geweld"].Points.Clear();
        }

        public void sql(string x, string y, string z)
        {
            SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +
                                                  "Database=ProjectDB;Persist Security Info=True;" +
                                                  "User ID=sa; Password=Teemo1999");
            DataSet ds = new DataSet();
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(x, con);
            adapt.Fill(ds);
            chart1.DataSource = ds;
            chart2.DataSource = ds;
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;

            chart1.ChartAreas[0].AxisX.Title = y;
            chart1.ChartAreas[0].AxisY.Title = z;

            //x-as
            chart1.Series["Geweld"].XValueMember = y;
            chart2.Series["Geweld"].XValueMember = y;
            // y-as
            chart1.Series["Geweld"].YValueMembers = z;
            chart2.Series["Geweld"].YValueMembers = z;

            /*if (chart1.Series["Geweld"].Points.Count > 5)
            {
                chart1.Series["Geweld"].Points[0].Color = Color.Green;
                chart1.Series["Geweld"].Points[1].Color = Color.Red;
                chart1.Series["Geweld"].Points[2].Color = Color.PowderBlue;
                chart1.Series["Geweld"].Points[3].Color = Color.Peru;
                chart1.Series["Geweld"].Points[4].Color = Color.Pink;
                chart1.Series["Geweld"].Points[5].Color = Color.Purple;
            }*/

            con.Close();
        }

        private void Home_bttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Wijk_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (poepjes == 1)
            {

                if (comboBox1.SelectedIndex == 0)
                {
                    chart1.Series["Geweld"].Points.Clear();
                    chart2.Series["Geweld"].Points.Clear();
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    sql("Select wijk,geweld_totaal from wijkgeweld", "wijk", "geweld_totaal");
                    chart1.Series["Geweld"].Points.Clear();
                    chart2.Series["Geweld"].Points.Clear();
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    sql("Select wijk,Bedreigingen from wijkgeweld", "wijk", "Bedreigingen");
                    chart1.Series["Geweld"].Points.Clear();
                    chart2.Series["Geweld"].Points.Clear();
                }
                if (comboBox1.SelectedIndex == 3)
                {
                    sql("Select wijk,Mishandelingen from wijkgeweld", "wijk", "Mishandelingen");
                    chart1.Series["Geweld"].Points.Clear();
                    chart2.Series["Geweld"].Points.Clear();
                }
                if (comboBox1.SelectedIndex == 4)
                {
                    sql("Select wijk,Open_geweld from wijkgeweld", "wijk", "Open_geweld");
                    chart1.Series["Geweld"].Points.Clear();
                    chart2.Series["Geweld"].Points.Clear();
                }
                if (comboBox1.SelectedIndex == 5)
                {
                    sql("Select wijk,Overval from wijkgeweld", "wijk", "Overval");
                    chart1.Series["Geweld"].Points.Clear();
                    chart2.Series["Geweld"].Points.Clear();
                }
                if (comboBox1.SelectedIndex == 6)
                {
                    sql("Select wijk,Straatroof from wijkgeweld", "wijk", "Straatroof");
                    chart1.Series["Geweld"].Points.Clear();
                    chart2.Series["Geweld"].Points.Clear();
                }
                if (comboBox1.SelectedIndex == 7)
                {
                    sql("Select wijk,Overig_geweld from wijkgeweld", "wijk", "Overig_geweld");
                    chart1.Series["Geweld"].Points.Clear();
                    chart2.Series["Geweld"].Points.Clear();
                }
            }
            if (poepjes == 2)
            {

                if (comboBox1.SelectedIndex == 0)
                {
                    chart1.Series["Geweld"].Points.Clear();
                    chart2.Series["Geweld"].Points.Clear();
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    sql("Select subwijk,geweld_totaal from subwijkgeweld", "subwijk", "geweld_totaal");
                    chart1.Series["Geweld"].Points.Clear();
                    chart2.Series["Geweld"].Points.Clear();
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    sql("Select subwijk,Bedreigingen from subwijkgeweld", "subwijk", "Bedreigingen");
                    chart1.Series["Geweld"].Points.Clear();
                    chart2.Series["Geweld"].Points.Clear();
                }
                if (comboBox1.SelectedIndex == 3)
                {
                    sql("Select subwijk,Mishandelingen from subwijkgeweld", "subwijk", "Mishandelingen");
                    chart1.Series["Geweld"].Points.Clear();
                    chart2.Series["Geweld"].Points.Clear();
                }
                if (comboBox1.SelectedIndex == 4)
                {
                    sql("Select subwijk,Open_geweld from subwijkgeweld", "subwijk", "Open_geweld");
                    chart1.Series["Geweld"].Points.Clear();
                    chart2.Series["Geweld"].Points.Clear();
                }
                if (comboBox1.SelectedIndex == 5)
                {
                    sql("Select subwijk,Overval from subwijkgeweld", "subwijk", "Overval");
                    chart1.Series["Geweld"].Points.Clear();
                    chart2.Series["Geweld"].Points.Clear();
                }
                if (comboBox1.SelectedIndex == 6)
                {
                    sql("Select subwijk,Straatroof from subwijkgeweld", "subwijk", "Straatroof");
                    chart1.Series["Geweld"].Points.Clear();
                    chart2.Series["Geweld"].Points.Clear();
                }
                if (comboBox1.SelectedIndex == 7)
                {
                    sql("Select subwijk,Overig_geweld from subwijkgeweld", "subwijk", "Overig_geweld");
                    chart1.Series["Geweld"].Points.Clear();
                    chart2.Series["Geweld"].Points.Clear();
                }
            }
            if (poepjes == 3)
            {

                if (comboBox1.SelectedIndex == 0)
                {
                    chart1.Series["Geweld"].Points.Clear();
                    chart2.Series["Geweld"].Points.Clear();
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    sql("Select buurt,geweld_totaal from buurtgeweld WHERE geweld_totaal > 0", "buurt", "geweld_totaal");
                    chart1.Series["Geweld"].Points.Clear();
                    chart2.Series["Geweld"].Points.Clear();
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    sql("Select buurt,Bedreigingen from buurtgeweld WHERE Bedreigingen > 0", "buurt", "Bedreigingen");
                    chart1.Series["Geweld"].Points.Clear();
                    chart2.Series["Geweld"].Points.Clear();
                }
                if (comboBox1.SelectedIndex == 3)
                {
                    sql("Select buurt,Mishandelingen from buurtgeweld WHERE Mishandelingen > 0", "buurt", "Mishandelingen");
                    chart1.Series["Geweld"].Points.Clear();
                    chart2.Series["Geweld"].Points.Clear();
                }
                if (comboBox1.SelectedIndex == 4)
                {
                    sql("Select buurt,Open_geweld from buurtgeweld WHERE Open_geweld > 0", "buurt", "Open_geweld");
                    chart1.Series["Geweld"].Points.Clear();
                    chart2.Series["Geweld"].Points.Clear();
                }
                if (comboBox1.SelectedIndex == 5)
                {
                    sql("Select buurt,Overval from buurtgeweld WHERE Overval > 0 ", "buurt", "Overval");
                    chart1.Series["Geweld"].Points.Clear();
                    chart2.Series["Geweld"].Points.Clear();
                }
                if (comboBox1.SelectedIndex == 6)
                {
                    sql("Select buurt,Straatroof from buurtgeweld WHERE Straatroof > 0", "buurt", "Straatroof");
                    chart1.Series["Geweld"].Points.Clear();
                    chart2.Series["Geweld"].Points.Clear();
                }
                if (comboBox1.SelectedIndex == 7)
                {
                    sql("Select buurt,Overig_geweld from buurtgeweld WHERE Overig_geweld > 0", "buurt", "Overig_geweld");
                    chart1.Series["Geweld"].Points.Clear();
                    chart2.Series["Geweld"].Points.Clear();
                }
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            chart2.Hide();
            pictureBox1.Hide();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            chart2.Show();
            chart1.Show();
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            chart2.Show();
            pictureBox1.Show();
            if (scheetjes == 1)
            {
                pictureBox1.Hide();
                scheetjes = 2;
            }
            else
            {
                chart2.Hide();
                scheetjes = 1;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
                       
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (poepjes == 1)
            {
                    if ((comboBox1.SelectedIndex == 0))
                    {
                        chart1.Series["Geweld"].Points.Clear();
                        chart2.Series["Geweld"].Points.Clear();
                    }
                    if ((comboBox1.SelectedIndex == 1))
                    {
                        sql("Select wijk,geweld_totaal from wijkgeweld WHERE geweld_totaal > 240", "wijk", "geweld_totaal");
                        chart1.Series["Geweld"].Points.Clear();
                        chart2.Series["Geweld"].Points.Clear();
                    }
                    if ((comboBox1.SelectedIndex == 2))
                    {
                        sql("Select wijk,Bedreigingen from wijkgeweld WHERE Bedreigingen > 77", "wijk", "Bedreigingen");
                        chart1.Series["Geweld"].Points.Clear();
                        chart2.Series["Geweld"].Points.Clear();
                    }
                    if ((comboBox1.SelectedIndex == 3))
                    {
                        sql("Select wijk,Mishandelingen from wijkgeweld WHERE Mishandelingen > 115", "wijk", "Mishandelingen");
                        chart1.Series["Geweld"].Points.Clear();
                        chart2.Series["Geweld"].Points.Clear();
                    }
                    if ((comboBox1.SelectedIndex == 4))
                    {
                        sql("Select wijk,Open_geweld from wijkgeweld WHERE Open_geweld > 20", "wijk", "Open_geweld");
                        chart1.Series["Geweld"].Points.Clear();
                        chart2.Series["Geweld"].Points.Clear();
                    }
                    if ((comboBox1.SelectedIndex == 5))
                    {
                        sql("Select wijk,Overval from wijkgeweld WHERE Overval > 5", "wijk", "Overval");
                        chart1.Series["Geweld"].Points.Clear();
                        chart2.Series["Geweld"].Points.Clear();
                    }
                    if ((comboBox1.SelectedIndex == 6))
                    {
                        sql("Select wijk,Straatroof from wijkgeweld WHERE Straatroof > 15", "wijk", "Straatroof");
                        chart1.Series["Geweld"].Points.Clear();
                        chart2.Series["Geweld"].Points.Clear();
                    }
                    if ((comboBox1.SelectedIndex == 7))
                    {
                        sql("Select wijk,Overig_geweld from wijkgeweld WHERE Overig_geweld > 10", "wijk", "Overig_geweld");
                        chart1.Series["Geweld"].Points.Clear();
                        chart2.Series["Geweld"].Points.Clear();
                    }
                
            }
            if (poepjes == 2)
            {

                if (comboBox1.SelectedIndex == 0)
                {
                    chart1.Series["Geweld"].Points.Clear();
                    chart2.Series["Geweld"].Points.Clear();
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    sql("Select subwijk,geweld_totaal from subwijkgeweld WHERE geweld_totaal > 72", "subwijk", "geweld_totaal");
                    chart1.Series["Geweld"].Points.Clear();
                    chart2.Series["Geweld"].Points.Clear();
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    sql("Select subwijk,Bedreigingen from subwijkgeweld WHERE Bedreigingen > 22", "subwijk", "Bedreigingen");
                    chart1.Series["Geweld"].Points.Clear();
                    chart2.Series["Geweld"].Points.Clear();
                }
                if (comboBox1.SelectedIndex == 3)
                {
                    sql("Select subwijk,Mishandelingen from subwijkgeweld WHERE Mishandelingen > 33", "subwijk", "Mishandelingen");
                    chart1.Series["Geweld"].Points.Clear();
                    chart2.Series["Geweld"].Points.Clear();
                }
                if (comboBox1.SelectedIndex == 4)
                {
                    sql("Select subwijk,Open_geweld from subwijkgeweld WHERE Open_geweld > 5", "subwijk", "Open_geweld");
                    chart1.Series["Geweld"].Points.Clear();
                    chart2.Series["Geweld"].Points.Clear();
                }
                if (comboBox1.SelectedIndex == 5)
                {
                    sql("Select subwijk,Overval from subwijkgeweld WHERE Overval > 0", "subwijk", "Overval");
                    chart1.Series["Geweld"].Points.Clear();
                    chart2.Series["Geweld"].Points.Clear();
                }
                if (comboBox1.SelectedIndex == 6)
                {
                    sql("Select subwijk,Straatroof from subwijkgeweld WHERE Straatroof > 5", "subwijk", "Straatroof");
                    chart1.Series["Geweld"].Points.Clear();
                    chart2.Series["Geweld"].Points.Clear();
                }
                if (comboBox1.SelectedIndex == 7)
                {
                    sql("Select subwijk,Overig_geweld from subwijkgeweld WHERE Overig_geweld > 2", "subwijk", "Overig_geweld");
                    chart1.Series["Geweld"].Points.Clear();
                    chart2.Series["Geweld"].Points.Clear();
                }
            }
            if (poepjes == 3)
            {

                if (comboBox1.SelectedIndex == 0)
                {
                    chart1.Series["Geweld"].Points.Clear();
                    chart2.Series["Geweld"].Points.Clear();
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    sql("Select buurt,geweld_totaal from buurtgeweld WHERE geweld_totaal > 22", "buurt", "geweld_totaal");
                    chart1.Series["Geweld"].Points.Clear();
                    chart2.Series["Geweld"].Points.Clear();
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    sql("Select buurt,Bedreigingen from buurtgeweld WHERE Bedreigingen > 7", "buurt", "Bedreigingen");
                    chart1.Series["Geweld"].Points.Clear();
                    chart2.Series["Geweld"].Points.Clear();
                }
                if (comboBox1.SelectedIndex == 3)
                {
                    sql("Select buurt,Mishandelingen from buurtgeweld WHERE Mishandelingen > 9", "buurt", "Mishandelingen");
                    chart1.Series["Geweld"].Points.Clear();
                    chart2.Series["Geweld"].Points.Clear();
                }
                if (comboBox1.SelectedIndex == 4)
                {
                    sql("Select buurt,Open_geweld from buurtgeweld WHERE Open_geweld > 2", "buurt", "Open_geweld");
                    chart1.Series["Geweld"].Points.Clear();
                    chart2.Series["Geweld"].Points.Clear();
                }
                if (comboBox1.SelectedIndex == 5)
                {
                    sql("Select buurt,Overval from buurtgeweld WHERE Overval > 1 ", "buurt", "Overval");
                    chart1.Series["Geweld"].Points.Clear();
                    chart2.Series["Geweld"].Points.Clear();
                }
                if (comboBox1.SelectedIndex == 6)
                {
                    sql("Select buurt,Straatroof from buurtgeweld WHERE Straatroof > 2", "buurt", "Straatroof");
                    chart1.Series["Geweld"].Points.Clear();
                    chart2.Series["Geweld"].Points.Clear();
                }
                if (comboBox1.SelectedIndex == 7)
                {
                    sql("Select buurt,Overig_geweld from buurtgeweld WHERE Overig_geweld > 2", "buurt", "Overig_geweld");
                    chart1.Series["Geweld"].Points.Clear();
                    chart2.Series["Geweld"].Points.Clear();
                }
            }

        }   
    }
}



//private void fillChart()
//{
//    //Standaard Chart
//    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +
//                                                 "Database=ProjectDB;Persist Security Info=True;" +
//                                                 "User ID=sa; Password=Teemo1999");
//    DataSet ds = new DataSet();
//    con.Open();
//    SqlDataAdapter adapt = new SqlDataAdapter("Select wijk,geweld_totaal from wijkgeweld", con);
//    adapt.Fill(ds);
//    chart1.DataSource = ds;
//
//    //set the member of the chart data source used to data bind to the X-values of the series  
//    chart1.Series["Geweld"].XValueMember = "wijk";
//    //set the member columns of the chart data source used to data bind to the X-values of the series  
//    chart1.Series["Geweld"].YValueMembers = "geweld_totaal";
//
//    con.Close();
//