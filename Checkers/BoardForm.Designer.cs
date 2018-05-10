using System;
using System.Drawing;
using System.Windows.Forms;

namespace Checkers
{
    partial class BoardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Point gridMargins = new Point(3, 3);
        private Size squareSize = new Size(45, 45);
        private PictureBox[][] squares = new PictureBox[Board.boardLength][];

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox0 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            this.pictureBox28 = new System.Windows.Forms.PictureBox();
            this.pictureBox29 = new System.Windows.Forms.PictureBox();
            this.pictureBox30 = new System.Windows.Forms.PictureBox();
            this.pictureBox31 = new System.Windows.Forms.PictureBox();
            this.pictureBox32 = new System.Windows.Forms.PictureBox();
            this.pictureBox33 = new System.Windows.Forms.PictureBox();
            this.pictureBox34 = new System.Windows.Forms.PictureBox();
            this.pictureBox35 = new System.Windows.Forms.PictureBox();
            this.pictureBox36 = new System.Windows.Forms.PictureBox();
            this.pictureBox37 = new System.Windows.Forms.PictureBox();
            this.pictureBox38 = new System.Windows.Forms.PictureBox();
            this.pictureBox39 = new System.Windows.Forms.PictureBox();
            this.pictureBox40 = new System.Windows.Forms.PictureBox();
            this.pictureBox41 = new System.Windows.Forms.PictureBox();
            this.pictureBox42 = new System.Windows.Forms.PictureBox();
            this.pictureBox43 = new System.Windows.Forms.PictureBox();
            this.pictureBox44 = new System.Windows.Forms.PictureBox();
            this.pictureBox45 = new System.Windows.Forms.PictureBox();
            this.pictureBox46 = new System.Windows.Forms.PictureBox();
            this.pictureBox47 = new System.Windows.Forms.PictureBox();
            this.pictureBox48 = new System.Windows.Forms.PictureBox();
            this.pictureBox49 = new System.Windows.Forms.PictureBox();
            this.pictureBox50 = new System.Windows.Forms.PictureBox();
            this.pictureBox51 = new System.Windows.Forms.PictureBox();
            this.pictureBox52 = new System.Windows.Forms.PictureBox();
            this.pictureBox53 = new System.Windows.Forms.PictureBox();
            this.pictureBox54 = new System.Windows.Forms.PictureBox();
            this.pictureBox55 = new System.Windows.Forms.PictureBox();
            this.pictureBox56 = new System.Windows.Forms.PictureBox();
            this.pictureBox57 = new System.Windows.Forms.PictureBox();
            this.pictureBox58 = new System.Windows.Forms.PictureBox();
            this.pictureBox59 = new System.Windows.Forms.PictureBox();
            this.pictureBox60 = new System.Windows.Forms.PictureBox();
            this.pictureBox61 = new System.Windows.Forms.PictureBox();
            this.pictureBox62 = new System.Windows.Forms.PictureBox();
            this.pictureBox63 = new System.Windows.Forms.PictureBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.undoButton = new System.Windows.Forms.Button();
            this.moveAIButton = new System.Windows.Forms.Button();
            this.newGameButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox49)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox53)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox54)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox55)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox56)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox57)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox58)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox59)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox60)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox61)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox62)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox63)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox0, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox5, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox6, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox7, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox8, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox9, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox10, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox11, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox12, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox13, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox14, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox15, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox16, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox17, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox18, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox19, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox20, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox21, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox22, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox23, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox24, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox25, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox26, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox27, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox28, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox29, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox30, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox31, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox32, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox33, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox34, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox35, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox36, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox37, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox38, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox39, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox40, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox41, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox42, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox43, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox44, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox45, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox46, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox47, 7, 5);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox48, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox49, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox50, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox51, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox52, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox53, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox54, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox55, 7, 6);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox56, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox57, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox58, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox59, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox60, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox61, 5, 7);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox62, 6, 7);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox63, 7, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(32, 64);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(960, 858);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox0
            // 
            this.pictureBox0.BackColor = System.Drawing.Color.Khaki;
            this.pictureBox0.Location = new System.Drawing.Point(0, 0);
            this.pictureBox0.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox0.Name = "pictureBox0";
            this.pictureBox0.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox0.Size = new System.Drawing.Size(120, 107);
            this.pictureBox0.TabIndex = 2;
            this.pictureBox0.TabStop = false;
            this.pictureBox0.Click += new System.EventHandler(this.EmptySquareClickListener);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pictureBox1.Location = new System.Drawing.Point(120, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox1.Size = new System.Drawing.Size(120, 107);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.SquareClickListener);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Khaki;
            this.pictureBox2.Location = new System.Drawing.Point(240, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox2.Size = new System.Drawing.Size(120, 107);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.EmptySquareClickListener);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pictureBox3.Location = new System.Drawing.Point(360, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox3.Size = new System.Drawing.Size(120, 107);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.SquareClickListener);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Khaki;
            this.pictureBox4.Location = new System.Drawing.Point(480, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox4.Size = new System.Drawing.Size(120, 107);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.EmptySquareClickListener);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pictureBox5.Location = new System.Drawing.Point(600, 0);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox5.Size = new System.Drawing.Size(120, 107);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.SquareClickListener);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Khaki;
            this.pictureBox6.Location = new System.Drawing.Point(720, 0);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox6.Size = new System.Drawing.Size(120, 107);
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.EmptySquareClickListener);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pictureBox7.Location = new System.Drawing.Point(840, 0);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox7.Size = new System.Drawing.Size(120, 107);
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.SquareClickListener);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pictureBox8.Location = new System.Drawing.Point(0, 107);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox8.Size = new System.Drawing.Size(120, 107);
            this.pictureBox8.TabIndex = 0;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.SquareClickListener);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Khaki;
            this.pictureBox9.Location = new System.Drawing.Point(120, 107);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox9.Size = new System.Drawing.Size(120, 107);
            this.pictureBox9.TabIndex = 0;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.EmptySquareClickListener);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pictureBox10.Location = new System.Drawing.Point(240, 107);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox10.Size = new System.Drawing.Size(120, 107);
            this.pictureBox10.TabIndex = 0;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.SquareClickListener);
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Khaki;
            this.pictureBox11.Location = new System.Drawing.Point(360, 107);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox11.Size = new System.Drawing.Size(120, 107);
            this.pictureBox11.TabIndex = 0;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.EmptySquareClickListener);
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pictureBox12.Location = new System.Drawing.Point(480, 107);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox12.Size = new System.Drawing.Size(120, 107);
            this.pictureBox12.TabIndex = 0;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Click += new System.EventHandler(this.SquareClickListener);
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Khaki;
            this.pictureBox13.Location = new System.Drawing.Point(600, 107);
            this.pictureBox13.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox13.Size = new System.Drawing.Size(120, 107);
            this.pictureBox13.TabIndex = 0;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Click += new System.EventHandler(this.EmptySquareClickListener);
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pictureBox14.Location = new System.Drawing.Point(720, 107);
            this.pictureBox14.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox14.Size = new System.Drawing.Size(120, 107);
            this.pictureBox14.TabIndex = 0;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Click += new System.EventHandler(this.SquareClickListener);
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.Khaki;
            this.pictureBox15.Location = new System.Drawing.Point(840, 107);
            this.pictureBox15.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox15.Size = new System.Drawing.Size(120, 107);
            this.pictureBox15.TabIndex = 0;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Click += new System.EventHandler(this.EmptySquareClickListener);
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackColor = System.Drawing.Color.Khaki;
            this.pictureBox16.Location = new System.Drawing.Point(0, 214);
            this.pictureBox16.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox16.Size = new System.Drawing.Size(120, 107);
            this.pictureBox16.TabIndex = 0;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.Click += new System.EventHandler(this.EmptySquareClickListener);
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pictureBox17.Location = new System.Drawing.Point(120, 214);
            this.pictureBox17.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox17.Size = new System.Drawing.Size(120, 107);
            this.pictureBox17.TabIndex = 0;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.Click += new System.EventHandler(this.SquareClickListener);
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackColor = System.Drawing.Color.Khaki;
            this.pictureBox18.Location = new System.Drawing.Point(240, 214);
            this.pictureBox18.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox18.Size = new System.Drawing.Size(120, 107);
            this.pictureBox18.TabIndex = 0;
            this.pictureBox18.TabStop = false;
            this.pictureBox18.Click += new System.EventHandler(this.EmptySquareClickListener);
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pictureBox19.Location = new System.Drawing.Point(360, 214);
            this.pictureBox19.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox19.Size = new System.Drawing.Size(120, 107);
            this.pictureBox19.TabIndex = 0;
            this.pictureBox19.TabStop = false;
            this.pictureBox19.Click += new System.EventHandler(this.SquareClickListener);
            // 
            // pictureBox20
            // 
            this.pictureBox20.BackColor = System.Drawing.Color.Khaki;
            this.pictureBox20.Location = new System.Drawing.Point(480, 214);
            this.pictureBox20.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox20.Size = new System.Drawing.Size(120, 107);
            this.pictureBox20.TabIndex = 0;
            this.pictureBox20.TabStop = false;
            this.pictureBox20.Click += new System.EventHandler(this.EmptySquareClickListener);
            // 
            // pictureBox21
            // 
            this.pictureBox21.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pictureBox21.Location = new System.Drawing.Point(600, 214);
            this.pictureBox21.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox21.Size = new System.Drawing.Size(120, 107);
            this.pictureBox21.TabIndex = 0;
            this.pictureBox21.TabStop = false;
            this.pictureBox21.Click += new System.EventHandler(this.SquareClickListener);
            // 
            // pictureBox22
            // 
            this.pictureBox22.BackColor = System.Drawing.Color.Khaki;
            this.pictureBox22.Location = new System.Drawing.Point(720, 214);
            this.pictureBox22.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox22.Size = new System.Drawing.Size(120, 107);
            this.pictureBox22.TabIndex = 0;
            this.pictureBox22.TabStop = false;
            this.pictureBox22.Click += new System.EventHandler(this.EmptySquareClickListener);
            // 
            // pictureBox23
            // 
            this.pictureBox23.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pictureBox23.Location = new System.Drawing.Point(840, 214);
            this.pictureBox23.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox23.Size = new System.Drawing.Size(120, 107);
            this.pictureBox23.TabIndex = 0;
            this.pictureBox23.TabStop = false;
            this.pictureBox23.Click += new System.EventHandler(this.SquareClickListener);
            // 
            // pictureBox24
            // 
            this.pictureBox24.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pictureBox24.Location = new System.Drawing.Point(0, 321);
            this.pictureBox24.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox24.Size = new System.Drawing.Size(120, 107);
            this.pictureBox24.TabIndex = 0;
            this.pictureBox24.TabStop = false;
            this.pictureBox24.Click += new System.EventHandler(this.SquareClickListener);
            // 
            // pictureBox25
            // 
            this.pictureBox25.BackColor = System.Drawing.Color.Khaki;
            this.pictureBox25.Location = new System.Drawing.Point(120, 321);
            this.pictureBox25.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox25.Size = new System.Drawing.Size(120, 107);
            this.pictureBox25.TabIndex = 0;
            this.pictureBox25.TabStop = false;
            this.pictureBox25.Click += new System.EventHandler(this.EmptySquareClickListener);
            // 
            // pictureBox26
            // 
            this.pictureBox26.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pictureBox26.Location = new System.Drawing.Point(240, 321);
            this.pictureBox26.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox26.Size = new System.Drawing.Size(120, 107);
            this.pictureBox26.TabIndex = 0;
            this.pictureBox26.TabStop = false;
            this.pictureBox26.Click += new System.EventHandler(this.SquareClickListener);
            // 
            // pictureBox27
            // 
            this.pictureBox27.BackColor = System.Drawing.Color.Khaki;
            this.pictureBox27.Location = new System.Drawing.Point(360, 321);
            this.pictureBox27.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox27.Size = new System.Drawing.Size(120, 107);
            this.pictureBox27.TabIndex = 0;
            this.pictureBox27.TabStop = false;
            this.pictureBox27.Click += new System.EventHandler(this.EmptySquareClickListener);
            // 
            // pictureBox28
            // 
            this.pictureBox28.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pictureBox28.Location = new System.Drawing.Point(480, 321);
            this.pictureBox28.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox28.Name = "pictureBox28";
            this.pictureBox28.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox28.Size = new System.Drawing.Size(120, 107);
            this.pictureBox28.TabIndex = 0;
            this.pictureBox28.TabStop = false;
            this.pictureBox28.Click += new System.EventHandler(this.SquareClickListener);
            // 
            // pictureBox29
            // 
            this.pictureBox29.BackColor = System.Drawing.Color.Khaki;
            this.pictureBox29.Location = new System.Drawing.Point(600, 321);
            this.pictureBox29.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox29.Name = "pictureBox29";
            this.pictureBox29.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox29.Size = new System.Drawing.Size(120, 107);
            this.pictureBox29.TabIndex = 0;
            this.pictureBox29.TabStop = false;
            this.pictureBox29.Click += new System.EventHandler(this.EmptySquareClickListener);
            // 
            // pictureBox30
            // 
            this.pictureBox30.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pictureBox30.Location = new System.Drawing.Point(720, 321);
            this.pictureBox30.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox30.Name = "pictureBox30";
            this.pictureBox30.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox30.Size = new System.Drawing.Size(120, 107);
            this.pictureBox30.TabIndex = 0;
            this.pictureBox30.TabStop = false;
            this.pictureBox30.Click += new System.EventHandler(this.SquareClickListener);
            // 
            // pictureBox31
            // 
            this.pictureBox31.BackColor = System.Drawing.Color.Khaki;
            this.pictureBox31.Location = new System.Drawing.Point(840, 321);
            this.pictureBox31.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox31.Name = "pictureBox31";
            this.pictureBox31.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox31.Size = new System.Drawing.Size(120, 107);
            this.pictureBox31.TabIndex = 0;
            this.pictureBox31.TabStop = false;
            this.pictureBox31.Click += new System.EventHandler(this.EmptySquareClickListener);
            // 
            // pictureBox32
            // 
            this.pictureBox32.BackColor = System.Drawing.Color.Khaki;
            this.pictureBox32.Location = new System.Drawing.Point(0, 428);
            this.pictureBox32.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox32.Name = "pictureBox32";
            this.pictureBox32.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox32.Size = new System.Drawing.Size(120, 107);
            this.pictureBox32.TabIndex = 0;
            this.pictureBox32.TabStop = false;
            this.pictureBox32.Click += new System.EventHandler(this.EmptySquareClickListener);
            // 
            // pictureBox33
            // 
            this.pictureBox33.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pictureBox33.Location = new System.Drawing.Point(120, 428);
            this.pictureBox33.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox33.Name = "pictureBox33";
            this.pictureBox33.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox33.Size = new System.Drawing.Size(120, 107);
            this.pictureBox33.TabIndex = 0;
            this.pictureBox33.TabStop = false;
            this.pictureBox33.Click += new System.EventHandler(this.SquareClickListener);
            // 
            // pictureBox34
            // 
            this.pictureBox34.BackColor = System.Drawing.Color.Khaki;
            this.pictureBox34.Location = new System.Drawing.Point(240, 428);
            this.pictureBox34.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox34.Name = "pictureBox34";
            this.pictureBox34.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox34.Size = new System.Drawing.Size(120, 107);
            this.pictureBox34.TabIndex = 0;
            this.pictureBox34.TabStop = false;
            this.pictureBox34.Click += new System.EventHandler(this.EmptySquareClickListener);
            // 
            // pictureBox35
            // 
            this.pictureBox35.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pictureBox35.Location = new System.Drawing.Point(360, 428);
            this.pictureBox35.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox35.Name = "pictureBox35";
            this.pictureBox35.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox35.Size = new System.Drawing.Size(120, 107);
            this.pictureBox35.TabIndex = 0;
            this.pictureBox35.TabStop = false;
            this.pictureBox35.Click += new System.EventHandler(this.SquareClickListener);
            // 
            // pictureBox36
            // 
            this.pictureBox36.BackColor = System.Drawing.Color.Khaki;
            this.pictureBox36.Location = new System.Drawing.Point(480, 428);
            this.pictureBox36.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox36.Name = "pictureBox36";
            this.pictureBox36.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox36.Size = new System.Drawing.Size(120, 107);
            this.pictureBox36.TabIndex = 0;
            this.pictureBox36.TabStop = false;
            this.pictureBox36.Click += new System.EventHandler(this.EmptySquareClickListener);
            // 
            // pictureBox37
            // 
            this.pictureBox37.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pictureBox37.Location = new System.Drawing.Point(600, 428);
            this.pictureBox37.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox37.Name = "pictureBox37";
            this.pictureBox37.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox37.Size = new System.Drawing.Size(120, 107);
            this.pictureBox37.TabIndex = 0;
            this.pictureBox37.TabStop = false;
            this.pictureBox37.Click += new System.EventHandler(this.SquareClickListener);
            // 
            // pictureBox38
            // 
            this.pictureBox38.BackColor = System.Drawing.Color.Khaki;
            this.pictureBox38.Location = new System.Drawing.Point(720, 428);
            this.pictureBox38.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox38.Name = "pictureBox38";
            this.pictureBox38.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox38.Size = new System.Drawing.Size(120, 107);
            this.pictureBox38.TabIndex = 0;
            this.pictureBox38.TabStop = false;
            this.pictureBox38.Click += new System.EventHandler(this.EmptySquareClickListener);
            // 
            // pictureBox39
            // 
            this.pictureBox39.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pictureBox39.Location = new System.Drawing.Point(840, 428);
            this.pictureBox39.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox39.Name = "pictureBox39";
            this.pictureBox39.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox39.Size = new System.Drawing.Size(120, 107);
            this.pictureBox39.TabIndex = 0;
            this.pictureBox39.TabStop = false;
            this.pictureBox39.Click += new System.EventHandler(this.SquareClickListener);
            // 
            // pictureBox40
            // 
            this.pictureBox40.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pictureBox40.Location = new System.Drawing.Point(0, 535);
            this.pictureBox40.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox40.Name = "pictureBox40";
            this.pictureBox40.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox40.Size = new System.Drawing.Size(120, 107);
            this.pictureBox40.TabIndex = 0;
            this.pictureBox40.TabStop = false;
            this.pictureBox40.Click += new System.EventHandler(this.SquareClickListener);
            // 
            // pictureBox41
            // 
            this.pictureBox41.BackColor = System.Drawing.Color.Khaki;
            this.pictureBox41.Location = new System.Drawing.Point(120, 535);
            this.pictureBox41.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox41.Name = "pictureBox41";
            this.pictureBox41.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox41.Size = new System.Drawing.Size(120, 107);
            this.pictureBox41.TabIndex = 0;
            this.pictureBox41.TabStop = false;
            this.pictureBox41.Click += new System.EventHandler(this.EmptySquareClickListener);
            // 
            // pictureBox42
            // 
            this.pictureBox42.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pictureBox42.Location = new System.Drawing.Point(240, 535);
            this.pictureBox42.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox42.Name = "pictureBox42";
            this.pictureBox42.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox42.Size = new System.Drawing.Size(120, 107);
            this.pictureBox42.TabIndex = 0;
            this.pictureBox42.TabStop = false;
            this.pictureBox42.Click += new System.EventHandler(this.SquareClickListener);
            // 
            // pictureBox43
            // 
            this.pictureBox43.BackColor = System.Drawing.Color.Khaki;
            this.pictureBox43.Location = new System.Drawing.Point(360, 535);
            this.pictureBox43.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox43.Name = "pictureBox43";
            this.pictureBox43.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox43.Size = new System.Drawing.Size(120, 107);
            this.pictureBox43.TabIndex = 0;
            this.pictureBox43.TabStop = false;
            this.pictureBox43.Click += new System.EventHandler(this.EmptySquareClickListener);
            // 
            // pictureBox44
            // 
            this.pictureBox44.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pictureBox44.Location = new System.Drawing.Point(480, 535);
            this.pictureBox44.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox44.Name = "pictureBox44";
            this.pictureBox44.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox44.Size = new System.Drawing.Size(120, 107);
            this.pictureBox44.TabIndex = 0;
            this.pictureBox44.TabStop = false;
            this.pictureBox44.Click += new System.EventHandler(this.SquareClickListener);
            // 
            // pictureBox45
            // 
            this.pictureBox45.BackColor = System.Drawing.Color.Khaki;
            this.pictureBox45.Location = new System.Drawing.Point(600, 535);
            this.pictureBox45.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox45.Name = "pictureBox45";
            this.pictureBox45.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox45.Size = new System.Drawing.Size(120, 107);
            this.pictureBox45.TabIndex = 0;
            this.pictureBox45.TabStop = false;
            this.pictureBox45.Click += new System.EventHandler(this.EmptySquareClickListener);
            // 
            // pictureBox46
            // 
            this.pictureBox46.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pictureBox46.Location = new System.Drawing.Point(720, 535);
            this.pictureBox46.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox46.Name = "pictureBox46";
            this.pictureBox46.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox46.Size = new System.Drawing.Size(120, 107);
            this.pictureBox46.TabIndex = 0;
            this.pictureBox46.TabStop = false;
            this.pictureBox46.Click += new System.EventHandler(this.SquareClickListener);
            // 
            // pictureBox47
            // 
            this.pictureBox47.BackColor = System.Drawing.Color.Khaki;
            this.pictureBox47.Location = new System.Drawing.Point(840, 535);
            this.pictureBox47.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox47.Name = "pictureBox47";
            this.pictureBox47.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox47.Size = new System.Drawing.Size(120, 107);
            this.pictureBox47.TabIndex = 0;
            this.pictureBox47.TabStop = false;
            this.pictureBox47.Click += new System.EventHandler(this.EmptySquareClickListener);
            // 
            // pictureBox48
            // 
            this.pictureBox48.BackColor = System.Drawing.Color.Khaki;
            this.pictureBox48.Location = new System.Drawing.Point(0, 642);
            this.pictureBox48.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox48.Name = "pictureBox48";
            this.pictureBox48.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox48.Size = new System.Drawing.Size(120, 107);
            this.pictureBox48.TabIndex = 0;
            this.pictureBox48.TabStop = false;
            this.pictureBox48.Click += new System.EventHandler(this.EmptySquareClickListener);
            // 
            // pictureBox49
            // 
            this.pictureBox49.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pictureBox49.Location = new System.Drawing.Point(120, 642);
            this.pictureBox49.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox49.Name = "pictureBox49";
            this.pictureBox49.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox49.Size = new System.Drawing.Size(120, 107);
            this.pictureBox49.TabIndex = 0;
            this.pictureBox49.TabStop = false;
            this.pictureBox49.Click += new System.EventHandler(this.SquareClickListener);
            // 
            // pictureBox50
            // 
            this.pictureBox50.BackColor = System.Drawing.Color.Khaki;
            this.pictureBox50.Location = new System.Drawing.Point(240, 642);
            this.pictureBox50.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox50.Name = "pictureBox50";
            this.pictureBox50.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox50.Size = new System.Drawing.Size(120, 107);
            this.pictureBox50.TabIndex = 0;
            this.pictureBox50.TabStop = false;
            this.pictureBox50.Click += new System.EventHandler(this.EmptySquareClickListener);
            // 
            // pictureBox51
            // 
            this.pictureBox51.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pictureBox51.Location = new System.Drawing.Point(360, 642);
            this.pictureBox51.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox51.Name = "pictureBox51";
            this.pictureBox51.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox51.Size = new System.Drawing.Size(120, 107);
            this.pictureBox51.TabIndex = 0;
            this.pictureBox51.TabStop = false;
            this.pictureBox51.Click += new System.EventHandler(this.SquareClickListener);
            // 
            // pictureBox52
            // 
            this.pictureBox52.BackColor = System.Drawing.Color.Khaki;
            this.pictureBox52.Location = new System.Drawing.Point(480, 642);
            this.pictureBox52.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox52.Name = "pictureBox52";
            this.pictureBox52.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox52.Size = new System.Drawing.Size(120, 107);
            this.pictureBox52.TabIndex = 0;
            this.pictureBox52.TabStop = false;
            this.pictureBox52.Click += new System.EventHandler(this.EmptySquareClickListener);
            // 
            // pictureBox53
            // 
            this.pictureBox53.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pictureBox53.Location = new System.Drawing.Point(600, 642);
            this.pictureBox53.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox53.Name = "pictureBox53";
            this.pictureBox53.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox53.Size = new System.Drawing.Size(120, 107);
            this.pictureBox53.TabIndex = 0;
            this.pictureBox53.TabStop = false;
            this.pictureBox53.Click += new System.EventHandler(this.SquareClickListener);
            // 
            // pictureBox54
            // 
            this.pictureBox54.BackColor = System.Drawing.Color.Khaki;
            this.pictureBox54.Location = new System.Drawing.Point(720, 642);
            this.pictureBox54.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox54.Name = "pictureBox54";
            this.pictureBox54.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox54.Size = new System.Drawing.Size(120, 107);
            this.pictureBox54.TabIndex = 0;
            this.pictureBox54.TabStop = false;
            this.pictureBox54.Click += new System.EventHandler(this.EmptySquareClickListener);
            // 
            // pictureBox55
            // 
            this.pictureBox55.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pictureBox55.Location = new System.Drawing.Point(840, 642);
            this.pictureBox55.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox55.Name = "pictureBox55";
            this.pictureBox55.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox55.Size = new System.Drawing.Size(120, 107);
            this.pictureBox55.TabIndex = 0;
            this.pictureBox55.TabStop = false;
            this.pictureBox55.Click += new System.EventHandler(this.SquareClickListener);
            // 
            // pictureBox56
            // 
            this.pictureBox56.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pictureBox56.Location = new System.Drawing.Point(0, 749);
            this.pictureBox56.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox56.Name = "pictureBox56";
            this.pictureBox56.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox56.Size = new System.Drawing.Size(120, 107);
            this.pictureBox56.TabIndex = 0;
            this.pictureBox56.TabStop = false;
            this.pictureBox56.Click += new System.EventHandler(this.SquareClickListener);
            // 
            // pictureBox57
            // 
            this.pictureBox57.BackColor = System.Drawing.Color.Khaki;
            this.pictureBox57.Location = new System.Drawing.Point(120, 749);
            this.pictureBox57.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox57.Name = "pictureBox57";
            this.pictureBox57.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox57.Size = new System.Drawing.Size(120, 107);
            this.pictureBox57.TabIndex = 0;
            this.pictureBox57.TabStop = false;
            this.pictureBox57.Click += new System.EventHandler(this.EmptySquareClickListener);
            // 
            // pictureBox58
            // 
            this.pictureBox58.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pictureBox58.Location = new System.Drawing.Point(240, 749);
            this.pictureBox58.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox58.Name = "pictureBox58";
            this.pictureBox58.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox58.Size = new System.Drawing.Size(120, 107);
            this.pictureBox58.TabIndex = 0;
            this.pictureBox58.TabStop = false;
            this.pictureBox58.Click += new System.EventHandler(this.SquareClickListener);
            // 
            // pictureBox59
            // 
            this.pictureBox59.BackColor = System.Drawing.Color.Khaki;
            this.pictureBox59.Location = new System.Drawing.Point(360, 749);
            this.pictureBox59.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox59.Name = "pictureBox59";
            this.pictureBox59.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox59.Size = new System.Drawing.Size(120, 107);
            this.pictureBox59.TabIndex = 0;
            this.pictureBox59.TabStop = false;
            this.pictureBox59.Click += new System.EventHandler(this.EmptySquareClickListener);
            // 
            // pictureBox60
            // 
            this.pictureBox60.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pictureBox60.Location = new System.Drawing.Point(480, 749);
            this.pictureBox60.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox60.Name = "pictureBox60";
            this.pictureBox60.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox60.Size = new System.Drawing.Size(120, 107);
            this.pictureBox60.TabIndex = 0;
            this.pictureBox60.TabStop = false;
            this.pictureBox60.Click += new System.EventHandler(this.SquareClickListener);
            // 
            // pictureBox61
            // 
            this.pictureBox61.BackColor = System.Drawing.Color.Khaki;
            this.pictureBox61.Location = new System.Drawing.Point(600, 749);
            this.pictureBox61.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox61.Name = "pictureBox61";
            this.pictureBox61.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox61.Size = new System.Drawing.Size(120, 107);
            this.pictureBox61.TabIndex = 0;
            this.pictureBox61.TabStop = false;
            this.pictureBox61.Click += new System.EventHandler(this.EmptySquareClickListener);
            // 
            // pictureBox62
            // 
            this.pictureBox62.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pictureBox62.Location = new System.Drawing.Point(720, 749);
            this.pictureBox62.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox62.Name = "pictureBox62";
            this.pictureBox62.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox62.Size = new System.Drawing.Size(120, 107);
            this.pictureBox62.TabIndex = 0;
            this.pictureBox62.TabStop = false;
            this.pictureBox62.Click += new System.EventHandler(this.SquareClickListener);
            // 
            // pictureBox63
            // 
            this.pictureBox63.BackColor = System.Drawing.Color.Khaki;
            this.pictureBox63.Location = new System.Drawing.Point(840, 749);
            this.pictureBox63.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox63.Name = "pictureBox63";
            this.pictureBox63.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox63.Size = new System.Drawing.Size(120, 107);
            this.pictureBox63.TabIndex = 0;
            this.pictureBox63.TabStop = false;
            this.pictureBox63.Click += new System.EventHandler(this.EmptySquareClickListener);
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(467, 21);
            this.stateLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(93, 32);
            this.stateLabel.TabIndex = 1;
            this.stateLabel.Text = "label1";
            this.stateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // undoButton
            // 
            this.undoButton.Location = new System.Drawing.Point(192, 937);
            this.undoButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(200, 55);
            this.undoButton.TabIndex = 2;
            this.undoButton.Text = "Undo";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undoClickListener);
            // 
            // moveAIButton
            // 
            this.moveAIButton.Location = new System.Drawing.Point(408, 937);
            this.moveAIButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.moveAIButton.Name = "moveAIButton";
            this.moveAIButton.Size = new System.Drawing.Size(200, 55);
            this.moveAIButton.TabIndex = 3;
            this.moveAIButton.Text = "AI Move";
            this.moveAIButton.UseVisualStyleBackColor = true;
            this.moveAIButton.Click += new System.EventHandler(this.AIClickListener);
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(624, 937);
            this.newGameButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(200, 55);
            this.newGameButton.TabIndex = 4;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameClickListener);
            // 
            // BoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 999);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.moveAIButton);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "BoardForm";
            this.Text = "Checkers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BoardForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BoardForm_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox49)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox53)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox54)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox55)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox56)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox57)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox58)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox59)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox60)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox61)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox62)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox63)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void InitializeSquares()
        {
            squares[0] = new PictureBox[Board.boardLength];
            squares[1] = new PictureBox[Board.boardLength];
            squares[2] = new PictureBox[Board.boardLength];
            squares[3] = new PictureBox[Board.boardLength];
            squares[4] = new PictureBox[Board.boardLength];
            squares[5] = new PictureBox[Board.boardLength];
            squares[6] = new PictureBox[Board.boardLength];
            squares[7] = new PictureBox[Board.boardLength];
            squares[0][0] = pictureBox0;
            squares[1][0] = pictureBox1;
            squares[2][0] = pictureBox2;
            squares[3][0] = pictureBox3;
            squares[4][0] = pictureBox4;
            squares[5][0] = pictureBox5;
            squares[6][0] = pictureBox6;
            squares[7][0] = pictureBox7;
            squares[0][1] = pictureBox8;
            squares[1][1] = pictureBox9;
            squares[2][1] = pictureBox10;
            squares[3][1] = pictureBox11;
            squares[4][1] = pictureBox12;
            squares[5][1] = pictureBox13;
            squares[6][1] = pictureBox14;
            squares[7][1] = pictureBox15;
            squares[0][2] = pictureBox16;
            squares[1][2] = pictureBox17;
            squares[2][2] = pictureBox18;
            squares[3][2] = pictureBox19;
            squares[4][2] = pictureBox20;
            squares[5][2] = pictureBox21;
            squares[6][2] = pictureBox22;
            squares[7][2] = pictureBox23;
            squares[0][3] = pictureBox24;
            squares[1][3] = pictureBox25;
            squares[2][3] = pictureBox26;
            squares[3][3] = pictureBox27;
            squares[4][3] = pictureBox28;
            squares[5][3] = pictureBox29;
            squares[6][3] = pictureBox30;
            squares[7][3] = pictureBox31;
            squares[0][4] = pictureBox32;
            squares[1][4] = pictureBox33;
            squares[2][4] = pictureBox34;
            squares[3][4] = pictureBox35;
            squares[4][4] = pictureBox36;
            squares[5][4] = pictureBox37;
            squares[6][4] = pictureBox38;
            squares[7][4] = pictureBox39;
            squares[0][5] = pictureBox40;
            squares[1][5] = pictureBox41;
            squares[2][5] = pictureBox42;
            squares[3][5] = pictureBox43;
            squares[4][5] = pictureBox44;
            squares[5][5] = pictureBox45;
            squares[6][5] = pictureBox46;
            squares[7][5] = pictureBox47;
            squares[0][6] = pictureBox48;
            squares[1][6] = pictureBox49;
            squares[2][6] = pictureBox50;
            squares[3][6] = pictureBox51;
            squares[4][6] = pictureBox52;
            squares[5][6] = pictureBox53;
            squares[6][6] = pictureBox54;
            squares[7][6] = pictureBox55;
            squares[0][7] = pictureBox56;
            squares[1][7] = pictureBox57;
            squares[2][7] = pictureBox58;
            squares[3][7] = pictureBox59;
            squares[4][7] = pictureBox60;
            squares[5][7] = pictureBox61;
            squares[6][7] = pictureBox62;
            squares[7][7] = pictureBox63;
        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox0;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.PictureBox pictureBox22;
        private System.Windows.Forms.PictureBox pictureBox23;
        private System.Windows.Forms.PictureBox pictureBox24;
        private System.Windows.Forms.PictureBox pictureBox25;
        private System.Windows.Forms.PictureBox pictureBox26;
        private System.Windows.Forms.PictureBox pictureBox27;
        private System.Windows.Forms.PictureBox pictureBox28;
        private System.Windows.Forms.PictureBox pictureBox29;
        private System.Windows.Forms.PictureBox pictureBox30;
        private System.Windows.Forms.PictureBox pictureBox31;
        private System.Windows.Forms.PictureBox pictureBox32;
        private System.Windows.Forms.PictureBox pictureBox33;
        private System.Windows.Forms.PictureBox pictureBox34;
        private System.Windows.Forms.PictureBox pictureBox35;
        private System.Windows.Forms.PictureBox pictureBox36;
        private System.Windows.Forms.PictureBox pictureBox37;
        private System.Windows.Forms.PictureBox pictureBox38;
        private System.Windows.Forms.PictureBox pictureBox39;
        private System.Windows.Forms.PictureBox pictureBox40;
        private System.Windows.Forms.PictureBox pictureBox41;
        private System.Windows.Forms.PictureBox pictureBox42;
        private System.Windows.Forms.PictureBox pictureBox43;
        private System.Windows.Forms.PictureBox pictureBox44;
        private System.Windows.Forms.PictureBox pictureBox45;
        private System.Windows.Forms.PictureBox pictureBox46;
        private System.Windows.Forms.PictureBox pictureBox47;
        private System.Windows.Forms.PictureBox pictureBox48;
        private System.Windows.Forms.PictureBox pictureBox49;
        private System.Windows.Forms.PictureBox pictureBox50;
        private System.Windows.Forms.PictureBox pictureBox51;
        private System.Windows.Forms.PictureBox pictureBox52;
        private System.Windows.Forms.PictureBox pictureBox53;
        private System.Windows.Forms.PictureBox pictureBox54;
        private System.Windows.Forms.PictureBox pictureBox55;
        private System.Windows.Forms.PictureBox pictureBox56;
        private System.Windows.Forms.PictureBox pictureBox57;
        private System.Windows.Forms.PictureBox pictureBox58;
        private System.Windows.Forms.PictureBox pictureBox59;
        private System.Windows.Forms.PictureBox pictureBox60;
        private System.Windows.Forms.PictureBox pictureBox61;
        private System.Windows.Forms.PictureBox pictureBox62;
        private System.Windows.Forms.PictureBox pictureBox63;
        private Label stateLabel;
        private Button undoButton;
        private Button moveAIButton;
        private Button newGameButton;
    }
}