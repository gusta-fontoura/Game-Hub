using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Hub.Model;

namespace Game_Hub.Games
{
    public static class TicTacToe
    {
        public static void Play()
        {
            char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            int player = 1;
            int choice;
            int flag = 0;
            var player1 = Player.All[0];
            var player2 = Player.All[1];
            
                do
                {
                    Console.Clear();
                Console.WriteLine($"Player 1: {player1.Name} is X and Player 2: {player2.Name} is O");
                    Console.WriteLine("\n");
                    if (player % 2 == 0)
                    {
                        Console.WriteLine($"{player2.Name} Chance");
                    }
                    else
                    {
                        Console.WriteLine($"{player1.Name} Chance");
                    }
                    Console.WriteLine("\n");
                    Board(arr);
                    choice = int.Parse(Console.ReadLine());

                    if (arr[choice] != 'X' && arr[choice] != 'O')
                    {
                        if (player % 2 == 0)
                        {
                            arr[choice] = 'O';
                            player++;
                        }
                        else
                        {
                            arr[choice] = 'X';
                            player++;
                        }
                    }
                    else

                    {
                        Console.WriteLine("Sorry the row {0} is already marked with {1}", choice, arr[choice]);
                        Console.WriteLine("\n");
                        Console.WriteLine("Please wait 2 second board is loading again.....");
                        Thread.Sleep(2000);
                    }

                    flag = CheckWin(arr);
                }
                while (flag != 1 && flag != -1);

                Console.Clear();
                Board(arr);
                if (flag == 1)

                {
                    int win = (player % 2) + 1;
                Console.WriteLine($"{Player.All[win - 1].Name} has won");
                Player.All[win - 1].VitoriaTictactoe();
                Console.WriteLine($"The player{Player.All[win - 1].Name} has {Player.All[win - 1].PontosTictactoe} points.");
                }
                else
                {
                    Console.WriteLine("Draw");
                }
                Console.ReadLine();
        }

            static void Board(char[] arr)
            {
                Console.WriteLine("     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
                Console.WriteLine("_____|_____|_____ ");
                Console.WriteLine("     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
                Console.WriteLine("_____|_____|_____ ");
                Console.WriteLine("     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
                Console.WriteLine("     |     |      ");
            }

        static int CheckWin(char[] arr)
            {


                if (arr[1] == arr[2] && arr[2] == arr[3])
                {
                    return 1;
                }

                else if (arr[4] == arr[5] && arr[5] == arr[6])
                {
                    return 1;
                }

                else if (arr[6] == arr[7] && arr[7] == arr[8])
                {
                    return 1;
                }


                else if (arr[1] == arr[4] && arr[4] == arr[7])
                {
                    return 1;
                }

                else if (arr[2] == arr[5] && arr[5] == arr[8])
                {
                    return 1;
                }

                else if (arr[3] == arr[6] && arr[6] == arr[9])
                {
                    return 1;
                }

                else if (arr[1] == arr[5] && arr[5] == arr[9])
                {
                    return 1;
                }
                else if (arr[3] == arr[5] && arr[5] == arr[7])
                {
                    return 1;
                }

                else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
                {
                    return -1;
                }

                else
                {
                    return 0;
                }
            }
        
    }
}
