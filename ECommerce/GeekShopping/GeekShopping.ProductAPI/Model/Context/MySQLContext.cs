using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() { }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Camiseta GNU Linux",
                Price = new decimal(69.9),
                Description = "Lorem Ipsum é simplesmente uma simulação de texto da indústria tipográfica e de impressos, e vem sendo utilizado desde o século XVI, quando um impressor desconhecido pegou uma bandeja de tipos e os embaralhou para fazer um livro de modelos de tipos.",
                ImageURL = "data:image/jpeg;base64,/9j/",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Camiseta Ubuntu Server",
                Price = new decimal(69.9),
                Description = "Lorem Ipsum é simplesmente uma simulação de texto da indústria tipográfica e de impressos, e vem sendo utilizado desde o século XVI, quando um impressor desconhecido pegou uma bandeja de tipos e os embaralhou para fazer um livro de modelos de tipos.",
                ImageURL = "data:image/jpeg;base64,/9j/",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Camiseta Goku Fases",
                Price = new decimal(69.9),
                Description = "Lorem Ipsum é simplesmente uma simulação de texto da indústria tipográfica e de impressos, e vem sendo utilizado desde o século XVI, quando um impressor desconhecido pegou uma bandeja de tipos e os embaralhou para fazer um livro de modelos de tipos.",
                ImageURL = "data:image/jpeg;base64,/9j/",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Camiseta Windows Server",
                Price = new decimal(69.9),
                Description = "Lorem Ipsum é simplesmente uma simulação de texto da indústria tipográfica e de impressos, e vem sendo utilizado desde o século XVI, quando um impressor desconhecido pegou uma bandeja de tipos e os embaralhou para fazer um livro de modelos de tipos.",
                ImageURL = "data:image/jpeg;base64,/9j/",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Camiseta Fedora Fases",
                Price = new decimal(69.9),
                Description = "Lorem Ipsum é simplesmente uma simulação de texto da indústria tipográfica e de impressos, e vem sendo utilizado desde o século XVI, quando um impressor desconhecido pegou uma bandeja de tipos e os embaralhou para fazer um livro de modelos de tipos.",
                ImageURL = "data:image/jpeg;base64,/9j/",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Camiseta Solaris Server",
                Price = new decimal(69.9),
                Description = "Lorem Ipsum é simplesmente uma simulação de texto da indústria tipográfica e de impressos, e vem sendo utilizado desde o século XVI, quando um impressor desconhecido pegou uma bandeja de tipos e os embaralhou para fazer um livro de modelos de tipos.",
                ImageURL = "data:image/jpeg;base64,/9j/",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Camiseta Freeza Fases",
                Price = new decimal(69.9),
                Description = "Lorem Ipsum é simplesmente uma simulação de texto da indústria tipográfica e de impressos, e vem sendo utilizado desde o século XVI, quando um impressor desconhecido pegou uma bandeja de tipos e os embaralhou para fazer um livro de modelos de tipos.",
                ImageURL = "data:image/jpeg;base64,/9j/",
                CategoryName = "T-shirt"
            });

        }
    }
}
