namespace Training.SrtExtraction
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonOFD = new System.Windows.Forms.Button();
            this.OFDSRT = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // ButtonOFD
            // 
            this.ButtonOFD.Location = new System.Drawing.Point(12, 12);
            this.ButtonOFD.Name = "ButtonOFD";
            this.ButtonOFD.Size = new System.Drawing.Size(128, 70);
            this.ButtonOFD.TabIndex = 0;
            this.ButtonOFD.Text = "Open File";
            this.ButtonOFD.UseVisualStyleBackColor = true;
            this.ButtonOFD.Click += new System.EventHandler(this.ButtonOFD_Click);
            // 
            // OFDSRT
            // 
            this.OFDSRT.Filter = "srt files (*.srt)|*.srt|txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.OFDSRT.FilterIndex = 3;
            this.OFDSRT.Title = "Browse srt Files";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 314);
            this.Controls.Add(this.ButtonOFD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button ButtonOFD;
        private OpenFileDialog OFDSRT;
    }
}