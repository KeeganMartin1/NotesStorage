using CsvHelper;
using Notes.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Services
{
    public class DataService : IDataService
    {
        public IEnumerable<RawNote> GetNotes(string fileName)
        {
            List<RawNote> notes = new List<RawNote>();
            using (var reader = new StreamReader(fileName))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                notes = new List<RawNote>(csv.GetRecords<RawNote>());
            }
            return notes;
        }
    }
}
