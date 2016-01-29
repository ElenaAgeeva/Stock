using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureInStock
{
    class Genotype
    {
        private int numberOfFurniture;
        private List<int> genotype;

        private Random randomCount;

        private int minCountOfOneKindOfFurniture;

        public Genotype(int _numberOfFurniture,int _minCountOfOneKindOfFurniture)
        {
            numberOfFurniture = _numberOfFurniture;
            genotype = new List<int>();
            randomCount = new Random();
            _minCountOfOneKindOfFurniture = minCountOfOneKindOfFurniture;
        }

        public List<int> FormRandomGenotype()
        {
            for(int indexOfFurniture=0; indexOfFurniture< numberOfFurniture; indexOfFurniture++)
            {
                genotype.Add(randomCount.Next(0, minCountOfOneKindOfFurniture));
            }
            return genotype;
        }

        public Phenotype GenotypeToPhenotype()
        {
            Phenotype phenotype = new Phenotype(numberOfFurniture, minCountOfOneKindOfFurniture);
            int[,] matrixOfPhenotype = phenotype.getPhenotype();
            for (int allele=0; allele<genotype.Count;allele++)
            {
                matrixOfPhenotype[allele,genotype[allele]] = 1;
            }
            phenotype.setPhenotype(matrixOfPhenotype);
            return phenotype;
        }
    }
}
