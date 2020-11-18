using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNoteApp
{
    public partial class NoteItem : UserControl
    {
        public event EventHandler NoteItemClick;
        public event EventHandler NoteItemDoubleClick;
        private Note item;
        

        public Note Item { get => item; set => item = value; }

        public NoteItem(Note item)
        {
            InitializeComponent();
            this.Item = item;
            item.ValueChanged += Item_ValueChanged;
            NoteItemLoad();
            SetCheckBoxDelete(false);
        }

        private void Item_ValueChanged(object sender, EventArgs e)
        {
            NoteItemLoad();
        }

        public void SetCheckBoxDelete(bool isEnableAndVisible)
        {
            checkBoxDelete.Enabled = checkBoxDelete.Visible = isEnableAndVisible;
        }

        public bool IsCheckBoxDeleteCheck()
        {
            return checkBoxDelete.Checked;
        }

        public void SetCheckBoxDeleteCheck(bool isCheck)
        {
            checkBoxDelete.Checked = isCheck;
        }
        public void NoteItemLoad()
        {
            labelTitle.Text = item.Title;
            labelDate.Text = item.Date.ToString();
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {
            
            NoteItemClick?.Invoke(this, new EventArgs());
        }

        private void labelDate_Click(object sender, EventArgs e)
        {
            
            NoteItemClick?.Invoke(this, new EventArgs());
        }

        private void NoteItem_Click(object sender, EventArgs e)
        {
            
            NoteItemClick?.Invoke(this, new EventArgs());
        }

        private void NoteItem_DoubleClick(object sender, EventArgs e)
        {
            NoteItemDoubleClick?.Invoke(this, new EventArgs());
        }

        private void labelTitle_DoubleClick(object sender, EventArgs e)
        {
            NoteItemDoubleClick?.Invoke(this, new EventArgs());
        }

        private void labelDate_DoubleClick(object sender, EventArgs e)
        {
            NoteItemDoubleClick?.Invoke(this, new EventArgs());
        }
    }
}
