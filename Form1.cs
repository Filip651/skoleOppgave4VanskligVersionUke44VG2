using System;
using System.Windows.Forms;

namespace oppgave4VanskligVersion
{
    public partial class Form1 : Form
    {
        bool bStarted = false; // Flag to track if the countdown has started
        private int countdown = 10; // Initialize the countdown variable to 10
        private int numOfClicks = 0; // Initialize the number of clicks to 0

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Event handler for form load
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            if (!bStarted)
            {
                lblTimeLeft.Text = countdown.ToString(); // Display the countdown value
                tCountDown.Interval = 1000; // Set the interval to 1000 milliseconds (1 second)
                tCountDown.Start(); // Start the countdown timer
            }

            numOfClicks++; // Increment the number of clicks
            lblNumOfClicks.Text = numOfClicks.ToString(); // Display the number of clicks
        }

        private void tCountDown_Tick(object sender, EventArgs e)
        {
            if (countdown > 0)
            {
                countdown--; // Decrement the countdown value
                lblTimeLeft.Text = countdown.ToString(); // Display the updated countdown value
            }
            else
            {
                tCountDown.Stop(); // Stop the countdown timer
                btnClick.Enabled = false; // Disable the click button
                btnReset.Visible = true; // Make the reset button visible
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnClick.Enabled = true; // Enable the click button
            btnReset.Visible = false; // Hide the reset button
            bStarted = false; // Reset the started flag
            countdown = 10; // Reset the countdown value to 10
            numOfClicks = 0; // Reset the number of clicks to 0
        }
    }
}