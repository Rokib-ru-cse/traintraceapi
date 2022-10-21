using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace traintraceapi.Model
{
    public class Report
    {
        public int Id { get; set; }
        public Train Train { get; set; }
        [Required]
        public int TrainId { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }
    }
}