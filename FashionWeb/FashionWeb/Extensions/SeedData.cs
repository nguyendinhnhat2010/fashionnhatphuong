using FashionWeb.Enums;
using FashionWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FashionWeb.Extensions
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category() {CategoryId = 1, ParentId = null, Name = "Áo Thun" , Status = Status.Active},
                new Category() {CategoryId = 2, ParentId = null, Name = "Áo Sơ Mi", Status = Status.Active },
                new Category() {CategoryId = 3, ParentId = null, Name = "Quần Short", Status = Status.Active },
                new Category() {CategoryId = 4, ParentId = null, Name = "Quần Jean", Status = Status.Active }
                );

            modelBuilder.Entity<Product>().HasData(
                // áo thun
                new Product()
                {
                    ProductId = 1,
                    ProductName = "Áo Thun ICON DENIM Boss Acid Wash",
                    Price = 300.000m,
                    OriginalPrice = 0,
                    Stock = 0,
                    ViewCount = 0,
                    Description = "Chất vải cotton dày dặn co giãn và có độ thoáng khí tốt.",
                    Size = (Size.M)
                },

                new Product()
                {
                    ProductId = 2,
                    ProductName = "Áo Thun BOUTON Basic",
                    Price = 180.000m,
                    OriginalPrice = 0,
                    Stock = 0,
                    ViewCount = 0,
                    Description = "Áo thun basic được làm từ chất vải 100% organic cotton dày dặn.",
                    Size = (Size.L)
                },

                new Product()
                {
                    ProductId = 3,
                    ProductName = "Áo Nỉ Tay Dài ICON DENIM W Details",
                    Price = 300.000m,
                    OriginalPrice = 0,
                    Stock = 0,
                    ViewCount = 0,
                    Description = "Nổi bật với chi tiết đánh bông đường may và cuốn biên ở phần tay, cổ và lai áo.",
                    Size = (Size.XL)
                },

                new Product()
                {
                    ProductId = 4,
                    ProductName = "Áo Thun ICON DENIM Printed",
                    Price = 280.000m,
                    OriginalPrice = 0,
                    Stock = 0,
                    ViewCount = 0,
                    Description = "Áo thun basic được làm từ chất vải 100% organic cotton dày dặn.",
                    Size = (Size.M)
                },

                new Product()
                {
                    ProductId = 5,
                    ProductName = "Áo Thun ICON DENIM Graphic",
                    Price = 280.000m,
                    OriginalPrice = 0,
                    Stock = 0,
                    ViewCount = 0,
                    Description = "Áo thun basic được làm từ chất vải 100% organic cotton dày dặn.",
                    Size = (Size.L)
                },

                new Product()
                {
                    ProductId = 6,
                    ProductName = "Áo Thun BOUTON Paint Splash Effect",
                    Price = 280.000m,
                    OriginalPrice = 0,
                    Stock = 0,
                    ViewCount = 0,
                    Description = "Dòng áo thun đơn giản nhưng vẫn có chất riêng, sở hữu gam màu dễ mặc.",
                    Size = (Size.XL)
                },

                new Product()
                {
                    ProductId = 7,
                    ProductName = "Áo Thun BOUTON x GOKU Wash",
                    Price = 360.000m,
                    OriginalPrice = 250.000m,
                    Stock = 0,
                    ViewCount = 0,
                    Description = "Áo thun basic được làm từ chất vải 100% organic cotton dày dặn.",
                    Size = (Size.M)
                },

                 new Product()
                 {
                     ProductId = 8,
                     ProductName = "Áo Thun BOUTON City Print",
                     Price = 280.000m,
                     OriginalPrice = 0,
                     Stock = 0,
                     ViewCount = 0,
                     Description = "Dòng áo thun đơn giản nhưng vẫn có chất riêng, sở hữu gam màu dễ mặc.",
                     Size = (Size.L)
                 },

                 // áo sơ mi
                 new Product()
                 {
                     ProductId = 9,
                     ProductName = "Áo Sơmi BOUTON Angel Printed (TN)",
                     Price = 330.000m,
                     OriginalPrice = 0,
                     Stock = 0,
                     ViewCount = 0,
                     Description = "BOUTON Angel Soiree Shirt // Phiên bản “Áo sơmi ngắn tay” IN FULL phát hành đặc biệt cho mùa đông 2021.",
                     Size = (Size.M)
                 },

                 new Product()
                 {
                     ProductId = 10,
                     ProductName = "Áo Sơmi BOUTON Flanel Caro ss21",
                     Price = 350.000m,
                     OriginalPrice = 0,
                     Stock = 0,
                     ViewCount = 0,
                     Description = "Với chất vải cotton được chải mịn, đem lại cảm giác mềm mại, mặc rất thoải mái.",
                     Size = (Size.L)
                 },

                 new Product()
                 {
                     ProductId = 11,
                     ProductName = "Áo Sơmi Thun Bóng Chày BOUTON Printed",
                     Price = 300.000m,
                     OriginalPrice = 0,
                     Stock = 0,
                     ViewCount = 0,
                     Description = "BOUTON Angel Soiree Shirt // Phiên bản “Áo sơmi ngắn tay” IN FULL phát hành đặc biệt cho mùa đông 2021.",
                     Size = (Size.XL)
                 },

                 new Product()
                 {
                     ProductId = 12,
                     ProductName = "Áo Sơmi Tay Ngắn BOUTON Thêu Chữ Ký",
                     Price = 300.000m,
                     OriginalPrice = 0,
                     Stock = 0,
                     ViewCount = 0,
                     Description = "BOUTON Angel Soiree Shirt // Phiên bản “Áo sơmi ngắn tay” IN FULL phát hành đặc biệt cho mùa đông 2021.",
                     Size = (Size.XL)
                 },

                 new Product()
                 {
                     ProductId = 13,
                     ProductName = "Áo Sơmi BOUTON Moutain Printed Relaxed",
                     Price = 300.000m,
                     OriginalPrice = 0,
                     Stock = 0,
                     ViewCount = 0,
                     Description = "BOUTON Angel Soiree Shirt // Phiên bản “Áo sơmi ngắn tay” IN FULL phát hành đặc biệt cho mùa đông 2021.",
                     Size = (Size.M)
                 },

                 new Product()
                 {
                     ProductId = 14,
                     ProductName = "Áo Sơmi Oxford BOUTON Basic",
                     Price = 300.000m,
                     OriginalPrice = 0,
                     Stock = 0,
                     ViewCount = 0,
                     Description = "BOUTON Suede Shirts // Dòng sơmi không thể bỏ qua Thu Đông này.",
                     Size = (Size.L)
                 },

                 new Product()
                 {
                     ProductId = 15,
                     ProductName = "Áo Sơmi Cổ Trụ NOMOUS ESSENTIALS Linen",
                     Price = 300.000m,
                     OriginalPrice = 0,
                     Stock = 0,
                     ViewCount = 0,
                     Description = "Với chất vải cotton được chải mịn, đem lại cảm giác mềm mại, mặc rất thoải mái.",
                     Size = (Size.L)
                 },

                 new Product()
                 {
                     ProductId = 16,
                     ProductName = "Áo Sơmi BOUTON Suede Leather",
                     Price = 300.000m,
                     OriginalPrice = 0,
                     Stock = 0,
                     ViewCount = 0,
                     Description = "BOUTON Suede Shirts // Dòng sơmi không thể bỏ qua Thu Đông này.",
                     Size = (Size.L)
                 },

                 // quần jean
                 new Product()
                 {
                     ProductId = 17,
                     ProductName = "Quần Jeans BOUTON Dark Blue Skinny",
                     Price = 500.000m,
                     OriginalPrice = 30.000m,
                     Stock = 0,
                     ViewCount = 0,
                     Description = "Form dáng skinny ôm chân, tôn dáng cùng chất vải denim dày dặn có độ co giãn tốt.",
                     Size = (Size.M)
                 },

                 new Product()
                 {
                     ProductId = 18,
                     ProductName = "Quần Jeans BOUTON Rách Lai Skinny",
                     Price = 500.000m,
                     OriginalPrice = 0,
                     Stock = 0,
                     ViewCount = 0,
                     Description = "Sở hữu chất vải denim dày dặn, có độ co giãn nên rất thoải mái và dễ chịu khi mặc.",
                     Size = (Size.L)
                 },

                 new Product()
                 {
                     ProductId = 19,
                     ProductName = "Quần Jeans BOUTON Black Slim",
                     Price = 500.000m,
                     OriginalPrice = 0,
                     Stock = 0,
                     ViewCount = 0,
                     Description = "Form dáng skinny ôm chân, tôn dáng cùng chất vải denim dày dặn có độ co giãn tốt.",
                     Size = (Size.XL)
                 },

                 new Product()
                 {
                     ProductId = 20,
                     ProductName = "Quần Jeans BOUTON Baggy",
                     Price = 500.000m,
                     OriginalPrice = 0,
                     Stock = 0,
                     ViewCount = 0,
                     Description = "Sở hữu chất vải denim dày dặn, có độ co giãn nên rất thoải mái và dễ chịu khi mặc.",
                     Size = (Size.M)
                 },

                 new Product()
                 {
                     ProductId = 21,
                     ProductName = "Quần Denim BOUTON Slim Fit ss21",
                     Price = 380.000m,
                     OriginalPrice = 0,
                     Stock = 0,
                     ViewCount = 0,
                     Description = "Form dáng skinny ôm chân, tôn dáng cùng chất vải denim dày dặn có độ co giãn tốt.",
                     Size = (Size.M)
                 },

                 new Product()
                 {
                     ProductId = 22,
                     ProductName = "Quần Jeans BOUTON Black w Chain Skinny",
                     Price = 400.000m,
                     OriginalPrice = 0,
                     Stock = 0,
                     ViewCount = 0,
                     Description = "Sở hữu sắc đen đơn giản nhưng dễ phối cùng các items khác tạo nên outfit theo nhiều phong cách đa dạng và cuốn hút.",
                     Size = (Size.M)
                 },

                 new Product()
                 {
                     ProductId =23,
                     ProductName = "Quần jeans NOMOUS ESSENTIALS light bule",
                     Price = 500.000m,
                     OriginalPrice = 0,
                     Stock = 0,
                     ViewCount = 0,
                     Description = "Form dáng skinny ôm chân, tôn dáng cùng chất vải denim dày dặn có độ co giãn tốt.",
                     Size = (Size.M)
                 },

                 new Product()
                 {
                     ProductId = 24,
                     ProductName = "Quần jeans MASCUS Indigo slim",
                     Price = 500.000m,
                     OriginalPrice = 0,
                     Stock = 0,
                     ViewCount = 0,
                     Description = "Form dáng skinny ôm chân, tôn dáng cùng chất vải denim dày dặn có độ co giãn tốt.",
                     Size = (Size.M)
                 },

                  // quần short
                 new Product()
                  {
                      ProductId = 25,
                      ProductName = "Quần Short Kaki BOUTON",
                      Price = 300.000m,
                      OriginalPrice = 0,
                      Stock = 0,
                      ViewCount = 0,
                      Description = "BOUTON Kaki Shorts // Ae yêu thích phong cách tối giản thì không thể bỏ qua dòng quần shorts kaki này.",
                      Size = (Size.M)
                  },

                 new Product()
                 {
                     ProductId = 26,
                     ProductName = "Quần Short Jeans BOUTON Vảy Sơn",
                     Price = 350.000m,
                     OriginalPrice = 0,
                     Stock = 0,
                     ViewCount = 0,
                     Description = "Form dáng trẻ trung, đường may tỉ mỉ với các họa tiết caro nhỏ, quần chính là “MUST-HAVE-ITEM” của ae.",
                     Size = (Size.M)
                 },

                 new Product()
                 {
                     ProductId = 27,
                     ProductName = "Quần Short BOUTON Pique Camo",
                     Price = 280.000m,
                     OriginalPrice = 0,
                     Stock = 0,
                     ViewCount = 0,
                     Description = "BOUTON Kaki Shorts // Ae yêu thích phong cách tối giản thì không thể bỏ qua dòng quần shorts kaki này.",
                     Size = (Size.M)
                 },

                 new Product()
                 {
                     ProductId = 28,
                     ProductName = "Quần Short Thun Umi BOUTON Slim Fit",
                     Price = 300.000m,
                     OriginalPrice = 0,
                     Stock = 0,
                     ViewCount = 0,
                     Description = "Form dáng trẻ trung, đường may tỉ mỉ với các họa tiết caro nhỏ, quần chính là “MUST-HAVE-ITEM” của ae.",
                     Size = (Size.M)
                 },

                 new Product()
                 {
                     ProductId = 29,
                     ProductName = "Quần Short Biển BOUTON Printed",
                     Price = 200.000m,
                     OriginalPrice = 0,
                     Stock = 0,
                     ViewCount = 0,
                     Description = "Đặc biệt, dòng này được đựng trong túi vải gọn nhẹ và tiện lợi ae dễ dàng mang theo đi bất cứ đâu.",
                     Size = (Size.M)
                 },

                 new Product()
                 {
                     ProductId = 30,
                     ProductName = "Quần Short BOUTON Acid wash",
                     Price = 320.000m,
                     OriginalPrice = 0,
                     Stock = 0,
                     ViewCount = 0,
                     Description = "Form dáng trẻ trung, đường may tỉ mỉ với các họa tiết caro nhỏ, quần chính là “MUST-HAVE-ITEM” của ae.",
                     Size = (Size.M)
                 },

                 new Product()
                 {
                     ProductId = 31,
                     ProductName = "Quần Short Biển C0TT0N.0N",
                     Price = 200.000m,
                     OriginalPrice = 0,
                     Stock = 0,
                     ViewCount = 0,
                     Description = "Đặc biệt, dòng này được đựng trong túi vải gọn nhẹ và tiện lợi ae dễ dàng mang theo đi bất cứ đâu.",
                     Size = (Size.M)
                 },

                 new Product()
                 {
                     ProductId = 32,
                     ProductName = "Quần Short BOUTON Velvet Basic",
                     Price = 280.000m,
                     OriginalPrice = 0,
                     Stock = 0,
                     ViewCount = 0,
                     Description = "BOUTON Kaki Shorts // Ae yêu thích phong cách tối giản thì không thể bỏ qua dòng quần shorts kaki này.",
                     Size = (Size.M)
                 }
                );

            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1},
                new ProductInCategory() { ProductId = 2, CategoryId = 1},
                new ProductInCategory() { ProductId = 3, CategoryId = 1},
                new ProductInCategory() { ProductId = 4, CategoryId = 1},
                new ProductInCategory() { ProductId = 5, CategoryId = 1},
                new ProductInCategory() { ProductId = 6, CategoryId = 1},
                new ProductInCategory() { ProductId = 7, CategoryId = 1},
                new ProductInCategory() { ProductId = 8, CategoryId = 1},
                new ProductInCategory() { ProductId = 9, CategoryId = 2},
                new ProductInCategory() { ProductId = 10, CategoryId = 2},
                new ProductInCategory() { ProductId = 11, CategoryId = 2},
                new ProductInCategory() { ProductId = 12, CategoryId = 2},
                new ProductInCategory() { ProductId = 13, CategoryId = 2},
                new ProductInCategory() { ProductId = 14, CategoryId = 2},
                new ProductInCategory() { ProductId = 15, CategoryId = 2},
                new ProductInCategory() { ProductId = 16, CategoryId = 2},
                new ProductInCategory() { ProductId = 17, CategoryId = 4},
                new ProductInCategory() { ProductId = 18, CategoryId = 4},
                new ProductInCategory() { ProductId = 19, CategoryId = 4},
                new ProductInCategory() { ProductId = 20, CategoryId = 4},
                new ProductInCategory() { ProductId = 21, CategoryId = 4},
                new ProductInCategory() { ProductId = 22, CategoryId = 4},
                new ProductInCategory() { ProductId = 23, CategoryId = 4},
                new ProductInCategory() { ProductId = 24, CategoryId = 4},
                new ProductInCategory() { ProductId = 25, CategoryId = 3},
                new ProductInCategory() { ProductId = 26, CategoryId = 3},
                new ProductInCategory() { ProductId = 27, CategoryId = 3},
                new ProductInCategory() { ProductId = 28, CategoryId = 3},
                new ProductInCategory() { ProductId = 29, CategoryId = 3},
                new ProductInCategory() { ProductId = 30, CategoryId = 3},
                new ProductInCategory() { ProductId = 31, CategoryId = 3},
                new ProductInCategory() { ProductId = 32, CategoryId = 3}
                
                );
        }
    }
}
