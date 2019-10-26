using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PET_MANAGEMENT.Models
{
    public class TPET
    {
        [Key]
        [Required]
        public String petID { get; set; }
        //type CAT00001

        [Display(Name = "Tên")]
        [Required]
        public String petName { get; set; }

        [Display(Name = "Ngày sinh")]
        public DateTime BirthDay { get; set; }

        [Display(Name = "Giới tính")]
        [Required]
        public Int32 gender { get; set; }

        [Display(Name = "Giống")]
        public String typeID { get; set; }

        [Display(Name = "Màu sắc")]
        public Int32 colorID { get; set; }

        [Display(Name = "Nơi xuất xứ")]
        public String originPlace { get; set; }

        [Display(Name = "Giá")]
        public Decimal money { get; set; }

        [Display(Name = "Người sỡ hữu")]
        public String ownerID { get; set; }

        /// <summary>0: displayed, 1:not displayed </summary>
        [Display(Name = "Cho phép hiển thị")]
        public int display { get; set; }

        public String crt_usr { get; set; }
        public String upd_usr { get; set; }
        public DateTime crt_dt { get; set; }
        public DateTime upd_dt { get; set; }
    }
}
