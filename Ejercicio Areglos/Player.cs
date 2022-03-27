using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Areglos
{
    public class Player
    {
        public int id { get; set; }
        public string username { get; set; }
        public List<int> userPositions { get; set; }

        Board board = new Board();

        public Player (int id_, string username_, Board board_) 
        {
            this.id = id_;
            this.username = username_;
            this.board = board_;

            userPositions = new List<int> { 0 };
        }

        public void pushPositionToTable(int posToFind)
        {
            bool playerSetter = board.getPlayerSetter();
            List<Positions> availablePositions = board.getPositions();

            int availablePos = availablePositions.FindIndex(x => x.position == posToFind && x.Available == true);

            if (availablePos >= 0)
            {
                userPositions.Add(posToFind);
                availablePositions[availablePos].Available = false;
                List<int> tablePos = board.ReasignPos(posToFind);
                if (playerSetter)
                {
                    board.setValue('X',tablePos[0], tablePos[1]);
                    board.setPlayerSetter(false);
                }
                else
                {
                    board.setValue('O', tablePos[0], tablePos[1]);
                    board.setPlayerSetter(true);
                }
            }
        }

        public bool setWinner()
        {
            List<int[]> posibilitiesToWin = board.getWinPosibilities();

            foreach (var item in posibilitiesToWin)
            {
                var secondNotFirst = item.Except(userPositions).ToList();

                if (secondNotFirst.Count > 0)
                {
                    secondNotFirst.Clear();
                }
                else if (secondNotFirst.Count == 0)
                {
                    board.setWinner(this.username);
                    return true;
                }
            }
            return false;
        }

    }
}
