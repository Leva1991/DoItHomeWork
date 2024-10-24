using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture11
{
    internal class Car
    {
        private String make { get; set; }
        private String model { get; set; }
        private int cylinder { get; set; }
        private double engine { get; set; }
        private String drive { get; set; }
        private String transmission { get; set; }
        private int city { get; set; }
        private int combined { get; set; }
        private int highway { get; set; }

        /*public Car(string make, string model, int cylinder, double engine, string drive, string transmission, int city, int combined, int highway)
        {
            this.make = make;
            this.model = model;
            this.cylinder = cylinder;
            this.engine = engine;
            this.drive = drive;
            this.transmission = transmission;
            this.city = city;
            this.combined = combined;
            this.highway = highway;
        }*/

        

        public static Car Parse(String modelOption ) 
        {
            String[] lineCar = modelOption.Split( ',' );

            Car car =new Car()
            {
                make = lineCar[0],
                model = lineCar[1],
                cylinder = int.Parse(lineCar[2]),
                engine = double.Parse(lineCar[3]),
                drive = lineCar[4],
                transmission = lineCar[5],
                city= int.Parse(lineCar[6]),
                combined = int.Parse(lineCar[7]),
                highway = int.Parse(lineCar[8]),
            };

            return car;
        }
    }
}
