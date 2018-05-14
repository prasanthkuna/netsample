using System;
using System.Collections.Generic;

namespace coreMysql.Model
{
    public partial class Mixture
    {
        public int Id { get; set; }
        public int? Juiceid { get; set; }
        public int? Resourceid { get; set; }
        public decimal? Quantity { get; set; }
    }
}
