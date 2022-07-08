using MinimalAPI.Models;

namespace MinimalAPI.Data
{
    public interface ICommandRepo
    {
        Task CreateCommand(Command cmd);
        Task<IEnumerable<Command>> GetAllCommands();
        Task<Command?> GetCommandById(int id);
        
        Task SaveChanges();
        void DeleteCommand(Command cmd);
    }
}