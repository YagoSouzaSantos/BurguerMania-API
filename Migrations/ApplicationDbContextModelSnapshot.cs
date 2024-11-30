﻿// <auto-generated />
using BurguerMania_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BurguerMania_API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("BurguerMania_API.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("PathImage")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Deliciosos hambúrgueres feitos com todo o carinho, 100% vegetais e cheios de sabor. Perfeito para quem busca uma refeição consciente e deliciosa!",
                            Name = "X-Vegan",
                            PathImage = "https://s3-alpha-sig.figma.com/img/62e9/60a8/916fccb3e9f039a653a71fe3c3b305a0?Expires=1733702400&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=DJDu--0o~IdaTaRhTRGQ3C7WLw0aGT4dryBxg1hjVQuzdfLyM4Rv1lJmG0VSje8KRcgDFAn1pfQWK19YPJo3flKF6S7hIvAfT8TdXyqW8qpmYtWm9FrUrYkZCQSwgkCCzCcyp99cNl~VX1W-7fDUuDnYFHBt0MT-7T-5xW4Q--HHsnidbB0cS7M~RIqNXCwIw4xvCTz~8sVVlyBOEjAdCozqnyn6Z40C44K094SICVIIqetbAOJlwfKAdhW6SRAgYOjwJd3-VVRMg~rU0c5Vp9Lg3dCFFQ6f74nGqDvG-XjfyZj4529nufSYPN6ADhPvAtPbs~W8NNUTF5FCwTv7Xg__"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Hambúrgueres leves e nutritivos para quem quer manter o foco na saúde, sem abrir mão do sabor. Feitos com ingredientes frescos e integrais!",
                            Name = "X-Fitness",
                            PathImage = "https://s3-alpha-sig.figma.com/img/62e9/60a8/916fccb3e9f039a653a71fe3c3b305a0?Expires=1733702400&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=DJDu--0o~IdaTaRhTRGQ3C7WLw0aGT4dryBxg1hjVQuzdfLyM4Rv1lJmG0VSje8KRcgDFAn1pfQWK19YPJo3flKF6S7hIvAfT8TdXyqW8qpmYtWm9FrUrYkZCQSwgkCCzCcyp99cNl~VX1W-7fDUuDnYFHBt0MT-7T-5xW4Q--HHsnidbB0cS7M~RIqNXCwIw4xvCTz~8sVVlyBOEjAdCozqnyn6Z40C44K094SICVIIqetbAOJlwfKAdhW6SRAgYOjwJd3-VVRMg~rU0c5Vp9Lg3dCFFQ6f74nGqDvG-XjfyZj4529nufSYPN6ADhPvAtPbs~W8NNUTF5FCwTv7Xg__"
                        });
                });

            modelBuilder.Entity("BurguerMania_API.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<float>("Value")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("StatusId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BurguerMania_API.Models.OrderProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderProducts");
                });

            modelBuilder.Entity("BurguerMania_API.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BaseDescription")
                        .HasColumnType("longtext");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("FullDescription")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("PathImage")
                        .HasColumnType("longtext");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BaseDescription = "Pão, Hambúrguer vegano, alface crocante, molho especial e temperos inconfundíveis.",
                            CategoryId = 1,
                            FullDescription = "Um hambúrguer vegano suculento feito com uma base de grão-de-bico e quinoa, temperado com especiarias defumadas, cebola caramelizada e alho, garantindo uma textura rica e saborosa. Servido em um pão macio, ele vem acompanhado de fatias frescas de tomate, alface crocante, picles, abacate cremoso e uma generosa camada de maionese de ervas vegana. Finalizado com molho barbecue agridoce e uma pitada de pimenta-do-reino moída na hora, proporcionando uma combinação deliciosa de sabores e texturas em cada mordida.",
                            Name = "X-Alface-Premium",
                            PathImage = "https://s3-alpha-sig.figma.com/img/62e9/60a8/916fccb3e9f039a653a71fe3c3b305a0?Expires=1733702400&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=DJDu--0o~IdaTaRhTRGQ3C7WLw0aGT4dryBxg1hjVQuzdfLyM4Rv1lJmG0VSje8KRcgDFAn1pfQWK19YPJo3flKF6S7hIvAfT8TdXyqW8qpmYtWm9FrUrYkZCQSwgkCCzCcyp99cNl~VX1W-7fDUuDnYFHBt0MT-7T-5xW4Q--HHsnidbB0cS7M~RIqNXCwIw4xvCTz~8sVVlyBOEjAdCozqnyn6Z40C44K094SICVIIqetbAOJlwfKAdhW6SRAgYOjwJd3-VVRMg~rU0c5Vp9Lg3dCFFQ6f74nGqDvG-XjfyZj4529nufSYPN6ADhPvAtPbs~W8NNUTF5FCwTv7Xg__",
                            Price = 22.50m
                        },
                        new
                        {
                            Id = 2,
                            BaseDescription = "Pão, Hambúrguer vegano, tomate fresco, cebola caramelizada e mostarda artesanal.",
                            CategoryId = 1,
                            FullDescription = "Este hambúrguer vegano traz um pão macio recheado com uma deliciosa combinação de tomate fresco, cebola caramelizada e um toque de mostarda artesanal. O hambúrguer vegano é preparado com especiarias especiais para um sabor marcante e harmonioso. A adição de alface crocante e molho especial finaliza o prato com uma textura fresca e saborosa.",
                            Name = "X-Tomate",
                            PathImage = "https://s3-alpha-sig.figma.com/img/62e9/60a8/916fccb3e9f039a653a71fe3c3b305a0?Expires=1733702400&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=DJDu--0o~IdaTaRhTRGQ3C7WLw0aGT4dryBxg1hjVQuzdfLyM4Rv1lJmG0VSje8KRcgDFAn1pfQWK19YPJo3flKF6S7hIvAfT8TdXyqW8qpmYtWm9FrUrYkZCQSwgkCCzCcyp99cNl~VX1W-7fDUuDnYFHBt0MT-7T-5xW4Q--HHsnidbB0cS7M~RIqNXCwIw4xvCTz~8sVVlyBOEjAdCozqnyn6Z40C44K094SICVIIqetbAOJlwfKAdhW6SRAgYOjwJd3-VVRMg~rU0c5Vp9Lg3dCFFQ6f74nGqDvG-XjfyZj4529nufSYPN6ADhPvAtPbs~W8NNUTF5FCwTv7Xg__",
                            Price = 24.00m
                        },
                        new
                        {
                            Id = 3,
                            BaseDescription = "Pão, Peito de frango grelhado, alface, tomate, molho light e especiarias.",
                            CategoryId = 2,
                            FullDescription = "Este hambúrguer fitness traz uma combinação equilibrada com peito de frango grelhado, alface fresca, tomate e um molho light. Servido em um pão integral, este prato é ideal para quem busca uma refeição leve e saborosa, mas sem abrir mão do sabor. O toque de especiarias garante um sabor irresistível e saudável.",
                            Name = "X-Fitness-Leve",
                            PathImage = "https://s3-alpha-sig.figma.com/img/62e9/60a8/916fccb3e9f039a653a71fe3c3b305a0?Expires=1733702400&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=DJDu--0o~IdaTaRhTRGQ3C7WLw0aGT4dryBxg1hjVQuzdfLyM4Rv1lJmG0VSje8KRcgDFAn1pfQWK19YPJo3flKF6S7hIvAfT8TdXyqW8qpmYtWm9FrUrYkZCQSwgkCCzCcyp99cNl~VX1W-7fDUuDnYFHBt0MT-7T-5xW4Q--HHsnidbB0cS7M~RIqNXCwIw4xvCTz~8sVVlyBOEjAdCozqnyn6Z40C44K094SICVIIqetbAOJlwfKAdhW6SRAgYOjwJd3-VVRMg~rU0c5Vp9Lg3dCFFQ6f74nGqDvG-XjfyZj4529nufSYPN6ADhPvAtPbs~W8NNUTF5FCwTv7Xg__",
                            Price = 27.00m
                        });
                });

            modelBuilder.Entity("BurguerMania_API.Models.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("BurguerMania_API.Models.Order", b =>
                {
                    b.HasOne("BurguerMania_API.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Status");
                });

            modelBuilder.Entity("BurguerMania_API.Models.OrderProduct", b =>
                {
                    b.HasOne("BurguerMania_API.Models.Order", "Order")
                        .WithMany("OrderProducts")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BurguerMania_API.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BurguerMania_API.Models.Product", b =>
                {
                    b.HasOne("BurguerMania_API.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BurguerMania_API.Models.Order", b =>
                {
                    b.Navigation("OrderProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
