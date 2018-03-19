
namespace Checkers
{
    //Contains static methods for performing checks on pieces
    //Pieces are represented as bytes
    public static class Pieces
    {
        public static readonly byte blank = 0, red = 1, redk = 2, black = 3, blackk = 4;
        //If pc is a byte representing a piece, then names[pc] returns a string describing the piece
        public static readonly string[] names = { "blank", "red", "red king", "black", "black king" };
        public static string ToString(byte pc) => names[pc];

        //Kings the given piece; i.e. King(red) returns redk, King(black) returns blackk
        //For speed, this does NOT throw exceptions for blank pieces. King(blank) returns blank
        public static byte King(byte pc) => (pc % 2 == 1) ? (byte)(pc + 1) : pc;
        //For speed, this does NOT check for blank pieces. IsKing(blank) returns true
        public static bool IsKing(byte pc) => (pc % 2) == 0;

        //red player is represented throughout as true, black player is false
        public static bool IsRed(byte pc) => pc == 1 || pc == 2;
        //returns true if and only if the specified piece is on the specified team
        public static bool OnTeam(bool team, byte pc) => (pc != blank) && (IsRed(pc) == team);
        public static bool OnOppTeam(bool team, byte pc) => OnTeam(!team, pc);
    }
}