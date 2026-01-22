using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_02.OOP_Generic
{
    public class TwoWheeler : Vehicle, IExteriorDesign
    {
      
        public TwoWheeler() { }
        public TwoWheeler(string modelNo, int yearMake, int numberOfGear, int engineCapacityInCC, VehicelType vehicelType,string StartingMethod, int MaximumPowerInBPH, int MaximumTorqueInNM, int Mileage, string Cooling, string FrontBrake, string RearBrake): base(modelNo,yearMake,numberOfGear,engineCapacityInCC,vehicelType)
        {
            this.StartingMethod = StartingMethod;
            this.MaximumPowerInBPH = MaximumPowerInBPH;
            this.MaximumTorqueInNM = MaximumTorqueInNM;
            this.Mileage = Mileage;
            this.Cooling = Cooling;
            this.FrontBrake = FrontBrake;
            this.RearBrake = RearBrake;
        }

        private List<string> exDesigns = new List<string>();

        public string StartingMethod { get; set; }
        public int MaximumPowerInBPH { get; set; }
        public int MaximumTorqueInNM { get; set; }
        public int Mileage { get; set; }
        public string Cooling { get; set; }
        public string FrontBrake { get; set; }
        public string RearBrake { get; set; }

        public void AddExteriorDesign(params string[] Design)
        {
            this.exDesigns.AddRange(Design);
        }

        public override string Details()
        {
            return $"{ModelNo},{YearMake},{NumberOfGear},{StartingMethod},{EngineCapacityInCC},{MaximumPowerInBPH},{MaximumTorqueInNM},{Mileage},{Cooling},{FrontBrake},{RearBrake},{VehicelType}";
        }

        public string GetExterior()
        {
            return string.Join(",", exDesigns);
        }
    }
}
