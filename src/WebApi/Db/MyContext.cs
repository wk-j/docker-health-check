using Microsoft.EntityFrameworkCore;

namespace WebApi.Db {
    public class MyContext : DbContext {

        public MyContext(DbContextOptions options) : base(options) {
        }

        public DbSet<Student> Students { set; get; }
    }
}
