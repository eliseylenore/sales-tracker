using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesTracker.Models
{
    [Table("Sales")]
    public class CarSale
    {
        
        [Key]
        public virtual Car Car { get; set; }
        public decimal SellingPrice { get; set; }
        public string Comment { get; set; }
    }
}
