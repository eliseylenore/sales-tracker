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
    }
}
