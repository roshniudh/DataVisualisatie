namespace peerc
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Utrecht_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Europa_button = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // Utrecht_button
            // 
            this.Utrecht_button.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Utrecht_button.Location = new System.Drawing.Point(154, 231);
            this.Utrecht_button.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Utrecht_button.Name = "Utrecht_button";
            this.Utrecht_button.Size = new System.Drawing.Size(94, 31);
            this.Utrecht_button.TabIndex = 0;
            this.Utrecht_button.Text = "Utrecht";
            this.toolTip1.SetToolTip(this.Utrecht_button, "Klik \'Utrecht\' om de gewelds-dialicten van Utrecht te weergeven");
            this.Utrecht_button.UseVisualStyleBackColor = false;
            this.Utrecht_button.Click += new System.EventHandler(this.Utrecht_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Geweld in Utrecht ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 40);
            this.label2.TabIndex = 2;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 40);
            this.label3.TabIndex = 3;
            this.label3.Text = "en Europa";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Europa_button
            // 
            this.Europa_button.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Europa_button.Location = new System.Drawing.Point(250, 231);
            this.Europa_button.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Europa_button.Name = "Europa_button";
            this.Europa_button.Size = new System.Drawing.Size(94, 31);
            this.Europa_button.TabIndex = 5;
            this.Europa_button.Text = "Europa";
            this.toolTip1.SetToolTip(this.Europa_button, "Klik Europa om het verband tussen de poluplatie en de misdaden van Europa te weer" +
        "geven");
            this.Europa_button.UseVisualStyleBackColor = false;
            this.Europa_button.Click += new System.EventHandler(this.Europa_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(501, 346);
            this.Controls.Add(this.Europa_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Utrecht_button);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Utrecht_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Europa_button;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}