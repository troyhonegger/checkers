using System;

namespace Checkers
{
    //Immutable class that encapsulates game state at a single instant in game play. Also implements move generation rules.
    //Boards are represented as 1D byte arrays of length 32 (not 64 since the light-brown squares cannot hold a piece).
    //Each element of the array contains the piece at the given location. Indecies are numbered from left to right and from top to bottom.
    public class Board
    {
        public static readonly int boardLength = 8;
        public static readonly int lengthY = boardLength;
        public static readonly int lengthX = boardLength / 2;
        public static readonly int numSquares = boardLength * boardLength;
        public static readonly int usableSquares = lengthX * lengthY;

        //The next three methods convert between rectangular and one-dimensional coordinates.
        //NOTE: For speed, none of the methods check for illegal parameters.
        //Values of x, y, or i outside the legal bounds will not throw exceptions but rather yield nonsensical results
        public static int GetY(int i) => i / lengthX;
        public static int GetX(int i) => (i % lengthX) * 2 + (1 - GetY(i) % 2);
        public static int GetI(int x, int y) => y * lengthX + x / 2;

        public static bool InRange(int x, int y) => x < boardLength && y < boardLength && x >= 0 && y >= 0;
        public static bool InRange(int i) => 0 <= i && i < usableSquares;

        //generates the starting board state
        private static byte[] BuildStartingPcs()
        {
            byte[] pcs = new byte[usableSquares];
            int i = 0;
            for (; i < 12; i++)
                pcs[i] = Pieces.black;
            for (; i < usableSquares - 12; i++)
                pcs[i] = Pieces.blank;
            for (; i < usableSquares; i++)
                pcs[i] = Pieces.red;
            return pcs;
        }
        public static readonly Board starting = new Board(null, BuildStartingPcs(), true);

        private LinkedList<Move> redMoves, blackMoves;
        public LinkedList<Move> RedMoves
        {
            get
            {
                if (redMoves == null)
                    RedMoves = GenerateMoves(true);
                return redMoves;
            }
            private set => redMoves = value;
        }
        public LinkedList<Move> BlackMoves
        {
            get
            {
                if (blackMoves == null)
                    BlackMoves = GenerateMoves(false);
                return blackMoves;
            }
            private set => blackMoves = value;
        }
        private byte[] pcs = new byte[usableSquares];
        public bool RedTurn { get; private set; }
        //Board stores a reference to the previous move to allow an undo function
        public Move Prev { get; private set; }

        //WARNING: For speed and to avoid redundancy, the parameter pcs is not copied upon initialization
        //Copy array before initialization to avoid anti-aliasing issues
        public Board(Move prev, byte[] pcs, bool redTurn)
        {
            Prev = prev;
            RedTurn = redTurn;
            this.pcs = pcs;
        }

        public byte PcAt(int i) => pcs[i];
        public byte PcAt(int x, int y) => PcAt(GetI(x, y));
        //returns a copy of this board's pcs field
        public byte[] CopyPcs()
        {
            byte[] newPcs = new byte[usableSquares];
            Array.Copy(pcs, newPcs, usableSquares);
            return newPcs;
        }

        //Move generation logic
        public LinkedList<Move> GetMoves(bool team) => team ? RedMoves : BlackMoves;
        //helper function checks if move==null and if not adds it to the list
        private void CheckAndAdd(LinkedList<Move> moves, Move move)
        {
            if (move != null)
                moves.Add(move);
        }
        //Helper function used only by GenerateMoves(int)
        //Looks in the specified direction (i.e. dx=1, dy=-1 means up and to the left)
        //and returns the move if one can be made, null otherwise
        public Move GetMoveInDir(int pcLoc, int dx, int dy)
        {
            int x = GetX(pcLoc) + dx, y = GetY(pcLoc) + dy;
            if (!InRange(x, y))
                return null;
            int toLoc = GetI(x, y);
            if (PcAt(toLoc) == Pieces.blank)
                return new Move(this, pcLoc, toLoc, -1, false);
            else if (Pieces.OnOppTeam(Pieces.IsRed(PcAt(pcLoc)), PcAt(toLoc)))
            {
                x += dx;
                y += dy;
                if (InRange(x, y) && PcAt(x, y) == Pieces.blank)
                    return new Move(this, pcLoc, GetI(x, y), toLoc, false);
            }
            return null;
        }
        //Generates all possible moves for a single piece. Assumes the specified location is not empty
        public LinkedList<Move> GenerateMoves(int pcLoc)
        {
            LinkedList<Move> moves = new LinkedList<Move>();
            byte pc = PcAt(pcLoc);
            if (pc != Pieces.black)//pc can move in the negative y-direction
            {
                CheckAndAdd(moves, GetMoveInDir(pcLoc, 1, -1));
                CheckAndAdd(moves, GetMoveInDir(pcLoc, -1, -1));
            }
            if (pc != Pieces.red)//pc can move in the positive y-direction
            {
                CheckAndAdd(moves, GetMoveInDir(pcLoc, 1, 1));
                CheckAndAdd(moves, GetMoveInDir(pcLoc, -1, 1));
            }
            LinkedList<Move> doubleJumps = new LinkedList<Move>();
            foreach (Move m in moves)
                doubleJumps.AddAll(m.SubMoves);
            moves.AddAll(doubleJumps);
            return moves;
        }
        public LinkedList<Move> GenerateMoves(bool team)
        {
            LinkedList<Move> list = new LinkedList<Move>();
            for (int i = 0; i < usableSquares; i++)
                if (Pieces.OnTeam(team, PcAt(i)))
                    list.AddAll(GenerateMoves(i));
            return list;
        }

        //If a jump is made, this function is called on the move's NextBoard property to see if any double jumps can ensue.
        //Thus double-jump move possibilities are discovered recursively, so triple, quadruple, etc. jumps are theoretically possible
        public LinkedList<Move> GetDoubleMoves(int pcLoc)
        {
            LinkedList<Move> moves = new LinkedList<Move>();
            byte pc = PcAt(pcLoc);
            if (pc != Pieces.black)//pc can move in the negative y-direction
            {
                CheckAndAdd(moves, CaptureDoubleInDir(pcLoc, 1, -1));
                CheckAndAdd(moves, CaptureDoubleInDir(pcLoc, -1, -1));
            }
            if (pc != Pieces.red)//pc can move in the positive y-direction
            {
                CheckAndAdd(moves, CaptureDoubleInDir(pcLoc, 1, 1));
                CheckAndAdd(moves, CaptureDoubleInDir(pcLoc, -1, 1));
            }
            return moves;
        }
        //helper function used only by GetDoubleMoves(), similar to GetMoveInDir() for GenerateMoves()
        public Move CaptureDoubleInDir(int pcLoc, int dx, int dy)
        {
            //requirements in order for the move to be valid
            //1. the destination is in the board
            //2. it is empty, and
            //3. the square in between has a piece on the opposite team
            int x = GetX(pcLoc) + 2 * dx, y = GetY(pcLoc) + 2 * dy;
            if (!InRange(x, y))
                return null;
            int toLoc = Board.GetI(x, y), captureLoc = Board.GetI(x - dx, y - dy);
            if (PcAt(toLoc) == Pieces.blank && Pieces.OnOppTeam(Pieces.IsRed(PcAt(pcLoc)), PcAt(captureLoc)))
                return new Move(this, pcLoc, toLoc, captureLoc, true);
            return null;
        }

        //Game is over if and only if the current player has no moves available
        public bool GameOver() => GetMoves(RedTurn).Length == 0;
        public string GameState() => GameOver() ? "Game Over" : ((RedTurn ? "Red" : "Black") + " Turn");

        //This function is called after the AI decides on a move.
        //It sets RedMoves, BlackMoves, and Prev to null, allowing the garbage collector to dispose of the
        //list of all possible board configurations stemming from moves that were not selected by the AI
        public void ReleaseResources()
        {
            RedMoves = null;
            BlackMoves = null;
            if (Prev != null)
                Prev.ReleaseResources();
        }
    }
}