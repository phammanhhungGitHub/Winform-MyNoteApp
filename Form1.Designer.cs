namespace MyNoteApp
{
    partial class FormNoteList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNoteList));
            this.labelNoteList = new System.Windows.Forms.Label();
            this.buttonAddNote = new System.Windows.Forms.Button();
            this.buttonModifyNote = new System.Windows.Forms.Button();
            this.flowLayoutPanelNoteList = new System.Windows.Forms.FlowLayoutPanel();
            this.labelNumber = new System.Windows.Forms.Label();
            this.buttonDeleteNote = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNoteList
            // 
            this.labelNoteList.AutoSize = true;
            this.labelNoteList.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoteList.Location = new System.Drawing.Point(13, 13);
            this.labelNoteList.Name = "labelNoteList";
            this.labelNoteList.Size = new System.Drawing.Size(274, 37);
            this.labelNoteList.TabIndex = 0;
            this.labelNoteList.Text = "Danh sách ghi chú";
            // 
            // buttonAddNote
            // 
            this.buttonAddNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNote.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNote.Location = new System.Drawing.Point(12, 723);
            this.buttonAddNote.Name = "buttonAddNote";
            this.buttonAddNote.Size = new System.Drawing.Size(75, 31);
            this.buttonAddNote.TabIndex = 1;
            this.buttonAddNote.Text = "Mới";
            this.buttonAddNote.UseVisualStyleBackColor = true;
            this.buttonAddNote.Click += new System.EventHandler(this.buttonAddNote_Click);
            // 
            // buttonModifyNote
            // 
            this.buttonModifyNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifyNote.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifyNote.Location = new System.Drawing.Point(740, 723);
            this.buttonModifyNote.Name = "buttonModifyNote";
            this.buttonModifyNote.Size = new System.Drawing.Size(75, 31);
            this.buttonModifyNote.TabIndex = 2;
            this.buttonModifyNote.Text = "Sửa";
            this.buttonModifyNote.UseVisualStyleBackColor = true;
            this.buttonModifyNote.Click += new System.EventHandler(this.buttonModifyNote_Click);
            // 
            // flowLayoutPanelNoteList
            // 
            this.flowLayoutPanelNoteList.AutoScroll = true;
            this.flowLayoutPanelNoteList.Location = new System.Drawing.Point(20, 69);
            this.flowLayoutPanelNoteList.Name = "flowLayoutPanelNoteList";
            this.flowLayoutPanelNoteList.Size = new System.Drawing.Size(795, 648);
            this.flowLayoutPanelNoteList.TabIndex = 3;
            this.flowLayoutPanelNoteList.Click += new System.EventHandler(this.flowLayoutPanelNoteList_Click);
            this.flowLayoutPanelNoteList.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.flowLayoutPanelNoteList_ControlAdded);
            this.flowLayoutPanelNoteList.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.flowLayoutPanelNoteList_ControlRemoved);
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumber.Location = new System.Drawing.Point(371, 737);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(64, 17);
            this.labelNumber.TabIndex = 4;
            this.labelNumber.Text = "0 ghi chú";
            // 
            // buttonDeleteNote
            // 
            this.buttonDeleteNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteNote.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteNote.Location = new System.Drawing.Point(659, 723);
            this.buttonDeleteNote.Name = "buttonDeleteNote";
            this.buttonDeleteNote.Size = new System.Drawing.Size(75, 31);
            this.buttonDeleteNote.TabIndex = 5;
            this.buttonDeleteNote.Text = "Xóa";
            this.buttonDeleteNote.UseVisualStyleBackColor = true;
            this.buttonDeleteNote.Click += new System.EventHandler(this.buttonDeleteNote_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDone.Location = new System.Drawing.Point(740, 723);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(75, 31);
            this.buttonDone.TabIndex = 6;
            this.buttonDone.Text = "Xong";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // FormNoteList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(827, 766);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.buttonDeleteNote);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.flowLayoutPanelNoteList);
            this.Controls.Add(this.buttonModifyNote);
            this.Controls.Add(this.buttonAddNote);
            this.Controls.Add(this.labelNoteList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNoteList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyNoteApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNoteList_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormNoteList_FormClosed);
            this.Load += new System.EventHandler(this.FormNoteList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNoteList;
        private System.Windows.Forms.Button buttonAddNote;
        private System.Windows.Forms.Button buttonModifyNote;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNoteList;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Button buttonDeleteNote;
        private System.Windows.Forms.Button buttonDone;
    }
}

