using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Checkers
{
    //designed solely for testing the AI feature; in particular, so the AI can play games against itself and print only the desired results
    public partial class AITest : Form
    {
        private Thread testThread;
        public AITest()
        {
            InitializeComponent();
            testThread=new Thread(RunTests);
            testThread.Start();
        }
        public void Write(string s)
        {
            if (textBox1.InvokeRequired)
                this.Invoke(new StrToVoid(Write), new object[] { s });
            else
                textBox1.Text += s;
        }
        public void WriteLine(string s) => Write(s + "\r\n");
        public void WriteLine() => WriteLine("");
        
        //at 0.15 increments black won all games from 1 <= i,j <= 3.1
        public void RunTests()
        {
            int[] wins = new int[15];
            int num = 0;
            for(int i = 0; i<wins.Length; i++)
            {
                for(int j = 0; j<wins.Length; j++)
                {
                    if (j == i)
                        continue;
                    Write("Starting game " + num);
                    Write(" (i="+ToK(i)+", j="+ToK(j)+") ... ");
                    bool redWin = RedWinsGame(ToK(i), ToK(j));
                    WriteLine(redWin?"Red wins":"Black wins");
                    if (redWin)
                        wins[i]++;
                    else
                        wins[j]++;
                    num++;
                }
            }
            for(int i = 0; i < wins.Length; i++)
                WriteLine("AI with value " + ToK(i) + " won " + wins[i] + " games");
            WriteLine("Each played a total of 28 games");
        }
        public double ToK(int i) => 1.0 + (0.15 * i);
        public bool RedWinsGame(double kingVal1,double kingVal2)
        {
            throw new NotSupportedException("kingVal is readonly, so kingVal tests are not supported at this time");
            /*Board b = Board.starting;
            AI p1 = new AI(2), p2 = new AI(2);//both are set to hard
            while (!b.GameOver())
            {
                Checkers.Move.kingVal = b.RedTurn?kingVal1:kingVal2;
                b = (b.RedTurn ? p1 : p2).GetMove(b).NextBoard;
            }
            //you can only lose on your own turn; so if the game is over the winner must be the one whose turn it isn't
            return !b.RedTurn;*/
        }

        private void AITest_FormClosing(object sender, FormClosingEventArgs e) => testThread.Abort();
    }
    public delegate void StrToVoid(string s);
}