using System.Collections.Generic;
using CommanderWebApi.Models;

namespace CommanderWebApi.Data
{
    public interface ICommanderRepo
    {
        bool SaveChanges();
        IEnumerable<Command> GetAllComands();
        Command GetCommandById(int id);
        void CreateCommand(Command cmd);

    }
}