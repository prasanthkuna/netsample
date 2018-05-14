using System;
using System.Collections.Generic;

namespace coreMysql.Model
{
    public partial class Cart
    {
        public int Id { get; set; }
        public int? Userid { get; set; }
        public int? Juiceid { get; set; }
        public DateTime? OrderedDate { get; set; }
        public int? Quantity { get; set; }
    }
}
