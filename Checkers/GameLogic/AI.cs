using System;
using System.Diagnostics;
using Microsoft.VisualBasic.Devices;

namespace Checkers
{
    //Contains methods for evaluating the optimal move up to a given number of moves ahead
    public class AI
    {
        private Stopwatch timer;//records the time spent on a call to GetMove so it can stop if it's taking too long
        public static readonly int maxTimeMillis = 20_000;//AI gets max ~20sec to think of a move
        public static readonly ulong minAvailableMemory = 40960L;//AI stops when available RAM gets below ~40MB
        //                                    {easy,medium,hard}
        public static readonly int[] depths = { 5, 7, 9 };//specifies how many moves ahead the AI will look
        public int Diff { get; private set; }
        public int Depth { get; private set; }
        private Move move;
        public AI(int diff)
        {
            Diff = diff;
            Depth = depths[diff];
            timer = new Stopwatch();
        }

        //Calculates and returns the best move up to Depth moves ahead. Stops when done or (roughly) when constraints are first exceeded
        public Move GetMove(Board board)
        {
            timer.Start();
            //calculate the best move and store it in the move field
            Negamax(board, Depth, double.NegativeInfinity, double.PositiveInfinity, true);
            //release RAM by deleting tree branches referring to unselected moves
            move.ReleaseResources();
            GC.Collect();
            timer.Reset();
            return move;
        }

        //This is the heart of the AI. The name negamax means the AI assumes its opponent will play optimally and, under that assumption, computes the optimal move.
        //It uses alpha-beta pruning to eliminate parts of the tree that it can prove will never happen (assuming both players play optimally)
        public double Negamax(Board board, int depth, double alpha, double beta, bool saveMove)
        {
            if (depth == 0)//Done looking ahead
                return 0;
            else if (board.GameOver())//We lost
                return double.NegativeInfinity;
            //On every sixth layer, the AI checks to make sure it hasn't run out of either time or memory
            //If it has, it returns alpha (the worst-case scenario value) so the game prunes the branch and focuses on other options it's already computed
            else if ((Depth - depth) % 6 == 0 && ConstraintsExceeded())
                return alpha;

            double best = double.NegativeInfinity;
            foreach (Move move in board.GetMoves(board.RedTurn))
            {
                double val = move.IntrinsicVal() - Negamax(move.NextBoard, depth - 1, -beta, -alpha, false);
                if (val >= best)
                {
                    best = val;
                    if (saveMove)
                        this.move = move;
                }
                alpha = Max(val, alpha);
                if (beta <= alpha)
                    break;
            }
            return best;
        }
        public static double Max(double a, double b) => a < b ? b : a;

        //If time or memory constraints exceed the given boundaries, returns true to signal the AI to exit
        private bool ConstraintsExceeded()
        {
            if (timer.ElapsedMilliseconds > maxTimeMillis)
                return true;
            return (new ComputerInfo().AvailablePhysicalMemory) < minAvailableMemory;
        }
    }
}