using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_5_Tutorials.Models
{
    public class HelloModel
    {
        public static List<Car> GetCar()
        {
            List<Car> cars = new List<Car>
             {
                 new Car {Id=1,Make="BMW",Model="i8" },
                 new Car { Id=2, Make="Audi",Model="R8"},
                 new Car { Id=3 , Make="Lamborgini", Model="Urus" }
             };
            return cars;
        }
    }

    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }
}