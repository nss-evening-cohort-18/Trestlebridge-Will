using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trestleBridge.Models.Plants
{
    internal class Sunflower
    {
        private Guid _id = Guid.NewGuid();
        private double _seedsProduced = 42.3;
        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }
        public double WaterPerDay { get; set; } = 4.7;
        public string Type { get; } = "Sesame";
        public void Absorb()
        {
            Console.WriteLine($"Sunflower plants {this._shortId} just absorbed {this.WaterPerDay} gallons of water");
        }
        public double Reap()
        {
            return _seedsProduced;
        }
        public override string ToString()
        {
            return $"Sunflower plants {this._shortId}. Shine!";
        }
    }
}
