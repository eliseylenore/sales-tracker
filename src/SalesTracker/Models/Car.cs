using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesTracker.Models
{
    [Table("Cars")]
    public class Car
    {
        [Key]
        public int CarId { get; set; }
        //make = car's manufacturer or companies who produced the car
        public string Make { get; set; }
        //model = car name 
        public string Model { get; set; }
        public string Year { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public Car(string make, string model, string year, decimal price, string description)
        {
            Make = make; 
            Model = model;
            Year = year;
            Price = price;
            Description = description;
        }
        public Car() { }

        public override bool Equals(System.Object otherCar)
        {
            if (!(otherCar is Car))
            {
                return false;
            }
            else
            {
                Car newCar = (Car)otherCar;
                return this.CarId.Equals(newCar.Price);
            }
        }
            public override int GetHashCode()
        {
            return this.CarId.GetHashCode();
        }
    }
}
