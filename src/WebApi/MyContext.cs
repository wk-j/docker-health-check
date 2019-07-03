using Microsoft.EntityFrameworkCore;

namespace WebApi {
    public class MyContext : DbContext {
        public MyContext(DbContextOptions options) : base(options) {
        }
        public DbSet<MyContext> Students { set; get; }
    }
}
