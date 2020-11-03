namespace WinForms
{
    partial class NewList
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
            this.textBoxNewList = new System.Windows.Forms.TextBox();
            this.labelTitleNewList = new System.Windows.Forms.Label();
            this.labelNewListLanguages = new System.Windows.Forms.Label();
            this.buttonNewListOk = new System.Windows.Forms.Button();
            this.buttonNewListCancel = new System.Windows.Forms.Button();
            this.textBoxLanguages = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxNewList
            // 
            this.textBoxNewList.Location = new System.Drawing.Point(12, 29);
            this.textBoxNewList.Name = "textBoxNewList";
            this.textBoxNewList.Size = new System.Drawing.Size(240, 22);
            this.textBoxNewList.TabIndex = 0;
            this.textBoxNewList.Text = "Enter name of word list";
            this.textBoxNewList.TextChanged += new System.EventHandler(this.textBoxNewList_TextChanged);
            this.textBoxNewList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewList_KeyPress);
            this.textBoxNewList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxNewList_MouseDown);
            // 
            // labelTitleNewList
            // 
            this.labelTitleNewList.AutoSize = true;
            this.labelTitleNewList.Location = new System.Drawing.Point(12, 9);
            this.labelTitleNewList.Name = "labelTitleNewList";
            this.labelTitleNewList.Size = new System.Drawing.Size(35, 17);
            this.labelTitleNewList.TabIndex = 1;
            this.labelTitleNewList.Text = "Title";
            // 
            // labelNewListLanguages
            // 
            this.labelNewListLanguages.AutoSize = true;
            this.labelNewListLanguages.Location = new System.Drawing.Point(9, 68);
            this.labelNewListLanguages.Name = "labelNewListLanguages";
            this.labelNewListLanguages.Size = new System.Drawing.Size(79, 17);
            this.labelNewListLanguages.TabIndex = 2;
            this.labelNewListLanguages.Text = "Languages";
            // 
            // buttonNewListOk
            // 
            this.buttonNewListOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonNewListOk.Enabled = false;
            this.buttonNewListOk.Location = new System.Drawing.Point(177, 226);
            this.buttonNewListOk.Name = "buttonNewListOk";
            this.buttonNewListOk.Size = new System.Drawing.Size(75, 25);
            this.buttonNewListOk.TabIndex = 2;
            this.buttonNewListOk.Text = "&OK";
            this.buttonNewListOk.UseVisualStyleBackColor = true;
            this.buttonNewListOk.Click += new System.EventHandler(this.buttonNewListOk_Click);
            // 
            // buttonNewListCancel
            // 
            this.buttonNewListCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonNewListCancel.Location = new System.Drawing.Point(12, 226);
            this.buttonNewListCancel.Name = "buttonNewListCancel";
            this.buttonNewListCancel.Size = new System.Drawing.Size(75, 25);
            this.buttonNewListCancel.TabIndex = 3;
            this.buttonNewListCancel.Text = "&Cancel";
            this.buttonNewListCancel.UseVisualStyleBackColor = true;
            // 
            // textBoxLanguages
            // 
            this.textBoxLanguages.Location = new System.Drawing.Point(12, 88);
            this.textBoxLanguages.Multiline = true;
            this.textBoxLanguages.Name = "textBoxLanguages";
            this.textBoxLanguages.Size = new System.Drawing.Size(240, 132);
            this.textBoxLanguages.TabIndex = 1;
            this.textBoxLanguages.Text = "Enter at leaste two languages on seperate lines";
            this.textBoxLanguages.TextChanged += new System.EventHandler(this.textBoxLanguages_TextChanged);
            this.textBoxLanguages.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxLanguages_MouseDown);
            // 
            // NewList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 260);
            this.Controls.Add(this.textBoxLanguages);
            this.Controls.Add(this.buttonNewListCancel);
            this.Controls.Add(this.buttonNewListOk);
            this.Controls.Add(this.labelNewListLanguages);
            this.Controls.Add(this.labelTitleNewList);
            this.Controls.Add(this.textBoxNewList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(282, 307);
            this.Name = "NewList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New list";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNewList;
        private System.Windows.Forms.Label labelTitleNewList;
        private System.Windows.Forms.Label labelNewListLanguages;
        private System.Windows.Forms.Button buttonNewListOk;
        private System.Windows.Forms.Button buttonNewListCancel;
        private System.Windows.Forms.TextBox textBoxLanguages;
    }
}