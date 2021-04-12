using commands_api.Models;
using Microsoft.EntityFrameworkCore;

namespace commands_api.Data
{
    public class CommandContext : DbContext
    {
        public CommandContext(DbContextOptions<CommandContext> options) : base(options)
        {

        }

        public DbSet<Command> CommandItems {get; set;}        
    }
}