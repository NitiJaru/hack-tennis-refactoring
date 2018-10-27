using System;

namespace Hack.Lib
{
    public class TennisGame2 : ITennisGame
    {
        private int player1point;
        private int player2point;

        private string player1;
        private string player2;
        private string player1Name;
        private string player2Name;

        public TennisGame2(string player1Name, string player2Name)
        {
            player1Name = player1Name;
            this.player2Name = player2Name;
        }

        public string GetScore()
        {
            var score = "";
            if (player1point == player2point)
            {
                if (player1point < 3) score = GetDisplayText(player1point) + "-All";
                else score = "Deuce";
            }
            else if (player1point > 3 || player2point > 3)
            {
                var winner = (player1point > player2point) ? "player1" : "player2";
                var isWin = (Math.Abs(player1point - player2point) >= 2)? "Win for ": "Advantage ";
                score = isWin + winner;
            }
            else
            {
                score = GetDisplayText(player1point) + "-" + GetDisplayText(player2point);
            }
            return score;
        }

        private string GetDisplayText(int number)
        {
            switch (number)
            {
                case 0: return "Love";
                case 1: return "Fifteen";
                case 2: return "Thirty";
                case 3: return "Forty";
                default: throw new Exception("Error number");
            }
        }

        public void SetPlayer1Score(int number)
        {
            player1point = number;
        }

        public void SetPlayer2Score(int number)
        {
            player2point = number;
        }

        public void WonPoint(string player)
        {
            if (player == "player1") player1point++;
            else player2point++;
        }

    }
}

