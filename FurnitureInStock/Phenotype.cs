using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureInStock
{
    class Phenotype
    {
        private int numberOfFurniture;

        private int minCountOfOneKindOfFurniture;

        private int[,] phenotype;

        public Phenotype(int _numberOfFurniture,int _minCountOfOneKindOfFurniture)
        {
            _numberOfFurniture = numberOfFurniture;
            _minCountOfOneKindOfFurniture = minCountOfOneKindOfFurniture;
            phenotype = new int[numberOfFurniture,minCountOfOneKindOfFurniture];
        }

        public int[,] getPhenotype()
        {
            return phenotype;
        }

        public void setPhenotype(int[,] _phenotype)
        {
            _phenotype = phenotype;
        }
    }
}
