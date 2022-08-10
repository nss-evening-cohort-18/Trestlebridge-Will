using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;

namespace trestleBridge.Models.Animals
{
    public class Duck : IGrazing, IMeatProducing
    {
        private Guid _id = Guid.NewGuid();
        private double _meatProduced = 6.75;
        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public double GrassPerDay { get; set; } =0.8;
        public object Type { get; } = "Duck";

        // Methods
        public void Graze()
        {
            Console.WriteLine($"Duck {this._shortId} just ate {this.GrassPerDay}kg of feed");
        }

        public double Butcher()
        {
            return _meatProduced;
        }
        public override string ToString()
        {
            return $"Duck {this._shortId}. Quack!";
        }

    }
}
