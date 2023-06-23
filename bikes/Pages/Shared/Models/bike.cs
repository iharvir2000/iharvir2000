using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace bikes.Models
{
    public class bike
    {
        public int ID { get; set; }
        public string Model { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime BuildTime { get; set; }
        public string Place { get; set; }
        public string Company { get; set; }
        public string Power { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Cost { get; set; }
        public int Rating { get; set; }
        public string Colour { get; set; }

    }
}



