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

        private double SCommon;

        private double PCommon;

        public Individual(int _numberOfFurniture, int _maxCountOfOneKindOfFurniture, List<AdditionalInformation> _additionalInformationAboutIndividual)
        {
            numberOfFurniture = _numberOfFurniture;
            maxCountOfOneKindOfFurniture = _maxCountOfOneKindOfFurniture;
            additionalInformationAboutIndividual = _additionalInformationAboutIndividual;
            genotypeOfIndividual = new Genotype(numberOfFurniture, maxCountOfOneKindOfFurniture);
            individual = genotypeOfIndividual.FormRandomGenotype();
            phenotypeOfIndividual = genotypeOfIndividual.GenotypeToPhenotype();
            CountPCommon();
            CountSCommon();
        }

        private void CountPCommon()
        {
            for(int i=0; i<individual.Count; i++)
            {
                PCommon += individual[i] * (additionalInformationAboutIndividual[i].getTheProbabilityOfSellingTheFurniture() *
                    additionalInformationAboutIndividual[i].getProfitsFromTheSaleOf() - additionalInformationAboutIndividual[i].getStorageCosts());
            }
        }

        private void CountSCommon()
        {
            for (int i = 0; i < individual.Count; i++)
            {
                SCommon += individual[i] * (additionalInformationAboutIndividual[i].getConsumptionDueToTheLackOfStockss()+
                    additionalInformationAboutIndividual[i].getAccommodationCosts() + additionalInformationAboutIndividual[i].getMaintenanceCosts()+
                    additionalInformationAboutIndividual[i].getManufacturingCosts());
            }
        }
    }
}
