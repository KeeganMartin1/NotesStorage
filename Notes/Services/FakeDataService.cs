using Notes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Services
{
    public class FakeDataService : IDataService
    {
        public IEnumerable<RawNote> GetNotes(string fileName)
        {
            return new List<RawNote>
            {
                new RawNote
                {
                    Note = "aasdfagdf",
                    Course = "sdf",
                    Time = "123",
                    Url = "sldfk",
                    Module = "13klj"
                },
                new RawNote
                {
                    Note = "3grewqcae",
                    Course = "er",
                    Time = "453",
                    Url = "esdea",
                    Module = "sdkfj3"
                }
            };
        }
    }
}
