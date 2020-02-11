using System;
using System.Collections.Generic;

namespace GameShop.Models
{
    public partial class UserItems
    {
        public int UserItemsId { get; set; }
        public string UserId { get; set; }
        public int? ItemId { get; set; }

        public virtual Items Item { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
