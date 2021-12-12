using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class SearchVolumeByMonth
    {
        public int? Searches { get; set; }
        public string EnglishMonthName { get; set; }
        public short CalendarYear { get; set; }
    }
}
