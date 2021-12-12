using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class Account
    {
        public int Id { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool? IsActive { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Location { get; set; }
    }
}
