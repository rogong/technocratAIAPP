﻿using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class AbpWebhookEvent
    {
        public AbpWebhookEvent()
        {
            AbpWebhookSendAttempts = new HashSet<AbpWebhookSendAttempt>();
        }

        public Guid Id { get; set; }
        public string WebhookName { get; set; }
        public string Data { get; set; }
        public DateTime CreationTime { get; set; }
        public int? TenantId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletionTime { get; set; }

        public virtual ICollection<AbpWebhookSendAttempt> AbpWebhookSendAttempts { get; set; }
    }
}
