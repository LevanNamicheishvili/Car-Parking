using System;                    
using CarParkingSystem.Models;        

namespace CarParkingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("ABC123", "Toyota Corolla", "Blue", "medium");
            Console.WriteLine(myCar.ToString());
        }
    }
}
