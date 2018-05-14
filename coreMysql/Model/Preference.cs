using System;
using System.Collections.Generic;

namespace coreMysql.Model
{
    public partial class Preference
    {
        public int Id { get; set; }
        public int? Userid { get; set; }
        public int? Bugid { get; set; }
        public bool IsActive { get; set; }
    }
}
