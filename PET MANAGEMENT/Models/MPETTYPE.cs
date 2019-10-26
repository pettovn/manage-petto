using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PET_MANAGEMENT.Models
{
    public class MPETTYPE
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public String typeID { get; set; }

        [Display(Name = "Loại thú cưng")]
        [Required]
        public String typeName { get; set; }

        [Display(Name = "Ghi chú")]
        public String note { get; set; }

        public String crt_usr { get; set; }
        public String upd_usr { get; set; }
        public DateTime crt_dt { get; set; }
        public DateTime upd_dt { get; set; }
    }
}
