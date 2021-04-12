using System.Collections.Generic;
using commands_api.Models;

namespace commands_api.Data
{
    public interface ICommandAPIRepo
    {
         bool SaveChanges();

         IEnumerable<Command> GetAllCommands();

         Command GetCommandById(int id);

         void CreateCommand(Command cmd);

         void UpdateCommand(Command cmd);
         
         void DeleteComand(Command cmd);
    }
}