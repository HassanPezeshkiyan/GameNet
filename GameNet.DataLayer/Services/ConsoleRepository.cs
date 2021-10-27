using GameNet.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace GameNet.DataLayer.Services
{
    public class ConsoleRepository : IConsoleRepository
    {
        private readonly GameNetEntities db;

        public ConsoleRepository(GameNetEntities context) {
            db = context;
        }
        public virtual bool Edit(Console console) {
            try {
                var local = db.Set<Console>().Local.FirstOrDefault(n => n.Id == console.Id);
                if (local != null) {
                    db.Entry(local).State = EntityState.Detached;
                }
                db.Entry(console).State = EntityState.Modified;
                return true;
            }
            catch {

                return false;
            }
        }

        public async Task<List<Console>> GetAll() {

            var list = await db.Consoles.ToListAsync();
            return list;
        }

        public Console GetConsoleById(int consoleId) {
            return db.Consoles.Find(consoleId);
        }
    }
}
