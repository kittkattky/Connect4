using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4
{
    enum Player
    {
        EMPTY, RED, YELLOW
    }
    class Board
    {
        private const int rows = 6;
        private const int cols = 7;
        private Player[,] board = new Player[rows,cols];
        public Player currentPlayer = Player.EMPTY;
        private int lastrow = 0;
        private int lastcol = 0;

        public Board()
        {
            //constructor
            ResetBoard();
            currentPlayer = Player.RED;
        }

        public void ResetBoard()
        {
            //reset the game board to empty
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    board[i, j] = Player.EMPTY;
                }
            }
            
        }

        public void DrawBoard(Graphics g)
        {
            int start = 50; //board top left corner offset

            g.FillRectangle(Brushes.Navy, start, start, 700, 600);

            //draw the board columns
            for(int i = 100;i<=600;i = i+100)
                g.DrawLine(Pens.White, start + i, start, start + i, start + 600);

            //draw the board rows
            for (int i = 100; i <= 500; i = i + 100)
                g.DrawLine(Pens.White, start, start + i, start + 700, start + i);


            for (int i= 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (board[i, j] == Player.RED)
                    {
                        g.FillEllipse(Brushes.Red, (start + 5) + (j * 100), (start + 5) + (i * 100), 90, 90);
                    }
                    else if (board[i, j] == Player.YELLOW)
                    {
                        g.FillEllipse(Brushes.Yellow, (start + 5) + (j * 100), (start + 5) + (i * 100), 90, 90);
                    }
                    else
                    {
                        g.FillEllipse(Brushes.White, (start + 5) + (j * 100), (start + 5) + (i * 100), 90, 90);
                    }
                }
            }
        }
        internal Player NextTurn()
        {
            if (currentPlayer == Player.RED) {
                currentPlayer= Player.YELLOW;
            }
            else {
                    currentPlayer= Player.RED;
            }
            return currentPlayer;
        }
        internal Boolean CheckWin()
        {
            int searchrow;
            int searchcol;
            int inARow;
            Boolean winner = false;

            // left to right
            inARow = 1;
            searchrow = lastrow;
            searchcol = lastcol - 1;
            while (searchcol >= 0 && board[searchrow,searchcol] == currentPlayer)
            {
                inARow++;
                searchcol--;
            }
            searchrow = lastrow;
            searchcol = lastcol + 1;
            while (searchcol < cols && board[searchrow, searchcol] == currentPlayer)
            {
                inARow++;
                searchcol++;
            }
            if (inARow >= 4)
            {
                winner = true;
            }
            // top to bottom
            inARow = 1;
            searchrow = lastrow - 1;
            searchcol = lastcol;
            while (searchrow >= 0 && board[searchrow,searchcol] == currentPlayer)
            {
                inARow++;
                searchrow--;
            }
            searchrow = lastrow + 1;
            searchcol = lastcol;
            while (searchrow < rows && board[searchrow, searchcol] == currentPlayer)
            {
                inARow++;   
                searchrow++; 
            }
            if (inARow >= 4)
            {
                winner = true;
            }

            //top left to bottom right
            inARow = 1;
            searchrow = lastrow - 1;
            searchcol = lastcol - 1;
            while (searchrow >= 0 && searchcol >= 0 && board[searchrow, searchcol] == currentPlayer)
            {
                inARow++;
                searchrow--;
                searchcol--;
            }
            searchrow = lastrow + 1;
            searchcol = lastcol + 1;
            while (searchrow < rows && searchcol < cols && board[searchrow, searchcol] == currentPlayer)
            {
                inARow++;
                searchrow++;
                searchcol++;
            }
            if (inARow >= 4)
            {
                winner = true;
            }

            //bottom left to top right
            inARow = 1;
            searchrow = lastrow + 1;
            searchcol = lastcol - 1;
            while (searchrow < rows && searchcol >= 0 && board[searchrow, searchcol] == currentPlayer)
            {
                inARow++;
                searchrow++;
                searchcol--;
            }
            searchrow = lastrow - 1;
            searchcol = lastcol + 1;
            while (searchrow >= 0 && searchcol < cols && board[searchrow, searchcol] == currentPlayer)
            {
                inARow++;
                searchrow--;
                searchcol++;
            }
            if (inARow >= 4)
            {
                winner = true;
            }


            return winner;
        }
        internal void placePiece(int col)
        {
          
            col--;
            int row = rows-1;
            while ((row >= 0) && (board[row, col] != Player.EMPTY))
            {
                row--;
            }
            if (row < 0)
            {
                return;
            }
                
            board[row, col] = currentPlayer;
            lastrow = row;
            lastcol = col;
           
            
        }
    }
}

