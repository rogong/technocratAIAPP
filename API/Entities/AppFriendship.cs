﻿using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class AppFriendship
    {
        public long Id { get; set; }
        public DateTime CreationTime { get; set; }
        public Guid? FriendProfilePictureId { get; set; }
        public string FriendTenancyName { get; set; }
        public int? FriendTenantId { get; set; }
        public long FriendUserId { get; set; }
        public string FriendUserName { get; set; }
        public int State { get; set; }
        public int? TenantId { get; set; }
        public long UserId { get; set; }
    }
}
