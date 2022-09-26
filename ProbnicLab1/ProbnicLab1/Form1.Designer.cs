
namespace ProbnicLab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cleanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListFunc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InputA = new System.Windows.Forms.TextBox();
            this.InputB = new System.Windows.Forms.TextBox();
            this.e = new System.Windows.Forms.Label();
            this.InputE = new System.Windows.Forms.TextBox();
            this.k = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.InputK = new System.Windows.Forms.TextBox();
            this.InputM = new System.Windows.Forms.TextBox();
            this.InputN = new System.Windows.Forms.TextBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1016, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem,
            this.cleanToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.runToolStripMenuItem.Text = "Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // cleanToolStripMenuItem
            // 
            this.cleanToolStripMenuItem.Name = "cleanToolStripMenuItem";
            this.cleanToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.cleanToolStripMenuItem.Text = "Clean";
            // 
            // ListFunc
            // 
            this.ListFunc.FormattingEnabled = true;
            this.ListFunc.Items.AddRange(new object[] {
            "y=kx",
            "y=kx+m",
            "y=x^2",
            "y=kx^2+mx+n"});
            this.ListFunc.Location = new System.Drawing.Point(101, 69);
            this.ListFunc.Name = "ListFunc";
            this.ListFunc.Size = new System.Drawing.Size(239, 28);
            this.ListFunc.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "f(x)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "a                                b";
            // 
            // InputA
            // 
            this.InputA.Location = new System.Drawing.Point(85, 293);
            this.InputA.Name = "InputA";
            this.InputA.Size = new System.Drawing.Size(100, 26);
            this.InputA.TabIndex = 8;
            // 
            // InputB
            // 
            this.InputB.Location = new System.Drawing.Point(225, 293);
            this.InputB.Name = "InputB";
            this.InputB.Size = new System.Drawing.Size(100, 26);
            this.InputB.TabIndex = 9;
            // 
            // e
            // 
            this.e.AutoSize = true;
            this.e.Location = new System.Drawing.Point(64, 348);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(18, 20);
            this.e.TabIndex = 10;
            this.e.Text = "e";
            // 
            // InputE
            // 
            this.InputE.Location = new System.Drawing.Point(85, 342);
            this.InputE.Name = "InputE";
            this.InputE.Size = new System.Drawing.Size(100, 26);
            this.InputE.TabIndex = 11;
            // 
            // k
            // 
            this.k.AutoSize = true;
            this.k.Location = new System.Drawing.Point(65, 113);
            this.k.Name = "k";
            this.k.Size = new System.Drawing.Size(17, 20);
            this.k.TabIndex = 12;
            this.k.Text = "k";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "m";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "n";
            // 
            // InputK
            // 
            this.InputK.Location = new System.Drawing.Point(88, 110);
            this.InputK.Name = "InputK";
            this.InputK.Size = new System.Drawing.Size(100, 26);
            this.InputK.TabIndex = 15;
            // 
            // InputM
            // 
            this.InputM.Location = new System.Drawing.Point(88, 142);
            this.InputM.Name = "InputM";
            this.InputM.Size = new System.Drawing.Size(100, 26);
            this.InputM.TabIndex = 16;
            // 
            // InputN
            // 
            this.InputN.Location = new System.Drawing.Point(88, 174);
            this.InputN.Name = "InputN";
            this.InputN.Size = new System.Drawing.Size(100, 26);
            this.InputN.TabIndex = 17;
            // 
            // chart
            // 
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(400, 68);
            this.chart.Name = "chart";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Lime;
            series2.Legend = "Legend1";
            series2.LegendText = "f(x)";
            series2.Name = "Series1";
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(577, 321);
            this.chart.TabIndex = 18;
            this.chart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 430);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.InputN);
            this.Controls.Add(this.InputM);
            this.Controls.Add(this.InputK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.k);
            this.Controls.Add(this.InputE);
            this.Controls.Add(this.e);
            this.Controls.Add(this.InputB);
            this.Controls.Add(this.InputA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListFunc);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cleanToolStripMenuItem;
        private System.Windows.Forms.ComboBox ListFunc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InputA;
        private System.Windows.Forms.TextBox InputB;
        private System.Windows.Forms.Label e;
        private System.Windows.Forms.TextBox InputE;
        private System.Windows.Forms.Label k;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox InputK;
        private System.Windows.Forms.TextBox InputM;
        private System.Windows.Forms.TextBox InputN;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    }
}

