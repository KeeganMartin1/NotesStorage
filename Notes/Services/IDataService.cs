using Notes.Model;
using System.Collections.Generic;

namespace Notes.Services
{
    public interface IDataService
    {
        IEnumerable<RawNote> GetNotes(string fileName);
    }
}