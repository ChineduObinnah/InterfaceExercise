﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle , ICompany
    {
        public bool moonroof { get; set; }
        public bool Leather { get; set; }
        public int Wheels { get; set; } 
        public string Name { get; set; }    
        public bool Wipers { get; set; }
        public bool Airbags { get; set; }   
        public string Logo { get; set; }
        public int Revenue { get; set; }    
        public int Age  { get; set; }
        public string Motto { get; set; }   
    }
}
