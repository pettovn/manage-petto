using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PET_MANAGEMENT.Models
{
    public class TPETHIS
    {
        [Key, Column(Order = 0)]
        [Required]
        public String petID { get; set; }

        [Key, Column(Order = 1)]
        [Required]
        public String ownerID { get; set; }

        [Display(Name = "Giá")]
        public Decimal money { get; set; }

        [Display(Name = "Ghi chú")]
        public String note { get; set; }

        public String crt_usr { get; set; }
        public String upd_usr { get; set; }
        public DateTime crt_dt { get; set; }
        public DateTime upd_dt { get; set; }
    }
}
