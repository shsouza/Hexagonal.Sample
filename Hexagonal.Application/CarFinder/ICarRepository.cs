using Hexagonal.Domain.Cars;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hexagonal.Application.CarFinder
{
    public interface ICarRepository
    {
        Task<IList<Car>> Search(CarSearch search);
    }
}
