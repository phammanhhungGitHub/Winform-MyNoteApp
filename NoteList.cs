using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNoteApp
{
    [Serializable]
    public class NoteList
    {
        private List<Note> dataList;

        public List<Note> DataList { get => dataList; set => dataList = value; }

        public NoteList()
        {
            dataList = new List<Note>();
        }
    }
}
