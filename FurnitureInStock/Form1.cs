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
            Population population = new Population(5, 7, 2);
            population.FormInitialPopulation();
            List<Individual> initialPopulation = population.getInitialPopulation();
            List<SetOfNonDominatedOptions> setOfNonDominatedOptions = new List<SetOfNonDominatedOptions>();
            SetOfNonDominatedOptions r = new SetOfNonDominatedOptions();
            List<Individual> IntermediaryPopulation = new List<Individual>();
            IntermediaryPopulation = r.findSetOfDominatedOptions(initialPopulation);
            setOfNonDominatedOptions.Add(r);
            while ((IntermediaryPopulation).Count!=0)
            {
                SetOfNonDominatedOptions nonDominated = new SetOfNonDominatedOptions();
                IntermediaryPopulation=nonDominated.findSetOfDominatedOptions(initialPopulation);
                setOfNonDominatedOptions.Add(nonDominated);
            }
        }
    }
}
