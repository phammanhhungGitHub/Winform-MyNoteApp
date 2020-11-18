namespace MyNoteApp
{
    partial class NoteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteForm));
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelBack = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.buttonFormat = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.labelDateCreated = new System.Windows.Forms.Label();
            this.labelDateModified = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackgroundImage = global::MyNoteApp.Properties.Resources.download;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Location = new System.Drawing.Point(26, 13);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(48, 46);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelBack
            // 
            this.labelBack.AutoSize = true;
            this.labelBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBack.Location = new System.Drawing.Point(80, 23);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(161, 23);
            this.labelBack.TabIndex = 1;
            this.labelBack.Text = "Danh sách ghi chú";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTitle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitle.Location = new System.Drawing.Point(26, 76);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(773, 27);
            this.textBoxTitle.TabIndex = 2;
            // 
            // textBoxContent
            // 
            this.textBoxContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxContent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContent.Location = new System.Drawing.Point(26, 120);
            this.textBoxContent.Multiline = true;
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.Size = new System.Drawing.Size(773, 580);
            this.textBoxContent.TabIndex = 3;
            // 
            // buttonFormat
            // 
            this.buttonFormat.BackColor = System.Drawing.Color.Gold;
            this.buttonFormat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFormat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFormat.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFormat.Location = new System.Drawing.Point(623, 12);
            this.buttonFormat.Name = "buttonFormat";
            this.buttonFormat.Size = new System.Drawing.Size(75, 47);
            this.buttonFormat.TabIndex = 4;
            this.buttonFormat.Text = "Format";
            this.buttonFormat.UseVisualStyleBackColor = false;
            this.buttonFormat.Click += new System.EventHandler(this.buttonFormat_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.BackColor = System.Drawing.Color.Gold;
            this.buttonModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonModify.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModify.Location = new System.Drawing.Point(724, 12);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(75, 47);
            this.buttonModify.TabIndex = 5;
            this.buttonModify.Text = "Sửa";
            this.buttonModify.UseVisualStyleBackColor = false;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.Gold;
            this.buttonDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDone.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDone.Location = new System.Drawing.Point(724, 12);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(75, 47);
            this.buttonDone.TabIndex = 6;
            this.buttonDone.Text = "Xong";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // labelDateCreated
            // 
            this.labelDateCreated.AutoSize = true;
            this.labelDateCreated.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateCreated.Location = new System.Drawing.Point(26, 725);
            this.labelDateCreated.Name = "labelDateCreated";
            this.labelDateCreated.Size = new System.Drawing.Size(0, 22);
            this.labelDateCreated.TabIndex = 7;
            this.labelDateCreated.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDateModified
            // 
            this.labelDateModified.AutoSize = true;
            this.labelDateModified.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateModified.Location = new System.Drawing.Point(487, 725);
            this.labelDateModified.Name = "labelDateModified";
            this.labelDateModified.Size = new System.Drawing.Size(0, 22);
            this.labelDateModified.TabIndex = 8;
            this.labelDateModified.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(827, 766);
            this.Controls.Add(this.labelDateModified);
            this.Controls.Add(this.labelDateCreated);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonFormat);
            this.Controls.Add(this.textBoxContent);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelBack);
            this.Controls.Add(this.buttonBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NoteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MyNoteApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NoteForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NoteForm_FormClosed);
            this.Load += new System.EventHandler(this.NoteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelBack;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxContent;
        private System.Windows.Forms.Button buttonFormat;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label labelDateCreated;
        private System.Windows.Forms.Label labelDateModified;
    }
}