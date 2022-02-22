namespace ASCII_To_Shift_JIS_Converter
{
    partial class MainForm
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
            this.convertButton = new System.Windows.Forms.Button();
            this.asciiLabel = new System.Windows.Forms.Label();
            this.shiftJISLabel = new System.Windows.Forms.Label();
            this.asciiRTE = new System.Windows.Forms.RichTextBox();
            this.shiftJISHexRTE = new System.Windows.Forms.RichTextBox();
            this.shiftJISStringRTE = new System.Windows.Forms.RichTextBox();
            this.clipboardCheckBox = new System.Windows.Forms.CheckBox();
            this.copyStringRadiobutton = new System.Windows.Forms.RadioButton();
            this.copyHexRadiobutton = new System.Windows.Forms.RadioButton();
            this.shiftJISStringRTELabel = new System.Windows.Forms.Label();
            this.shiftJISHexRTELabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(187, 484);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(94, 29);
            this.convertButton.TabIndex = 1;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // asciiLabel
            // 
            this.asciiLabel.AutoSize = true;
            this.asciiLabel.Location = new System.Drawing.Point(30, 52);
            this.asciiLabel.Name = "asciiLabel";
            this.asciiLabel.Size = new System.Drawing.Size(147, 20);
            this.asciiLabel.TabIndex = 4;
            this.asciiLabel.Text = "Enter ASCII text here:";
            // 
            // shiftJISLabel
            // 
            this.shiftJISLabel.AutoSize = true;
            this.shiftJISLabel.Location = new System.Drawing.Point(595, 52);
            this.shiftJISLabel.Name = "shiftJISLabel";
            this.shiftJISLabel.Size = new System.Drawing.Size(105, 20);
            this.shiftJISLabel.TabIndex = 5;
            this.shiftJISLabel.Text = "Shift-JIS result:";
            // 
            // asciiRTE
            // 
            this.asciiRTE.Location = new System.Drawing.Point(30, 144);
            this.asciiRTE.Name = "asciiRTE";
            this.asciiRTE.Size = new System.Drawing.Size(485, 313);
            this.asciiRTE.TabIndex = 6;
            this.asciiRTE.Text = "";
            // 
            // shiftJISHexRTE
            // 
            this.shiftJISHexRTE.Location = new System.Drawing.Point(595, 310);
            this.shiftJISHexRTE.Name = "shiftJISHexRTE";
            this.shiftJISHexRTE.ReadOnly = true;
            this.shiftJISHexRTE.Size = new System.Drawing.Size(366, 147);
            this.shiftJISHexRTE.TabIndex = 7;
            this.shiftJISHexRTE.Text = "";
            // 
            // shiftJISStringRTE
            // 
            this.shiftJISStringRTE.Location = new System.Drawing.Point(595, 144);
            this.shiftJISStringRTE.Name = "shiftJISStringRTE";
            this.shiftJISStringRTE.ReadOnly = true;
            this.shiftJISStringRTE.Size = new System.Drawing.Size(366, 140);
            this.shiftJISStringRTE.TabIndex = 8;
            this.shiftJISStringRTE.Text = "";
            // 
            // clipboardCheckBox
            // 
            this.clipboardCheckBox.AutoSize = true;
            this.clipboardCheckBox.Checked = true;
            this.clipboardCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.clipboardCheckBox.Location = new System.Drawing.Point(30, 489);
            this.clipboardCheckBox.Name = "clipboardCheckBox";
            this.clipboardCheckBox.Size = new System.Drawing.Size(151, 24);
            this.clipboardCheckBox.TabIndex = 9;
            this.clipboardCheckBox.Text = "Copy to clipboard";
            this.clipboardCheckBox.UseVisualStyleBackColor = true;
            // 
            // copyStringRadiobutton
            // 
            this.copyStringRadiobutton.AutoSize = true;
            this.copyStringRadiobutton.Location = new System.Drawing.Point(30, 549);
            this.copyStringRadiobutton.Name = "copyStringRadiobutton";
            this.copyStringRadiobutton.Size = new System.Drawing.Size(105, 24);
            this.copyStringRadiobutton.TabIndex = 10;
            this.copyStringRadiobutton.Text = "Copy string";
            this.copyStringRadiobutton.UseVisualStyleBackColor = true;
            // 
            // copyHexRadiobutton
            // 
            this.copyHexRadiobutton.AutoSize = true;
            this.copyHexRadiobutton.Checked = true;
            this.copyHexRadiobutton.Location = new System.Drawing.Point(30, 519);
            this.copyHexRadiobutton.Name = "copyHexRadiobutton";
            this.copyHexRadiobutton.Size = new System.Drawing.Size(91, 24);
            this.copyHexRadiobutton.TabIndex = 11;
            this.copyHexRadiobutton.TabStop = true;
            this.copyHexRadiobutton.Text = "Copy hex";
            this.copyHexRadiobutton.UseVisualStyleBackColor = true;
            // 
            // shiftJISStringRTELabel
            // 
            this.shiftJISStringRTELabel.AutoSize = true;
            this.shiftJISStringRTELabel.Location = new System.Drawing.Point(596, 121);
            this.shiftJISStringRTELabel.Name = "shiftJISStringRTELabel";
            this.shiftJISStringRTELabel.Size = new System.Drawing.Size(39, 20);
            this.shiftJISStringRTELabel.TabIndex = 12;
            this.shiftJISStringRTELabel.Text = "Text:";
            // 
            // shiftJISHexRTELabel
            // 
            this.shiftJISHexRTELabel.AutoSize = true;
            this.shiftJISHexRTELabel.Location = new System.Drawing.Point(595, 287);
            this.shiftJISHexRTELabel.Name = "shiftJISHexRTELabel";
            this.shiftJISHexRTELabel.Size = new System.Drawing.Size(38, 20);
            this.shiftJISHexRTELabel.TabIndex = 13;
            this.shiftJISHexRTELabel.Text = "Hex:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 624);
            this.Controls.Add(this.shiftJISHexRTELabel);
            this.Controls.Add(this.shiftJISStringRTELabel);
            this.Controls.Add(this.copyHexRadiobutton);
            this.Controls.Add(this.copyStringRadiobutton);
            this.Controls.Add(this.clipboardCheckBox);
            this.Controls.Add(this.shiftJISStringRTE);
            this.Controls.Add(this.shiftJISHexRTE);
            this.Controls.Add(this.asciiRTE);
            this.Controls.Add(this.shiftJISLabel);
            this.Controls.Add(this.asciiLabel);
            this.Controls.Add(this.convertButton);
            this.Name = "MainForm";
            this.Text = "ASCII To Shift-JIS Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button convertButton;
        private Label asciiLabel;
        private Label shiftJISLabel;
        private RichTextBox asciiRTE;
        private RichTextBox shiftJISHexRTE;
        private RichTextBox shiftJISStringRTE;
        private CheckBox clipboardCheckBox;
        private RadioButton copyStringRadiobutton;
        private RadioButton copyHexRadiobutton;
        private Label shiftJISStringRTELabel;
        private Label shiftJISHexRTELabel;
    }
}