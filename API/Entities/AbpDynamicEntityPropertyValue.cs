﻿using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class AbpDynamicEntityPropertyValue
    {
        public string Value { get; set; }
        public string EntityId { get; set; }
        public int DynamicEntityPropertyId { get; set; }
        public int? TenantId { get; set; }
        public long Id { get; set; }

        public virtual AbpDynamicEntityProperty DynamicEntityProperty { get; set; }
    }
}
