using System.Collections.Generic;

namespace Stripe
{
    public class StripeAccountService : StripeService
    {
        public StripeAccountService(string apiKey = null) : base(apiKey) { }

        public virtual StripeAccount Create(StripeAccountCreateOptions createOptions)
        {
            var url = this.ApplyAllParameters(createOptions, Urls.Accounts, false);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeAccount>.MapFromJson(response);
        }

        public virtual StripeAccount Get(string accountId)
        {
            var url = string.Format("{0}/{1}", Urls.Accounts, accountId);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeAccount>.MapFromJson(response);
        }

        public virtual StripeAccount Update(string accountId, StripeAccountUpdateOptions updateOptions)
        {
            var url = string.Format("{0}/{1}", Urls.Accounts, accountId);
            url = this.ApplyAllParameters(updateOptions, url, false);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeAccount>.MapFromJson(response);
        }

        public virtual void Delete(string accountId)
        {
            var url = string.Format("{0}/{1}", Urls.Accounts, accountId);

            Requestor.Delete(url, ApiKey);
        }

        public virtual IEnumerable<StripeAccount> List(StripeListOptions listOptions = null)
        {
            var url = Urls.Accounts;
            url = this.ApplyAllParameters(listOptions, url, true);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeAccount>.MapCollectionFromJson(response);
        }

        // Original version to support getting the current account based on the ApiKey
        public virtual StripeAccount Get()
        {
            var response = Requestor.GetString(Urls.Account, ApiKey);

            return Mapper<StripeAccount>.MapFromJson(response);
        }
    }
}