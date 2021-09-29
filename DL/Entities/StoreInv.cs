using System;
using System.Collections.Generic;

#nullable disable

namespace DL.Entities
{
    public partial class StoreInv
    {
        public StoreInv()
        {
            LineItems = new HashSet<LineItem>();
        }

        public int Id { get; set; }
        public string Ch { get; set; }
        public string ProdName { get; set; }
        public decimal ProdPrice { get; set; }
        public int ProdStock { get; set; }
        public int StoreId { get; set; }

        public virtual Store Store { get; set; }
        public virtual ICollection<LineItem> LineItems { get; set; }
    }
}
