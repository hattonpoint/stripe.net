﻿using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeTosAcceptance
    {
        [JsonProperty("date")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? Date { get; set; }

        [JsonProperty("ip")]
        public string IP { get; set; }

        [JsonProperty("user_agent")]
        public string UserAgent { get; set; }
    }
}
