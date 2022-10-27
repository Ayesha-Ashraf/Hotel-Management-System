using System.Text.Json.Serialization;
using System.Text.Json;

namespace Hotel_Management_System.Model
{
    public class room

    {
        [JsonPropertyName("id")]
        public int room_id { get; set; }
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("image")]
        public string image { get; set; }
        //save the Data Back To file????
        public override string ToString()
        {
            return JsonSerializer.Serialize<room>(this);
        }
    }
}

