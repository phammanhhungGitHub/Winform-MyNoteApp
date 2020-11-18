namespace MyNoteApp
{
    partial class NoteItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.checkBoxDelete = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(38, 13);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(74, 26);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "label1";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            this.labelTitle.DoubleClick += new System.EventHandler(this.labelTitle_DoubleClick);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(40, 51);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(40, 16);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "label2";
            this.labelDate.Click += new System.EventHandler(this.labelDate_Click);
            this.labelDate.DoubleClick += new System.EventHandler(this.labelDate_DoubleClick);
            // 
            // checkBoxDelete
            // 
            this.checkBoxDelete.AutoSize = true;
            this.checkBoxDelete.Location = new System.Drawing.Point(3, 21);
            this.checkBoxDelete.Name = "checkBoxDelete";
            this.checkBoxDelete.Size = new System.Drawing.Size(18, 17);
            this.checkBoxDelete.TabIndex = 3;
            this.checkBoxDelete.UseVisualStyleBackColor = true;
            // 
            // NoteItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.checkBoxDelete);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelTitle);
            this.Name = "NoteItem";
            this.Size = new System.Drawing.Size(789, 75);
            this.Click += new System.EventHandler(this.NoteItem_Click);
            this.DoubleClick += new System.EventHandler(this.NoteItem_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.CheckBox checkBoxDelete;
    }
}
