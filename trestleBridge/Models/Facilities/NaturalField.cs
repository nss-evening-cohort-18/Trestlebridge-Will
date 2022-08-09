using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;

namespace trestleBridge.Models.Facilities
{
    internal class NaturalField : IFacility<IFlower>
    {
        private double _capacity = 10; //10 rows of plants; 6 plants per row
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
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public void AddResource(List<IFlower> flowers)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";
            output.Append($"Natural field {shortId} has {this._flowers.Count} flowers\n");
            this._flowers.ForEach(a => output.Append($"   {a}\n"));
            return output.ToString();
        }
    }
}
