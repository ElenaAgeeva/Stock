﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureInStock
{
    class mutation
    {
        public List<Individual> mutatio(List<Individual> ch, double probability)
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
            bool t = true;
            while ((newch.Count != 0) && (t))
            {
                Random rand = new Random();
                int index_of_ch = rand.Next(0, newch.Count);
                List<Individual> lis = new List<Individual>();
                ch.Add(simple(newch[index_of_ch]));
                newch.Remove(newch[index_of_ch]);
            }
            return ch;
        }

        private Individual simple(Individual individual)
        {
            int[] a = individual.getIndividual().ToArray();
            if (a.Length > 1)
            {
                int[] c = new int[a.Length];
                Random rand = new Random();
                int point = rand.Next(1, a.Length - 1);
                Array.Copy(a, c, a.Length);
                int ct = c[point];
                c[point] = c[point - 1];
                c[point - 1] = ct;
                //надо проверить на выполнение ограничений
                individual.setIndividual(c.ToList());
                return individual;
            }
            else
            {
                return individual;
            }
        }
    }
}