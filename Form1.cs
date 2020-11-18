using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNoteApp
{
    public partial class FormNoteList : Form
    {
        private NoteListManager noteManager;
        private string filePath = "data.xml";
        private NoteItem focusingNoteItem;

        private void LoadSetting()
        {
            this.Size = Properties.Settings.Default.Size;
        }

        private void SaveSetting()
        {
            Properties.Settings.Default.Size = this.Size;
        }
        public FormNoteList()
        {
            InitializeComponent();
            SetButtonEnableAndVisible(buttonDeleteNote, false);
            SetButtonEnableAndVisible(buttonDone, false);
            noteManager = new NoteListManager();
            try
            {
                noteManager.NoteListInstance = noteManager.DeserializeFromXML(filePath) as NoteList;
            }
            catch
            {
                SetDefaultNote();
            }
            ShowNote();
        }

        private void SetDefaultNote()
        {
            Note note = new Note()
            {
                Date = DateTime.Now,
                Title = "Untitled",
                Content = "",
            };
            noteManager.NoteListInstance.DataList.Add(note);
        }

        private void ShowNote()
        {
            foreach (Note item in noteManager.NoteListInstance.DataList)
            {
                AddNoteItem(item);
            }
        }

        private void AddNoteItem(Note item)
        {
            NoteItem noteItem = new NoteItem(item);
            noteItem.NoteItemClick += NoteItem_NoteItemClick;
            noteItem.NoteItemDoubleClick += NoteItem_NoteItemDoubleClick;
            flowLayoutPanelNoteList.Controls.Add(noteItem);
        }

        private void ChangeBackColorNoteItem(NoteItem item)
        {
            if (focusingNoteItem != null)
                focusingNoteItem.BackColor = Color.PaleGoldenrod;
            item.BackColor = Color.Gold;
            focusingNoteItem = item;
        }

        private void NoteItem_NoteItemDoubleClick(object sender, EventArgs e)
        {
            ShowNoteForm((sender as NoteItem).Item);
        }

        private void ShowNoteForm(Note note)
        {
            NoteForm noteForm = new NoteForm(note);
            noteForm.BackToFirstForm += NoteForm_BackToFirstForm;
            noteForm.SaveBeforeClosed += NoteForm_SaveBeforeClosed;
            this.Hide();
            noteForm.ShowDialog();
        }

        private void NoteForm_SaveBeforeClosed(object sender, EventArgs e)
        {
            Note note = (sender as NoteForm).Data;
            if (noteManager.NoteListInstance.DataList.IndexOf(note) == -1)
            {
                noteManager.NoteListInstance.DataList.Add(note);
                AddNoteItem(note);
            }
            this.Close();
        }

        private void NoteForm_BackToFirstForm(object sender, EventArgs e)
        {
            (sender as NoteForm).IsContinue = false;
            (sender as NoteForm).Close();
            this.Show();
        }

        private void NoteItem_NoteItemClick(object sender, EventArgs e)
        {
            ChangeBackColorNoteItem(sender as NoteItem);
        }

        private void FormNoteList_FormClosing(object sender, FormClosingEventArgs e)
        {
            noteManager.SerializeToXML(filePath);
        }

        private void flowLayoutPanelNoteList_ControlAdded(object sender, ControlEventArgs e)
        {
            labelNumber.Text = flowLayoutPanelNoteList.Controls.Count.ToString() + " ghi chú";
        }

        private void flowLayoutPanelNoteList_ControlRemoved(object sender, ControlEventArgs e)
        {
            labelNumber.Text = flowLayoutPanelNoteList.Controls.Count.ToString() + " ghi chú";
        }

        private void FormNoteList_Load(object sender, EventArgs e)
        {
            LoadSetting();
        }

        private void FormNoteList_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveSetting();
        }

        private void buttonAddNote_Click(object sender, EventArgs e)
        {
            Note note = new Note();
            ShowNoteForm(note);
            AddNoteItem(note);
            noteManager.NoteListInstance.DataList.Add(note);
        }

        private void buttonModifyNote_Click(object sender, EventArgs e)
        {
            SetButtonEnableAndVisible(buttonModifyNote, false);
            SetButtonEnableAndVisible(buttonAddNote, false);
            SetButtonEnableAndVisible(buttonDone, true);
            SetButtonEnableAndVisible(buttonDeleteNote, true);
            foreach (NoteItem noteItem in flowLayoutPanelNoteList.Controls)
            {
                noteItem.SetCheckBoxDelete(true);
            }    
        }

        private void buttonDeleteNote_Click(object sender, EventArgs e)
        {
            List<int> indexDelete = new List<int>();
            foreach (NoteItem noteItem in flowLayoutPanelNoteList.Controls)
            {
                if (noteItem.IsCheckBoxDeleteCheck())
                    indexDelete.Add(flowLayoutPanelNoteList.Controls.IndexOf(noteItem));
            }
            for (int i = 0; i < indexDelete.Count; ++i)
            {
                flowLayoutPanelNoteList.Controls.RemoveAt(indexDelete.ElementAt(i) - i);
                noteManager.NoteListInstance.DataList.RemoveAt(indexDelete.ElementAt(i) - i);
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            foreach (NoteItem noteItem in flowLayoutPanelNoteList.Controls)
            {
                noteItem.SetCheckBoxDelete(false);
                noteItem.SetCheckBoxDeleteCheck(false);
            }
            SetButtonEnableAndVisible(buttonModifyNote, true);
            SetButtonEnableAndVisible(buttonAddNote, true);
            SetButtonEnableAndVisible(buttonDone, false);
            SetButtonEnableAndVisible(buttonDeleteNote, false);
        }

        private void SetButtonEnableAndVisible(Button button, bool isEnableAndVisible)
        {
            button.Enabled = button.Visible = isEnableAndVisible;
        }

        private void flowLayoutPanelNoteList_Click(object sender, EventArgs e)
        {
            if (focusingNoteItem != null)
                focusingNoteItem.BackColor = Color.PaleGoldenrod;
            focusingNoteItem = null;
        }
    }
}
