using Basic2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Basic2.Context
{
    public class Users : DbContext
    {
        public Users() : base(@"Data Source=192.168.0.80;Initial Catalog=kostaDB10;Persist Security Info=True;User ID=kosta10;Password=***********")
        { }
        public DbSet<User> UserInfo { get; set; }
    }
}