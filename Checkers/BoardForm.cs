using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Checkers
{
    public partial class BoardForm : Form
    {
        //c1 and c2 are the colors of the checkerboard pattern; selectedColor is the highlight color
        public static readonly Color c1 = Color.Khaki, c2 = Color.DarkGoldenrod, selectedColor = Color.Aqua;
        //if pc is a byte representing a piece, pcIcons[pc] returns the image corresponding to that piece
        public static readonly Image[] pcIcons = { null, Properties.Resources.red, Properties.Resources.redk, Properties.Resources.black, Properties.Resources.blackk };

        //stores the location of the square currently selected by the user
        private int selectedX=-1, selectedY=-1;
        //all moves that can be made by the piece at the selected location, or null if no location is selected
        private LinkedList<Move> possibleChoices;
        //this thread uses the AI function to compute a move and then update the UI
        private Thread moveGenerator;
        //if this flag is set to false when a square is clicked, the click listeners will not process the event
        private bool listeningToSquares;
        
        private AI p1, p2;
        //returns the AI object representing the specified player, or null if the player is human
        public AI GetPlayer(bool team) => team ? p1 : p2;
        public bool IsHuman(bool team) => GetPlayer(team)==null;
        //returns the difficulty of specified player, or throws an exception if the player is human
        public int Diff(bool team) => GetPlayer(team).Diff;

        private Board board;
        public Board CurrentBoard
        {
            get => board;
            private set
            {
                board = value;
                UpdateUI();
            }
        }

        private StartForm startForm;

        public BoardForm(StartForm startForm, int p1Diff, int p2Diff)
        {
            this.startForm = startForm;
            InitializeComponent();
            InitializeSquares();
            if (p1Diff != -1)
                p1 = new AI(p1Diff);
            if (p2Diff != -1)
                p2 = new AI(p2Diff);
            CurrentBoard = Board.starting;
        }
        public void UpdateUI()
        {
            SetText(stateLabel, CurrentBoard.GameState());
            for(int i = 0; i < Board.usableSquares; i++)
            {
                int x = Board.GetX(i), y = Board.GetY(i);
                SetImage(squares[x][y], pcIcons[CurrentBoard.PcAt(i)]);
            }
            listeningToSquares = IsHuman(CurrentBoard.RedTurn) && !CurrentBoard.GameOver();
            SetEnabled(moveAIButton, !IsHuman(CurrentBoard.RedTurn) && !CurrentBoard.GameOver());
        }

        //highlights the specified location and the destinations of all moves that can be made from it
        public void Select(int x,int y)
        {
            //deselect if necessary (I know it's inefficient to set the variables twice, but it shouldn't be a performance issue)
            if (selectedX != -1)
                Deselect();

            selectedX = x;
            selectedY = y;
            possibleChoices = board.GenerateMoves(Board.GetI(x, y));
            SetBackColor(squares[selectedX][selectedY], selectedColor);
            foreach(Move choice in possibleChoices)
            {
                int toX = Board.GetX(choice.To), toY = Board.GetY(choice.To);
                squares[toX][toY].BackColor = selectedColor;
                SetBackColor(squares[toX][toY], selectedColor);
            }
        }
        //removes the highlights from selection
        public void Deselect()
        {
            if (selectedX == -1)//if already deselected
                return;
            foreach(Move choice in possibleChoices)
            {
                int toX = Board.GetX(choice.To), toY = Board.GetY(choice.To);
                SetBackColor(squares[toX][toY], c2);
            }
            SetBackColor(squares[selectedX][selectedY], c2);
            selectedX = -1;
            selectedY = -1;
            possibleChoices = null;
        }
        //finds the move from (selectedX,selectedY) to (x,y)
        public Move FindHighlightedMove(int x,int y)
        {
            int to = Board.GetI(x, y);
            foreach (Move choice in possibleChoices)
                if (choice.To == to)
                    return choice;
            return null;
        }

        //for the dark-brown squares that can contain pieces
        private void SquareClickListener(object sender, EventArgs e)
        {
            if (!listeningToSquares)
                return;
            int loc = Int32.Parse(((PictureBox)sender).Name.Substring(10));
            int x = loc % Board.boardLength, y = loc / Board.boardLength;
            //if the piece is on the current team, select it no matter what
            if (Pieces.OnTeam(CurrentBoard.RedTurn, CurrentBoard.PcAt(x, y)))
                Select(x, y);
            else if(selectedX!=-1)//otherwise, if a piece is selected, deselect it and make the move (if valid)
            {
                Move move = FindHighlightedMove(x, y);
                Deselect();
                if (move != null)
                    CurrentBoard = move.NextBoard;
            }
        }
        //for the light-brown squares that cannot contain pieces
        private void EmptySquareClickListener(object sender, EventArgs e) => Deselect();

        private void BoardForm_FormClosed(object sender, FormClosedEventArgs e) => startForm.Show();
        private void BoardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (moveGenerator!=null && moveGenerator.ThreadState == ThreadState.Running)
                moveGenerator.Abort();
        }

        private void newGameClickListener(object sender, EventArgs e)
        {
            Deselect();
            CurrentBoard = Board.starting;
        }
        private void undoClickListener(object sender, EventArgs e)
        {
            Deselect();
            if (CurrentBoard.Prev != null)
                CurrentBoard = CurrentBoard.Prev.PrevBoard;
        }

        private void AIClickListener(object sender, EventArgs e)
        {
            string prevText = moveAIButton.Text;
            SetText(moveAIButton, "Thinking...");
            SetEnabled(moveAIButton, false);
            SetEnabled(undoButton, false);
            SetEnabled(newGameButton, false);
            moveGenerator = new Thread(DoAIMove);
            moveGenerator.Start();
        }
        public void DoAIMove()
        {
            try
            {
                Move move = GetPlayer(CurrentBoard.RedTurn).GetMove(CurrentBoard);
                SetText(moveAIButton, "AI Move");
                SetEnabled(undoButton, true);
                SetEnabled(newGameButton, true);
                CurrentBoard = move.NextBoard;//this sets moveAIButton.Enabled so we don't need to do that again here
            }
            catch (ThreadAbortException)
            {
                return;
            }
        }

        //thread-safe setter methods for controls on the form so either the UI thread or moveGenerator can update the UI
        public void SetEnabled(Control ctrl, bool enabled)
        {
            if (ctrl.InvokeRequired)
                Invoke(new CtrlBoolToVoid(SetEnabled), new object[] { ctrl, enabled });
            else
                ctrl.Enabled = enabled;
        }
        public void SetText(Control ctrl, string str)
        {
            if (ctrl.InvokeRequired)
                Invoke(new CtrlStrToVoid(SetText), new object[] { ctrl, str });
            else
                ctrl.Text = str;
        }
        public void SetImage(PictureBox box, Image img)
        {
            if (box.InvokeRequired)
                Invoke(new PicBoxImgToVoid(SetImage), new object[] { box, img });
            else
                box.Image=img;
        }
        public void SetBackColor(Control ctrl, Color color)
        {
            if (ctrl.InvokeRequired)
                Invoke(new CtrlColorToVoid(SetBackColor), new object[] { ctrl, color });
            else
                ctrl.BackColor = color;
        }
    }

    //delegate declarations used to set control properties in a thread-safe way
    public delegate void CtrlBoolToVoid(Control ctrl, bool b);
    public delegate void CtrlStrToVoid(Control ctrl, string s);
    public delegate void PicBoxImgToVoid(PictureBox ctrl, Image img);
    public delegate void CtrlColorToVoid(Control ctrl, Color c);
}