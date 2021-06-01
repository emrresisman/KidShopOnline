using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidShopOnline.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category(){Name="Tişört",Description="Tişört Ürünleri" },
                new Category(){Name="Çorap",Description="Çorap Ürünleri"},
                new Category(){Name="Eldiven",Description="Eldiven Ürünleri"}
            };
            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();
            var urunler = new List<Product>()
            {
                new Product(){Name="Kırmızı Tişört",Description="Kırmızı Tişört",Price=39,Stock=125,isHome=true,isApproved=true,isFeatured=false,Slider=true,CategoryId=1,image="1.jpg"},
                new Product(){Name="Mavi Çorap",Description="Mavi Çorap",Price=20,Stock=200,isHome=true,isApproved=true,isFeatured=true,Slider=false,CategoryId=2,image="2.jpg"},
                new Product(){Name="Sarı Eldiven",Description="Bağcıklı Eldiven",Price=28,Stock=25,isHome=false,isApproved=true,isFeatured=false,Slider=false,CategoryId=3,image="3.jpg"},
                new Product(){Name="Renkli Çorap",Description="Renkli Çorap",Price=18,Stock=225,isHome=true,isApproved=true,isFeatured=false,Slider=true,CategoryId=2,image="4.jpg"},
            };
            foreach (var urun in urunler)
            {
                context.Products.Add(urun);

            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}