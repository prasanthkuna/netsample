using System;
using System.Collections.Generic;

namespace coreMysql.Model
{
    public partial class Favourite
    {
        public int Id { get; set; }
        public int? Userid { get; set; }
        public int? Juiceid { get; set; }
    }
}
