using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIInterfaceHierarchy.Interfaces
{
    public interface IShape : IDrawable, IPrintable
    {
        int GetNumberOfSides();
    }
}
