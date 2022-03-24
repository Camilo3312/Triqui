using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Areglos
{
    public class Board
    {
        private int rows { get; set; }
        private int columns { get; set; }
        private int[,] Table { get; set; }
        private List<int[]> positionToWin { get; set; }
        private Player player1 { set; get; }
        private Player player2 { set; get; }
        public Board(int rows_, int columns_)
        {
            rows = rows_;
            columns = columns_;
            Table = new int[rows, columns];
            positionToWin = new List<int[]>{ new int[] { 0, 1, 2 }, new int[] { 3, 4, 5 }, new int[] { 6, 7, 8 }, new int[] { 0, 3, 6 }, new int[] { 1, 4, 7 }, new int[] { 2, 5, 8 }, new int[] { 0, 4, 9 }, new int[] { 3, 4, 7} };
        } 
        public void setValue(int value, int row, int column)
        {
            Table[row, column] = value;
        }
        public void calcWinner()
        {

        }

    }
}
