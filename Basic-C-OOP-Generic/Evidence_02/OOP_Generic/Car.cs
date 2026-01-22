using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_02.OOP_Generic
{
    public sealed class Car:FourWheeler

    {
        public Car()
        {
        }

        public Car(string modelNo, int yearMake, int numberOfGear, int engineCapacityInCC, VehicelType vehicelType, int NumberOfSeat, int NumberOfDoor) : base(modelNo, yearMake, numberOfGear, engineCapacityInCC, vehicelType, NumberOfSeat, NumberOfDoor)
        {
        }
    }
}
