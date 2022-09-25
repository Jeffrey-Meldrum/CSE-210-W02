
using System;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
// main function of the program
        static void Main(string[] args)
        {
        List<string> rowList = makeRows();
        printRows(rowList);
        int winnerNumber = 0;
        int turnnumber = 0;
        while (winnerNumber == 0 && turnnumber != 9)
            {
                string player=determineTurn(turnnumber);
                Console.WriteLine($"It is {player} players turn");
                turnnumber = turnnumber + 1;
                rowList = playerAction(player, rowList);
                printRows(rowList);
                winnerNumber = winnerDeterminer(rowList);
                if (winnerNumber == 1)
                {
                    Console.WriteLine("x is the winner");
                }
                else if (winnerNumber == 2)
                {
                    Console.WriteLine("o is the winner");
                }
                if (turnnumber == 9 && winnerNumber != 1 && winnerNumber != 2)
                {
                    Console.WriteLine("It's a tie");
                }
            }
            }
        
// creates the list for the board
        static List<string> makeRows()
        {
        List<string> rowList = new List<string>();
        rowList.Add("1");
        rowList.Add("2");
        rowList.Add("3");
        rowList.Add("4");
        rowList.Add("5");
        rowList.Add("6");
        rowList.Add("7");
        rowList.Add("8");
        rowList.Add("9");

        return rowList;
        }

// prints the board after every turn
        static void printRows(List<string> rowList)
        {
        Console.WriteLine($"{rowList[0]}|{rowList[1]}|{rowList[2]}");
        Console.WriteLine("-+-+-");
        Console.WriteLine($"{rowList[3]}|{rowList[4]}|{rowList[5]}");
        Console.WriteLine("-+-+-");
        Console.WriteLine($"{rowList[6]}|{rowList[7]}|{rowList[8]}");
        }

// determines whose turn it is 
        static string determineTurn(int turnnumber)
        {
            string player = "x";
            if (turnnumber%2 == 0)
            {
                player = "x";
            }
            if (turnnumber%2 == 1)
            {
                player = "o";
            }
            return player;
        }


// determines if there is a winner
        static int winnerDeterminer(List<string> rowList)
        {
        List<int> winnerNumbers = new List<int>();
        winnerNumbers.Add(0);
        winnerNumbers.Add(1);
        winnerNumbers.Add(2);
        int winner = 0;
        // checks to see if x has won
        if (rowList[0] == "x" && rowList[1] == "x" && rowList[2] == "x")
        {
            winner = winnerNumbers[1];
        }
        else if (rowList[3] == "x" && rowList[4] == "x" && rowList[5] == "x")
        {
            winner = winnerNumbers[1];
        }
        else if (rowList[6] == "x" && rowList[7] == "x" && rowList[8] == "x")
        {
            winner = winnerNumbers[1];
        }
        else if (rowList[0] == "x" && rowList[3] == "x" && rowList[6] == "x")
        {
            winner = winnerNumbers[1];
        }
        else if (rowList[1] == "x" && rowList[4] == "x" && rowList[7] == "x")
        {
            winner = winnerNumbers[1];
        }
        else if (rowList[2] == "x" && rowList[5] == "x" && rowList[8] == "x")
        {
            winner = winnerNumbers[1];
        }
        else if (rowList[0] == "x" && rowList[4] == "x" && rowList[8] == "x")
        {
            winner = winnerNumbers[1];
        }
        else if (rowList[2] == "x" && rowList[4] == "x" && rowList[8] == "x")
        {
            winner = winnerNumbers[1];
        }
        // checks to see if o has won
        else if (rowList[0] == "o" && rowList[1] == "o" && rowList[2] == "o")
        {
            winner = winnerNumbers[2];
        }
        else if (rowList[3] == "o" && rowList[4] == "o" && rowList[5] == "o")
        {
            winner = winnerNumbers[2];
        }
        else if (rowList[6] == "o" && rowList[7] == "o" && rowList[8] == "o")
        {
            winner = winnerNumbers[2];
        }
        else if (rowList[0] == "o" && rowList[3] == "o" && rowList[6] == "o")
        {
            winner = winnerNumbers[2];
        }
        else if (rowList[1] == "o" && rowList[4] == "o" && rowList[7] == "o")
        {
            winner = winnerNumbers[2];
        }
        else if (rowList[2] == "o" && rowList[5] == "o" && rowList[8] == "o")
        {
            winner = winnerNumbers[2];
        }
        else if (rowList[0] == "o" && rowList[4] == "o" && rowList[8] == "o")
        {
            winner = winnerNumbers[2];
        }
        else if (rowList[2] == "o" && rowList[4] == "o" && rowList[8] == "o")
        {
            winner = winnerNumbers[2];
        }
        else
        winner = winnerNumbers[0];
        return winner;
        }

//players action
        static List<string> playerAction(string player, List<string> rowList)
        {
            Boolean validAction = false;
            int tries = 0;
            while (validAction == false)
            {
                if (tries >=1)
                {
                    Console.WriteLine("invalid input");
                }
                Console.WriteLine("What space would you like to fill?");
                string space = Console.ReadLine();
                    for (int i = 0; i < rowList.Count; i++)
                    {
                        if (rowList[i]==space)
                        {
                            rowList[i] = player;
                            validAction = true;
                            break;
                        }
                    }
                    tries = tries + 1;
                }
 
        return rowList;
        }
        }
    }


