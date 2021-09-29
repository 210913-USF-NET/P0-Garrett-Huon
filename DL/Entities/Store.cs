using System;
using System.Collections.Generic;

#nullable disable

namespace DL.Entities
{
    public partial class Store
    {
        public Store()
        {
            LineItems = new HashSet<LineItem>();
            StoreInvs = new HashSet<StoreInv>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public virtual ICollection<LineItem> LineItems { get; set; }
        public virtual ICollection<StoreInv> StoreInvs { get; set; }
    }
}
