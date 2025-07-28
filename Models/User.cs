using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Models
{
    public class User
    {
        public string Username { get; private set; }
        public decimal Balance { get; private set; }

        
        public int GamesPlayed { get; private set; }
        public int GamesWon { get; private set; }
        public int GamesLost { get; private set; }

        public User(string username, decimal startingBalance = 1000)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Användarnamn kan inte vara tomt.");

            Username = username;
            Balance = startingBalance;
            GamesPlayed = 0;
            GamesWon = 0;
            GamesLost = 0;
        }

        public bool AdjustBalance(decimal amount)
        {
            decimal newBalance = Balance + amount;

            if (newBalance < 0)
                return false; 

            Balance = newBalance;
            return true;
        }

        public void RecordGameResult(bool won)
        {
            GamesPlayed++;
            if (won) GamesWon++;
            else GamesLost++;
        }

        public override string ToString()
        {
            return $"{Username} | Saldo: {Balance} kr | Spelade: {GamesPlayed}, Vunna: {GamesWon}, Förlorade: {GamesLost}";
        }
    }
}
}
