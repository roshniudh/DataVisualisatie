using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace peerc
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        int landen = 1;

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
            chart1.Series["15"].XValueMember = y;
            chart2.Series["Intentional_homicide"].XValueMember = y;
            // y-as
            chart1.Series["15"].YValueMembers = z;
            chart2.Series["Intentional_homicide"].YValueMembers = z;

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

        private void Form4_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
            SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Belgium'", con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            chart1.DataSource = dt;
            chart1.Titles.Add("Populatie");
            chart2.Titles.Add("Geweld in 2015");
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

            chart1.Series["15"].XValueMember = "country";
            chart1.Series["15"].YValueMembers = "vijftien";
            chart1.Series["16"].YValueMembers = "zestien";
            chart1.Series["17"].YValueMembers = "zeventien";



            SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Belgium'", con);
            DataTable ds = new DataTable();
            sql.Fill(ds);
            chart2.DataSource = ds;
            chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
            chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

            chart2.Series["Intentional_homicide"].XValueMember = "Country";
            chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
            chart2.Series["Assault"].YValueMembers = "Assault";
            chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
            chart2.Series["Rape"].YValueMembers = "Rape";
            chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
            chart2.Series["Theft"].YValueMembers = "Theft";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (landen == 1)
            {
                if (comboBox1.SelectedIndex == 0)

                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Belgium'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Belgium'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Bulgaria'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Bulgaria'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Czech Republic'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Czech Republic'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 3)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Denmark'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Denmark'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 4)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Germany'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Germany'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 5)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Estonia'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Estonia'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 6)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Ireland'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Ireland'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 7)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Greece'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Greece'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 8)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Spain'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Spain'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 9)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'France'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='France'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 10)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Croatia'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Croatia'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 11)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Italy'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Italy'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 12)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Cyprus'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Cyprus'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 13)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Latvia'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Latvia'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 14)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Lithuania'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Lithuania'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 15)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Luxembourg'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Luxembourg'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 16)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Hungary'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Hungary'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 17)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Malta'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Malta'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 18)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Netherlands'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Netherlands'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 19)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Austria'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Austria'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 20)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Poland'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Poland'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 21)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Portugal'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Portugal'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 22)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Romania'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Romania'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 23)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Slovenia'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Slovenia'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 24)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Slovakia'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Slovakia'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 25)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Finland'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Finland'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 26)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Sweden'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Sweden'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 27)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'United Kingdom'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='United Kingdom'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 28)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Iceland'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Iceland'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 29)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Norway'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Norway'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 30)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Switzerland'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Switzerland'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 31)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Montenegro'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Montenegro'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 32)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Macedonia'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Macedonia'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 33)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Albania'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Albania'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 34)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Serbia'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Serbia'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 35)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Turkey'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Turkey'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 36)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Andorra'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Andorra'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 37)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Belarus'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Belarus'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 38)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Bosnia and Herzegovina'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Bosnia and Herzegovina'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 39)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Kosovo'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Kosovo'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 40)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Moldova'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Moldova'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 41)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Monaco'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Monaco'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 42)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'San Marino'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='San Marino'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 43)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Ukraine'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Ukraine'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 44)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Armenia'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Armenia'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 45)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Azerbaijan'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Azerbaijan'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
                if (comboBox1.SelectedIndex == 46)
                {
                    SqlConnection con = new SqlConnection("Data Source=145.24.222.151,8080;" +"Database=ProjectDB;Persist Security Info=True;" +"User ID=sa; Password=Teemo1999");
                    SqlDataAdapter ad = new SqlDataAdapter("select * from population where country = 'Georgia'", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Country";
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Europian Country";

                    chart1.Series["15"].XValueMember = "country";
                    chart1.Series["15"].YValueMembers = "vijftien";
                    chart1.Series["16"].YValueMembers = "zestien";
                    chart1.Series["17"].YValueMembers = "zeventien";



                    SqlDataAdapter sql = new SqlDataAdapter("SELECT country, Intentional_homicide, Assault, Sexual_violence, Rape, Sexual_Assault, Theft FROM RecordedOffences2015 where country='Georgia'", con);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    chart2.DataSource = ds;
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Country";
                    chart2.ChartAreas["ChartArea2"].AxisX.Title = "Europian Country";

                    chart2.Series["Intentional_homicide"].XValueMember = "Country";
                    chart2.Series["Intentional_homicide"].YValueMembers = "Intentional_homicide";
                    chart2.Series["Assault"].YValueMembers = "Assault";
                    chart2.Series["Sexual_violence"].YValueMembers = "Sexual_violence";
                    chart2.Series["Rape"].YValueMembers = "Rape";
                    chart2.Series["Sexual_Assault"].YValueMembers = "Sexual_Assault";
                    chart2.Series["Theft"].YValueMembers = "Theft";
                }
            }
        }

        private void Home_bttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void comboBox1_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
