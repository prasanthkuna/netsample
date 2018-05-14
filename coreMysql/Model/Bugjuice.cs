using System;
using System.Collections.Generic;

namespace coreMysql.Model
{
    public partial class Bugjuice
    {
        public int Id { get; set; }
        public int? Bugid { get; set; }
        public int? Juiceid { get; set; }
    }
}
