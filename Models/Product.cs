using System.Text.Json.Serialization;
using System.Text.Json;

namespace CraftSite2.Models
{
    public class Product
    {
        public required String Id { get; set; }
        public required String Maker { get; set; }

        [JsonPropertyName("img")]
        public required String Image { get; set; }

        public required String Url { get; set; }
        public required String Title { get; set; }
        public required String Description { get; set; }
        public required int[] Ratings { get; set; }

        public override String ToString() => JsonSerializer.Serialize<Product>(this);
    }
}
