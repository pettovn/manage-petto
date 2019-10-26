using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PET_MANAGEMENT.Models
{
    public class TIMAGE
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int imageID { get; set; }

        [Required]
        public String petID { get; set; }

        [Display(Name = "Tiêu đề")]
        [Required]
        public String imageName { get; set; }

        [Required]
        public String pathImage { get; set; }

        /// <summary>0 : image uploaded ; 1 : ref image</summary>
        [Required]
        public int typeImage { get; set; }

        public String note { get; set; }

        public String crt_usr { get; set; }
        public String upd_usr { get; set; }
        public DateTime crt_dt { get; set; }
        public DateTime upd_dt { get; set; }
    }
}
