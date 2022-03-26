using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Areglos
{
    public class Player : Board
    {
        public int id { get; set; }
        public string username { get; set; }
        public List<int> userPositions { get; set; }

        public Player (int id_, string username_) : base (3,3)
        {
            id = id_;
            username = username_;
        }

        public void pushPositionToTable(int posToFind)
        {
            bool playerSetter = true;
            List<Positions> availablePositions = getPositions();

            int availablePos = availablePositions.FindIndex(x => x.position == posToFind && x.Available == true);

            if (availablePos >= 0)
            {
                userPositions.Add(posToFind);
                availablePositions[availablePos].Available = false;
                List<int> tablePos = ReasignPos(posToFind);
                if (playerSetter)
                {
                    setValue(1,tablePos[0], tablePos[1]);
                    playerSetter = !playerSetter;
                }
                else
                {
                    setValue(2, tablePos[0], tablePos[1]);
                    playerSetter = !playerSetter;
                }
            }

        }

        public bool setWinner()
        {
            List<int[]> posibilitiesToWin = getWinPosibilities();
            foreach (var item in posibilitiesToWin)
            {
                int[] winningPositions;
                foreach (var position in item)
                {
                    winningPositions.CopyTo(userPositions.Where(i => posibilitiesToWin.Contains(item)).ToArray(),0);
                }
                if (winningPositions == item)
                {
                    return true;
                }
            }
        }

    }
}
