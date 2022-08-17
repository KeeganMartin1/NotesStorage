using Notes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Services
{
    public class DbService : IDbService
    {
        private NotesDbContext context;
        public DbService(NotesDbContext dbContext)
        {
            context = dbContext;
        }
        public IEnumerable<RawNote> GetNotes()
        {
            throw new NotImplementedException();
        }

        public void SaveNotes(IEnumerable<RawNote> notes)
        {
            throw new NotImplementedException();
        }
    }
}
