using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void SolveWithGeneticAlgorithm_Click(object sender, EventArgs e)
        {
            Population population = new Population(5, 7, 2,15,1000,10);
            population.FormInitialPopulation();
            List<Individual> initialPopulation = population.getInitialPopulation();
            initialPopulation = population.FindFitnessAssessment(initialPopulation);
            OtherOutputData.Text += "S = " + population.getCommonNonDominatedOptions().FirstOrDefault().getSCommon().ToString()+"\r\n";
            OtherOutputData.Text += "P = " + population.getCommonNonDominatedOptions().FirstOrDefault().getPCommon().ToString()+"\r\n";
            OtherOutputData.Text += "X = " + string.Join(", ", population.getCommonNonDominatedOptions().FirstOrDefault().getIndividual()) + "\r\n";
            OtherOutputData.Text += "========================= 0\r\n";
            int iteration = 1;
            do
            {
                Selection selection = new Selection(initialPopulation.Count);
                initialPopulation=selection.tournament(initialPopulation, 3);
                initialPopulation=crossover.cross(initialPopulation, 0.3);
                initialPopulation=mutation.mutatio(initialPopulation, 0.7);
                initialPopulation = population.FindFitnessAssessment(initialPopulation);
                OtherOutputData.Text += "S = " + population.getCommonNonDominatedOptions().FirstOrDefault().getSCommon().ToString() + "\r\n";
                OtherOutputData.Text += "P = " + population.getCommonNonDominatedOptions().FirstOrDefault().getPCommon().ToString() + "\r\n";
                OtherOutputData.Text += "X = " + string.Join(", ", population.getCommonNonDominatedOptions().FirstOrDefault().getIndividual()) + "\r\n";
                OtherOutputData.Text += "========================= "+iteration.ToString()+" \r\n";
                iteration++;
            }
            while (population.CheckForNoImprovment());   
        }
    }
}
