using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using StartedGuide.Data;

namespace StartedGuide.Seed
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Books.Any())
                {
                    var fakeBookData = new FakeBookData();
                    context.Books.AddRange(fakeBookData.Books);
                    context.SaveChanges();
                }

            }
        }
    }
}