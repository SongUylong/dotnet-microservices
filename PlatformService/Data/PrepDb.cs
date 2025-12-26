using Microsoft.AspNetCore.Builder;

namespace PlatformService.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                seedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }

        private static void seedData(AppDbContext context)
        {
            if (!context.Platforms.Any())
            {
                Console.WriteLine("--> Seeding Data....");
                context.Platforms.AddRange(
                    new Models.Platform()
                    {
                        Name = "SQL Server",
                        Publisher = "Microsoft",
                        Cost = "Free",
                    },
                    new Models.Platform()
                    {
                        Name = "Kubernetes",
                        Publisher = "Cloud Native Computing Foudation",
                        Cost = "Free",
                    },
                    new Models.Platform()
                    {
                        Name = "Dot Net",
                        Publisher = "Microsoft",
                        Cost = "Free",
                    }
                );
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("--> Data Already Exist");
            }
        }
    }
}
