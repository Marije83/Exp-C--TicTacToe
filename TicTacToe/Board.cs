using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Board
    {
        // TODO: change to multidimentional array
        BoardObject[] m_row1 = new BoardObject[3];
        BoardObject[] m_row2 = new BoardObject[3];
        BoardObject[] m_row3 = new BoardObject[3];
      
        public void Display()
        {
            Console.WriteLine("  a   b   c ");
            Console.Write("1");
            DisplayRow(m_row1);              
            Console.WriteLine("------------");
            Console.Write("2");
            DisplayRow(m_row2);
            Console.WriteLine("------------");
            Console.Write("3");
            DisplayRow(m_row3);


            /*
            Console.WriteLine(" a   b  c ");
            Console.WriteLine("1  |  |  ");
            Console.WriteLine(" --------");
            Console.WriteLine("2  |  |  ");
            Console.WriteLine("--------");
            Console.WriteLine("3  |  |  ");
            */
        }

        void DisplayRow(BoardObject[] row)
        {
            for (int i = 0; i < row.Length; i++)
            {
                if (row[i] != null)
                {
                    row[i].Display();
                }
                else
                {
                    Console.Write("   ");
                }
                if (i != row.Length - 1)
                {
                    Console.Write("|");
                }
            }
            Console.WriteLine("");
        }
        
            //rowNumber and ColNumber refer to human input (starts from 1; not 0)
        public bool AddBoardObject(int rowNumber, int colNumber, int playerNumber)
        {
            //TODO: define type of boardObject
            if (rowNumber == 1 && m_row1[colNumber -1] != null)
            {
                return false;
            }
            if (rowNumber == 2 && m_row2[colNumber - 1] != null)
            {
                return false;
            }
            if (rowNumber == 3 && m_row3[colNumber - 1] != null)
            {
                return false;
            }

            BoardObject boardObject = new BoardObject(playerNumber);
            if (rowNumber == 1)
            {
                m_row1[colNumber-1] = boardObject;
            }
            else if (rowNumber == 2)
            {
                m_row2[colNumber -1] = boardObject;
            }
            else if (rowNumber == 3)
            {
                m_row3[colNumber -1] = boardObject;
            }

            return true;
        }
    }


}
