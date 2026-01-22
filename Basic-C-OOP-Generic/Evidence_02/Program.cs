using Evidence_02.OOP_Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MotorCycle m1 = new MotorCycle("R15M4", 2023, 6, 250, VehicelType.Personal, "self", 10000, 7500, 45, "Air", "AVS", "Disk");
            m1.AddExteriorDesign("P P Horn","Fog Hight","LED Light","3 Part Handel");
            GenericDetailImpl <MotorCycle> gd = new GenericDetailImpl<MotorCycle>();
            Console.WriteLine(gd.GetDetail<MotorCycle>(m1));
            Console.WriteLine(m1.GetExterior());
            Console.WriteLine();


            Car c1 = new Car("Land Cruiser",2019,6,1500,VehicelType.Family,5,5);
            c1.AddInteriorDesign("GPS","Auto Drive","DVD Music");
            VehicelDetailImpl<Car> cm = new VehicelDetailImpl<Car>();
            Console.WriteLine(gd.GetDetail<Car>(c1));
            Console.WriteLine(c1.GetInteriorDesign());
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
