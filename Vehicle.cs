using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoVehicleProject
{
    public class Vehicle
    {
        string make;
        string type;
        string color;
        int speed;
        string madeIn;

        public Vehicle() 
        {
            this.madeIn = "USA";
        }

        //actionable item
        public void stopVehicle()
        {
            this.speed = 0;
            
        }

    }

    }

