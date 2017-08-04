using System.Collections.Generic;
using System.Linq;

namespace BotExample
{
    public class Move
    {
        static Move()
        {
            var rockMove = new Move();
            var paperMove = new Move();
            var scissorsMove = new Move();
            var dynamiteMove = new Move();
            var waterbombMove = new Move();


            paperMove.WillBeat(rockMove);
            paperMove.WillBeat(waterbombMove);
            scissorsMove.WillBeat(paperMove);
            scissorsMove.WillBeat(waterbombMove);
            rockMove.WillBeat(scissorsMove);
            rockMove.WillBeat(waterbombMove);
            dynamiteMove.WillBeat(rockMove);
            dynamiteMove.WillBeat(paperMove);
            dynamiteMove.WillBeat(scissorsMove);
            waterbombMove.WillBeat(dynamiteMove);

            possibleMoves.Add("PAPER", paperMove);
            possibleMoves.Add("SCISSORS", scissorsMove);
            possibleMoves.Add("ROCK", rockMove);
            possibleMoves.Add("DYNAMITE", dynamiteMove);
            possibleMoves.Add("WATERBOMB", waterbombMove);
        }

        private static Dictionary<string, Move> possibleMoves = new Dictionary<string, Move>();

        public static Move Parse(string move)
        {
            return possibleMoves[move];
        }

        public static IEnumerable<KeyValuePair<string, Move>> GetPossibleMoves()
        {
            return possibleMoves.ToArray();
        }

        private void WillBeat(Move otherMove)
        {
            this.BeatsList.Add(otherMove);
        }

        public List<Move> BeatsList = new List<Move>();

        public bool Beats(Move otherMove)
        {
            return BeatsList.Contains(otherMove);
        }

        public override string ToString()
        {
            return possibleMoves.Single(entry => entry.Value == this).Key;
        }
    }

    enum Moves
    {
        Rock,
        Paper,
        Scissors
    }
}