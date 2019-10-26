using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PET_MANAGEMENT.Models
{
    public class TGENEALONY
    {
        [Key, Column(Order = 0)]
        [Required]
        public String petID { get; set; }

        [Key, Column(Order = 1)]
        [Required]
        public String petMorther { get; set; }

        [Key, Column(Order = 2)]
        [Required]
        public String petFather { get; set; }

        public String crt_usr { get; set; }
        public String upd_usr { get; set; }
        public DateTime crt_dt { get; set; }
        public DateTime upd_dt { get; set; }
    }
}
