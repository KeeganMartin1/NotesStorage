using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;


namespace Notes.Model
{
    public class RawNote
    {
        public RawNote()
        {
            Id = Guid.NewGuid().ToString();
        }
        [Key]
        public string Id { get; set; }
        public string Note { get; set; }
        public string Course { get; set; }
        public string Module { get; set; }
        public string Clip { get; set; }
        [Name("Time in Clip")]
        public string Time { get; set; }
        [Name("URL")]
        public string Url { get; set; }
    }
}
