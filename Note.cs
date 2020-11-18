using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNoteApp
{
    public class Note
    {
        public event EventHandler ValueChanged;
        private DateTime date;
        public DateTime Date { get => date; set => date = value; }

        private DateTime lastModifiedDate;
        public DateTime LastModifiedDate { get => lastModifiedDate; set => lastModifiedDate = value; }
        private string title;
        public string Title 
        {
            get => title; 
            set { title = value; ValueChanged?.Invoke(this, new EventArgs()); } 
        }

        private string content;
        public string Content 
        {
            get => content; 
            set { content = value; ValueChanged?.Invoke(this, new EventArgs()); }
        }

        public Note()
        {
            Date = DateTime.Now;
            LastModifiedDate = DateTime.Now;
            Title = "Untitled";
            Content = "";
        }
    }
}
