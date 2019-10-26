using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PET_MANAGEMENT.Models
{
    public class TVIDEO
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int videoID { get; set; }

        [Required]
        public String petID { get; set; }

        [Required]
        public String url { get; set; }

        public String note { get; set; }

        public String crt_usr { get; set; }
        public String upd_usr { get; set; }
        public DateTime crt_dt { get; set; }
        public DateTime upd_dt { get; set; }
    }
}
