using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureInStock
{
    class crossover
    {
        public static List<Individual> cross(List<Individual> ch, double probability)
        {
            List<Individual> newch = new List<Individual>();
            int j = 0;
            int pr = ch.Count;
            while (j < Convert.ToInt32(Math.Round(pr * probability)))
            {
                Random rand = new Random();
                int index_of_ch = rand.Next(0, ch.Count);
                newch.Add(ch[index_of_ch]);
                ch.Remove(ch[index_of_ch]);
                j++;
            }
            while (newch.Count > 1)
            {
                Random rand = new Random();
                int index_of_ch1 = rand.Next(0, newch.Count);
                int index_of_ch2 = rand.Next(0, newch.Count);
                while (index_of_ch1 == index_of_ch2)
                {
                    index_of_ch2 = rand.Next(0, newch.Count);
                }
                List<Individual> lis = new List<Individual>();
                lis = steady(newch[index_of_ch1], newch[index_of_ch2]);
                foreach(Individual individ in lis)
                {
                    while (individ.checkForAllowabilityInVolume()||individ.checkForAllowabilityInCost())
                    {
                        individ.changeSomethingLittle();
                    }
                }
                if (index_of_ch1>index_of_ch2)
                {
                    newch.Remove(newch[index_of_ch1]);
                    newch.Remove(newch[index_of_ch2]);
                }
                else
                {
                    newch.Remove(newch[index_of_ch2]);
                    newch.Remove(newch[index_of_ch1]);
                }
                ch.AddRange(lis);
            }
            return ch;
        }

        private static List<Individual> steady(Individual a, Individual b)
        {
            List<Individual> lis = new List<Individual>();
            Random rand = new Random();
            int[] c1 = a.getIndividual().ToArray();
            int[] c2 = b.getIndividual().ToArray();
            for (int i = 0; i < a.getIndividual().Count; i++)
            {
                int point = rand.Next(0, 2);
                if (point == 0) { int temp = c1[i]; c1[i] = c2[i]; c2[i] = temp; }
            }
            a.setIndividual(c1.ToList());
            b.setIndividual(c2.ToList());
            lis.Add(a);
            lis.Add(b);
            return lis;
        }
    }
}
