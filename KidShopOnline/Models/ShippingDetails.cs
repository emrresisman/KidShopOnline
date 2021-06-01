using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KidShopOnline.Models
{
    public class ShippingDetails
    {
        
      
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen Adres Bilginizi Giriniz")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Lütfen Şehir Bilginizi Giriniz")]
        public string City { get; set; }
        [Required(ErrorMessage = "Lütfen İlçe Bilginizi Giriniz")]
        public string District { get; set; }
        [Required(ErrorMessage = "Lütfen Mahalle Bilginizi Giriniz")]
        public string Neighborhood { get; set; }
        [Required(ErrorMessage = "Lütfen Posta Kodu Bilginizi Giriniz")]
        public string PostCode { get; set; }
     
    }
}