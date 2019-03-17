namespace RacetrackSimulator
{
    public class PlaceBet
    {
        public Gamblers gamble;
        public int cash;
        public int cycle;
        

        public int CashOut(int winner)//this method updates the cash for the winner
        {
            if (cycle == winner)
            {
                return cash;
            }
            return cash * -1;
        }
        public string Bets(Gamblers bettor)//this method checks if the user has placed a bet 
        {
            gamble = bettor;
            if (cash > 0)
            {
                return $@"{gamble.Name} bet ${cash} on Cycle {cycle}";
            }
            return $@"{gamble.Name} has not yet placed a bet";
        }

       
    }
}