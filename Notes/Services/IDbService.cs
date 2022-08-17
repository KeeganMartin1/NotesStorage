using Notes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Services
{
    public interface IDbService
    {
        IEnumerable<RawNote> GetNotes();
        void SaveNotes(IEnumerable<RawNote> notes);
    }
}
