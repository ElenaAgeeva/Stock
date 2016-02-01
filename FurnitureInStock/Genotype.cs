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

        private int maxCountOfOneKindOfFurniture;

        public Genotype(int _numberOfFurniture,int _maxCountOfOneKindOfFurniture)
        {
            numberOfFurniture = _numberOfFurniture;
            genotype = new List<int>();
            randomCount = new Random();
            this.maxCountOfOneKindOfFurniture = _maxCountOfOneKindOfFurniture;
        }

        public List<int> FormRandomGenotype()
        {
            for(int indexOfFurniture=0; indexOfFurniture< numberOfFurniture; indexOfFurniture++)
            {
                genotype.Add(randomCount.Next(0, maxCountOfOneKindOfFurniture+1));
            }
            return genotype;
        }

        public Phenotype GenotypeToPhenotype()
        {
            Phenotype phenotype = new Phenotype(numberOfFurniture, maxCountOfOneKindOfFurniture+1);
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
