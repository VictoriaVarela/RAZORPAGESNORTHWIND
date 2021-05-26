using System;
using System.ComponentModel.DataAnnotations;

namespace RAZORPAGESNORTHWIND.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime RegisterDate { get; set; }

        public string Category { get; set; }

        public decimal UnityPrice { get; set; }
    }
}
