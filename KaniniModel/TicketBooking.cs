using System;
using System.Collections.Generic;

#nullable disable

namespace MovieApi.KaniniModel
{
    public partial class TicketBooking
    {
        public string Name { get; set; }
        public int? Age { get; set; }
        public DateTime? DateTime { get; set; }
        public int PhoneNumber { get; set; }
        public string EmailId { get; set; }
    }
}
