using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeTosAcceptanceOptions
    {
        [JsonProperty("tos_acceptance[date]")]
        public DateTime TosDate { get; set; }

        [JsonProperty("tos_acceptance[ip]")]
        public string TosIP { get; set; }
    }
}
