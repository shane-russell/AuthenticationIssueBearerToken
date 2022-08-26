using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NewAuth.Api.Domain;

namespace NewAuth.Api
{
    public class NewAuthDbcontext : IdentityDbContext<User, Role, int>
    {
        public DbSet<ExampleDomainClass> ExampleDomainClasses { get; set; }

        public NewAuthDbcontext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // connection string can be set here or in startup as is done now.
            // optionsBuilder.UseSqlServer(@"Data Source = DESKTOP-7M7OSA9; Initial Catalog = NewAuthDb; Integrated Security = True";);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
