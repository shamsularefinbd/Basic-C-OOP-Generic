using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_02.OOP_Generic
{
    public sealed class MotorCycle : TwoWheeler
    {
        public MotorCycle()
        {
        }

        public MotorCycle(string modelNo, int yearMake, int numberOfGear, int engineCapacityInCC, VehicelType vehicelType, string StartingMethod, int MaximumPowerInBPH, int MaximumTorqueInNM, int Mileage, string Cooling, string FrontBrake, string RearBrake) : base(modelNo, yearMake, numberOfGear, engineCapacityInCC, vehicelType, StartingMethod, MaximumPowerInBPH, MaximumTorqueInNM, Mileage, Cooling, FrontBrake, RearBrake)
        {
        }
    }
}
