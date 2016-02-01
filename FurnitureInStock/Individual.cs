using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureInStock
{
    public class Individual
    {
        private List<int> individual;

        private Genotype genotypeOfIndividual;

        private Phenotype phenotypeOfIndividual;

        private int numberOfFurniture;

        private int maxCountOfOneKindOfFurniture;

        private List<AdditionalInformation> additionalInformationAboutIndividual;

        public Individual(int _numberOfFurniture, int _maxCountOfOneKindOfFurniture, List<AdditionalInformation> _additionalInformationAboutIndividual)
        {
            numberOfFurniture = _numberOfFurniture;
            maxCountOfOneKindOfFurniture = _maxCountOfOneKindOfFurniture;
            additionalInformationAboutIndividual = _additionalInformationAboutIndividual;
            genotypeOfIndividual = new Genotype(numberOfFurniture, maxCountOfOneKindOfFurniture);
            individual = genotypeOfIndividual.FormRandomGenotype();
            phenotypeOfIndividual = genotypeOfIndividual.GenotypeToPhenotype();
        }
    }
}
