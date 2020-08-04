using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldMVCWebApp._00Data
{
    public class EFModels
    {
        public int MovieId { get; set;}
        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Director { get; set; }
        public string EmailAddress { get; set; }
        public string Language { get; set; }
        public string Category { get; set; }
    }
}
