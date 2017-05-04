using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesTracker.Models
{
    [Table("CarSales")]
    public class CarSale
    {
        [Key]
        public int CarSaleId { get; set; }
        public decimal SellingPrice { get; set; }
        public string Comment { get; set; }
        public int CarId { get; set; }
        public virtual Car Car { get; set; }

    }
}
