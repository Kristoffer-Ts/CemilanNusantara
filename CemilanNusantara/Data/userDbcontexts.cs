using CemilanNusantara.Models;
using Microsoft.EntityFrameworkCore;
namespace CemilanNusantara.Data
{
    public class userDbcontext : DbContext
    {
        public userDbcontext(DbContextOptions<userDbcontext>options) : base(options)
        {

        }

        public DbSet<user> users { get; set; }
       
    }
}
