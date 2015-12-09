using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.TestHost;
using Microsoft.Data.Entity;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace ASPNET5_EF7_Test
{
    public class SiteTests
    {
        [Fact]
        public async Task GetIt()
        {
            var server = TestServer.Create(app => { app.UseMvc(); }, services =>
            {
                services.AddMvc();

                services.AddEntityFramework()
                .AddSqlServer()
                .AddDbContext<TestContext>(options => options.UseInMemoryDatabase());

                services.AddScoped<TestContext, TestContext>();

            });

            var client = server.CreateClient();

            var response = await client.GetAsync("http://localhost/api/test");
            var content = await response.Content.ReadAsStringAsync();

            Assert.True(response.IsSuccessStatusCode);
        }
    }
}
