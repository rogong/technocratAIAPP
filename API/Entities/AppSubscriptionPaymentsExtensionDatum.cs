using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class AppSubscriptionPaymentsExtensionDatum
    {
        public long Id { get; set; }
        public long SubscriptionPaymentId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public bool IsDeleted { get; set; }
    }
}
