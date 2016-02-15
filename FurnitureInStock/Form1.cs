using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurnitureInStock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MainOutputData.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvUserDetails_RowPostPaint);
            this.MainOutputData.TopLeftHeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.MainOutputData.TopLeftHeaderCell.Value = "i";
        }

        private void dgvUserDetails_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(MainOutputData.RowHeadersDefaultCellStyle.ForeColor))
            {
                var centerFormat = new StringFormat()
                {
                    // right alignment might actually make more sense for numbers
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };

                var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, (sender as DataGridView).RowHeadersWidth, e.RowBounds.Height);
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, headerBounds, centerFormat);
            }
        }

        private void SolveWithGeneticAlgorithm_Click(object sender, EventArgs e)
        {
            int numberOfPopulation = Convert.ToInt32(NumberOfIndividuals.Text);
            int numberOfDifferentKind = Convert.ToInt32(TheNumberOfDifferentTypesOfFurniture.Text);
            Population population = new Population(numberOfPopulation, numberOfDifferentKind, 2, 15, 1000, 30,50);
            
            do
            {
                population.FormInitialPopulation();
                List<Individual> initialPopulation = population.getInitialPopulation();
                initialPopulation = population.FindFitnessAssessment(initialPopulation);
                OtherOutputData.Text += "S = " + population.getCommonNonDominatedOptions().FirstOrDefault().getSCommon().ToString() + "\r\n";
                OtherOutputData.Text += "P = " + population.getCommonNonDominatedOptions().FirstOrDefault().getPCommon().ToString() + "\r\n";
                OtherOutputData.Text += "X = " + string.Join(", ", population.getCommonNonDominatedOptions().FirstOrDefault().getIndividual()) + "\r\n";
                OtherOutputData.Text += "========================= 0\r\n";
                chart1.Series[0].Points.AddXY(population.getCommonNonDominatedOptions().FirstOrDefault().getSCommon(),
                    population.getCommonNonDominatedOptions().FirstOrDefault().getPCommon());
                MainOutputData.Rows.Add();
                MainOutputData.Rows[0].Cells[0].Value = population.getCommonNonDominatedOptions().FirstOrDefault().getSCommon().ToString();
                MainOutputData.Rows[0].Cells[1].Value = population.getCommonNonDominatedOptions().FirstOrDefault().getPCommon().ToString();
                double probabilityOfMutation = Convert.ToDouble(TheProbabilityOfMutation.Text, CultureInfo.InvariantCulture);
                double probabilityOfCrossover = Convert.ToDouble(TheProbabilityOfCrossing.Text, CultureInfo.InvariantCulture);
                int iteration = 1;
                //System.IO.StreamWriter file =
                //new System.IO.StreamWriter(@"dataToCheckAll.txt");
                using (StreamWriter sw = new StreamWriter("dataToCheckAll.txt"))
                {
                    sw.WriteLine("Начальная популяция");
                    foreach (Individual indiv in initialPopulation)
                    {
                        sw.WriteLine(string.Join(", ", indiv.getIndividual()));
                    }
                    int i = 1;
                    do
                    {
                        Selection selection = new Selection(initialPopulation.Count);
                        initialPopulation = selection.tournament(initialPopulation, 3);
                        sw.WriteLine(i.ToString() + " популяция после селекции");
                        foreach (Individual indiv in initialPopulation)
                        {
                            sw.WriteLine(string.Join(", ", indiv.getIndividual()));
                        }
                        initialPopulation = crossover.cross(initialPopulation, probabilityOfCrossover);
                        sw.WriteLine(i.ToString() + " Популяция после кроссовера");
                        foreach (Individual indiv in initialPopulation)
                        {
                            sw.WriteLine(string.Join(", ", indiv.getIndividual()));
                        }
                        initialPopulation = mutation.mutatio(initialPopulation, probabilityOfMutation);
                        sw.WriteLine(i.ToString() + " Популяция после мутации");
                        foreach (Individual indiv in initialPopulation)
                        {
                            sw.WriteLine(string.Join(", ", indiv.getIndividual()));
                        }
                        initialPopulation = population.FindFitnessAssessment(initialPopulation);
                        OtherOutputData.Text += "S = " + population.getCommonNonDominatedOptions().FirstOrDefault().getSCommon().ToString() + "\r\n";
                        OtherOutputData.Text += "P = " + population.getCommonNonDominatedOptions().FirstOrDefault().getPCommon().ToString() + "\r\n";
                        OtherOutputData.Text += "X = " + string.Join(", ", population.getCommonNonDominatedOptions().FirstOrDefault().getIndividual()) + "\r\n";
                        OtherOutputData.Text += "========================= " + iteration.ToString() + " \r\n";
                        chart1.Series[0].Points.AddXY(population.getCommonNonDominatedOptions().FirstOrDefault().getSCommon(),
                        population.getCommonNonDominatedOptions().FirstOrDefault().getPCommon());
                        MainOutputData.Rows.Add();
                        MainOutputData.Rows[iteration].Cells[0].Value = population.getCommonNonDominatedOptions().FirstOrDefault().getSCommon().ToString();
                        MainOutputData.Rows[iteration].Cells[1].Value = population.getCommonNonDominatedOptions().FirstOrDefault().getPCommon().ToString();
                        iteration++;
                        i++;
                    }
                    while (population.CheckForNoImprovment());
                }
            }
            while (population.CheckForTheBestIndividual(population.getInitialPopulation().First()));

            }
    }
}
