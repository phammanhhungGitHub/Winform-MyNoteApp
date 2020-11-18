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
    public partial class NoteForm : Form
    {
        #region Properties
        private Note data;
        public Note Data { get => data; set => data = value; }

        private bool isContinue;
        public bool IsContinue { get => isContinue; set => isContinue = value; }

        public event EventHandler BackToFirstForm;
        public event EventHandler SaveBeforeClosed;
        #endregion
        private void LoadSetting()
        {
            this.Size = Properties.Settings.Default.Size;
            textBoxTitle.Font = Properties.Settings.Default.FontTitle;
            textBoxContent.Font = Properties.Settings.Default.FontContent;
        }

        private void SaveSetting()
        {
            Properties.Settings.Default.Size = this.Size;
            Properties.Settings.Default.FontTitle = textBoxTitle.Font;
            Properties.Settings.Default.FontContent = textBoxContent.Font;
        }
        public NoteForm(Note data)
        {
            InitializeComponent();
            this.Data = data;
            SetButtonEnable(false);

            textBoxTitle.Text = data.Title;
            textBoxContent.Text = data.Content;

            SetTextBoxReadOnly(true);

            isContinue = true;

            labelDateCreated.Text = "Ngày tạo: " + data.Date.ToString();
            if (data.Date != data.LastModifiedDate)
            {
                labelDateModified.Text = "Sửa lần cuối: " + data.LastModifiedDate.ToString();
            }
            else
            {
                buttonModify_Click(buttonModify, new EventArgs());
            }
        }

        private void SetButtonEnable(bool isEnable)
        {
            buttonDone.Enabled = buttonDone.Visible =
                buttonFormat.Enabled = buttonFormat.Visible = isEnable;
        }

        private void SetTextBoxReadOnly(bool isReadOnly)
        {
            textBoxContent.ReadOnly = textBoxTitle.ReadOnly = isReadOnly;
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            SetTextBoxReadOnly(false);
            SetButtonEnable(true);
            (sender as Button).Enabled = false;
            buttonBack.Enabled = false;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            data.Title = textBoxTitle.Text;
            data.Content = textBoxContent.Text;
            data.LastModifiedDate = DateTime.Now;
            labelDateModified.Text = "Sửa lần cuối: " + DateTime.Now;
            SetTextBoxReadOnly(true);
            buttonModify.Enabled = true;
            SetButtonEnable(false);
            buttonBack.Enabled = true;
        }

        private void buttonFormat_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = textBoxContent.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxContent.Font = fontDialog1.Font;
            }
        }

        private void NoteForm_Load(object sender, EventArgs e)
        {
            LoadSetting();
        }

        private void NoteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (buttonModify.Enabled == false)
            {
                DialogResult res = MessageBox.Show("Bạn có muốn lưu ghi chú?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else if (res == DialogResult.Yes)
                {
                    buttonDone.PerformClick();
                    SaveBeforeClosed?.Invoke(this, new EventArgs());
                }    
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            BackToFirstForm?.Invoke(this, new EventArgs());
        }

        private void NoteForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isContinue)
                Application.Exit();
        }
    }
}
