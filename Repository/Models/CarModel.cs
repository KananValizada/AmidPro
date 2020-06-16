using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class CarModel
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public Car Car { get; set; }
    }
}
