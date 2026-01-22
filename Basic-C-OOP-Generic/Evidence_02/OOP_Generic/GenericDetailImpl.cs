using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_02.OOP_Generic
{
    public class GenericDetailImpl<T> : IGenericDetail<T>
    {
        public string GetDetail<T1>(T1 obj)
        {
            if (obj is Vehicle)
            {
                Vehicle v = obj as Vehicle;
                return v.Details();
            }
            else
            {
                return "Not a Vehicel";
            }
        }
    }
}
