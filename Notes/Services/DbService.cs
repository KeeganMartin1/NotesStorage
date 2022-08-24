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
            return context.Notes;
        }

        public void SaveNotes(IEnumerable<RawNote> notes)
        {
            foreach(var note in notes)
            {
                if(string.IsNullOrEmpty(note.Id))
                {
                    note.Id = Guid.NewGuid().ToString();
                    context.Notes.Add(note);
                }
                else
                {
                    context.Notes.Update(note);
                }
            }
        }
    }
}
