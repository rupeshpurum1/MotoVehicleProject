using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoVehicleProject
{
    public class Vehicle
    {
        public string make;
        public string type;
        public string color;
        public int speed;
        public string madeIn;

        public Vehicle() 
        {
            this.madeIn = "USA";
        }

        //actionable item
        public void stopVehicle()
        {
            this.speed = 10;
            
        }


    }

}



