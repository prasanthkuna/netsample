using System;
using System.Collections.Generic;

namespace coreMysql.Model
{
    public partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mobileno { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Email { get; set; }
        public DateTime? Createdon { get; set; }
        public DateTime? Modifiedon { get; set; }
        public string AuthToken { get; set; }
        public bool IsDeleted { get; set; }
    }
}
