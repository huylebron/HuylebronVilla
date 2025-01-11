using HuylebronVilla.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HuylebronVilla.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Villa>().HasData(
                new Villa
                {
                    Id = 1,
                    Name = "Royal Infinity Pool Villa",
                    Description =
                        "Trải nghiệm bể bơi vô cực với phong cách hoàng gia, mang lại sự thư giãn đỉnh cao cùng không gian sang trọng.",
                    ImageUrl = "https://placehold.co/600x400",
                    Occupancy = 4,
                    Price = 200,
                    Sqft = 550,
                },
                new Villa
                {
                    Id = 2,
                    Name = "Premium Paradise Villa",
                    Description =
                        "Một thiên đường nghỉ dưỡng với bể bơi riêng và thiết kế hiện đại, mang đến sự thoải mái và tiện nghi tuyệt đối.",
                    ImageUrl = "https://placehold.co/600x401",
                    Occupancy = 4,
                    Price = 300,
                    Sqft = 550,
                },
                new Villa
                {
                    Id = 3,
                    Name = "Luxury Oceanfront Villa",
                    Description =
                        "Hòa mình vào thiên nhiên với căn villa hướng biển sang trọng, nơi sự xa hoa và tầm nhìn tuyệt đẹp kết hợp hoàn hảo.",
                    ImageUrl = "https://placehold.co/600x402",
                    Occupancy = 4,
                    Price = 400,
                    Sqft = 750,
                },
                new Villa
                {
                    Id = 4,
                    Name = "Eco Retreat Villa",
                    Description =
                        "Căn villa thân thiện với môi trường, được bao quanh bởi cây xanh và không gian yên bình, lý tưởng để tái tạo năng lượng.",
                    ImageUrl = "https://placehold.co/600x403",
                    Occupancy = 2,
                    Price = 180,
                    Sqft = 500,
                },
                new Villa
                {
                    Id = 5,
                    Name = "Mountain View Haven",
                    Description =
                        "Thưởng ngoạn cảnh quan núi non hùng vĩ ngay từ căn villa ấm cúng, nơi bạn có thể cảm nhận sự yên tĩnh và thanh bình.",
                    ImageUrl = "https://placehold.co/600x404",
                    Occupancy = 3,
                    Price = 250,
                    Sqft = 600,
                },
                new Villa
                {
                    Id = 6,
                    Name = "Sunset Serenity Villa",
                    Description =
                        "Ngắm nhìn hoàng hôn tuyệt đẹp từ căn villa với không gian mở, mang đến cảm giác thư thái và lãng mạn khó quên.",
                    ImageUrl = "https://placehold.co/600x405",
                    Occupancy = 2,
                    Price = 220,
                    Sqft = 520,
                }
            );
        }
    }
}