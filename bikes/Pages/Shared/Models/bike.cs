using System;
using System.ComponentModel.DataAnnotations;

namespace bikes.Models
{
    public class bike
    {
        public int ID { get; set; }
        public string Model { get; set; }

        [DataType(DataType.Date)]
        public DateTime BuildTime { get; set; }
        public string Place { get; set; }
        public string Company { get; set; }
        public string Power { get; set; }
        public decimal Cost { get; set; }

    }
}



