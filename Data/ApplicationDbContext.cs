using BurguerMania_API.Models;
using Microsoft.EntityFrameworkCore;

namespace BurguerMania_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public required DbSet<Category> Categories { get; set; }
        public required DbSet<Product> Products { get; set; }
        public required DbSet<Order> Orders { get; set; }
        public required DbSet<OrderProduct> OrderProducts { get; set; }
        public required DbSet<Status> Status { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "X-Vegan",
                    Description = "Deliciosos hambúrgueres feitos com todo o carinho, 100% vegetais e cheios de sabor. Perfeito para quem busca uma refeição consciente e deliciosa!",
                    PathImage = "https://s3-alpha-sig.figma.com/img/62e9/60a8/916fccb3e9f039a653a71fe3c3b305a0?Expires=1733702400&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=DJDu--0o~IdaTaRhTRGQ3C7WLw0aGT4dryBxg1hjVQuzdfLyM4Rv1lJmG0VSje8KRcgDFAn1pfQWK19YPJo3flKF6S7hIvAfT8TdXyqW8qpmYtWm9FrUrYkZCQSwgkCCzCcyp99cNl~VX1W-7fDUuDnYFHBt0MT-7T-5xW4Q--HHsnidbB0cS7M~RIqNXCwIw4xvCTz~8sVVlyBOEjAdCozqnyn6Z40C44K094SICVIIqetbAOJlwfKAdhW6SRAgYOjwJd3-VVRMg~rU0c5Vp9Lg3dCFFQ6f74nGqDvG-XjfyZj4529nufSYPN6ADhPvAtPbs~W8NNUTF5FCwTv7Xg__"
                },
                new Category
                {
                    Id = 2,
                    Name = "X-Fitness",
                    Description = "Hambúrgueres leves e nutritivos para quem quer manter o foco na saúde, sem abrir mão do sabor. Feitos com ingredientes frescos e integrais!",
                    PathImage = "https://s3-alpha-sig.figma.com/img/62e9/60a8/916fccb3e9f039a653a71fe3c3b305a0?Expires=1733702400&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=DJDu--0o~IdaTaRhTRGQ3C7WLw0aGT4dryBxg1hjVQuzdfLyM4Rv1lJmG0VSje8KRcgDFAn1pfQWK19YPJo3flKF6S7hIvAfT8TdXyqW8qpmYtWm9FrUrYkZCQSwgkCCzCcyp99cNl~VX1W-7fDUuDnYFHBt0MT-7T-5xW4Q--HHsnidbB0cS7M~RIqNXCwIw4xvCTz~8sVVlyBOEjAdCozqnyn6Z40C44K094SICVIIqetbAOJlwfKAdhW6SRAgYOjwJd3-VVRMg~rU0c5Vp9Lg3dCFFQ6f74nGqDvG-XjfyZj4529nufSYPN6ADhPvAtPbs~W8NNUTF5FCwTv7Xg__"
                },
                new Category
                {
                    Id = 3,
                    Name = "X-Deluxe",
                    Description = "Uma experiência gourmet! Hambúrgueres feitos com ingredientes premium, combinações sofisticadas e um toque de exclusividade.",
                    PathImage = "https://s3-alpha-sig.figma.com/img/62e9/60a8/916fccb3e9f039a653a71fe3c3b305a0?Expires=1733702400&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=DJDu--0o~IdaTaRhTRGQ3C7WLw0aGT4dryBxg1hjVQuzdfLyM4Rv1lJmG0VSje8KRcgDFAn1pfQWK19YPJo3flKF6S7hIvAfT8TdXyqW8qpmYtWm9FrUrYkZCQSwgkCCzCcyp99cNl~VX1W-7fDUuDnYFHBt0MT-7T-5xW4Q--HHsnidbB0cS7M~RIqNXCwIw4xvCTz~8sVVlyBOEjAdCozqnyn6Z40C44K094SICVIIqetbAOJlwfKAdhW6SRAgYOjwJd3-VVRMg~rU0c5Vp9Lg3dCFFQ6f74nGqDvG-XjfyZj4529nufSYPN6ADhPvAtPbs~W8NNUTF5FCwTv7Xg__"
                }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "X-Alface-Premium",
                    CategoryId = 1,
                    Description = "Pão, Hambúrguer vegano, alface crocante, molho especial e temperos inconfundíveis.",
                    FullDescription = "Um hambúrguer vegano suculento feito com uma base de grão-de-bico e quinoa, temperado com especiarias defumadas, cebola caramelizada e alho, garantindo uma textura rica e saborosa. Servido em um pão macio, ele vem acompanhado de fatias frescas de tomate, alface crocante, picles, abacate cremoso e uma generosa camada de maionese de ervas vegana. Finalizado com molho barbecue agridoce e uma pitada de pimenta-do-reino moída na hora, proporcionando uma combinação deliciosa de sabores e texturas em cada mordida.",
                    Price = 22.50m,
                    PathImage = "https://s3-alpha-sig.figma.com/img/62e9/60a8/916fccb3e9f039a653a71fe3c3b305a0?Expires=1733702400&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=DJDu--0o~IdaTaRhTRGQ3C7WLw0aGT4dryBxg1hjVQuzdfLyM4Rv1lJmG0VSje8KRcgDFAn1pfQWK19YPJo3flKF6S7hIvAfT8TdXyqW8qpmYtWm9FrUrYkZCQSwgkCCzCcyp99cNl~VX1W-7fDUuDnYFHBt0MT-7T-5xW4Q--HHsnidbB0cS7M~RIqNXCwIw4xvCTz~8sVVlyBOEjAdCozqnyn6Z40C44K094SICVIIqetbAOJlwfKAdhW6SRAgYOjwJd3-VVRMg~rU0c5Vp9Lg3dCFFQ6f74nGqDvG-XjfyZj4529nufSYPN6ADhPvAtPbs~W8NNUTF5FCwTv7Xg__"
                },
                new Product
                {
                    Id = 2,
                    Name = "X-Tomate",
                    CategoryId = 1,
                    Description = "Pão, Hambúrguer vegano, tomate fresco, cebola caramelizada e mostarda artesanal.",
                    FullDescription = "Este hambúrguer vegano traz um pão macio recheado com uma deliciosa combinação de tomate fresco, cebola caramelizada e um toque de mostarda artesanal. O hambúrguer vegano é preparado com especiarias especiais para um sabor marcante e harmonioso. A adição de alface crocante e molho especial finaliza o prato com uma textura fresca e saborosa.",
                    Price = 24.00m,
                    PathImage = "https://s3-alpha-sig.figma.com/img/62e9/60a8/916fccb3e9f039a653a71fe3c3b305a0?Expires=1733702400&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=DJDu--0o~IdaTaRhTRGQ3C7WLw0aGT4dryBxg1hjVQuzdfLyM4Rv1lJmG0VSje8KRcgDFAn1pfQWK19YPJo3flKF6S7hIvAfT8TdXyqW8qpmYtWm9FrUrYkZCQSwgkCCzCcyp99cNl~VX1W-7fDUuDnYFHBt0MT-7T-5xW4Q--HHsnidbB0cS7M~RIqNXCwIw4xvCTz~8sVVlyBOEjAdCozqnyn6Z40C44K094SICVIIqetbAOJlwfKAdhW6SRAgYOjwJd3-VVRMg~rU0c5Vp9Lg3dCFFQ6f74nGqDvG-XjfyZj4529nufSYPN6ADhPvAtPbs~W8NNUTF5FCwTv7Xg__"
                },
                new Product
                {
                    Id = 3,
                    Name = "X-Fitness-Leve",
                    CategoryId = 2,
                    Description = "Pão, Peito de frango grelhado, alface, tomate, molho light e especiarias.",
                    FullDescription = "Este hambúrguer fitness traz uma combinação equilibrada com peito de frango grelhado, alface fresca, tomate e um molho light. Servido em um pão integral, este prato é ideal para quem busca uma refeição leve e saborosa, mas sem abrir mão do sabor. O toque de especiarias garante um sabor irresistível e saudável.",
                    Price = 27.00m,
                    PathImage = "https://s3-alpha-sig.figma.com/img/62e9/60a8/916fccb3e9f039a653a71fe3c3b305a0?Expires=1733702400&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=DJDu--0o~IdaTaRhTRGQ3C7WLw0aGT4dryBxg1hjVQuzdfLyM4Rv1lJmG0VSje8KRcgDFAn1pfQWK19YPJo3flKF6S7hIvAfT8TdXyqW8qpmYtWm9FrUrYkZCQSwgkCCzCcyp99cNl~VX1W-7fDUuDnYFHBt0MT-7T-5xW4Q--HHsnidbB0cS7M~RIqNXCwIw4xvCTz~8sVVlyBOEjAdCozqnyn6Z40C44K094SICVIIqetbAOJlwfKAdhW6SRAgYOjwJd3-VVRMg~rU0c5Vp9Lg3dCFFQ6f74nGqDvG-XjfyZj4529nufSYPN6ADhPvAtPbs~W8NNUTF5FCwTv7Xg__"
                },
                new Product
                {
                    Id = 4,
                    Name = "X-Deluxe-Sophisticate",
                    CategoryId = 3,
                    Description = "Pão, Hambúrguer de carne premium, molho trufado, queijo brie e especiarias finas.",
                    FullDescription = "Este hambúrguer gourmet é preparado com carne premium de alta qualidade, que é complementada por um molho trufado delicado e queijo brie. O pão macio serve como base para essa combinação sofisticada, que é finalizada com uma pitada de especiarias finas. Um prato que oferece uma experiência única para os amantes de sabores refinados.",
                    Price = 35.00m,
                    PathImage = "https://s3-alpha-sig.figma.com/img/62e9/60a8/916fccb3e9f039a653a71fe3c3b305a0?Expires=1733702400&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=DJDu--0o~IdaTaRhTRGQ3C7WLw0aGT4dryBxg1hjVQuzdfLyM4Rv1lJmG0VSje8KRcgDFAn1pfQWK19YPJo3flKF6S7hIvAfT8TdXyqW8qpmYtWm9FrUrYkZCQSwgkCCzCcyp99cNl~VX1W-7fDUuDnYFHBt0MT-7T-5xW4Q--HHsnidbB0cS7M~RIqNXCwIw4xvCTz~8sVVlyBOEjAdCozqnyn6Z40C44K094SICVIIqetbAOJlwfKAdhW6SRAgYOjwJd3-VVRMg~rU0c5Vp9Lg3dCFFQ6f74nGqDvG-XjfyZj4529nufSYPN6ADhPvAtPbs~W8NNUTF5FCwTv7Xg__"
                },
                new Product
                {
                    Id = 5,
                    Name = "X-Frutas",
                    CategoryId = 1,
                    Description = "Pão, Hambúrguer vegano, frutas frescas, molho agridoce e temperos especiais.",
                    FullDescription = "Este hambúrguer vegano inovador combina o sabor refrescante de frutas frescas com um molho agridoce que faz uma fusão perfeita com o hambúrguer preparado com grãos selecionados. O prato é servido com pão macio e alface crocante, oferecendo uma experiência única de sabores doce e salgado com um toque de temperos especiais.",
                    Price = 23.00m,
                    PathImage = "https://s3-alpha-sig.figma.com/img/62e9/60a8/916fccb3e9f039a653a71fe3c3b305a0?Expires=1733702400&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=DJDu--0o~IdaTaRhTRGQ3C7WLw0aGT4dryBxg1hjVQuzdfLyM4Rv1lJmG0VSje8KRcgDFAn1pfQWK19YPJo3flKF6S7hIvAfT8TdXyqW8qpmYtWm9FrUrYkZCQSwgkCCzCcyp99cNl~VX1W-7fDUuDnYFHBt0MT-7T-5xW4Q--HHsnidbB0cS7M~RIqNXCwIw4xvCTz~8sVVlyBOEjAdCozqnyn6Z40C44K094SICVIIqetbAOJlwfKAdhW6SRAgYOjwJd3-VVRMg~rU0c5Vp9Lg3dCFFQ6f74nGqDvG-XjfyZj4529nufSYPN6ADhPvAtPbs~W8NNUTF5FCwTv7Xg__"
                },
                new Product
                {
                    Id = 6,
                    Name = "X-Abacate-Avocado",
                    CategoryId = 1,
                    Description = "Pão, Hambúrguer vegano, abacate cremoso, alface, tomate, molho especial e especiarias.",
                    FullDescription = "Este hambúrguer vegano combina uma generosa camada de abacate cremoso com o sabor suave do hambúrguer preparado com vegetais frescos. O abacate, juntamente com alface e tomate frescos, cria um contraste refrescante, enquanto o molho especial e as especiarias proporcionam um toque de sabor e cremosidade únicos.",
                    Price = 25.00m,
                    PathImage = "https://s3-alpha-sig.figma.com/img/62e9/60a8/916fccb3e9f039a653a71fe3c3b305a0?Expires=1733702400&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=DJDu--0o~IdaTaRhTRGQ3C7WLw0aGT4dryBxg1hjVQuzdfLyM4Rv1lJmG0VSje8KRcgDFAn1pfQWK19YPJo3flKF6S7hIvAfT8TdXyqW8qpmYtWm9FrUrYkZCQSwgkCCzCcyp99cNl~VX1W-7fDUuDnYFHBt0MT-7T-5xW4Q--HHsnidbB0cS7M~RIqNXCwIw4xvCTz~8sVVlyBOEjAdCozqnyn6Z40C44K094SICVIIqetbAOJlwfKAdhW6SRAgYOjwJd3-VVRMg~rU0c5Vp9Lg3dCFFQ6f74nGqDvG-XjfyZj4529nufSYPN6ADhPvAtPbs~W8NNUTF5FCwTv7Xg__"
                }
            );
        }
    }
}
