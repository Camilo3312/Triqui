using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Areglos
{
    public class Board : Positions
    {
        private int rows { get; set; }
        private int columns { get; set; }
        private int[,] Table { get; set; }
        private List<int[]> positionToWin { get; set; }
        private Player player1 { set; get; }
        private Player player2 { set; get; }
        private List<Positions> availablePos { set; get; }


        public Board(int rows_, int columns_)
        {
            rows = rows_;
            columns = columns_;
            Table = new int[rows, columns];
            positionToWin = new List<int[]> { new int[] { 0, 1, 2 }, new int[] { 3, 4, 5 }, new int[] { 6, 7, 8 }, new int[] { 0, 3, 6 }, new int[] { 1, 4, 7 }, new int[] { 2, 5, 8 }, new int[] { 0, 4, 9 }, new int[] { 3, 4, 7 } };

            availablePos = new List<Positions> { 

                new Positions(1, true),
                new Positions(2, true),
                new Positions(3, true),
                new Positions(4, true),
                new Positions(5, true),
                new Positions(6, true),
                new Positions(7, true),
                new Positions(8, true),
                new Positions(9, true)

                };
        }    
        public void setValue(int value, int row, int column)
        {
            Table[row, column] = value;
        }
        public List<int> ReasignPos(int posToReasign)
        {
            List<int> reasignedPos = new List<int>();

            switch (posToReasign)
            {
                case 1:
                    reasignedPos.Add(0);
                    reasignedPos.Add(0);
                    break;
                case 2:
                    reasignedPos.Add(0);
                    reasignedPos.Add(1);
                    break;
                case 3:
                    reasignedPos.Add(0);
                    reasignedPos.Add(2);
                    break;
                case 4:
                    reasignedPos.Add(1);
                    reasignedPos.Add(0);
                    break;
                case 5:
                    reasignedPos.Add(1);
                    reasignedPos.Add(1);
                    break;
                case 6:
                    reasignedPos.Add(1);
                    reasignedPos.Add(2);
                    break;
                case 7:
                    reasignedPos.Add(2);
                    reasignedPos.Add(0);
                    break;
                case 8:
                    reasignedPos.Add(2);
                    reasignedPos.Add(1);
                    break;
                case 9:
                    reasignedPos.Add(2);
                    reasignedPos.Add(2);
                    break;
            }

            return reasignedPos;
        }

        public List<Positions> getPositions()
        {
            return availablePos;
        }

        public List<int[]> getWinPosibilities()
        {
            return positionToWin;
        }

    }
}
