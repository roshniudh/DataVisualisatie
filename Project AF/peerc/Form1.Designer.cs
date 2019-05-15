namespace peerc
{
    partial class Geweld_Diagram
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Geweld_Diagram));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button2 = new System.Windows.Forms.Button();
            this.Test = new System.Windows.Forms.Button();
            this.Home_bttn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(895, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Wijk\r\n";
            this.toolTip1.SetToolTip(this.button1, "Hiermee kiest uw de gegevens van de wijk");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            this.chart1.ImeMode = System.Windows.Forms.ImeMode.On;
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))))};
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series5.IsValueShownAsLabel = true;
            series5.IsXValueIndexed = true;
            series5.LabelToolTip = "#VALX";
            series5.Legend = "Legend1";
            series5.Name = "Geweld";
            series5.YValuesPerPoint = 2;
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(818, 556);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "Geweld";
            this.toolTip1.SetToolTip(this.chart1, "Staafdiagram met data");
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(1046, 501);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 67);
            this.button2.TabIndex = 2;
            this.toolTip1.SetToolTip(this.button2, "Hiermee haalt uw de alle tabellen  leeg");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Test
            // 
            this.Test.Location = new System.Drawing.Point(895, 517);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(109, 54);
            this.Test.TabIndex = 3;
            this.Test.Text = "Buurt";
            this.toolTip1.SetToolTip(this.Test, "Hiermee kiest uw de gegevens van de Buurt");
            this.Test.UseVisualStyleBackColor = true;
            this.Test.Click += new System.EventHandler(this.button3_Click);
            // 
            // Home_bttn
            // 
            this.Home_bttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Home_bttn.BackgroundImage")));
            this.Home_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Home_bttn.Location = new System.Drawing.Point(1046, 406);
            this.Home_bttn.Name = "Home_bttn";
            this.Home_bttn.Size = new System.Drawing.Size(61, 68);
            this.Home_bttn.TabIndex = 5;
            this.Home_bttn.Text = "\r\n";
            this.toolTip1.SetToolTip(this.Home_bttn, "Hiermee gaat uw terug naar het hoofdmenu");
            this.Home_bttn.UseVisualStyleBackColor = true;
            this.Home_bttn.Click += new System.EventHandler(this.Home_bttn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Clear",
            "Totaal",
            "Bedreigingen",
            "Mishandelingen",
            "Open_geweld",
            "Overval",
            "Straatroof",
            "Overige_geweld"});
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.toolTip1.SetToolTip(this.comboBox1, "Hiermee kan u filteren op de gewenste data");
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(895, 457);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 54);
            this.button3.TabIndex = 7;
            this.button3.Text = "Subwijk";
            this.toolTip1.SetToolTip(this.button3, "Hiermee kiest uw de gegevens van de subwijk");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // chart2
            // 
            chartArea6.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart2.Legends.Add(legend6);
            this.chart2.Location = new System.Drawing.Point(836, 12);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series6.BorderColor = System.Drawing.Color.Black;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series6.IsValueShownAsLabel = true;
            series6.IsXValueIndexed = true;
            series6.Label = "#PERCENT";
            series6.Legend = "Legend1";
            series6.LegendText = "#VALX";
            series6.LegendToolTip = "#VALX";
            series6.Name = "Geweld";
            series6.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(442, 362);
            this.chart2.TabIndex = 10;
            this.chart2.Text = "chart2";
            this.toolTip1.SetToolTip(this.chart2, "Cirkel diagram met precentages");
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(139, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 18;
            this.button6.Text = "Hoog";
            this.toolTip1.SetToolTip(this.button6, "Kies data dat 10% hoger dan het gemiddelde ligt");
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(837, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(441, 362);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1146, 393);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 58);
            this.button5.TabIndex = 16;
            this.button5.Text = "Wijk/Chart";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(220, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 13);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "Data uit 2016";
            // 
            // Geweld_Diagram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 581);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Home_bttn);
            this.Controls.Add(this.Test);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.Name = "Geweld_Diagram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gewelds_Dialicten";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Test;
        private System.Windows.Forms.Button Home_bttn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox1;
    }
}

