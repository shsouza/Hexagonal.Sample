using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hexagonal.WebApi.CarFinder
{
    public class FindACarRequest
    {
        public double Budget { get; set; }

        public int Seats { get; set; }
    }
}
