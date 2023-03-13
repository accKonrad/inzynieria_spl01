using System;
using System.Collections.Generic;
using System.Text;
namespace TestProject1.Models
{
    class Car
    {
        public String Mark { get; set; }
        public String Model { get; set; }
        public int Year { get; set; }
        public List<Engine> Engine { get; set; }
        public List<AboutCar> AboutCar { get; set; }
    }
}
