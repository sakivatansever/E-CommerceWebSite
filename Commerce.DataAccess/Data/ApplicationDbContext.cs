using Commerce.Models;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Commerce.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Elektronik", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Moda", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Sağlık", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Kitap", DisplayOrder = 4 },
                new Category { Id = 5, Name = "Spor", DisplayOrder = 5 }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { 
                    Id = 1, 
                    Title = "HP 15s Dizüstü Bilgisayar, 15.6'' FHD IPS, Intel Core i3-1215U, 8 GB Ram, 256 GB SSD, FreeDOS, Kömür Grisi, 6G0H5EA" ,
                    Description = "Mikro kenarlı ekranıyla ince ve hafif - Hafif tasarımıyla her yere taşıyabileceğiniz bu bilgisayarın titremesiz ve mikro kenarlı ekranı daha konforlu görüntüleme deneyimi sunar.",
                    Price = 9499.00,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 2,
                    Title = "Acer Aspire 3 A315-58 Dizüstü Bilgisayar, Intel i5-1135G7 İşlemci, 8GB Ram, 256GB SSD, 15,6\" FHD IPS Ekran",
                    Description = "Evde, okulda, işte veya nerede olursanız olun, düzeninizi koruyun ve uygulamalarınızı uyumlu ve sorunsuz bir şekilde çalıştırın.",
                    Price = 9999.00,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 3,
                    Title = "ASUS Notebook Laptop X515EA-BQ868 ,FHD Ekran, Intel Core i3-1115G4 İşlemci,Intel® UHD Graphics, 4GB RAM, 256GB SSD",
                    Description = "Evde, okulda, işte veya nerede olursanız olun, düzeninizi koruyun ve uygulamalarınızı uyumlu ve sorunsuz bir şekilde çalıştırın.",
                    Price = 8299.00,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 4,
                    Title = "Gece Yarısı Kütüphanesi",
                    Description = "Yaşamla ölüm arasında bir kütüphane var,\" dedi. \"Bu kütüphanedeki raflar sonsuza kadar gider. Her kitap yaşamış olabileceğin başka bir hayatı yaşama şansını sunar sana. Farklı seçimler yapmış olsan, şu an nasıl bir hayatın olacağını görürsün.Pişmanlıklarını telafi etme şansın olsaydı, bazı konularda farklı davranır mıydın?",
                    Price = 72.36,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 5,
                    Title = "Kızıl Veba",
                    Description = "Jack London, 1912 yılında İngiltere'de London Magazine'de yayımlanmaya başlayan Kızıl Veba yapıtıyla \"kıyamet sonrası\" edebiyatın öncüleri arasına girmiştir.",
                    Price = 15.10,
                    CategoryId = 1,
                    ImageUrl = ""
                }
            );

        }
    }
}
