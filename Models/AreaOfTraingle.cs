using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wema.BIT.Models
{
    internal class AreaOfTraingle     
    {
        public class Triangle
        {
            public double Base { get; set; }
            public double Height { get; set; }

            public double CalculateArea()
            {
                return 0.5 * Base * Height;
            }
        }
    }

}

