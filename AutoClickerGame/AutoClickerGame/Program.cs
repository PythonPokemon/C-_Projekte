using System;
using System.Windows.Forms;
using System.Threading;

namespace AutoClickerGame
{
    public partial class MainForm : Form
    {
        private int score = 0;
        private bool autoClickerActive = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            score++;
            lblScore.Text = "Score: " + score.ToString();
        }

        private void btnStartAutoClicker_Click(object sender, EventArgs e)
        {
            autoClickerActive = true;

            Thread autoClickerThread = new Thread(new ThreadStart(AutoClickerThread));
            autoClickerThread.Start();
        }

        private void btnStopAutoClicker_Click(object sender, EventArgs e)
        {
            autoClickerActive = false;
        }

        private void AutoClickerThread()
        {
            while (autoClickerActive)
            {
                // Simulate a click event
                Invoke(new MethodInvoker(() =>
                {
                    btnClick.PerformClick();
                }));

                // Adjust sleep time to change clicking speed
                Thread.Sleep(100);
            }
        }
    }
}
