using Microsoft.Win32;
using Notes.Model;
using Notes.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Notes
{
    public class MainWindowViewModel
    {
        public ObservableCollection<RawNote> Notes { get; set; }
        private IDataService fileService;
        private IDbService dbService;

        public MainWindowViewModel(IDataService fileService, IDbService dbService)
        {
            this.fileService = fileService;
            this.dbService = dbService;
            Notes = new ObservableCollection<RawNote>(dbService.GetNotes());
        }

        public void LoadFile(string path)
        {
            var newNotes = fileService.GetNotes(path);
            foreach(var note in newNotes)
            {
                while (note.Note.Contains("\\n"))
                {
                    note.Note = note.Note.Replace("\\n", "\n");
                }
            }
            dbService.SaveNotes(newNotes);
            Notes = new ObservableCollection<RawNote>(dbService.GetNotes());
        }
    }
}
