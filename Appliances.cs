using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Appliances_Rental_System
{
    public class Appliances
    {
        private string brand;
        private string type;
        private string model;
        private string dimensions;
        private string colour;
        private string energyConsumption;
        private int monthlyFee;
        private int appliancesId;

        public string Brand { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Dimensions { get; set; }
        public string Colour { get; set; }
        public string EnergyConsumption { get; set; }
        public int MonthlyFee { get; set; }
        public int AppliancesId { get; set; }
        public Appliances(string brand, string type, string model, string dimensions, string colour, string energyConsumption, int monthlyFee, int appliancesId)
        {
            Brand = brand;
            Type = type;
            Model = model;
            Dimensions = dimensions;
            Colour = colour;
            EnergyConsumption = energyConsumption;
            MonthlyFee = monthlyFee;
            AppliancesId = appliancesId;
        }

    }


}

