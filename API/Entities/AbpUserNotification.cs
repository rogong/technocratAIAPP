﻿using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class AbpUserNotification
    {
        public Guid Id { get; set; }
        public DateTime CreationTime { get; set; }
        public int State { get; set; }
        public int? TenantId { get; set; }
        public Guid TenantNotificationId { get; set; }
        public long UserId { get; set; }
    }
}
