using Microsoft.EntityFrameworkCore.Migrations;

namespace FashionWeb.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Size",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name", "ParentId", "Status" },
                values: new object[,]
                {
                    { 1, "Áo Thun", null, 1 },
                    { 2, "Áo Sơ Mi", null, 1 },
                    { 3, "Quần Short", null, 1 },
                    { 4, "Quần Jean", null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "ImageUrl", "OriginalPrice", "Price", "ProductName", "Size" },
                values: new object[,]
                {
                    { 18, "Sở hữu chất vải denim dày dặn, có độ co giãn nên rất thoải mái và dễ chịu khi mặc.", null, 0m, 500.000m, "Quần Jeans BOUTON Rách Lai Skinny", 1 },
                    { 19, "Form dáng skinny ôm chân, tôn dáng cùng chất vải denim dày dặn có độ co giãn tốt.", null, 0m, 500.000m, "Quần Jeans BOUTON Black Slim", 2 },
                    { 20, "Sở hữu chất vải denim dày dặn, có độ co giãn nên rất thoải mái và dễ chịu khi mặc.", null, 0m, 500.000m, "Quần Jeans BOUTON Baggy", 0 },
                    { 21, "Form dáng skinny ôm chân, tôn dáng cùng chất vải denim dày dặn có độ co giãn tốt.", null, 0m, 380.000m, "Quần Denim BOUTON Slim Fit ss21", 0 },
                    { 22, "Sở hữu sắc đen đơn giản nhưng dễ phối cùng các items khác tạo nên outfit theo nhiều phong cách đa dạng và cuốn hút.", null, 0m, 400.000m, "Quần Jeans BOUTON Black w Chain Skinny", 0 },
                    { 23, "Form dáng skinny ôm chân, tôn dáng cùng chất vải denim dày dặn có độ co giãn tốt.", null, 0m, 500.000m, "Quần jeans NOMOUS ESSENTIALS light bule", 0 },
                    { 25, "BOUTON Kaki Shorts // Ae yêu thích phong cách tối giản thì không thể bỏ qua dòng quần shorts kaki này.", null, 0m, 300.000m, "Quần Short Kaki BOUTON", 0 },
                    { 17, "Form dáng skinny ôm chân, tôn dáng cùng chất vải denim dày dặn có độ co giãn tốt.", null, 30.000m, 500.000m, "Quần Jeans BOUTON Dark Blue Skinny", 0 },
                    { 26, "Form dáng trẻ trung, đường may tỉ mỉ với các họa tiết caro nhỏ, quần chính là “MUST-HAVE-ITEM” của ae.", null, 0m, 350.000m, "Quần Short Jeans BOUTON Vảy Sơn", 0 },
                    { 27, "BOUTON Kaki Shorts // Ae yêu thích phong cách tối giản thì không thể bỏ qua dòng quần shorts kaki này.", null, 0m, 280.000m, "Quần Short BOUTON Pique Camo", 0 },
                    { 28, "Form dáng trẻ trung, đường may tỉ mỉ với các họa tiết caro nhỏ, quần chính là “MUST-HAVE-ITEM” của ae.", null, 0m, 300.000m, "Quần Short Thun Umi BOUTON Slim Fit", 0 },
                    { 29, "Đặc biệt, dòng này được đựng trong túi vải gọn nhẹ và tiện lợi ae dễ dàng mang theo đi bất cứ đâu.", null, 0m, 200.000m, "Quần Short Biển BOUTON Printed", 0 },
                    { 30, "Form dáng trẻ trung, đường may tỉ mỉ với các họa tiết caro nhỏ, quần chính là “MUST-HAVE-ITEM” của ae.", null, 0m, 320.000m, "Quần Short BOUTON Acid wash", 0 },
                    { 24, "Form dáng skinny ôm chân, tôn dáng cùng chất vải denim dày dặn có độ co giãn tốt.", null, 0m, 500.000m, "Quần jeans MASCUS Indigo slim", 0 },
                    { 16, "BOUTON Suede Shirts // Dòng sơmi không thể bỏ qua Thu Đông này.", null, 0m, 300.000m, "Áo Sơmi BOUTON Suede Leather", 1 },
                    { 14, "BOUTON Suede Shirts // Dòng sơmi không thể bỏ qua Thu Đông này.", null, 0m, 300.000m, "Áo Sơmi Oxford BOUTON Basic", 1 },
                    { 31, "Đặc biệt, dòng này được đựng trong túi vải gọn nhẹ và tiện lợi ae dễ dàng mang theo đi bất cứ đâu.", null, 0m, 200.000m, "Quần Short Biển C0TT0N.0N", 0 },
                    { 13, "BOUTON Angel Soiree Shirt // Phiên bản “Áo sơmi ngắn tay” IN FULL phát hành đặc biệt cho mùa đông 2021.", null, 0m, 300.000m, "Áo Sơmi BOUTON Moutain Printed Relaxed", 0 },
                    { 12, "BOUTON Angel Soiree Shirt // Phiên bản “Áo sơmi ngắn tay” IN FULL phát hành đặc biệt cho mùa đông 2021.", null, 0m, 300.000m, "Áo Sơmi Tay Ngắn BOUTON Thêu Chữ Ký", 2 },
                    { 11, "BOUTON Angel Soiree Shirt // Phiên bản “Áo sơmi ngắn tay” IN FULL phát hành đặc biệt cho mùa đông 2021.", null, 0m, 300.000m, "Áo Sơmi Thun Bóng Chày BOUTON Printed", 2 },
                    { 10, "Với chất vải cotton được chải mịn, đem lại cảm giác mềm mại, mặc rất thoải mái.", null, 0m, 350.000m, "Áo Sơmi BOUTON Flanel Caro ss21", 1 },
                    { 9, "BOUTON Angel Soiree Shirt // Phiên bản “Áo sơmi ngắn tay” IN FULL phát hành đặc biệt cho mùa đông 2021.", null, 0m, 330.000m, "Áo Sơmi BOUTON Angel Printed (TN)", 0 },
                    { 8, "Dòng áo thun đơn giản nhưng vẫn có chất riêng, sở hữu gam màu dễ mặc.", null, 0m, 280.000m, "Áo Thun BOUTON City Print", 1 },
                    { 7, "Áo thun basic được làm từ chất vải 100% organic cotton dày dặn.", null, 250.000m, 360.000m, "Áo Thun BOUTON x GOKU Wash", 0 },
                    { 6, "Dòng áo thun đơn giản nhưng vẫn có chất riêng, sở hữu gam màu dễ mặc.", null, 0m, 280.000m, "Áo Thun BOUTON Paint Splash Effect", 2 },
                    { 5, "Áo thun basic được làm từ chất vải 100% organic cotton dày dặn.", null, 0m, 280.000m, "Áo Thun ICON DENIM Graphic", 1 },
                    { 4, "Áo thun basic được làm từ chất vải 100% organic cotton dày dặn.", null, 0m, 280.000m, "Áo Thun ICON DENIM Printed", 0 },
                    { 3, "Nổi bật với chi tiết đánh bông đường may và cuốn biên ở phần tay, cổ và lai áo.", null, 0m, 300.000m, "Áo Nỉ Tay Dài ICON DENIM W Details", 2 },
                    { 2, "Áo thun basic được làm từ chất vải 100% organic cotton dày dặn.", null, 0m, 180.000m, "Áo Thun BOUTON Basic", 1 },
                    { 1, "Chất vải cotton dày dặn co giãn và có độ thoáng khí tốt.", null, 0m, 300.000m, "Áo Thun ICON DENIM Boss Acid Wash", 0 },
                    { 15, "Với chất vải cotton được chải mịn, đem lại cảm giác mềm mại, mặc rất thoải mái.", null, 0m, 300.000m, "Áo Sơmi Cổ Trụ NOMOUS ESSENTIALS Linen", 1 },
                    { 32, "BOUTON Kaki Shorts // Ae yêu thích phong cách tối giản thì không thể bỏ qua dòng quần shorts kaki này.", null, 0m, 280.000m, "Quần Short BOUTON Velvet Basic", 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductInCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 3, 30 },
                    { 3, 29 },
                    { 3, 28 },
                    { 3, 27 },
                    { 3, 26 },
                    { 3, 25 },
                    { 4, 24 },
                    { 4, 23 },
                    { 4, 22 },
                    { 4, 21 },
                    { 4, 20 },
                    { 4, 19 },
                    { 4, 18 },
                    { 4, 17 },
                    { 2, 16 },
                    { 2, 15 },
                    { 2, 14 },
                    { 2, 13 },
                    { 2, 12 },
                    { 2, 11 },
                    { 2, 10 },
                    { 2, 9 },
                    { 1, 8 },
                    { 1, 7 },
                    { 1, 6 },
                    { 1, 5 },
                    { 1, 4 },
                    { 1, 3 },
                    { 1, 2 },
                    { 3, 31 },
                    { 3, 32 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 11 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 13 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 14 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 15 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 16 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 25 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 26 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 27 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 28 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 29 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 30 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 31 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 32 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 17 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 18 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 19 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 20 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 21 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 22 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 23 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 24 });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 32);

            migrationBuilder.AlterColumn<string>(
                name: "Size",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
