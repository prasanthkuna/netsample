using System;
using System.Collections.Generic;

namespace coreMysql.Model
{
    public partial class Verificationcode
    {
        public int Id { get; set; }
        public string Mobileno { get; set; }
        public string Code { get; set; }
        public DateTime? Expirydate { get; set; }
    }
}
