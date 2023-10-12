namespace RGB
{
    public partial class Form1 : Form
    {

        int redMixerValue = 0;
        int greenMixerValue = 0;
        int blueMixerValue = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void numericRed_ValueChanged(object sender, EventArgs e)
        {
            int redValue = (int)numericRed.Value;
            int greenValue = 0;
            int blueValue = 0;

            redMixerValue = redValue;

            redBox.BackColor = Color.FromArgb(redValue, greenValue, blueValue);

            this.BackColor = Color.FromArgb (redMixerValue, greenMixerValue, blueMixerValue);
        }

        private void numericGreen_ValueChanged(object sender, EventArgs e)
        {
            int redValue = 0;
            int greenValue = (int)numericGreen.Value;
            int blueValue = 0;

            greenMixerValue = greenValue;

            this.BackColor = Color.FromArgb(redMixerValue, greenMixerValue, blueMixerValue);

            greenBox.BackColor = Color.FromArgb(redValue, greenValue, blueValue);
        }

        private void numericBlue_ValueChanged(object sender, EventArgs e)
        {
            int redValue = 0;
            int greenValue = 0;
            int blueValue = (int)numericBlue.Value;

            blueMixerValue = blueValue;

            this.BackColor = Color.FromArgb(redMixerValue, greenMixerValue, blueMixerValue);

            blueBox.BackColor = Color.FromArgb(redValue, greenValue, blueValue);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}