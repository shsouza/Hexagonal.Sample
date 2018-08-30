using Hexagonal.Application.CarFinder;
using Hexagonal.Domain.Cars;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hexagonal.Infrastructure.CarFinder
{
    public class CarRepository : ICarRepository
    {
        public Task<IList<Car>> Search(CarSearch search)
        {
            throw new NotImplementedException();
        }
    }
}
