﻿using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class AppChatMessage
    {
        public long Id { get; set; }
        public DateTime CreationTime { get; set; }
        public string Message { get; set; }
        public int ReadState { get; set; }
        public int Side { get; set; }
        public int? TargetTenantId { get; set; }
        public long TargetUserId { get; set; }
        public int? TenantId { get; set; }
        public long UserId { get; set; }
        public Guid? SharedMessageId { get; set; }
        public int ReceiverReadState { get; set; }
    }
}
