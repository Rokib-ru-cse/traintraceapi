using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace traintraceapi.Model
{
    public class Location
    {
        public int? Id { get; set; }
        public Train? Train { get; set; }
        [Required]
        public int TrainId { get; set; }
        public Country? Country { get; set; }
        [Required]
        public int CountryId { get; set; }
        [Required]
        public double Latitude { get; set; }
        [Required]
        public double Longitude { get; set; }
        [Required]
        public double Accuracy { get; set; }
        [MaxLength(20)]
        public string? MacAddress { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}