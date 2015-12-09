using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Extensions.Configuration;

namespace ASPNET5_EF7_Test
{
    public class TestContextFactory : IDbContextFactory<TestContext>
    {
        public TestContext Create()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json");

            var configuration = builder.Build();
            var optionBuilder = new DbContextOptionsBuilder<TestContext>();
            optionBuilder.UseSqlServer(configuration["Data:DefaultConnection:ConnectionString"]);

            return new TestContext(optionBuilder.Options);
        }
    }
}