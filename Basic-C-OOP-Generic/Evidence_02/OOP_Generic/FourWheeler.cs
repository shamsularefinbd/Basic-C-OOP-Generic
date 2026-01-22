using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_02.OOP_Generic
{
    public class FourWheeler : Vehicle, IInteriorDesign
    {
        public FourWheeler()
        {
        }

        public FourWheeler(string modelNo, int yearMake, int numberOfGear, int engineCapacityInCC, VehicelType vehicelType, int NumberOfSeat, int NumberOfDoor) : base(modelNo, yearMake, numberOfGear, engineCapacityInCC, vehicelType)
        { 
            this.NumberOfSeat = numberOfGear;
            this.NumberOfDoor = NumberOfDoor;
        }

        private List<string> InDesigns = new List<string>();

        public int NumberOfSeat { get; set; }
        public int NumberOfDoor { get; set; }


        public void AddInteriorDesign(params string[] design)
        {
            this.InDesigns.AddRange(design);
        }

        public override string Details()
        {
            return $"{ModelNo}, {EngineCapacityInCC}, {YearMake},{NumberOfGear}, {NumberOfSeat} seats, {NumberOfDoor}";
        }

        public string GetInteriorDesign()
        {
            return string.Join(", ", InDesigns);
        }
    }
}