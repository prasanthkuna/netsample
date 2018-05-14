using System;
using System.Collections.Generic;

namespace coreMysql.Model
{
    public partial class Bug
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
		public bool IsPopular { get; set; }
    }
}
