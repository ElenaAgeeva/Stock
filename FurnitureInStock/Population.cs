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

        private List<AdditionalInformation> additionalInformationAboutIndividual;

        public Population(int _countOfPopulation, int _numberOfFurniture, int _maxCountOfOneKindOfFurniture)
        {
            countOfPopulation = _countOfPopulation;
            numberOfFurniture = _numberOfFurniture;
            maxCountOfOneKindOfFurniture = _maxCountOfOneKindOfFurniture;
        }

        public List<Individual> FormInitialPopulation()
        {
            InitialPopulation = new List<Individual>();
            AddMoreInformation();
            for (int i=0; i< countOfPopulation; i++)
            {
                Individual individual = new Individual(numberOfFurniture, maxCountOfOneKindOfFurniture, additionalInformationAboutIndividual);
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
                    Convert.ToDouble(line[5]), Convert.ToDouble(line[6]));
                additionalInformationAboutIndividual.Add(AdditionalInformationAboutOneKind);
                System.Console.WriteLine(line);
                counter++;
            }
        }
    }
}
