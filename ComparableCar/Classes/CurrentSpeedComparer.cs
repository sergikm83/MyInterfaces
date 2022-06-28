using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ComparableCar.Classes
{
    public class CurrentSpeedComparer : IComparer
    {
        int IComparer.Compare(object x, object y)
        {
            Car t1 = x as Car;
            Car t2 = y as Car;
            if (t1 != null && t2 != null)
                return t1.CurrentSpeed.CompareTo(t2.CurrentSpeed);
            else
                throw new ArgumentException("Parameters is not a Car!");
        }
    }
}
