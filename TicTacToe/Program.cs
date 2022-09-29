using System;
using System.Collections.Generic;
using TicTacToe;

// Class Board
//  9 elements - multi-dimensional. 3 rows or 3 columns.
// Base boardObject - empty/nought/cross

// Tasks for Marije:
// - Ask player's for their names and display them on their turn

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Tic Tac Toe");

Board myBoard = new Board();
// Explain this
Game myGame = new Game(myBoard);

Console.WriteLine("\n");

while (myGame.UserHasQuit() == false)
{
    myBoard.Display(); 
    myGame.WritePlayerTurnPrompt(); 
}


