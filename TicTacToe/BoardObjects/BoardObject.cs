using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class BoardObject
    {
        // Tracks which player placed object
        int m_placedByPlayerNumber = -1;
        public BoardObject(int placedByPlayerNumber)
        {
            m_placedByPlayerNumber = placedByPlayerNumber;
        }

        internal void Display()
        {
            if (m_placedByPlayerNumber == 1)
            {
                Console.Write(" X ");
            }
            else if (m_placedByPlayerNumber == 2)
            {
                Console.Write(" O ");
            }
        }
    }
}
