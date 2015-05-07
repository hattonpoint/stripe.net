using Newtonsoft.Json;

namespace Stripe
{
    public class StripeLegalEntityOptions
    {
        [JsonProperty("legal_entity[first_name]")]
        public string LegalEntityFirstName { get; set; }

        [JsonProperty("legal_entity[last_name]")]
        public string LegalEntityLastName { get; set; }

        [JsonProperty("legal_entity[type]")]
        public string LegalEntityType { get; set; }

        [JsonProperty("legal_entity[business_name]")]
        public string LegalEntityBusinessName { get; set; }

        [JsonProperty("legal_entity[dob[day]]")]
        public string LegalEntityDobDay { get; set; }

        [JsonProperty("legal_entity[dob[month]]")]
        public string LegalEntityDobMonth { get; set; }

        [JsonProperty("legal_entity[dob[year]]")]
        public string LegalEntityDobYear { get; set; }

        [JsonProperty("legal_entity[address[line1]]")]
        public string LegalEntityAddressLine1 { get; set; }

        [JsonProperty("legal_entity[address[line2]]")]
        public string LegalEntityAddressLine2 { get; set; }

        [JsonProperty("legal_entity[address[city]]")]
        public string LegalEntityAddressCity { get; set; }

        [JsonProperty("legal_entity[address[state]]")]
        public string LegalEntityAddressState { get; set; }

        [JsonProperty("legal_entity[address[postal_code]]")]
        public string LegalEntityAddressPostalCode { get; set; }

        [JsonProperty("legal_entity[address[country]]")]
        public string LegalEntityAddressCountry { get; set; }
    }
}
