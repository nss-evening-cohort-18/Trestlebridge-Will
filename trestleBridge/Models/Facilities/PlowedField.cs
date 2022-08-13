using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;

namespace trestleBridge.Models.Facilities
{
    public class PlowedField : IFacility<IFlower>
    {
        private double _capacity = 13; //13 rows of plants; 5 plants per row
        private Guid _id = Guid.NewGuid();

        private List<IFlower> _flowers = new List<IFlower>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddResource(IFlower flower)
        {
            _flowers.Add(flower);
            _flowers.Add(flower);
            _flowers.Add(flower);
            _flowers.Add(flower);
            _flowers.Add(flower);
        }

        public void AddResource(List<IFlower> flowers)
        {
            _flowers.Add((IFlower)flowers);
        }
        public double OccupiedSpace()
        {
            return _flowers.Count / 5;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";
            output.Append($"Plowed field {shortId} has {this._flowers.Count} flowers\n");
            this._flowers.ForEach(a => output.Append($"   {a}\n"));
            return output.ToString();
        }
    }
}
