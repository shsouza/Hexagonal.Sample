﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hexagonal.WebApi.CarFinder
{
    public class CarSelectionModel
    {
        public string Maker { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public double Price { get; set; }
    }
}
