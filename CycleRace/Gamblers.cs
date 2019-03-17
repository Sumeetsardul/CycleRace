using System.Windows.Forms;

namespace RacetrackSimulator
{
    public class Gamblers
    {
        public RadioButton MyRadioButton;
        public Label MyLabel;
        public PlaceBet GuyBet;
        public string Name;
        
        public int Dollars;


        public bool Gamble(int Amount, int WinnerCycle)
        {
            GuyBet = new PlaceBet() { cash = Amount, gamble = this, cycle = WinnerCycle };

            if (Amount <= Dollars)
            {
                GuyBet.cash = Amount;
                GuyBet.cycle = WinnerCycle;
                return true;
            }
            Reset();
            BetDisplay();
            return false;
        }
        public void BetDisplay()
        {
            MyLabel.Text = GuyBet.Bets(this);
            MyRadioButton.Text = $@"{Name} has ${Dollars} dollars";
        }
        public void MoneyAdd(int winner)
        {
            Dollars += GuyBet.CashOut(winner);
            Reset();
            BetDisplay();
        }
       

        public void Reset()
        {
            GuyBet.cash = 0;
        }

       
    }
}