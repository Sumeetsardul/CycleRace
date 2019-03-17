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


        public bool Gamble(int Amount, int WinnerCycle)//this function send the value to 
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
        public void BetDisplay()// this method display the bet
        {
            MyLabel.Text = GuyBet.Bets(this);
            MyRadioButton.Text = $@"{Name} has ${Dollars} dollars";
        }
        public void MoneyAdd(int winner)//this method adds the money to winner
        {
            Dollars += GuyBet.CashOut(winner);
            Reset();
            BetDisplay();
        }
       

        public void Reset()//this is the reset method
        {
            GuyBet.cash = 0;
        }

       
    }
}