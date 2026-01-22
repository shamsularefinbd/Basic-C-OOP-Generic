using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_02.OOP_Generic
{
    public class VehicelDetailImpl<T> : IVehicelDetail<T>
    {
        public string GetDetail<T1>(T1 obj) where T1 : Vehicle
        {
            return obj.Details();
        }
    }
}
