using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class AppBinaryObject
    {
        public Guid Id { get; set; }
        public byte[] Bytes { get; set; }
        public int? TenantId { get; set; }
        public string Description { get; set; }
    }
}
