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
            Population population = new Population(5, 7, 2,15,1000);
            population.FormInitialPopulation();
            List<Individual> initialPopulation = population.getInitialPopulation();
            initialPopulation = population.FindFitnessAssessment(initialPopulation);
            
            do
            {
                Selection selection = new Selection(initialPopulation.Count);
                selection.tournament(initialPopulation, 3);
                crossover crossov = new crossover();
                crossov.cross(initialPopulation, 0.3);
                mutation mt = new mutation();
                mt.mutatio(initialPopulation, 0.1);
            }
            while (population.checkOldAndNewCommonNonDominatedOptions(commonNonDominated,population.getCommonNonDominatedOptions()));   
        }
    }
}
