namespace ASCII_To_Shift_JIS_Converter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            var copyToClipboard = clipboardCheckBox.Checked;
            var copyHex = copyHexRadiobutton.Checked;
            var asciiValue = asciiRTE.Text;

            var convertResult = AsciiToShiftJISConverter.Convert(asciiValue);
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
    }
}
