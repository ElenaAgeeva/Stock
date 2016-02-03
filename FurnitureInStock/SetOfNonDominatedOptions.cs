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

        public void setRang(int _rang)
        {
            rang = _rang;
        }

        public List<Individual> getNonDominated()
        {
            return nonDominated;
        }

        public List<Individual> findSetOfDominatedOptions(List<Individual> population)
        {
            dominated = new List<Individual>();
            population.ForEach(x => nonDominated.Add(x));
            for (int i = 0; i < population.Count; i++)
            {
                for (int j = 0; j < population.Count; j++)
                {
                    if (i != j)
                    {
                        if ((population[i].getSCommon() >= population[j].getSCommon()) && (population[i].getPCommon() > population[j].getPCommon()) ||
                            (population[i].getSCommon() > population[j].getSCommon()) && (population[i].getPCommon() >= population[j].getPCommon()))
                        {
                            dominated.Add(population[j]);
                        }
                    }
                }
            }
            dominated.ForEach(y => nonDominated.RemoveAll(x => x.Equals(y)));
            dominated.Clear();
            population.ForEach(x => dominated.Add(x));
            nonDominated.ForEach(y => dominated.RemoveAll(x => x.Equals(y)));
            return dominated;
        }

        public void AssessmentOfFitness()
        {
            for (int i = 0; i < nonDominated.Count; i++)
            {
                double max = -1;
                for (int j = 0; j < nonDominated.Count; j++)
                {
                    if (i != j)
                    {
                        double temprary = EuclideanDistance(nonDominated[i].getPCommon(), nonDominated[j].getPCommon(), nonDominated[i].getSCommon(), nonDominated[j].getSCommon());
                        if (temprary > max)
                        {
                            max = temprary;
                            nonDominated[i].setMaxEuclideanDistance(max);
                        }
                    }
                }
            }
            nonDominated.OrderBy(x => x.getMaxEuclideanDistance());
            for (int i = 0; i < nonDominated.Count; i++)
            {
                nonDominated[i].setAssessmentOfFitness(rang + (nonDominated.Count - (1 + i)) / Convert.ToDouble(nonDominated.Count));
            }
        }

        private double EuclideanDistance(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }
    }
}
