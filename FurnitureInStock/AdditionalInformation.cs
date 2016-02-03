using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureInStock
{
    public class AdditionalInformation
    {
        private double theProbabilityOfSellingTheFurniture;

        private double profitsFromTheSaleOf;

        private double storageCosts;

        private double manufacturingCosts;

        private double accommodationCosts;

        private double maintenanceCosts;

        private double consumptionDueToTheLackOfStocks;

        private double volumeOfFurniture;

        public AdditionalInformation(double _theProbabilityOfSellingTheFurniture, double _profitsFromTheSaleOf,double _storageCosts,
            double _manufacturingCosts, double _accommodationCosts, double _maintenanceCosts,double _consumptionDueToTheLackOfStocks,
            double _volumeOfFurniture)
        {
            theProbabilityOfSellingTheFurniture = _theProbabilityOfSellingTheFurniture;
            profitsFromTheSaleOf = _profitsFromTheSaleOf;
            storageCosts = _storageCosts;
            manufacturingCosts = _manufacturingCosts;
            accommodationCosts = _accommodationCosts;
            maintenanceCosts = _maintenanceCosts;
            consumptionDueToTheLackOfStocks = _consumptionDueToTheLackOfStocks;
            volumeOfFurniture = _volumeOfFurniture;
        }

        public double getVolumeOfFurniture()
        {
            return volumeOfFurniture;
        }

        public double getTheProbabilityOfSellingTheFurniture()
        {
            return theProbabilityOfSellingTheFurniture;
        }

        public double getStorageCosts()
        {
            return storageCosts;
        }

        public double getProfitsFromTheSaleOf()
        {
            return profitsFromTheSaleOf;
        }

        public double getManufacturingCosts()
        {
            return manufacturingCosts;
        }

        public double getAccommodationCosts()
        {
            return accommodationCosts;
        }

        public double getMaintenanceCosts()
        {
            return maintenanceCosts;
        }

        public double getConsumptionDueToTheLackOfStockss()
        {
            return consumptionDueToTheLackOfStocks;
        }
    }
}
