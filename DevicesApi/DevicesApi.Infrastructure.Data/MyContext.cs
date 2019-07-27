
using DevicesApi.Domain.Core;
using DevicesApi.Infrastructure.Data;
using System.Data.Entity;

namespace ONIONv3.Infrastructure.Data
{
    public class MyContext : DbContext
    {
        public MyContext() : base("MyContext")
        {
            Database.SetInitializer<MyContext>(new MyInitializer());
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Device> Devices { get; set; }

    }
}
