using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;

namespace trestleBridge.Models.Animals
{
    public class Chicken : IGrazing, IMeatProducing
    {
        private Guid _id = Guid.NewGuid();
        //on the livestock table in the readme it is 7 / .5kg / 1.7kg but i need to check how to do a range
        private double _meatProduced = 7.5;
        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public double GrassPerDay { get; set; } = 0.9;
        public object Type { get; } = "Chicken";

        // Methods
        public void Graze()
        {
            Console.WriteLine($"Chicken {this._shortId} just ate {this.GrassPerDay}kg of feed");
        }

        public double Butcher()
        {
            return _meatProduced;
        }
        public override string ToString()
        {
            return $"Chicken {this._shortId}. Cluck!";
        }
    }
}