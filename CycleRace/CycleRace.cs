using System;
using System.Windows.Forms;

namespace RacetrackSimulator
{
    public partial class CycleRace : Form
    {
        CycleRun[] cycleist = new CycleRun[4];
        Gamblers[] gambler = new Gamblers[3];
        Random myRandom = new Random();
       
        public CycleRace()
        {
            InitializeComponent();

            cycleist[0] = new CycleRun()
            {
                MyPictureBox = cycle1PB,
                StartLine = cycle1PB.Left,
                Length = pictureBox1.Width - cycle1PB.Width,
                Rand = myRandom
            };
            cycleist[1] = new CycleRun()
            {
                MyPictureBox = cycle2PB,
                StartLine = cycle2PB.Left,
                Length = pictureBox1.Width - cycle2PB.Width,
                Rand = myRandom
            };
            cycleist[2] = new CycleRun()
            {
                MyPictureBox = cycle3PB,
                StartLine = cycle3PB.Left,
                Length = pictureBox1.Width - cycle3PB.Width,
                Rand = myRandom
            };
            cycleist[3] = new CycleRun()
            {
                MyPictureBox = Cycle4PB,
                StartLine = Cycle4PB.Left,
                Length = pictureBox1.Width - Cycle4PB.Width,
                Rand = myRandom
            };

            //Initialize all the guy objects
            gambler[0] = new Gamblers()
            {
                Dollars = 50,
                GuyBet = null,
                MyLabel = SimerBetLabel,
                MyRadioButton = SimerRadioButton,
                Name = "Simer"
            };
            gambler[1] = new Gamblers()
            {
                Dollars = 50,
                GuyBet = null,
                MyLabel = GillBetLabel,
                MyRadioButton = GillRadioButton,
                Name = "Gill"
            };
            gambler[2] = new Gamblers()
            {
                Dollars = 50,
                GuyBet = null,
                MyLabel = MalkeetBetLabel,
                MyRadioButton = MalkeetRadioButton,
                Name = "Malkeet"
            };

            foreach (Gamblers guy in gambler)
            {
                guy.GuyBet = new PlaceBet();
                guy.Reset();
                guy.BetDisplay();
            }

        }

        private void Start_Click(object sender, EventArgs e)
        {
            timer1.Start();
            gamble.Enabled = false;
        }

        private void SimerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            NameLabel.Text = gambler[0].Name;
        }

        private void GillRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            NameLabel.Text = gambler[1].Name;
        }

        private void MalkeetRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            NameLabel.Text = gambler[2].Name;
        }

        private void Bet_Click(object sender, EventArgs e)
        {
            if (gambler[0].MyRadioButton.Checked)
            {
                if (gambler[0].Gamble((int)GambleAmt.Value, (int)WinnerCycle.Value))
                {
                    gambler[0].BetDisplay();
                }
            }
            if (gambler[1].MyRadioButton.Checked)
            {
                if (gambler[1].Gamble((int)GambleAmt.Value, (int)WinnerCycle.Value))
                {
                    gambler[1].BetDisplay();
                }
            }
            if (gambler[2].MyRadioButton.Checked)
            {
                if (gambler[2].Gamble((int)GambleAmt.Value, (int)WinnerCycle.Value))
                {
                    gambler[2].BetDisplay();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (cycleist[i].CycleRunning())
                {
                    var winner = i + 1;
                    timer1.Stop();
                    MessageBox.Show($@"Cycleist number {winner} wins!", @"The Winner is");

                    foreach (Gamblers guy in gambler)
                    {
                        guy.MoneyAdd(winner);
                    }

                    foreach (CycleRun cycle in cycleist)
                    {
                        cycle.StartlinePosition();
                    }

                    gamble.Enabled = true;
                    break;
                }
            }
        }

        private void Cycle4PB_Click(object sender, EventArgs e)
        {

        }

        private void MalkeetBetLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
