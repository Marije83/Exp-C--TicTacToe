using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    // Game - handles game state, and manages players
    class Game
    {
        int m_currentPlayerNumber = 1;
        List<string> m_validStrings = new List<string>();
        List<string> m_validQuitStrings = new List<string>();
        bool m_userHasQuit = false;
        Board m_board;
        
        public Game(Board board)
        {
            m_board = board;
            InitialiseValidValues();
        }

        private void InitialiseValidValues()
        {
            CreateBoardCellValues('a', '1', null);
            CreateBoardCellValues('a', '1', ' ');
            CreateBoardCellValues('1', 'a', null);
            CreateBoardCellValues('1', 'a', ' ');
            m_validQuitStrings.Add("q");
            m_validQuitStrings.Add("Q");
        }

        private void CreateBoardCellValues(char startFirstChar, char secondSecondChar, char? cellSeparator)
        {
            // For every letter, loop over the number 3 times
            char letter = startFirstChar;
            for (int i = 0; i < 3; i++)
            {
                char number = secondSecondChar;

                for (int j = 0; j < 3; j++)
                {
                    if (cellSeparator != null)
                    {
                        string newValidStr = letter.ToString() + cellSeparator.ToString() + number.ToString(); 
                        m_validStrings.Add(newValidStr);
                    }
                    else
                    {
                        m_validStrings.Add(letter + number.ToString());
                    }
                    number++;
                }

                // Go to next letter
                letter++;
            }
        }

        public void WritePlayerTurnPrompt()
        {
            // Use a player index and display that
            Console.WriteLine("Player " + m_currentPlayerNumber + " turn");

            string? userInput = PromptUserForInput();

            // Keep looping until we get valid input cell
            // Validate each string input from the user via PromptUserForCellLocation
            while (true)
            {
                if (IsValid(userInput) == false && IsValidQuitString(userInput)==false)
                {
                    Console.WriteLine("Sorry, that is not a valid cell location. Please use the format 'a1' or '1a'");
                    userInput = PromptUserForInput();
                }
                else
                {
                    break;
                }
            }

            ProcessUserCommand(userInput);

            if (m_currentPlayerNumber == 1)
            {
                m_currentPlayerNumber = 2;
            }
            else
            {
                m_currentPlayerNumber = 1;
            }
        }

        private void ProcessUserCommand(string? userCellLocation)
        {
            // Does the input match any of the quit strings
            if (m_validQuitStrings.Contains(userCellLocation))
            {
                m_userHasQuit = true;
                return;
            }

            int rowIndex = -1;
            int colIndex = -1;
            
            if (userCellLocation.Contains("a"))
            {
                colIndex = 1;
            }
            else if(userCellLocation.Contains("b"))
            {
                colIndex = 2;
            }
            else if(userCellLocation.Contains("c"))
            {
                colIndex = 3;
            }
            
            if (userCellLocation.Contains("1"))
            {
                rowIndex = 1;
            }
            else if (userCellLocation.Contains("2"))
            {
                rowIndex = 2;
            }
            else if (userCellLocation.Contains("3"))
            {
                rowIndex = 3;
            }

            //TODO: flip playernumber
            if (colIndex != -1 && rowIndex != -1)
            {
                m_board.AddBoardObject(rowIndex, colIndex, m_currentPlayerNumber);
            }


        }

        private string? PromptUserForInput()
        {
            Console.Write("Please enter cell location or press 'q' to quit: ");
            return Console.ReadLine();
        }

        private bool IsValid(string? userCellLocation)
        {
            if (userCellLocation == null)
            {
                Console.WriteLine("Please enter a non-empty string");
                return false;
            }

            return m_validStrings.Contains(userCellLocation);
        }

        private bool IsValidQuitString(string? userInput)
        {
            return m_validQuitStrings.Contains(userInput);
        }

        public bool UserHasQuit()
        {
            return m_userHasQuit;
        }

        void QuitPrompt()
        {
            
        }
    }
}
