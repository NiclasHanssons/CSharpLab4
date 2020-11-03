namespace WinForms
{
    partial class ListViewDictionarys
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
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.labelWordLists = new System.Windows.Forms.Label();
            this.labelWordCount = new System.Windows.Forms.Label();
            this.listBoxDictionaries = new System.Windows.Forms.ListBox();
            this.listBoxLanguages = new System.Windows.Forms.ListBox();
            this.labelLanguages = new System.Windows.Forms.Label();
            this.buttonNewList = new System.Windows.Forms.Button();
            this.buttonPractice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonConfirm.Enabled = false;
            this.buttonConfirm.Location = new System.Drawing.Point(380, 305);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 25);
            this.buttonConfirm.TabIndex = 3;
            this.buttonConfirm.Text = "&Select";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // labelWordLists
            // 
            this.labelWordLists.AutoSize = true;
            this.labelWordLists.Location = new System.Drawing.Point(12, 21);
            this.labelWordLists.Name = "labelWordLists";
            this.labelWordLists.Size = new System.Drawing.Size(70, 17);
            this.labelWordLists.TabIndex = 3;
            this.labelWordLists.Text = "Word lists";
            // 
            // labelWordCount
            // 
            this.labelWordCount.AutoSize = true;
            this.labelWordCount.Location = new System.Drawing.Point(111, 21);
            this.labelWordCount.Name = "labelWordCount";
            this.labelWordCount.Size = new System.Drawing.Size(85, 17);
            this.labelWordCount.TabIndex = 4;
            this.labelWordCount.Text = "Word count:";
            // 
            // listBoxDictionaries
            // 
            this.listBoxDictionaries.FormattingEnabled = true;
            this.listBoxDictionaries.ItemHeight = 16;
            this.listBoxDictionaries.Location = new System.Drawing.Point(15, 41);
            this.listBoxDictionaries.Name = "listBoxDictionaries";
            this.listBoxDictionaries.Size = new System.Drawing.Size(198, 260);
            this.listBoxDictionaries.TabIndex = 6;
            this.listBoxDictionaries.SelectedIndexChanged += new System.EventHandler(this.listBoxDictionaries_SelectedIndexChanged);
            // 
            // listBoxLanguages
            // 
            this.listBoxLanguages.FormattingEnabled = true;
            this.listBoxLanguages.ItemHeight = 16;
            this.listBoxLanguages.Location = new System.Drawing.Point(240, 41);
            this.listBoxLanguages.Name = "listBoxLanguages";
            this.listBoxLanguages.Size = new System.Drawing.Size(215, 260);
            this.listBoxLanguages.TabIndex = 0;
            // 
            // labelLanguages
            // 
            this.labelLanguages.AutoSize = true;
            this.labelLanguages.Location = new System.Drawing.Point(237, 21);
            this.labelLanguages.Name = "labelLanguages";
            this.labelLanguages.Size = new System.Drawing.Size(79, 17);
            this.labelLanguages.TabIndex = 8;
            this.labelLanguages.Text = "Languages";
            // 
            // buttonNewList
            // 
            this.buttonNewList.Location = new System.Drawing.Point(15, 307);
            this.buttonNewList.Name = "buttonNewList";
            this.buttonNewList.Size = new System.Drawing.Size(75, 25);
            this.buttonNewList.TabIndex = 1;
            this.buttonNewList.Text = "&New list";
            this.buttonNewList.UseVisualStyleBackColor = true;
            this.buttonNewList.Click += new System.EventHandler(this.buttonNewList_Click);
            // 
            // buttonPractice
            // 
            this.buttonPractice.Enabled = false;
            this.buttonPractice.Location = new System.Drawing.Point(96, 307);
            this.buttonPractice.Name = "buttonPractice";
            this.buttonPractice.Size = new System.Drawing.Size(75, 25);
            this.buttonPractice.TabIndex = 2;
            this.buttonPractice.Text = "&Practice";
            this.buttonPractice.UseVisualStyleBackColor = true;
            this.buttonPractice.Click += new System.EventHandler(this.buttonPractice_Click);
            // 
            // ListViewDictionarys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 343);
            this.Controls.Add(this.buttonPractice);
            this.Controls.Add(this.buttonNewList);
            this.Controls.Add(this.labelLanguages);
            this.Controls.Add(this.listBoxLanguages);
            this.Controls.Add(this.listBoxDictionaries);
            this.Controls.Add(this.labelWordCount);
            this.Controls.Add(this.labelWordLists);
            this.Controls.Add(this.buttonConfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(490, 390);
            this.Name = "ListViewDictionarys";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dictionary";
            this.Load += new System.EventHandler(this.ListView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label labelWordLists;
        private System.Windows.Forms.Label labelWordCount;
        private System.Windows.Forms.ListBox listBoxDictionaries;
        private System.Windows.Forms.ListBox listBoxLanguages;
        private System.Windows.Forms.Label labelLanguages;
        private System.Windows.Forms.Button buttonNewList;
        private System.Windows.Forms.Button buttonPractice;
    }
}