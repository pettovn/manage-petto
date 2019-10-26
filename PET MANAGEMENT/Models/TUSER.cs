using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PET_MANAGEMENT.Models
{
    public class TUSER
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public Int64 userID { get; set; }

        [Display(Name = "Tên hiển thị")]
        [Required]
        public String userName { get; set; }

        [Display(Name = "Mật khẩu")]
        [Required]
        public String password { get; set; }

        [Display(Name = "Số điện thoại")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "123")]
        [Required]
        public String phone { get; set; }

        [Display(Name = "Giới tính")]
        [Required]
        public Int16 gender { get; set; }

        /// <summary>0:manager, 1:created, 2:customer </summary>
        [Display(Name = "Loại tài khoản")]
        [Required]
        public Int16 typeUser { get; set; }

        [Display(Name = "Email")]
        public String email { get; set; }

        [Display(Name = "Url Facebook")]
        [Required]
        public String facebook { get; set; }

        [Display(Name = "Địa chỉ")]
        public String address { get; set; }

        [Display(Name = "Ngày sinh")]
        [DataType(DataType.Date)]
        public DateTime birthday { get; set; }

        public String crt_usr { get; set; }
        public String upd_usr { get; set; }
        public DateTime crt_dt { get; set; }
        public DateTime upd_dt { get; set; }

        [NotMapped]
        public String repPassword { get; set; }
    }
}
