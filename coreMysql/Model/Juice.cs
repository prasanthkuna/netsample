using System;
using System.Collections.Generic;

namespace coreMysql.Model
{
    public partial class Juice
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public bool IsSingle { get; set; }
    }
}
