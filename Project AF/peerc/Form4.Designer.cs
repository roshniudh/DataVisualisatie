namespace peerc
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Home_bttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.Rotation = 15;
            chartArea1.Area3DStyle.WallWidth = 20;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.Gray;
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "15";
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "16";
            series3.ChartArea = "ChartArea1";
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "17";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(429, 371);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.Area3DStyle.Inclination = 10;
            chartArea2.Area3DStyle.IsClustered = true;
            chartArea2.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea2.Area3DStyle.Rotation = 15;
            chartArea2.Area3DStyle.WallWidth = 20;
            chartArea2.Name = "ChartArea2";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(447, 12);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea2";
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "Intentional_homicide";
            series5.ChartArea = "ChartArea2";
            series5.IsValueShownAsLabel = true;
            series5.Legend = "Legend1";
            series5.Name = "Assault";
            series6.ChartArea = "ChartArea2";
            series6.IsValueShownAsLabel = true;
            series6.Legend = "Legend1";
            series6.Name = "Sexual_violence";
            series7.ChartArea = "ChartArea2";
            series7.IsValueShownAsLabel = true;
            series7.Legend = "Legend1";
            series7.Name = "Rape";
            series8.ChartArea = "ChartArea2";
            series8.IsValueShownAsLabel = true;
            series8.Legend = "Legend1";
            series8.Name = "Sexual_Assault";
            series9.ChartArea = "ChartArea2";
            series9.IsValueShownAsLabel = true;
            series9.Legend = "Legend1";
            series9.Name = "Theft";
            this.chart2.Series.Add(series4);
            this.chart2.Series.Add(series5);
            this.chart2.Series.Add(series6);
            this.chart2.Series.Add(series7);
            this.chart2.Series.Add(series8);
            this.chart2.Series.Add(series9);
            this.chart2.Size = new System.Drawing.Size(548, 543);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Belgium",
            "Bulgaria",
            "Czech Republic",
            "Denmark",
            "Germany",
            "Estonia",
            "Ireland",
            "Greece",
            "Spain",
            "France",
            "Croatia",
            "Italy",
            "Cyprus",
            "Latvia",
            "Lithuania",
            "Luxembourg",
            "Hungary",
            "Malta",
            "Netherlands",
            "Austria",
            "Poland",
            "Portugal",
            "Romania",
            "Slovenia",
            "Slovakia",
            "Finland",
            "Sweden",
            "United Kingdom",
            "Iceland",
            "Norway",
            "Switzerland",
            "Montenegro",
            "Macedonia",
            "Albania",
            "Serbia",
            "Turkey",
            "Andorra",
            "Belarus",
            "Bosnia and Herzegovina",
            "Kosovo",
            "Moldova",
            "Monaco",
            "San Marino",
            "Ukraine",
            "Armenia",
            "Azerbaijan",
            "Georgia"});
            this.comboBox1.Location = new System.Drawing.Point(320, 389);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.MouseHover += new System.EventHandler(this.comboBox1_MouseHover);
            // 
            // Home_bttn
            // 
            this.Home_bttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Home_bttn.BackgroundImage")));
            this.Home_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Home_bttn.Location = new System.Drawing.Point(12, 487);
            this.Home_bttn.Name = "Home_bttn";
            this.Home_bttn.Size = new System.Drawing.Size(61, 68);
            this.Home_bttn.TabIndex = 6;
            this.Home_bttn.UseVisualStyleBackColor = true;
            this.Home_bttn.Click += new System.EventHandler(this.Home_bttn_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 567);
            this.Controls.Add(this.Home_bttn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Name = "Form4";
            this.Text = "Gewelds_Dialicten";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Home_bttn;
    }
}