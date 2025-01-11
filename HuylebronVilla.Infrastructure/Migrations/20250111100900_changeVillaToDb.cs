using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HuylebronVilla.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class changeVillaToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Trải nghiệm bể bơi vô cực với phong cách hoàng gia, mang lại sự thư giãn đỉnh cao cùng không gian sang trọng.", "Royal Infinity Pool Villa" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Một thiên đường nghỉ dưỡng với bể bơi riêng và thiết kế hiện đại, mang đến sự thoải mái và tiện nghi tuyệt đối.", "Premium Paradise Villa" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Hòa mình vào thiên nhiên với căn villa hướng biển sang trọng, nơi sự xa hoa và tầm nhìn tuyệt đẹp kết hợp hoàn hảo.", "Luxury Oceanfront Villa" });

            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Created_Date", "Description", "Name", "Occupancy", "Price", "Sqft", "Updated_Date" },
                values: new object[,]
                {
                    { 4, null, "Căn villa thân thiện với môi trường, được bao quanh bởi cây xanh và không gian yên bình, lý tưởng để tái tạo năng lượng.", "Eco Retreat Villa", 2, 180.0, 500, null },
                    { 5, null, "Thưởng ngoạn cảnh quan núi non hùng vĩ ngay từ căn villa ấm cúng, nơi bạn có thể cảm nhận sự yên tĩnh và thanh bình.", "Mountain View Haven", 3, 250.0, 600, null },
                    { 6, null, "Ngắm nhìn hoàng hôn tuyệt đẹp từ căn villa với không gian mở, mang đến cảm giác thư thái và lãng mạn khó quên.", "Sunset Serenity Villa", 2, 220.0, 520, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "Royal Villa" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "Premium Pool Villa" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "Luxury Pool Villa" });
        }
    }
}
