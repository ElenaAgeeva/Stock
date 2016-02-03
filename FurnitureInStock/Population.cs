﻿using System;
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

        private List<AdditionalInformation> additionalInformationAboutIndividual;

        private double maxVolume;

        private double maxCost;

        private List<Individual> commonNonDominatedOptions;

        private List<Individual> commonNonDominatedOld;

        private int maxNonImprovement;

        private int nonImprovement;

        public Population(int _countOfPopulation, int _numberOfFurniture, int _maxCountOfOneKindOfFurniture,double _maxVolume,
            double _maxCost,int _maxNonImprovement)
        {
            countOfPopulation = _countOfPopulation;
            numberOfFurniture = _numberOfFurniture;
            maxCountOfOneKindOfFurniture = _maxCountOfOneKindOfFurniture;
            maxVolume = _maxVolume;
            maxCost = _maxCost;
            maxNonImprovement = _maxNonImprovement;
            commonNonDominatedOld = new List<Individual>();
        }

        public List<Individual> FormInitialPopulation()
        {
            InitialPopulation = new List<Individual>();
            AddMoreInformation();
            Random randomCount= new Random();
            for (int i=0; i< countOfPopulation; i++)
            {
                Individual individual = new Individual(numberOfFurniture, maxCountOfOneKindOfFurniture, additionalInformationAboutIndividual,
                    randomCount,maxVolume,maxCost);
                InitialPopulation.Add(individual);
            }
            return InitialPopulation;
        }

        public void AddMoreInformation()
        {
            string lineFromFile = "";
            int counter = 0;
            additionalInformationAboutIndividual = new List<AdditionalInformation>();
            System.IO.StreamReader file =
    new System.IO.StreamReader(@"data.txt");
            while ((counter<numberOfFurniture) &&((lineFromFile = file.ReadLine()) != null))
            {
                string[] line= lineFromFile.Split(' ');
                AdditionalInformation AdditionalInformationAboutOneKind = new AdditionalInformation(Convert.ToDouble(line[0]),
                    Convert.ToDouble(line[1]), Convert.ToDouble(line[2]), Convert.ToDouble(line[3]), Convert.ToDouble(line[4]),
                    Convert.ToDouble(line[5]), Convert.ToDouble(line[6]),Convert.ToDouble(line[7]));
                additionalInformationAboutIndividual.Add(AdditionalInformationAboutOneKind);
                System.Console.WriteLine(line);
                counter++;
            }
        }

        public List<Individual> getInitialPopulation()
        {
            return InitialPopulation;
        }

        public List<Individual> FindFitnessAssessment(List<Individual> withoutFitnessAssessment)
        {
            if (withoutFitnessAssessment.Count!=0)
            {
                List<SetOfNonDominatedOptions> setOfNonDominatedOptions = new List<SetOfNonDominatedOptions>();
                List<Individual> IntermediaryPopulation = new List<Individual>();
                do
                {
                    SetOfNonDominatedOptions nonDominated = new SetOfNonDominatedOptions();
                    IntermediaryPopulation = nonDominated.findSetOfDominatedOptions(IntermediaryPopulation);
                    setOfNonDominatedOptions.Add(nonDominated);
                }
                while (IntermediaryPopulation.Count != 0);
                List<Individual> withFitnessAssessment = new List<Individual>();
                for (int i = 0; i < setOfNonDominatedOptions.Count; i++)
                {
                    setOfNonDominatedOptions[i].setRang(setOfNonDominatedOptions.Count - i);
                    setOfNonDominatedOptions[i].AssessmentOfFitness();
                    setOfNonDominatedOptions[i].getNonDominated().ForEach(x => withFitnessAssessment.Add(x));
                }
                if (setOfNonDominatedOptions.Count != 0)
                {
                    commonNonDominatedOptions.Clear();
                    setOfNonDominatedOptions[0].getNonDominated().ForEach(x => commonNonDominatedOptions.Add(x));
                }
                return withFitnessAssessment;
            }
            return withoutFitnessAssessment;
        }

        public bool checkOldAndNewCommonNonDominatedOptions()
        {
            List<Individual> intersectOfTwo = commonNonDominatedOld.Intersect(commonNonDominatedOptions.AsEnumerable()).ToList();
            return ((intersectOfTwo.Count.Equals(commonNonDominatedOld.Count)) && (intersectOfTwo.Count.Equals(commonNonDominatedOptions.Count)));
        }

        public List<Individual> getCommonNonDominatedOptions()
        {
            return commonNonDominatedOptions;
        }

        public bool CheckForNoImprovment()
        {
            if (checkOldAndNewCommonNonDominatedOptions())
                nonImprovement++;
            else
                nonImprovement = 0;
            return maxNonImprovement < nonImprovement;
        }
    }
}
