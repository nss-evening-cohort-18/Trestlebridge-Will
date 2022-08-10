using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;

namespace trestleBridge.Models.Plants
{
    internal class Wildflower : IFlower, IResource
    {
        private Guid _id = Guid.NewGuid();
        private double _seedsProduced = 36.1;
        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }
        public double WaterPerDay { get; set; } = 3.8;
        public object Type { get; } = "Wildflower";
        public void Absorb()
        {
            Console.WriteLine($"Wildflower plants {this._shortId} just absorbed {this.WaterPerDay} gallons of water");
        }
        public double Reap()
        {
            return _seedsProduced;
        }
        public override string ToString()
        {
            return $"Sunflower plants {this._shortId}. Yeehaw!";
        }
    }
}
