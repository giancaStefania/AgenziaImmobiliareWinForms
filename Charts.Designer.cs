
namespace ImmobiliWinForms
{
    partial class Charts
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.chartPropHouse = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPropHouse)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.chartPropHouse);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(802, 451);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "<-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chartPropHouse
            // 
            chartArea3.Name = "ChartArea1";
            chartArea4.Name = "AreaPie";
            this.chartPropHouse.ChartAreas.Add(chartArea3);
            this.chartPropHouse.ChartAreas.Add(chartArea4);
            legend3.DockedToChartArea = "ChartArea1";
            legend3.IsDockedInsideChartArea = false;
            legend3.Name = "Legend1";
            legend4.DockedToChartArea = "AreaPie";
            legend4.IsDockedInsideChartArea = false;
            legend4.Name = "Legend2";
            this.chartPropHouse.Legends.Add(legend3);
            this.chartPropHouse.Legends.Add(legend4);
            this.chartPropHouse.Location = new System.Drawing.Point(84, 3);
            this.chartPropHouse.Name = "chartPropHouse";
            series3.ChartArea = "AreaPie";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend2";
            series3.Name = "Numero Case";
            series3.ToolTip = "#SERIESNAME";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Prezzo Maggiore dell\'Immobile";
            this.chartPropHouse.Series.Add(series3);
            this.chartPropHouse.Series.Add(series4);
            this.chartPropHouse.Size = new System.Drawing.Size(644, 448);
            this.chartPropHouse.TabIndex = 1;
            this.chartPropHouse.Text = "chart1";
            title4.Name = "Title1";
            title4.Text = "Statistiche Proprietari";
            title5.DockedToChartArea = "AreaPie";
            title5.IsDockedInsideChartArea = false;
            title5.Name = "NIMM";
            title5.Text = "Numero Immobili";
            title6.DockedToChartArea = "ChartArea1";
            title6.IsDockedInsideChartArea = false;
            title6.Name = "VIMM";
            title6.Text = "Valore Immobili";
            this.chartPropHouse.Titles.Add(title4);
            this.chartPropHouse.Titles.Add(title5);
            this.chartPropHouse.Titles.Add(title6);
            // 
            // Charts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Charts";
            this.Text = "Charts";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPropHouse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPropHouse;
    }
}