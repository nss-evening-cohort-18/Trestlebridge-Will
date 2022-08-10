using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trestleBridge.Interfaces
{
    public interface IGrazing : IResource
    {
        double GrassPerDay { get; set; }
        void Graze();
    }
}
