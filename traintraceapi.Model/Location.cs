using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace traintraceapi.Model
{
    public class Location
    {
        public int Id { get; set; }
        public Train Train { get; set; }
        [Required]
        public int TrainId { get; set; }
        [Required]
        public float Latitude { get; set; }
        [Required]
        public float Longitude { get; set; }
        [Required]
        public float Accuracy { get; set; }
        [Required,MaxLength(20)]
        public string MacAddress { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }
    }
}