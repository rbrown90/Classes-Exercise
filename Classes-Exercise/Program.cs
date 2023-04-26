using System;
using System.Collections.Generic;
using Classes_Exercise;

namespace ClassExample // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Make = "Porsche";
            myCar.Model = "911";
            myCar.Year = 2023;


            var carList = new List<Car>() { myCar, myCar, myCar, myCar };
            Console.WriteLine(carList.Capacity);
        }
    }
}