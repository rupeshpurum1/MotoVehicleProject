using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoVehicleProject
{
    internal class AddEngineToVehicle
    {
        string engineType;
        
        int engineLife;

        public void electricEngine() {
            engineType = "Electric";
            engineLife = 30;
        }
    }
}
