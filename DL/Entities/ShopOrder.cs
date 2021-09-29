using System;
using System.Collections.Generic;

#nullable disable

namespace DL.Entities
{
    public partial class ShopOrder
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Cname { get; set; }
        public string Payment { get; set; }
        public decimal Cost { get; set; }
        public int? LineId { get; set; }

        public virtual LineItem Line { get; set; }
    }
}
