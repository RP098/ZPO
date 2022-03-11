using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategia
{
    class Program
    {
        static void Main(string[] args)
        {
            Maluch maluch = new Maluch();
            Ford ford = new Ford();
            Porsche porsche = new Porsche();
            Car car = new Car();
            IStrategyCar strategyCar = porsche;
            Console.WriteLine("Maluch max speed {0}", car.MaxSpeed(maluch));
            Console.WriteLine("Ford max speed {0}", car.MaxSpeed(ford));
            Console.WriteLine("Porsche max speed {0}", car.MaxSpeed(porsche));
           
            Car.SpeedDelegate speed = new Car.SpeedDelegate(car.MaxSpeed);
            Console.WriteLine("Ford max speed {0}",speed(new Ford())); 
            speed = new Car.SpeedDelegate(car.MinSpeed);
            Console.WriteLine("Maluch min speed {0}", speed(new Maluch()));

            Console.ReadKey();
        }
    }
}
