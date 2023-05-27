using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public int Wheels { get; set; }  
        public string Name { get; set; }

        public bool Wipers { get; set; }  

        public bool Airbags { get; set; }
    }
}
