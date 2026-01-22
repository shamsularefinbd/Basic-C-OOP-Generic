using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_02.OOP_Generic
{
    public interface IGenericDetail<T>
    {
        string GetDetail<T>(T obj);
    }
}
