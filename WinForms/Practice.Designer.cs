namespace WinForms
{
    partial class Practice
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
            this.labelLanguageAndWordToTranslate = new System.Windows.Forms.Label();
            this.textBoxTranslation = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.buttonEndPractice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLanguageAndWordToTranslate
            // 
            this.labelLanguageAndWordToTranslate.AutoSize = true;
            this.labelLanguageAndWordToTranslate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLanguageAndWordToTranslate.Location = new System.Drawing.Point(259, 96);
            this.labelLanguageAndWordToTranslate.Name = "labelLanguageAndWordToTranslate";
            this.labelLanguageAndWordToTranslate.Size = new System.Drawing.Size(53, 20);
            this.labelLanguageAndWordToTranslate.TabIndex = 0;
            this.labelLanguageAndWordToTranslate.Text = "label1";
            // 
            // textBoxTranslation
            // 
            this.textBoxTranslation.Location = new System.Drawing.Point(263, 141);
            this.textBoxTranslation.Name = "textBoxTranslation";
            this.textBoxTranslation.Size = new System.Drawing.Size(251, 22);
            this.textBoxTranslation.TabIndex = 1;
            this.textBoxTranslation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTranslation_KeyDown);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(259, 189);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 20);
            this.labelResult.TabIndex = 2;
            // 
            // buttonRestart
            // 
            this.buttonRestart.Location = new System.Drawing.Point(263, 257);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(75, 25);
            this.buttonRestart.TabIndex = 3;
            this.buttonRestart.Text = "&Restart";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // buttonEndPractice
            // 
            this.buttonEndPractice.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.buttonEndPractice.Location = new System.Drawing.Point(394, 257);
            this.buttonEndPractice.Name = "buttonEndPractice";
            this.buttonEndPractice.Size = new System.Drawing.Size(120, 25);
            this.buttonEndPractice.TabIndex = 4;
            this.buttonEndPractice.Text = "&End practice";
            this.buttonEndPractice.UseVisualStyleBackColor = true;
            this.buttonEndPractice.Click += new System.EventHandler(this.buttonEndPractice_Click);
            // 
            // Practice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEndPractice);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxTranslation);
            this.Controls.Add(this.labelLanguageAndWordToTranslate);
            this.Name = "Practice";
            this.Text = "Practice";
            this.Load += new System.EventHandler(this.Practice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLanguageAndWordToTranslate;
        private System.Windows.Forms.TextBox textBoxTranslation;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Button buttonEndPractice;
    }
}