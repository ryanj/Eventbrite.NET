﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventbriteNET.Entities
{
    public enum TicketType
    {
        FixedPrice,
        Donation
    }
    public class Ticket : EntityBase
    {
        public int Id;
        public string Name;
        public string Description;
        public TicketType Type;
        public string Currency;
        public decimal Price;
        public DateTime? StartDateTime;
        public DateTime EndDateTime;
        public int? QuantityAvailable;
        public int? QuantitySold;

        public Ticket(EventbriteContext context) : base(context) { }
    }
}
