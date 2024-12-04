using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BurguerMania_API.Migrations
{
    /// <inheritdoc />
    public partial class updateOrders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BaseDescription",
                table: "Products",
                newName: "Description");

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Orders",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "PathImage" },
                values: new object[] { 3, "Uma experiência gourmet! Hambúrgueres feitos com ingredientes premium, combinações sofisticadas e um toque de exclusividade.", "X-Deluxe", "https://s3-alpha-sig.figma.com/img/62e9/60a8/916fccb3e9f039a653a71fe3c3b305a0?Expires=1733702400&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=DJDu--0o~IdaTaRhTRGQ3C7WLw0aGT4dryBxg1hjVQuzdfLyM4Rv1lJmG0VSje8KRcgDFAn1pfQWK19YPJo3flKF6S7hIvAfT8TdXyqW8qpmYtWm9FrUrYkZCQSwgkCCzCcyp99cNl~VX1W-7fDUuDnYFHBt0MT-7T-5xW4Q--HHsnidbB0cS7M~RIqNXCwIw4xvCTz~8sVVlyBOEjAdCozqnyn6Z40C44K094SICVIIqetbAOJlwfKAdhW6SRAgYOjwJd3-VVRMg~rU0c5Vp9Lg3dCFFQ6f74nGqDvG-XjfyZj4529nufSYPN6ADhPvAtPbs~W8NNUTF5FCwTv7Xg__" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "FullDescription", "Name", "PathImage", "Price" },
                values: new object[,]
                {
                    { 5, 1, "Pão, Hambúrguer vegano, frutas frescas, molho agridoce e temperos especiais.", "Este hambúrguer vegano inovador combina o sabor refrescante de frutas frescas com um molho agridoce que faz uma fusão perfeita com o hambúrguer preparado com grãos selecionados. O prato é servido com pão macio e alface crocante, oferecendo uma experiência única de sabores doce e salgado com um toque de temperos especiais.", "X-Frutas", "https://s3-alpha-sig.figma.com/img/62e9/60a8/916fccb3e9f039a653a71fe3c3b305a0?Expires=1733702400&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=DJDu--0o~IdaTaRhTRGQ3C7WLw0aGT4dryBxg1hjVQuzdfLyM4Rv1lJmG0VSje8KRcgDFAn1pfQWK19YPJo3flKF6S7hIvAfT8TdXyqW8qpmYtWm9FrUrYkZCQSwgkCCzCcyp99cNl~VX1W-7fDUuDnYFHBt0MT-7T-5xW4Q--HHsnidbB0cS7M~RIqNXCwIw4xvCTz~8sVVlyBOEjAdCozqnyn6Z40C44K094SICVIIqetbAOJlwfKAdhW6SRAgYOjwJd3-VVRMg~rU0c5Vp9Lg3dCFFQ6f74nGqDvG-XjfyZj4529nufSYPN6ADhPvAtPbs~W8NNUTF5FCwTv7Xg__", 23.00m },
                    { 6, 1, "Pão, Hambúrguer vegano, abacate cremoso, alface, tomate, molho especial e especiarias.", "Este hambúrguer vegano combina uma generosa camada de abacate cremoso com o sabor suave do hambúrguer preparado com vegetais frescos. O abacate, juntamente com alface e tomate frescos, cria um contraste refrescante, enquanto o molho especial e as especiarias proporcionam um toque de sabor e cremosidade únicos.", "X-Abacate-Avocado", "https://s3-alpha-sig.figma.com/img/62e9/60a8/916fccb3e9f039a653a71fe3c3b305a0?Expires=1733702400&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=DJDu--0o~IdaTaRhTRGQ3C7WLw0aGT4dryBxg1hjVQuzdfLyM4Rv1lJmG0VSje8KRcgDFAn1pfQWK19YPJo3flKF6S7hIvAfT8TdXyqW8qpmYtWm9FrUrYkZCQSwgkCCzCcyp99cNl~VX1W-7fDUuDnYFHBt0MT-7T-5xW4Q--HHsnidbB0cS7M~RIqNXCwIw4xvCTz~8sVVlyBOEjAdCozqnyn6Z40C44K094SICVIIqetbAOJlwfKAdhW6SRAgYOjwJd3-VVRMg~rU0c5Vp9Lg3dCFFQ6f74nGqDvG-XjfyZj4529nufSYPN6ADhPvAtPbs~W8NNUTF5FCwTv7Xg__", 25.00m },
                    { 4, 3, "Pão, Hambúrguer de carne premium, molho trufado, queijo brie e especiarias finas.", "Este hambúrguer gourmet é preparado com carne premium de alta qualidade, que é complementada por um molho trufado delicado e queijo brie. O pão macio serve como base para essa combinação sofisticada, que é finalizada com uma pitada de especiarias finas. Um prato que oferece uma experiência única para os amantes de sabores refinados.", "X-Deluxe-Sophisticate", "https://s3-alpha-sig.figma.com/img/62e9/60a8/916fccb3e9f039a653a71fe3c3b305a0?Expires=1733702400&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=DJDu--0o~IdaTaRhTRGQ3C7WLw0aGT4dryBxg1hjVQuzdfLyM4Rv1lJmG0VSje8KRcgDFAn1pfQWK19YPJo3flKF6S7hIvAfT8TdXyqW8qpmYtWm9FrUrYkZCQSwgkCCzCcyp99cNl~VX1W-7fDUuDnYFHBt0MT-7T-5xW4Q--HHsnidbB0cS7M~RIqNXCwIw4xvCTz~8sVVlyBOEjAdCozqnyn6Z40C44K094SICVIIqetbAOJlwfKAdhW6SRAgYOjwJd3-VVRMg~rU0c5Vp9Lg3dCFFQ6f74nGqDvG-XjfyZj4529nufSYPN6ADhPvAtPbs~W8NNUTF5FCwTv7Xg__", 35.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Products",
                newName: "BaseDescription");
        }
    }
}
