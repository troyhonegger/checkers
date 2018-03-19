
namespace Checkers
{
    //Immutable class that encapsulates the transition from one Board to another
    public class Move
    {
        public static readonly double kingVal = 1.3;//Used in the static evaluator; a king is worth 1.3 regular pieces

        public Board PrevBoard { get; private set; }
        private Board nextBoard;
        public Board NextBoard
        {
            get
            {
                if (nextBoard == null)
                    nextBoard = GenerateNext();
                return nextBoard;
            }
            private set => nextBoard = value;
        }
        //Generator function for NextBoard, called only the first time the value of NextBoard is queried
        private Board GenerateNext()
        {
            byte[] newPcs = PrevBoard.CopyPcs();
            newPcs[From] = Pieces.blank;
            if (!Kinged)
                newPcs[To] = PrevBoard.PcAt(From);
            else
                newPcs[To] = Pieces.King(PrevBoard.PcAt(From));

            if (Captured)
                newPcs[CaptureLoc] = Pieces.blank;

            bool turn = !PrevBoard.RedTurn;
            if (IsDoubleJump)//if it's a double jump, switch it back - successive jumps don't switch turns
                turn = !turn;
            return new Board(this, newPcs, turn);
        }

        public int From { get; private set; }
        public int To { get; private set; }
        public bool IsDoubleJump { get; private set; }
        public int CaptureLoc { get; private set; }//the location of the captured piece, or -1 if none
        public bool Captured { get; private set; }//true if and only if the move entailed capturing a piece
        public bool Kinged { get; private set; }//true if and only if the move entailed kinging the moving piece
        public double CapturedVal { get; private set; }

        public Move(Board initial, int fromLoc, int toLoc, int captureLoc, bool doubleJump)
        {
            PrevBoard = initial;
            From = fromLoc;
            To = toLoc;
            CaptureLoc = captureLoc;
            Captured = captureLoc != -1;
            int yTo = Board.GetY(toLoc);
            Kinged = (yTo == 0 || yTo == Board.lengthY - 1) && !Pieces.IsKing(initial.PcAt(fromLoc));
            IsDoubleJump = doubleJump;
            if (Captured)
                CapturedVal = Pieces.IsKing(initial.PcAt(captureLoc)) ? kingVal : 1;
            else CapturedVal = 0;
        }

        //Used by IntrinsicVal() to determine how valuable the move is
        private double valOfAllCaptured = -1;
        public double ValOfAllCaptured
        {
            get
            {
                if (valOfAllCaptured == -1)
                    valOfAllCaptured = TallyCapturedVals();
                return valOfAllCaptured;
            }
            private set => valOfAllCaptured = value;
        }
        public double TallyCapturedVals() => CapturedVal + (IsDoubleJump ? PrevBoard.Prev.ValOfAllCaptured : 0);
        public double IntrinsicVal() => ValOfAllCaptured + (Kinged ? (kingVal - 1) : 0);

        //If this move was a jump and subsequent jumps were possible, they will be computed and stored here
        private LinkedList<Move> subMoves;
        public LinkedList<Move> SubMoves
        {
            get
            {
                if (subMoves != null)
                    return subMoves;
                SubMoves = (Captured && !Kinged) ? NextBoard.GetDoubleMoves(To) : new LinkedList<Move>();
                return subMoves;
            }
            private set
            {
                subMoves = value;
            }
        }
        //Retrieves not only SubMoves, but also the SubMoves of each sub-move, and so on, to allow for triple-, quadruple-, etc. jumps
        public LinkedList<Move> DeepSubMoves()
        {
            LinkedList<Move> list = new LinkedList<Move>();
            foreach (Move m in SubMoves)
                list.AddAll(m.DeepSubMoves());
            return list;
        }

        //Releases computed sub-moves and the previous board's computed moves to free up RAM
        public void ReleaseResources()
        {
            SubMoves = null;
            PrevBoard.ReleaseResources();
        }
    }
}