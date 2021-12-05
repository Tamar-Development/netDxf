using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netDxf
{
    public class DoubleEqualityComparer : IEqualityComparer<double>
    {
        public bool Equals(double x, double y)
        {
            return MathHelper.IsEqual( x,y);
        }

        public int GetHashCode(double obj)
        {
            return Math.Round(obj, 4).GetHashCode();
        }
    }
}
