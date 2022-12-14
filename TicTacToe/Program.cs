using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int flag;
        static int player = 1;
        static string namePlayer1 = "";
        static string namePlayer2 = "";

        static void Main(string[] args)
        {

            try
            {
               
              
                string signPlayer2 = "";
                Console.WriteLine("enter a name");
                namePlayer1 = Console.ReadLine();
                while (namePlayer1 == "")
                {
                    Console.WriteLine("wrong name!");
                    Console.WriteLine("enter a name");
                    namePlayer1 = Console.ReadLine();
                }
                Console.WriteLine("enter a sign");
                string signPlayer1 = Console.ReadLine().ToUpper();
                while (signPlayer1 != "X" && signPlayer1 != "O")
                {
                    Console.WriteLine("wrong sign!");
                    Console.WriteLine("enter a sign!");
                    signPlayer1 = Console.ReadLine().ToUpper();

                }
                Console.WriteLine("player2  enter a name ");
                 namePlayer2 = Console.ReadLine();
                while (namePlayer2 == "")
                {
                    Console.WriteLine("wrong name!");
                    Console.WriteLine("enter a name");
                    namePlayer2 = Console.ReadLine();
                }

                if (signPlayer1 == "X")
                    signPlayer2 = "O";
                else
                    signPlayer2 = "X";

                do
                {
                    Console.Clear();//מחיקת המסך
                    Console.WriteLine($"player {namePlayer1} : {signPlayer1} and player 2 {namePlayer2} {signPlayer2}");
                    if (player % 2 == 0)
                    {
                        Console.WriteLine($"name {namePlayer2} turn");
                    }
                    else
                        Console.WriteLine($"name {namePlayer1} turn");
                    DrawBoard();
                    int.TryParse(Console.ReadLine(), out int choice);
                    while (choice < 1 || choice > 9)
                    {
                        Console.WriteLine("error number!enter a number between 1-9");
                        int.TryParse(Console.ReadLine(), out choice);
                    }
                    choice -= 1;
                    if (board[choice] != 'X' && board[choice] != 'O')
                    {
                        DrawSign(ref player, choice, signPlayer1, signPlayer2);
                    }
                    else
                    {
                        Console.WriteLine($"the row {choice + 1} is already marked!");
                    }
                    flag = CheckWin();
                }
                while (flag != 1 && flag!= -1);
                Console.Clear();
                DrawBoard();
                ShowPlayerWin();
                Console.ReadLine();


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
        }

        static void ShowPlayerWin()
        {
            //Console.Clear();
            if(flag == 1)
            {
                if (player % 2 == 0)
                    Console.WriteLine($"player {namePlayer1} won");
                else
                {
                    Console.WriteLine($"player {namePlayer2} won");
                }
            }
            //else if()
            //{

            //}
            else
            {
                Console.WriteLine("tie game");
            }
        }
        static int CheckWin()
        {
            if ( 
                 board[0] == board[1] &&
                 board[1] == board[2] ||
                 board[3] == board[4] &&
                 board[4] == board[5] ||
                 board[6] == board[7] &&
                 board[7] == board[8] ||
                 board[0] == board[3] &&
                 board[3] == board[6] ||
                 board[1] == board[4] &&
                 board[4] == board[7] ||
                 board[2] == board[5] &&
                 board[5] == board[8] ||
                 board[0] == board[4] &&
                 board[4] == board[8] ||
                 board[2] == board[4] &&
                 board[4] == board[6])
            {
                return 1;
            }
            else if (

                    board[0] != '1'
                    && board[1] != '2'
                    && board[2] != '3'
                    && board[3] != '4' 
                    && board[4] != '5'
                    && board[5] != '6' 
                    && board[6] != '7' 
                    && board[7] != '8' 
                    && board[8] != '9')
            {
                return -1;//תיקו
            }
            return 0;

        }
        static void DrawSign(ref int player, int choice, string signPlayer1, string signPlayer2)
        {
            if (player % 2 == 0)
                board[choice] = Convert.ToChar(signPlayer2);
            else
                board[choice] = Convert.ToChar(signPlayer1);
            player++;
        }
        static void DrawBoard()
        {

            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {board[0]}  |  {board[1]}  |  {board[2]}");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {board[3]}  |  {board[4]}  |  {board[5]}");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {board[6]}  |  {board[7]}  |  {board[8]}");
            Console.WriteLine("     |     |      ");
        }
    }
}
