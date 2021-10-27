using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNet.DataLayer.Repositories
{
    public interface IConsoleRepository
    {
        bool Edit(Console console);
        Task<List<Console>> GetAll();
        Console GetConsoleById(int consoleId);
     }
}
