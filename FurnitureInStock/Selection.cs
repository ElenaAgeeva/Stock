using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureInStock
{
    class Selection
    {
        public static int nc;

        public Selection(int n)
        {
            nc = n;
        }

        public List<Individual> tournament(List<Individual> ch, int count_of_tour)
        {
            List<Individual> newch = new List<Individual>();
            
            Random rand = new Random();
            for (int j = 0; j < nc; j++)
            {
                List<Individual> tempch = new List<Individual>();
                int index1 = rand.Next(0, ch.Count);
                int index2 = rand.Next(0, ch.Count);
                int index3 = rand.Next(0, ch.Count);
                //int index4 = rand.Next(0, ch.Count);
                while (index1 == index2)
                {
                    index2 = rand.Next(0, ch.Count);
                }
                tempch.Add(ch[index1]);
                tempch.Add(ch[index2]);
                //if ((count_of_tour == 3) || (count_of_tour == 4))
                //{
                while ((index1 == index3) || (index2 == index3))
                    {
                        index3 = rand.Next(0, ch.Count);
                    }
                tempch.Add(ch[index3]);
                /*}
                else
                {
                    if (ch[index1].getAssessmentOfFitness() > ch[index2].getAssessmentOfFitness())
                    {
                        newch.Add(ch[index1]);
                    }
                    else
                    {
                        newch.Add(ch[index2]);
                    }
                }
                if (count_of_tour == 4)
                {
                    while ((index1 == index4) || (index2 == index4) || (index3 == index4))
                    {
                        index4 = rand.Next(0, ch.Count);
                    }
                    if ((ch[index1].getAssessmentOfFitness() > ch[index2].getAssessmentOfFitness()) 
                        && (ch[index1].getAssessmentOfFitness() > ch[index3].getAssessmentOfFitness())
                        && (ch[index1].getAssessmentOfFitness() > ch[index4].getAssessmentOfFitness()))
                    {
                        newch.Add(ch[index1]);
                    }
                    if ((ch[index2].getAssessmentOfFitness() > ch[index1].getAssessmentOfFitness())
                        && (ch[index2].getAssessmentOfFitness() > ch[index3].getAssessmentOfFitness())
                        && (ch[index2].getAssessmentOfFitness() > ch[index4].getAssessmentOfFitness()))
                    {
                        newch.Add(ch[index2]);
                    }
                    if ((ch[index3].getAssessmentOfFitness() > ch[index1].getAssessmentOfFitness())
                        && (ch[index3].getAssessmentOfFitness() > ch[index2].getAssessmentOfFitness())
                        && (ch[index3].getAssessmentOfFitness() > ch[index4].getAssessmentOfFitness()))
                    {
                        newch.Add(ch[index3]);
                    }
                    if ((ch[index4].getAssessmentOfFitness() > ch[index1].getAssessmentOfFitness())
                        && (ch[index4].getAssessmentOfFitness() > ch[index2].getAssessmentOfFitness())
                        && (ch[index4].getAssessmentOfFitness() > ch[index3].getAssessmentOfFitness()))
                    {
                        newch.Add(ch[index4]);
                    }
                }
                else
                {*/
                if (count_of_tour == 3)
                    {
                    newch.Add(tempch.OrderByDescending(x => x.AssessmentOfFitness).First());
                    
                    }
                //}
            }
            return newch;
        }
    }
}
