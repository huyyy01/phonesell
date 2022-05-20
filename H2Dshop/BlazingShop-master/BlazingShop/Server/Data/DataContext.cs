using BlazingShop.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Edition> Editions { get; set; }
        public DbSet<Stats> Stats { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductVariant>()
                .HasKey(p => new { p.ProductId, p.EditionId });

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "iPhone", Url = "iPhone", Icon = "phone" },
                new Category { Id = 2, Name = "Samsung", Url = "Samsung", Icon = "phone" },
                new Category { Id = 3, Name = "Oppo", Url = "Oppo", Icon = "phone" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "iPhone 11",
                    Description = "Apple đã chính thức trình làng bộ 3 siêu phẩm iPhone 11, trong đó phiên bản iPhone 11 64GB có mức giá rẻ nhất nhưng vẫn được nâng cấp mạnh mẽ như iPhone Xr ra mắt trước đó.",
                    Image = "https://cdn.tgdd.vn/Products/Images/42/153856/iphone-11-den-1-1-1-org.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 1,
                    Title = "iPhone 12",
                    Description = "Trong những tháng cuối năm 2020, Apple đã chính thức giới thiệu đến người dùng cũng như iFan thế hệ iPhone 12 series mới với hàng loạt tính năng bứt phá, thiết kế được lột xác hoàn toàn, hiệu năng đầy mạnh mẽ và một trong số đó chính là iPhone 12 64GB.",
                    Image = "https://cdn.tgdd.vn/Products/Images/42/213031/iphone-12-den-1-1-org.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 1,
                    Title = "iPhone 13",
                    Description = "Trong khi sức hút đến từ bộ 4 phiên bản iPhone 12 vẫn chưa nguội đi, thì hãng điện thoại Apple đã mang đến cho người dùng một siêu phẩm mới iPhone 13 với nhiều cải tiến thú vị sẽ mang lại những trải nghiệm hấp dẫn nhất cho người dùng.",
                    Image = "https://cdn.tgdd.vn/Products/Images/42/223602/iphone-13-1-2.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 4,
                    CategoryId = 2,
                    Title = "Samsung Galaxy S22 Ultra",
                    Description = "Galaxy S22 Ultra 5G chiếc smartphone cao cấp nhất trong bộ 3 Galaxy S22 series mà Samsung đã cho ra mắt. Tích hợp bút S Pen hoàn hảo trong thân máy, trang bị vi xử lý mạnh mẽ cho các tác vụ sử dụng vô cùng mượt mà và nổi bật hơn với cụm camera không viền độc đáo mang đậm dấu ấn riêng.",
                    Image = "https://cdn.tgdd.vn/Products/Images/42/235838/galaxy-s22-ultra-black-1.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 5,
                    CategoryId = 2,
                    Title = "Galaxy Z Fold3 ",
                    Description = "Galaxy Z Fold3 5G, chiếc điện thoại được nâng cấp toàn diện về nhiều mặt, đặc biệt đây là điện thoại màn hình gập đầu tiên trên thế giới có camera ẩn (08/2021). Sản phẩm sẽ là một “cú hit” của Samsung góp phần mang đến những trải nghiệm mới cho người dùng.",
                    Image = "https://cdn.tgdd.vn/Products/Images/42/226935/samsung-galaxy-z-fold-3-1-1-org.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 6,
                    CategoryId = 2,
                    Title = "Galaxy Z Flip3",
                    Description = "Galaxy Z Flip3 5G, chiếc điện thoại được nâng cấp toàn diện về nhiều mặt, đặc biệt đây là điện thoại màn hình gập đầu tiên trên thế giới có camera ẩn (08/2021). Sản phẩm sẽ là một “cú hit” của Samsung góp phần mang đến những trải nghiệm mới cho người dùng.",
                    Image = "https://cdn.tgdd.vn/Products/Images/42/281366/samsung-galaxy-z-flip3-5g-128gb-flex-your-way-tim-1-3.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 7,
                    CategoryId = 3,
                    Title = "OPPO Reno7 Z",
                    Description = "OPPO đã trình làng mẫu Reno7 Z 5G với thiết kế OPPO Glow độc quyền, camera mang hiệu ứng như máy DSLR chuyên nghiệp cùng viền sáng kép, máy có một cấu hình mạnh mẽ và đạt chứng nhận xếp hạng A về độ mượt.",
                    Image = "https://cdn.tgdd.vn/Products/Images/42/271717/oppo-reno7-z-1-2.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 8,
                    CategoryId = 3,
                    Title = "OPPO Reno6",
                    Description = "Sau khi ra mắt OPPO Reno5 chưa lâu thì OPPO lại cho ra mẫu smartphone mới mang tên OPPO Reno6 với hàng loạt cải tiến mới về ngoại hình bên ngoài lẫn hiệu năng bên trong, mang đến trải nghiệm vượt bật cho người dùng.",
                    Image = "https://cdn.tgdd.vn/Products/Images/42/236186/oppo-reno6-den-1-org.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 9,
                    CategoryId = 3,
                    Title = "OPPO Reno5",
                    Description = "OPPO đã trình làng OPPO Reno5 5G phiên bản kết nối 5G internet siêu nhanh ra thị trường. Chiếc điện thoại với hàng loạt các tính năng nổi bật cùng vẻ ngoài thời thượng giúp tôn lên vẻ sang trọng cho người sở hữu.",
                    Image = "https://cdn.tgdd.vn/Products/Images/42/233460/oppo-reno5-5g-den--org.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                }
            );

            modelBuilder.Entity<Edition>().HasData(
                    new Edition { Id = 1, Name = "Default" },
                    new Edition { Id = 2, Name = "64GB" },
                    new Edition { Id = 3, Name = "256GB" },
                    new Edition { Id = 4, Name = "512GB" },
                    new Edition { Id = 5, Name = "32GB" },
                    new Edition { Id = 6, Name = "64GB" },
                    new Edition { Id = 7, Name = "128GB" }
                );

            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 2,
                    Price = 500m,
                    OriginalPrice = 550m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 3,
                    Price = 750m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 4,
                    Price = 899m,
                    OriginalPrice = 1000m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    EditionId = 2,
                    Price = 600m,
                    OriginalPrice = 700m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    EditionId = 2,
                    Price = 1200m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    EditionId = 1,
                    Price = 699m,
                    OriginalPrice = 700m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    EditionId = 1,
                    Price = 1200m,
                    OriginalPrice = 1299m
                },
                new ProductVariant
                {
                    ProductId = 6,
                    EditionId = 1,
                    Price = 1200m,
                    OriginalPrice = 1299m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    EditionId = 5,
                    Price = 600m,
                    OriginalPrice = 699m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    EditionId = 6,
                    Price = 700m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    EditionId = 7,
                    Price = 500m,
                    OriginalPrice = 599m
                },
                new ProductVariant
                {
                    ProductId = 8,
                    EditionId = 5,
                    Price = 450m,
                    OriginalPrice = 499m,
                },
                new ProductVariant
                {
                    ProductId = 9,
                    EditionId = 5,
                    Price = 350m
                }
            );
        }
    }
}
