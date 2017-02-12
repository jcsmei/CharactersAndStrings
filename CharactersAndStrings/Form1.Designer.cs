namespace CharactersAndStrings
{
    partial class Form1
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
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnAboutChar = new System.Windows.Forms.Button();
            this.btnCharString = new System.Windows.Forms.Button();
            this.btnIsLetterChar = new System.Windows.Forms.Button();
            this.btnIndexOf = new System.Windows.Forms.Button();
            this.btnTwoParameterSubstring = new System.Windows.Forms.Button();
            this.btnPractice = new System.Windows.Forms.Button();
            this.btnOneParameterSubstring = new System.Windows.Forms.Button();
            this.btnReverseString = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbRemove = new System.Windows.Forms.Button();
            this.btnQuiz3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Location = new System.Drawing.Point(12, 291);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(607, 153);
            this.rtbDisplay.TabIndex = 0;
            this.rtbDisplay.Text = "";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(15, 47);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(604, 20);
            this.txtInput.TabIndex = 1;
            // 
            // btnAboutChar
            // 
            this.btnAboutChar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutChar.Location = new System.Drawing.Point(15, 82);
            this.btnAboutChar.Name = "btnAboutChar";
            this.btnAboutChar.Size = new System.Drawing.Size(160, 55);
            this.btnAboutChar.TabIndex = 2;
            this.btnAboutChar.Text = "about char";
            this.btnAboutChar.UseVisualStyleBackColor = true;
            this.btnAboutChar.Click += new System.EventHandler(this.btnAboutChar_Click);
            // 
            // btnCharString
            // 
            this.btnCharString.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCharString.Location = new System.Drawing.Point(15, 152);
            this.btnCharString.Name = "btnCharString";
            this.btnCharString.Size = new System.Drawing.Size(160, 55);
            this.btnCharString.TabIndex = 3;
            this.btnCharString.Text = "char from string";
            this.btnCharString.UseVisualStyleBackColor = true;
            this.btnCharString.Click += new System.EventHandler(this.btnCharString_Click);
            // 
            // btnIsLetterChar
            // 
            this.btnIsLetterChar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIsLetterChar.Location = new System.Drawing.Point(240, 82);
            this.btnIsLetterChar.Name = "btnIsLetterChar";
            this.btnIsLetterChar.Size = new System.Drawing.Size(160, 55);
            this.btnIsLetterChar.TabIndex = 4;
            this.btnIsLetterChar.Text = "char.IsLetter etc.";
            this.btnIsLetterChar.UseVisualStyleBackColor = true;
            this.btnIsLetterChar.Click += new System.EventHandler(this.btnIsLetterChar_Click);
            // 
            // btnIndexOf
            // 
            this.btnIndexOf.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndexOf.Location = new System.Drawing.Point(240, 152);
            this.btnIndexOf.Name = "btnIndexOf";
            this.btnIndexOf.Size = new System.Drawing.Size(160, 55);
            this.btnIndexOf.TabIndex = 5;
            this.btnIndexOf.Text = "IndexOf\r\nchar or string";
            this.btnIndexOf.UseVisualStyleBackColor = true;
            this.btnIndexOf.Click += new System.EventHandler(this.btnIndexOf_Click);
            // 
            // btnTwoParameterSubstring
            // 
            this.btnTwoParameterSubstring.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwoParameterSubstring.Location = new System.Drawing.Point(459, 82);
            this.btnTwoParameterSubstring.Name = "btnTwoParameterSubstring";
            this.btnTwoParameterSubstring.Size = new System.Drawing.Size(160, 55);
            this.btnTwoParameterSubstring.TabIndex = 6;
            this.btnTwoParameterSubstring.Text = "Substring\r\nTwo Parameter";
            this.btnTwoParameterSubstring.UseVisualStyleBackColor = true;
            this.btnTwoParameterSubstring.Click += new System.EventHandler(this.btnTwoParameterSubstring_Click);
            // 
            // btnPractice
            // 
            this.btnPractice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPractice.Location = new System.Drawing.Point(459, 152);
            this.btnPractice.Name = "btnPractice";
            this.btnPractice.Size = new System.Drawing.Size(160, 55);
            this.btnPractice.TabIndex = 7;
            this.btnPractice.Text = "Practice";
            this.btnPractice.UseVisualStyleBackColor = true;
            // 
            // btnOneParameterSubstring
            // 
            this.btnOneParameterSubstring.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOneParameterSubstring.Location = new System.Drawing.Point(240, 215);
            this.btnOneParameterSubstring.Name = "btnOneParameterSubstring";
            this.btnOneParameterSubstring.Size = new System.Drawing.Size(160, 55);
            this.btnOneParameterSubstring.TabIndex = 8;
            this.btnOneParameterSubstring.Text = "Substring \r\nOne Parameter";
            this.btnOneParameterSubstring.UseVisualStyleBackColor = true;
            this.btnOneParameterSubstring.Click += new System.EventHandler(this.btnOneParameterSubstring_Click);
            // 
            // btnReverseString
            // 
            this.btnReverseString.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReverseString.Location = new System.Drawing.Point(15, 213);
            this.btnReverseString.Name = "btnReverseString";
            this.btnReverseString.Size = new System.Drawing.Size(160, 55);
            this.btnReverseString.TabIndex = 9;
            this.btnReverseString.Text = "Reversing a string";
            this.btnReverseString.UseVisualStyleBackColor = true;
            this.btnReverseString.Click += new System.EventHandler(this.btnReverseString_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Type Here:";
            // 
            // rtbRemove
            // 
            this.rtbRemove.Location = new System.Drawing.Point(439, 245);
            this.rtbRemove.Name = "rtbRemove";
            this.rtbRemove.Size = new System.Drawing.Size(75, 23);
            this.rtbRemove.TabIndex = 11;
            this.rtbRemove.Text = "button1";
            this.rtbRemove.UseVisualStyleBackColor = true;
            this.rtbRemove.Click += new System.EventHandler(this.rtbRemove_Click);
            // 
            // btnQuiz3
            // 
            this.btnQuiz3.Location = new System.Drawing.Point(530, 245);
            this.btnQuiz3.Name = "btnQuiz3";
            this.btnQuiz3.Size = new System.Drawing.Size(75, 23);
            this.btnQuiz3.TabIndex = 12;
            this.btnQuiz3.Text = "Quiz3 #8";
            this.btnQuiz3.UseVisualStyleBackColor = true;
            this.btnQuiz3.Click += new System.EventHandler(this.btnQuiz3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 456);
            this.Controls.Add(this.btnQuiz3);
            this.Controls.Add(this.rtbRemove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReverseString);
            this.Controls.Add(this.btnOneParameterSubstring);
            this.Controls.Add(this.btnPractice);
            this.Controls.Add(this.btnTwoParameterSubstring);
            this.Controls.Add(this.btnIndexOf);
            this.Controls.Add(this.btnIsLetterChar);
            this.Controls.Add(this.btnCharString);
            this.Controls.Add(this.btnAboutChar);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.rtbDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnAboutChar;
        private System.Windows.Forms.Button btnCharString;
        private System.Windows.Forms.Button btnIsLetterChar;
        private System.Windows.Forms.Button btnIndexOf;
        private System.Windows.Forms.Button btnTwoParameterSubstring;
        private System.Windows.Forms.Button btnPractice;
        private System.Windows.Forms.Button btnOneParameterSubstring;
        private System.Windows.Forms.Button btnReverseString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button rtbRemove;
        private System.Windows.Forms.Button btnQuiz3;
    }
}

