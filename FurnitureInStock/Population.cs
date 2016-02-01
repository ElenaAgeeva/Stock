using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureInStock
{
    class Population
    {
        private int countOfPopulation;

        private List<Individual> InitialPopulation;

        private int numberOfFurniture;

        private int maxCountOfOneKindOfFurniture;

        public Population(int _countOfPopulation, int _numberOfFurniture, int _maxCountOfOneKindOfFurniture)
        {
            countOfPopulation = _countOfPopulation;
            numberOfFurniture = _numberOfFurniture;
            maxCountOfOneKindOfFurniture = _maxCountOfOneKindOfFurniture;
        }

        public List<Individual> FormInitialPopulation()
        {
            InitialPopulation = new List<Individual>();
            for (int i=0; i< countOfPopulation; i++)
            {
                Individual individual = new Individual(numberOfFurniture, maxCountOfOneKindOfFurniture);
                InitialPopulation.Add(individual);
            }
            return InitialPopulation;
        }
    }
}
