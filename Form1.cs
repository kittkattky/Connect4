// Name: (Kylia Hurley)
// CSC339 - Spring 2021
// Assignment 4

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4
{
    public partial class Form1 : Form
    {
        private Board board;
        public Form1()
        {
            InitializeComponent();
            
            //adds the event handler for when the screen is painted
            this.Paint += new PaintEventHandler(pic_board_Paint);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //hides final panel 
            FinalScreen.Hide();
            //gets called when the main form is loaded
            board = new Board();

        }

        private void pic_board_Paint(object sender, PaintEventArgs e)
        {
            //gets called whenever the screen is painted
            board.DrawBoard(e.Graphics);
        }
        private void btncalls(int btn)
        {
            board.placePiece(btn);
            this.Refresh();
            if (board.CheckWin())
            {
                WinnerLabel.Text = board.currentPlayer + " is the winner!!!";
                FinalScreen.Show();
                
            }
            board.NextTurn();
        }

        private void btn_col1_Click(object sender, EventArgs e)
        {
            // places piece in column1
            btncalls(1);
        }

        private void btn_col2_Click(object sender, EventArgs e)
        {
            // places piece in column2
            btncalls(2);
        }

        private void btn_col3_Click(object sender, EventArgs e)
        {
            // places piece in column3
            btncalls(3);
        }

        private void btn_col4_Click(object sender, EventArgs e)
        {
            // places piece in column4
            btncalls(4);
        }

        private void btn_col5_Click(object sender, EventArgs e)
        {
            // places piece in column5
            btncalls(5);
        }

        private void btn_col6_Click(object sender, EventArgs e)
        {
            // places piece in column6
            btncalls(6);
        }

        private void btn_col7_Click(object sender, EventArgs e)
        {
            // places piece in column7
            btncalls(7);
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            
            board.ResetBoard();
            FinalScreen.Hide();
            this.Refresh();


        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

