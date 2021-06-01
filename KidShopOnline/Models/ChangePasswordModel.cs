using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KidShopOnline.Models
{
    public class ChangePasswordModel
    {
        [Required]
        [DisplayName("Eski Şifre")]
        public string OldPassword { get; set; }
        [Required]
        [DisplayName("Yeni Şifre")]
        public string NewPassword { get; set; }
        [Required]
        [DisplayName("Yeni Şifrenizi Tekrar Girin")]
        [Compare("NewPassword", ErrorMessage = "Şifreler aynı değil.")]
        public string ConNewPassword { get; set; }
    }
}