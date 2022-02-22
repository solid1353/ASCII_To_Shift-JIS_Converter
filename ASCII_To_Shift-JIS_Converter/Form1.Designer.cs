namespace ASCII_To_Shift_JIS_Converter
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
            this.convertButton = new System.Windows.Forms.Button();
            this.asciiLabel = new System.Windows.Forms.Label();
            this.shiftJISLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.clipboardCheckBox = new System.Windows.Forms.CheckBox();
            this.copyStringRadiobutton = new System.Windows.Forms.RadioButton();
            this.copyHexRadiobutton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(214, 486);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(94, 29);
            this.convertButton.TabIndex = 1;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
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
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(30, 144);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(485, 313);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(595, 338);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(344, 119);
            this.richTextBox2.TabIndex = 7;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(595, 144);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(344, 119);
            this.richTextBox3.TabIndex = 8;
            this.richTextBox3.Text = "";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 624);
            this.Controls.Add(this.copyHexRadiobutton);
            this.Controls.Add(this.copyStringRadiobutton);
            this.Controls.Add(this.clipboardCheckBox);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.shiftJISLabel);
            this.Controls.Add(this.asciiLabel);
            this.Controls.Add(this.convertButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button convertButton;
        private Label asciiLabel;
        private Label shiftJISLabel;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private CheckBox clipboardCheckBox;
        private RadioButton copyStringRadiobutton;
        private RadioButton copyHexRadiobutton;
    }
}