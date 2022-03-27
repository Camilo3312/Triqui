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
        private char[,] Table { get; set; }
        private List<int[]> positionToWin { get; set; }
        private bool playerSetter { set; get; }
        private string winner { set; get; }
        private List<Positions> availablePos { set; get; }

        public Board()
        {
            this.playerSetter = true;
            Table = new char[3, 3];
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    Table[x, y] = ' ';
                }
            }
            positionToWin = new List<int[]> { new int[] { 0, 1, 2, 3 }, new int[] { 0, 4, 5, 6 }, new int[] { 0, 7, 8, 9 }, new int[] { 0, 1, 4, 7 }, new int[] { 0, 2, 5, 8 }, new int[] { 0, 3, 6, 9 }, new int[] { 0, 1, 5, 9 }, new int[] { 0, 3, 5, 7 } };         
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

        public string VisualTable(char[,] table)
        {
            var vTable = "";

            vTable = "┌───┬───┬───┐\n";
            vTable += $"│ {table[0, 0]} │ {table[0, 1]} │ {table[0, 2]} │\n";
            vTable += "├───┼───┼───┤\n";
            vTable += $"│ {table[1, 0]} │ {table[1, 1]} │ {table[1, 2]} │\n";
            vTable += "├───┼───┼───┤\n";
            vTable += $"│ {table[2, 0]} │ {table[2, 1]} │ {table[2, 2]} │\n";
            vTable += "└───┴───┴───┘\n";

            return vTable;
        }


        public void setPlayerSetter(bool value)
        {
            this.playerSetter = value;
        }

        public bool getPlayerSetter()
        {
            return this.playerSetter;
        }

        public void setValue(char value, int row, int column)
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

        public string getWinner()
        {
            return winner;
        }

        public char[,] getTable()
        {
            return Table;
        }

        public void setWinner(string player)
        {
            this.winner = player;
        }

    }
}
