using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hexagonal.WebApi.CarFinder
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarFinderController : ControllerBase
    {
        [HttpGet]
        public async Task<IList<CarSelectionModel>> FindACar(FindACarRequest request)
        {
            return null;
        }
    }
}