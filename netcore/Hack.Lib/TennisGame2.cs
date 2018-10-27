using System;

namespace Hack.Lib
{
    public class TennisGame2 : ITennisGame
    {
        private int player1point;
        private int player2point;

        private string p1res;
        private string p2res;
        private string player1Name;
        private string player2Name;

        public TennisGame2(string player1Name, string player2Name)
        {
            this.player1Name = player1Name;
            this.player2Name = player2Name;
        }

        public string GetScore()
        {
            var score = "";
            if (player1point == player2point && player1point < 3)
            {
                if (player1point == 0)
                    score = "Love";
                if (player1point == 1)
                    score = "Fifteen";
                if (player1point == 2)
                    score = "Thirty";
                score += "-All";
            }
            if (player1point == player2point && player1point > 2)
                score = "Deuce";

            if (player1point > 0 && player2point == 0)
            {
                if (player1point == 1)
                    p1res = "Fifteen";
                if (player1point == 2)
                    p1res = "Thirty";
                if (player1point == 3)
                    p1res = "Forty";

                p2res = "Love";
                score = p1res + "-" + p2res;
            }
            if (player2point > 0 && player1point == 0)
            {
                if (player2point == 1)
                    p2res = "Fifteen";
                if (player2point == 2)
                    p2res = "Thirty";
                if (player2point == 3)
                    p2res = "Forty";

                p1res = "Love";
                score = p1res + "-" + p2res;
            }

            if (player1point > player2point && player1point < 4)
            {
                if (player1point == 2)
                    p1res = "Thirty";
                if (player1point == 3)
                    p1res = "Forty";
                if (player2point == 1)
                    p2res = "Fifteen";
                if (player2point == 2)
                    p2res = "Thirty";
                score = p1res + "-" + p2res;
            }
            if (player2point > player1point && player2point < 4)
            {
                if (player2point == 2)
                    p2res = "Thirty";
                if (player2point == 3)
                    p2res = "Forty";
                if (player1point == 1)
                    p1res = "Fifteen";
                if (player1point == 2)
                    p1res = "Thirty";
                score = p1res + "-" + p2res;
            }

            if (player1point > player2point && player2point >= 3)
            {
                score = "Advantage player1";
            }

            if (player2point > player1point && player1point >= 3)
            {
                score = "Advantage player2";
            }

            if (player1point >= 4 && player2point >= 0 && (player1point - player2point) >= 2)
            {
                score = "Win for player1";
            }
            if (player2point >= 4 && player1point >= 0 && (player2point - player1point) >= 2)
            {
                score = "Win for player2";
            }
            return score;
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

