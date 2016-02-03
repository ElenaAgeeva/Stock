namespace FurnitureInStock
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SolveWithGeneticAlgorithm = new System.Windows.Forms.Button();
            this.TheNumberOfDifferentTypesOfFurniture = new System.Windows.Forms.TextBox();
            this.NumberOfIndividuals = new System.Windows.Forms.TextBox();
            this.TheProbabilityOfMutation = new System.Windows.Forms.TextBox();
            this.TheProbabilityOfCrossing = new System.Windows.Forms.TextBox();
            this.MainOutputData = new System.Windows.Forms.DataGridView();
            this.OtherOutputData = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.MainOutputData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество различных видов мебели:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество особей:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Вероятность мутации:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Вероятность скрещивания:";
            // 
            // SolveWithGeneticAlgorithm
            // 
            this.SolveWithGeneticAlgorithm.Location = new System.Drawing.Point(38, 219);
            this.SolveWithGeneticAlgorithm.Name = "SolveWithGeneticAlgorithm";
            this.SolveWithGeneticAlgorithm.Size = new System.Drawing.Size(186, 58);
            this.SolveWithGeneticAlgorithm.TabIndex = 4;
            this.SolveWithGeneticAlgorithm.Text = "Решить с помощью генетического алгоритма";
            this.SolveWithGeneticAlgorithm.UseVisualStyleBackColor = true;
            this.SolveWithGeneticAlgorithm.Click += new System.EventHandler(this.SolveWithGeneticAlgorithm_Click);
            // 
            // TheNumberOfDifferentTypesOfFurniture
            // 
            this.TheNumberOfDifferentTypesOfFurniture.Location = new System.Drawing.Point(312, 28);
            this.TheNumberOfDifferentTypesOfFurniture.Name = "TheNumberOfDifferentTypesOfFurniture";
            this.TheNumberOfDifferentTypesOfFurniture.Size = new System.Drawing.Size(100, 22);
            this.TheNumberOfDifferentTypesOfFurniture.TabIndex = 5;
            // 
            // NumberOfIndividuals
            // 
            this.NumberOfIndividuals.Location = new System.Drawing.Point(312, 74);
            this.NumberOfIndividuals.Name = "NumberOfIndividuals";
            this.NumberOfIndividuals.Size = new System.Drawing.Size(100, 22);
            this.NumberOfIndividuals.TabIndex = 6;
            // 
            // TheProbabilityOfMutation
            // 
            this.TheProbabilityOfMutation.Location = new System.Drawing.Point(312, 116);
            this.TheProbabilityOfMutation.Name = "TheProbabilityOfMutation";
            this.TheProbabilityOfMutation.Size = new System.Drawing.Size(100, 22);
            this.TheProbabilityOfMutation.TabIndex = 7;
            // 
            // TheProbabilityOfCrossing
            // 
            this.TheProbabilityOfCrossing.Location = new System.Drawing.Point(312, 166);
            this.TheProbabilityOfCrossing.Name = "TheProbabilityOfCrossing";
            this.TheProbabilityOfCrossing.Size = new System.Drawing.Size(100, 22);
            this.TheProbabilityOfCrossing.TabIndex = 8;
            // 
            // MainOutputData
            // 
            this.MainOutputData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainOutputData.Location = new System.Drawing.Point(38, 301);
            this.MainOutputData.Name = "MainOutputData";
            this.MainOutputData.RowTemplate.Height = 24;
            this.MainOutputData.Size = new System.Drawing.Size(374, 150);
            this.MainOutputData.TabIndex = 9;
            // 
            // OtherOutputData
            // 
            this.OtherOutputData.Location = new System.Drawing.Point(481, 301);
            this.OtherOutputData.Multiline = true;
            this.OtherOutputData.Name = "OtherOutputData";
            this.OtherOutputData.ReadOnly = true;
            this.OtherOutputData.Size = new System.Drawing.Size(434, 158);
            this.OtherOutputData.TabIndex = 10;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(481, 28);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(434, 249);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 515);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.OtherOutputData);
            this.Controls.Add(this.MainOutputData);
            this.Controls.Add(this.TheProbabilityOfCrossing);
            this.Controls.Add(this.TheProbabilityOfMutation);
            this.Controls.Add(this.NumberOfIndividuals);
            this.Controls.Add(this.TheNumberOfDifferentTypesOfFurniture);
            this.Controls.Add(this.SolveWithGeneticAlgorithm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Задача резервирования оптимального количества мебели";
            ((System.ComponentModel.ISupportInitialize)(this.MainOutputData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SolveWithGeneticAlgorithm;
        private System.Windows.Forms.TextBox TheNumberOfDifferentTypesOfFurniture;
        private System.Windows.Forms.TextBox NumberOfIndividuals;
        private System.Windows.Forms.TextBox TheProbabilityOfMutation;
        private System.Windows.Forms.TextBox TheProbabilityOfCrossing;
        private System.Windows.Forms.DataGridView MainOutputData;
        private System.Windows.Forms.TextBox OtherOutputData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

