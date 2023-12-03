using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Commerce.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addProductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Mikro kenarlı ekranıyla ince ve hafif - Hafif tasarımıyla her yere taşıyabileceğiniz bu bilgisayarın titremesiz ve mikro kenarlı ekranı daha konforlu görüntüleme deneyimi sunar.", 9499.0, "HP 15s Dizüstü Bilgisayar, 15.6'' FHD IPS, Intel Core i3-1215U, 8 GB Ram, 256 GB SSD, FreeDOS, Kömür Grisi, 6G0H5EA" },
                    { 2, "Evde, okulda, işte veya nerede olursanız olun, düzeninizi koruyun ve uygulamalarınızı uyumlu ve sorunsuz bir şekilde çalıştırın.", 9999.0, "Acer Aspire 3 A315-58 Dizüstü Bilgisayar, Intel i5-1135G7 İşlemci, 8GB Ram, 256GB SSD, 15,6\" FHD IPS Ekran" },
                    { 3, "Evde, okulda, işte veya nerede olursanız olun, düzeninizi koruyun ve uygulamalarınızı uyumlu ve sorunsuz bir şekilde çalıştırın.", 8299.0, "ASUS Notebook Laptop X515EA-BQ868 ,FHD Ekran, Intel Core i3-1115G4 İşlemci,Intel® UHD Graphics, 4GB RAM, 256GB SSD" },
                    { 4, "Yaşamla ölüm arasında bir kütüphane var,\" dedi. \"Bu kütüphanedeki raflar sonsuza kadar gider. Her kitap yaşamış olabileceğin başka bir hayatı yaşama şansını sunar sana. Farklı seçimler yapmış olsan, şu an nasıl bir hayatın olacağını görürsün.Pişmanlıklarını telafi etme şansın olsaydı, bazı konularda farklı davranır mıydın?", 72.359999999999999, "Gece Yarısı Kütüphanesi" },
                    { 5, "Jack London, 1912 yılında İngiltere'de London Magazine'de yayımlanmaya başlayan Kızıl Veba yapıtıyla \"kıyamet sonrası\" edebiyatın öncüleri arasına girmiştir.", 15.1, "Kızıl Veba" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);
        }
    }
}
