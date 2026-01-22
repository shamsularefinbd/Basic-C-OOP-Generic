using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_02.OOP_Generic
{
    public abstract class Vehicle
    {
        protected Vehicle()
        {
        }

        protected Vehicle(string modelNo, int yearMake, int numberOfGear, int engineCapacityInCC, VehicelType vehicelType)
        {
            ModelNo = modelNo;
            YearMake = yearMake;
            NumberOfGear = numberOfGear;
            EngineCapacityInCC = engineCapacityInCC;
            VehicelType = vehicelType;
        }

        public string ModelNo { get; set; }
        public int YearMake { get; set; }
        public int NumberOfGear {  get; set; }
        public int EngineCapacityInCC { get; set; }
        public VehicelType VehicelType { get; set; }

        public abstract string Details();

    }
}
