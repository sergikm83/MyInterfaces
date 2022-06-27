using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyInterfaces.Classes
{
    public class PointyTestClass : IPointy
    {
        public byte Points => throw new NotImplementedException();
    }
}
