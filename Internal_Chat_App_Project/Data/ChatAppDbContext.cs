using Microsoft.EntityFrameworkCore;
using Internal_Chat_App_Project.Models;

namespace Internal_Chat_App_Project.Data
{
    public class ChatAppDbContext : DbContext
    {
        public ChatAppDbContext(DbContextOptions <ChatAppDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }

    }


}
