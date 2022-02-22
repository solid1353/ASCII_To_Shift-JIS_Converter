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
            // ToDo:
            var copyToClipboard = clipboardCheckBox.Checked;
            var copyHex = copyHexRadiobutton.Checked;
            var asciiValue = asciiRTE.Text;

            var convertResult = AsciiToShiftJISConverter.Convert(asciiValue);

            shiftJISHexRTE.Text = Convert.ToHexString(convertResult.ShiftJISBytes);
            shiftJISStringRTE.Text = convertResult.ShiftJISString;
        }
    }
}
