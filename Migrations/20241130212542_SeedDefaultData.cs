using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BurguerMania_API.Migrations
{
    /// <inheritdoc />
    public partial class SeedDefaultData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "PathImage" },
                values: new object[,]
                {
                    { 1, "Deliciosos hambúrgueres feitos com todo o carinho, 100% vegetais e cheios de sabor. Perfeito para quem busca uma refeição consciente e deliciosa!", "X-Vegan", "https://s3-alpha-sig.figma.com/img/62e9/60a8/916fccb3e9f039a653a71fe3c3b305a0?Expires=1733702400&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=DJDu--0o~IdaTaRhTRGQ3C7WLw0aGT4dryBxg1hjVQuzdfLyM4Rv1lJmG0VSje8KRcgDFAn1pfQWK19YPJo3flKF6S7hIvAfT8TdXyqW8qpmYtWm9FrUrYkZCQSwgkCCzCcyp99cNl~VX1W-7fDUuDnYFHBt0MT-7T-5xW4Q--HHsnidbB0cS7M~RIqNXCwIw4xvCTz~8sVVlyBOEjAdCozqnyn6Z40C44K094SICVIIqetbAOJlwfKAdhW6SRAgYOjwJd3-VVRMg~rU0c5Vp9Lg3dCFFQ6f74nGqDvG-XjfyZj4529nufSYPN6ADhPvAtPbs~W8NNUTF5FCwTv7Xg__" },
                    { 2, "Hambúrgueres leves e nutritivos para quem quer manter o foco na saúde, sem abrir mão do sabor. Feitos com ingredientes frescos e integrais!", "X-Fitness", "https://s3-alpha-sig.figma.com/img/62e9/60a8/916fccb3e9f039a653a71fe3c3b305a0?Expires=1733702400&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=DJDu--0o~IdaTaRhTRGQ3C7WLw0aGT4dryBxg1hjVQuzdfLyM4Rv1lJmG0VSje8KRcgDFAn1pfQWK19YPJo3flKF6S7hIvAfT8TdXyqW8qpmYtWm9FrUrYkZCQSwgkCCzCcyp99cNl~VX1W-7fDUuDnYFHBt0MT-7T-5xW4Q--HHsnidbB0cS7M~RIqNXCwIw4xvCTz~8sVVlyBOEjAdCozqnyn6Z40C44K094SICVIIqetbAOJlwfKAdhW6SRAgYOjwJd3-VVRMg~rU0c5Vp9Lg3dCFFQ6f74nGqDvG-XjfyZj4529nufSYPN6ADhPvAtPbs~W8NNUTF5FCwTv7Xg__" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
