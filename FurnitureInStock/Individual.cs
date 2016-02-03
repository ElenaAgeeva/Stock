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

        private double maxEuclideanDistance;

        private double assessmentOfFitness;

        private Genotype genotypeOfIndividual;

        private Phenotype phenotypeOfIndividual;

        private int numberOfFurniture;

        private int maxCountOfOneKindOfFurniture;

        private List<AdditionalInformation> additionalInformationAboutIndividual;

        private double SCommon;

        private double PCommon;

        private Random randomCount;

        public Individual(int _numberOfFurniture, int _maxCountOfOneKindOfFurniture, List<AdditionalInformation> _additionalInformationAboutIndividual,Random _randomCount)
        {
            numberOfFurniture = _numberOfFurniture;
            maxCountOfOneKindOfFurniture = _maxCountOfOneKindOfFurniture;
            additionalInformationAboutIndividual = _additionalInformationAboutIndividual;
            randomCount = _randomCount;
            genotypeOfIndividual = new Genotype(numberOfFurniture, maxCountOfOneKindOfFurniture,randomCount);
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

        public double getSCommon()
        {
            return SCommon;
        }

        public double getPCommon()
        {
            return PCommon;
        }

        public void setMaxEuclideanDistance(double _maxEuclideanDistance)
        {
            maxEuclideanDistance= _maxEuclideanDistance;
        }

        public double getMaxEuclideanDistance()
        {
            return maxEuclideanDistance;
        }

        public void setAssessmentOfFitness(double _assessmentOfFitness)
        {
            assessmentOfFitness = _assessmentOfFitness;
        }

        public double getAssessmentOfFitness()
        {
            return assessmentOfFitness;
        }

        public List<int> getIndividual()
        {
            return individual;
        }

        public void setIndividual(List<int> _individual)
        {
            individual=_individual;
        }
    }
}
