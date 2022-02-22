namespace ASCII_To_Shift_JIS_Converter
{
    public partial class MainForm : Form
    {
        public bool AreClipboardRadioButtonsEnabled
        {
            get => clipboardCheckBox.Checked;
        }

        public MainForm()
        {
            InitializeComponent();
            copyHexRadiobutton.DataBindings.Add("Enabled", this, "AreClipboardRadioButtonsEnabled");
            copyStringRadiobutton.DataBindings.Add("Enabled", this, "AreClipboardRadioButtonsEnabled");
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            var copyToClipboard = clipboardCheckBox.Checked;
            var copyHex = copyHexRadiobutton.Checked;
            var asciiValue = asciiRTE.Text;
            var ignoreTags = ignoreTagsChecbox.Checked;

            var convertResult = ignoreTags
                ? AsciiToShiftJISConverter.ConvertExcludingTags(asciiValue)
                : AsciiToShiftJISConverter.Convert(asciiValue);
            var shiftJISString = convertResult.ShiftJISString;
            var hexString = Convert.ToHexString(convertResult.ShiftJISBytes);

            shiftJISHexRTE.Text = hexString;
            shiftJISStringRTE.Text = shiftJISString;

            if (copyToClipboard)
            {
                var clipboardText = copyHex ? hexString : shiftJISString;
                Clipboard.SetText(clipboardText);
            }
        }

        private void clipboardCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            copyHexRadiobutton.DataBindings[0].ReadValue();
            copyStringRadiobutton.DataBindings[0].ReadValue();
        }
    }
}
