using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;

namespace trestleBridge.Models.Plants
{
    internal class Sesame : IFlower, IResource
    {
        private Guid _id = Guid.NewGuid();
        private double _seedsProduced = 18.25;
        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }
        public double WaterPerDay { get; set; } = 5.4;
        public object Type { get; } = "Sesame";
        public void Absorb()
        {
            Console.WriteLine($"Sesame plants {this._shortId} just absorbed {this.WaterPerDay} gallons of water");
        }
        public double Reap()
        {
            return _seedsProduced;
        }
        public override string ToString()
        {
            return $"Sesame plants {this._shortId}. Open!";
        }
    }
}
