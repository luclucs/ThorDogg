using Newtonsoft.Json;

namespace ThorDogg
{
    public partial class DoggModel
    {
        [JsonProperty("breeds")]
        public Breed[] Breeds { get; set; }

        [JsonProperty("id")]
        public string  id { get; set; }

        [JsonProperty("url")]
        public string url { get; set; }
    }

    public partial class Breed
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("bred_for")]
        public string bredfor { get; set; }

        [JsonProperty("life_span")]
        public string lifespan { get; set; }

        [JsonProperty("temperament")]
        public string temperament { get; set; }

        [JsonProperty("url")]
        public string url { get; set; }
    }
}