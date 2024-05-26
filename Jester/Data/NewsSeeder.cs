using Jester.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Jester.Data
{
    public static class NewsSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            var sampleNewsItems = File.ReadAllText("sample-news.json");
            var seedDataItems = JsonConvert.DeserializeObject<List<NewsItem>>(sampleNewsItems, new JsonSerializerSettings
            {
                DateTimeZoneHandling = DateTimeZoneHandling.Utc
            });

            Console.WriteLine(seedDataItems);
            if (seedDataItems != null && seedDataItems.Any())
            {
                modelBuilder.Entity<NewsItem>().HasData(seedDataItems);
            }
        }
    }
}
