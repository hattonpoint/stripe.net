using Newtonsoft.Json;
using System.Collections.Generic;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeAccountGetOptions
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }
}
