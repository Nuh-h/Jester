using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Jester.Models
{

    public class NewsItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }
        
        public string? Story { get; set; }

        [Required]
        [StringLength(50)]
        public string Category { get; set; }

        [JsonConverter(typeof(UtcDateTimeConverter))]
        public DateTime DatePublished { get; set; }


        [StringLength(100)]
        public string Author { get; set; }

        public bool IsSponsored { get; set; }

        public string[] Tags { get; set; }

        public NewsItem()
        {
            DatePublished = DateTime.UtcNow;  //Initialize with the current UTC time
            Story = "";
            Tags = Array.Empty<string>();
            Author = "Jester Doe";
        }
    }

    public class UtcDateTimeConverter : JsonConverter<DateTime>
    {
        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TryGetDateTime(out DateTime dateTime))
            {
                return DateTime.SpecifyKind(dateTime, DateTimeKind.Utc);
            }
            return default;
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
        }
    }
}