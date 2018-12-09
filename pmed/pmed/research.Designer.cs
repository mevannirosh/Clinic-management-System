namespace pmed
{
    partial class research
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(research));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.resPnl = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bunifuCircleProgressbar6 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCustomLabel15 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCircleProgressbar3 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.resPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // resPnl
            // 
            this.resPnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resPnl.BackgroundImage")));
            this.resPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resPnl.Controls.Add(this.chart2);
            this.resPnl.Controls.Add(this.chart1);
            this.resPnl.Controls.Add(this.bunifuCircleProgressbar6);
            this.resPnl.Controls.Add(this.bunifuCustomLabel15);
            this.resPnl.Controls.Add(this.bunifuCircleProgressbar3);
            this.resPnl.Controls.Add(this.bunifuCircleProgressbar1);
            this.resPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resPnl.GradientBottomLeft = System.Drawing.Color.MidnightBlue;
            this.resPnl.GradientBottomRight = System.Drawing.Color.Firebrick;
            this.resPnl.GradientTopLeft = System.Drawing.Color.MidnightBlue;
            this.resPnl.GradientTopRight = System.Drawing.Color.Firebrick;
            this.resPnl.Location = new System.Drawing.Point(0, 0);
            this.resPnl.Name = "resPnl";
            this.resPnl.Quality = 10;
            this.resPnl.Size = new System.Drawing.Size(797, 491);
            this.resPnl.TabIndex = 0;
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(394, 244);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(316, 192);
            this.chart2.TabIndex = 97;
            this.chart2.Text = "healing percentage of patients";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(57, 244);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(305, 192);
            this.chart1.TabIndex = 96;
            this.chart1.Text = "deth percentage of patients";
            // 
            // bunifuCircleProgressbar6
            // 
            this.bunifuCircleProgressbar6.animated = true;
            this.bunifuCircleProgressbar6.animationIterval = 5;
            this.bunifuCircleProgressbar6.animationSpeed = 300;
            this.bunifuCircleProgressbar6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar6.BackgroundImage")));
            this.bunifuCircleProgressbar6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuCircleProgressbar6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar6.ForeColor = System.Drawing.Color.Orange;
            this.bunifuCircleProgressbar6.LabelVisible = true;
            this.bunifuCircleProgressbar6.LineProgressThickness = 8;
            this.bunifuCircleProgressbar6.LineThickness = 10;
            this.bunifuCircleProgressbar6.Location = new System.Drawing.Point(571, 82);
            this.bunifuCircleProgressbar6.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar6.MaxValue = 100;
            this.bunifuCircleProgressbar6.Name = "bunifuCircleProgressbar6";
            this.bunifuCircleProgressbar6.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgressbar6.ProgressColor = System.Drawing.Color.Red;
            this.bunifuCircleProgressbar6.Size = new System.Drawing.Size(129, 129);
            this.bunifuCircleProgressbar6.TabIndex = 95;
            this.bunifuCircleProgressbar6.Value = 43;
            // 
            // bunifuCustomLabel15
            // 
            this.bunifuCustomLabel15.AutoSize = true;
            this.bunifuCustomLabel15.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel15.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel15.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomLabel15.Location = new System.Drawing.Point(232, 9);
            this.bunifuCustomLabel15.Name = "bunifuCustomLabel15";
            this.bunifuCustomLabel15.Size = new System.Drawing.Size(264, 25);
            this.bunifuCustomLabel15.TabIndex = 92;
            this.bunifuCustomLabel15.Text = "Medical Statistics";
            // 
            // bunifuCircleProgressbar3
            // 
            this.bunifuCircleProgressbar3.animated = true;
            this.bunifuCircleProgressbar3.animationIterval = 5;
            this.bunifuCircleProgressbar3.animationSpeed = 300;
            this.bunifuCircleProgressbar3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar3.BackgroundImage")));
            this.bunifuCircleProgressbar3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuCircleProgressbar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar3.ForeColor = System.Drawing.Color.Orange;
            this.bunifuCircleProgressbar3.LabelVisible = true;
            this.bunifuCircleProgressbar3.LineProgressThickness = 8;
            this.bunifuCircleProgressbar3.LineThickness = 10;
            this.bunifuCircleProgressbar3.Location = new System.Drawing.Point(313, 82);
            this.bunifuCircleProgressbar3.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar3.MaxValue = 100;
            this.bunifuCircleProgressbar3.Name = "bunifuCircleProgressbar3";
            this.bunifuCircleProgressbar3.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgressbar3.ProgressColor = System.Drawing.Color.Red;
            this.bunifuCircleProgressbar3.Size = new System.Drawing.Size(129, 129);
            this.bunifuCircleProgressbar3.TabIndex = 2;
            this.bunifuCircleProgressbar3.Value = 57;
            // 
            // bunifuCircleProgressbar1
            // 
            this.bunifuCircleProgressbar1.animated = true;
            this.bunifuCircleProgressbar1.animationIterval = 5;
            this.bunifuCircleProgressbar1.animationSpeed = 300;
            this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
            this.bunifuCircleProgressbar1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.Orange;
            this.bunifuCircleProgressbar1.LabelVisible = true;
            this.bunifuCircleProgressbar1.LineProgressThickness = 8;
            this.bunifuCircleProgressbar1.LineThickness = 10;
            this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(57, 82);
            this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar1.MaxValue = 100;
            this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
            this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.Red;
            this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(129, 129);
            this.bunifuCircleProgressbar1.TabIndex = 0;
            this.bunifuCircleProgressbar1.Value = 30;
            // 
            // research
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 491);
            this.Controls.Add(this.resPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "research";
            this.Text = "research";
            this.resPnl.ResumeLayout(false);
            this.resPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel resPnl;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel15;
    }
}