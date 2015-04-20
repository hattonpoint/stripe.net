using System;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeTosAcceptance
    {
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("ip")]
        public string IP { get; set; }

        [JsonProperty("user_agent")]
        public string UserAgent { get; set; }
    }
}
