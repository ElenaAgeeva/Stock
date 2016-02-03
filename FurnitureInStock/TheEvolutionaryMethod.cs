using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureInStock
{
    class TheEvolutionaryMethod
    {
        private int numberOfFurniture;

        private int minCountOfOneKindOfFurniture;

        //private List<Genotype> population;

        public TheEvolutionaryMethod(int _numberOfFurniture, int _minCountOfOneKindOfFurniture)
        {
            numberOfFurniture = _numberOfFurniture;
            minCountOfOneKindOfFurniture = _minCountOfOneKindOfFurniture;
        }

        
        /*public void GenerationInitialPopulation(int countOfPopulation)
        {
            for (int indexOfGenotype=0; indexOfGenotype< countOfPopulation; countOfPopulation++)
            {
                population.Add(new Genotype(numberOfFurniture, minCountOfOneKindOfFurniture));
            }
        } */
    }
}
