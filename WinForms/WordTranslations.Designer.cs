namespace WinForms
{
    partial class WordTranslations
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
            this.dataGridViewWord = new System.Windows.Forms.DataGridView();
            this.buttonAddWord = new System.Windows.Forms.Button();
            this.buttonRemoveWord = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWord)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewWord
            // 
            this.dataGridViewWord.AllowUserToAddRows = false;
            this.dataGridViewWord.AllowUserToDeleteRows = false;
            this.dataGridViewWord.AllowUserToResizeColumns = false;
            this.dataGridViewWord.AllowUserToResizeRows = false;
            this.dataGridViewWord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewWord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewWord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWord.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewWord.MultiSelect = false;
            this.dataGridViewWord.Name = "dataGridViewWord";
            this.dataGridViewWord.ReadOnly = true;
            this.dataGridViewWord.RowHeadersVisible = false;
            this.dataGridViewWord.RowHeadersWidth = 51;
            this.dataGridViewWord.RowTemplate.Height = 24;
            this.dataGridViewWord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewWord.Size = new System.Drawing.Size(883, 412);
            this.dataGridViewWord.TabIndex = 2;
            this.dataGridViewWord.TabStop = false;
            // 
            // buttonAddWord
            // 
            this.buttonAddWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddWord.Location = new System.Drawing.Point(795, 420);
            this.buttonAddWord.Name = "buttonAddWord";
            this.buttonAddWord.Size = new System.Drawing.Size(75, 25);
            this.buttonAddWord.TabIndex = 0;
            this.buttonAddWord.Text = "&Add word";
            this.buttonAddWord.UseVisualStyleBackColor = true;
            this.buttonAddWord.Click += new System.EventHandler(this.buttonAddWord_Click);
            // 
            // buttonRemoveWord
            // 
            this.buttonRemoveWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoveWord.Enabled = false;
            this.buttonRemoveWord.Location = new System.Drawing.Point(671, 420);
            this.buttonRemoveWord.Name = "buttonRemoveWord";
            this.buttonRemoveWord.Size = new System.Drawing.Size(118, 25);
            this.buttonRemoveWord.TabIndex = 1;
            this.buttonRemoveWord.Text = "&Remove word";
            this.buttonRemoveWord.UseVisualStyleBackColor = true;
            this.buttonRemoveWord.Click += new System.EventHandler(this.buttonRemoveWord_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(12, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // WordTranslations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonRemoveWord);
            this.Controls.Add(this.buttonAddWord);
            this.Controls.Add(this.dataGridViewWord);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "WordTranslations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word translations";
            this.Load += new System.EventHandler(this.WordTranslations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewWord;
        private System.Windows.Forms.Button buttonAddWord;
        private System.Windows.Forms.Button buttonRemoveWord;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button1;
    }
}