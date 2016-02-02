using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureInStock
{
    class SetOfNonDominatedOptions
    {
        private int rang;

        private List<Individual> nonDominated;

        private List<Individual> dominated;

        public SetOfNonDominatedOptions()
        {
            nonDominated = new List<Individual>();
        }

        public List<Individual> getNonDominated()
        {
            return nonDominated;
        }

        public List<Individual> findSetOfDominatedOptions(List<Individual> population)
        {
            dominated = new List<Individual>();
            population.ForEach(x => nonDominated.Add(x));
            for (int i=0; i<population.Count; i++)
            {
                for (int j = 0; j < population.Count; j++)
                {
                    if (i!=j)
                    {
                        if ((population[i].getSCommon()>=population[j].getSCommon())&& (population[i].getPCommon() > population[j].getPCommon())||
                            (population[i].getSCommon() > population[j].getSCommon())&& (population[i].getPCommon() >= population[j].getPCommon()))
                        {
                            dominated.Add(population[j]);
                        }
                    }
                }
            }
            dominated.ForEach(y=> nonDominated.RemoveAll(x => x.Equals(y)));
            return dominated;
        }
    }
}
