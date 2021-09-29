using System;
using System.Collections.Generic;

#nullable disable

namespace DL.Entities
{
    public partial class LineItem
    {
        public LineItem()
        {
            ShopOrders = new HashSet<ShopOrder>();
        }

        public int Id { get; set; }
        public int Quant { get; set; }
        public int StoreId { get; set; }
        public int? ProdId { get; set; }

        public virtual StoreInv Prod { get; set; }
        public virtual Store Store { get; set; }
        public virtual ICollection<ShopOrder> ShopOrders { get; set; }
    }
}
