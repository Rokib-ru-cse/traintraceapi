using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace traintraceapi.Model
{
    public class Train
    {
        public int? Id { get; set; }
        [MaxLength(60)]
        public string? TrainName { get; set; }
        [MaxLength(10)]
        public string? TrainNo { get; set; }
        public Country? Country { get; set; }
        public int CountryId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

    }
}