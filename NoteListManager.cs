using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace MyNoteApp
{
    class NoteListManager
    {
        private NoteList noteListInstance;

        public NoteList NoteListInstance { get => noteListInstance; set => noteListInstance = value; }

        public NoteListManager()
        {
            noteListInstance = new NoteList();
        }
        public void SerializeToXML(string filePath)
        {
            //FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer xmlSerializer = new XmlSerializer(noteListInstance.GetType());
            using (var writer = XmlWriter.Create(filePath))
            {
                xmlSerializer.Serialize(writer, noteListInstance);
            }
            //xmlSerializer.Serialize(fs, noteListInstance);
            //fs.Close();
        }

        public object DeserializeFromXML(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read);
            XmlSerializer xmlSerializer = new XmlSerializer(noteListInstance.GetType());
            try
            {
                object result = xmlSerializer.Deserialize(fs);
                fs.Close();
                return result;
            }
            catch
            {
                fs.Close();
                throw new Exception();
            }
        }
    }
}
