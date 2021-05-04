using Basic.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Basic.Context
{
    public class Users : DbContext
    {
        public Users() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KOSTA\Desktop\KOSTA\Cs\ASP.NET\ASP_DB.mdf;Integrated Security=True;Connect Timeout=30")
        { }
        public DbSet<User> UserInfo { get; set; }
    }
}