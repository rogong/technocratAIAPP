using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class AbpPersistedGrant
    {
        public string Id { get; set; }
        public string ClientId { get; set; }
        public DateTime CreationTime { get; set; }
        public string Data { get; set; }
        public DateTime? Expiration { get; set; }
        public string SubjectId { get; set; }
        public string Type { get; set; }
        public DateTime? ConsumedTime { get; set; }
        public string Description { get; set; }
        public string SessionId { get; set; }
    }
}
