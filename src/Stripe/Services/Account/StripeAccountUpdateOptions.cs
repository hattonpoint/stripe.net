﻿using Newtonsoft.Json;
using System.Collections.Generic;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeAccountUpdateOptions
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("default_currency")]
        public string DefaultCurrency { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("bank_account")]
        public StripeBankAccountOptions BankAccount { get; set; }

        [JsonProperty("debit_negative_balances")]
        public bool DebitNegativeBalances { get; set; }

        [JsonProperty("tos_acceptance")]
        public StripeTosAcceptanceOptions TosAcceptance { get; set; }

        [JsonProperty("legal_entity")]
        public StripeLegalEntityOptions LegalEntity { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
