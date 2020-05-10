using System.Text.Json;
using System.Text.Json.Serialization;

namespace ImageGallery.Model
{
    public class Address
    {
        [JsonPropertyName("country")]
        public string Country
        {
            get;
            set;
        }

        [JsonPropertyName("locality")]
        public string Locality
        {
            get;
            set;
        }

        [JsonPropertyName("postal_code")]
        public int PostalCode
        {
            get;
            set;
        }

        [JsonPropertyName("street_address")]
        public string StreetAddress
        {
            get;
            set;
        }
    }
}