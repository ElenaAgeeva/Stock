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
                IntermediaryPopulation=nonDominated.findSetOfDominatedOptions(IntermediaryPopulation);
                setOfNonDominatedOptions.Add(nonDominated);
            }
            List<Individual> populationToSelection = new List<Individual>();
            for (int i=0; i<setOfNonDominatedOptions.Count;i++)
            {
                setOfNonDominatedOptions[i].setRang(setOfNonDominatedOptions.Count - i);
                setOfNonDominatedOptions[i].AssessmentOfFitness();
                setOfNonDominatedOptions[i].getNonDominated().ForEach(x => populationToSelection.Add(x));
            }
            Selection selection = new Selection(initialPopulation.Count);
            selection.tournament(populationToSelection, 3);
            crossover crossov = new crossover();
            crossov.cross(populationToSelection,0.3);
            mutation mt = new mutation();
            mt.mutatio(populationToSelection, 0.1);   
        }
    }
}
