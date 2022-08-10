﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trestleBridge.Interfaces
{
    public interface IFlower
    {
        double WaterPerDay { get; set; }
        string Type { get; }
        void Absorb();
    }
}