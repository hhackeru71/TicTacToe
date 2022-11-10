using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
			try
			{   int player = 1;
                string signPlayer2 = "";
                Console.WriteLine("enter a name");
                string namePlayer1 = Console.ReadLine();
                while (namePlayer1 == "")
                {
                    Console.WriteLine("wrong name!");
                    Console.WriteLine("enter a name");
                    namePlayer1 = Console.ReadLine();
                }
                Console.WriteLine("enter a sign");
                string signPlayer1 = Console.ReadLine().ToUpper();
                while(signPlayer1 !="X" && signPlayer1 !="O")
                {
                    Console.WriteLine("wrong sign!");
                    signPlayer1 = Console.ReadLine().ToUpper();
                        
                }
                Console.WriteLine("player2  enter a name ");
                string namePlayer2 = Console.ReadLine();
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
                    DrawBoard();
                }
                while ();




            }
			catch (Exception ex)
			{

				Console.WriteLine(ex.ToString());
			}
        }

        static void DrawBoard()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {1}  |  {2}  |  {3}");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {4}  |  {5}  |  {6}");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {7}  |  {8}  |  {9}");
            Console.WriteLine("     |     |      ");
        }
    }
}
