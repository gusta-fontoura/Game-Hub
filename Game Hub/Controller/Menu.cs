using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Game_Hub.Games;
using Game_Hub.Model;
using Game_Hub.Validations;
using Microsoft.VisualBasic.FileIO;


namespace Game_Hub.Controller
{
    public class Menu
    {
        public static void Inicio()
        {
            Console.WriteLine("Bem-vindo ao GameBug");
            Console.WriteLine("Digite qualquer tecla para continuar.");
            Console.ReadKey();
        }

        public static void ShowMenu()
        {
            Console.Clear();
            int option = -1;
            Console.WriteLine("Digite a opção desejada.");
            Console.WriteLine();
            Console.WriteLine("1 - Registre um jogador.");
            Console.WriteLine("2 - Entre no Game Bug.");
            Console.WriteLine("3 - Lista de jogadores.");
            Console.WriteLine("0 - Sair do menu");
            Console.WriteLine();
            do
            {
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 0:// sair
                        System.Environment.Exit(0);
                        break;
                    case 1:// register
                        RegisterPlayer();
                        break;
                    case 2:// start game
                        StartMenu();
                        break;
                    case 3:
                        ShowPlayers();
                        break;
                }
                break;
            }
            while (option != 0);
        }
        public static void ShowPlayers()
        {
            Console.WriteLine("Lista de jogadores\n\n");
            for(int i = 0; i < Player.All.Count; i++)
            {
                Console.WriteLine($"{i} - {Player.All[i].Name}");
            }
            Console.ReadLine();
        }

        public static void StartMenu()
        {
            int option = -1;
            Console.Clear();
            Console.WriteLine("Escolha o jogo que deseja jogar:");
            Console.WriteLine();
            Console.WriteLine("1 - Jogo da velha.");
            Console.WriteLine("2 - Jogo da batalha naval.");// TODO:falta adicionar o jogo
            Console.WriteLine("0 - Voltar ao menu princial.");

            do
            {
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 0:// sair
                        ShowMenu();
                        break;
                    case 1:// start jogo da velha
                        while (Validations.Validations.CheckTwoPlayers() == false)
                        {
                            Console.WriteLine("Número mínimo de jogadores não atingido.\nMin: 2.\n\nRegistre um novo jogador!");
                            RegisterPlayer();
                        }
                        TicTacToe.Play();
                        break;
                    case 2:// start game
                        
                        break;
                }
                break;
            }
            while (option != 0);

        }

        public static void RegisterPlayer()
        {
            Console.Write("Qual o seu nome: ");
            string name = Console.ReadLine();
            if (!IsNameExist(name)) 
            {
                Player player = new Player(name);
                Player.All.Add(player);
                Console.WriteLine("Registrado com sucesso.");
                Console.ReadLine();
                ShowMenu();
            }

            Console.WriteLine("Já existe um player com esse nome. Por favor, digite outro nome");
            Console.ReadKey();
            RegisterPlayer();
        }

        public static string GetName()
        {
            //pegar o nome para fazer checagens

            Console.WriteLine("Digite o seu nome: ");
            string name = Console.ReadLine();
            return name;
           
        }

        public static bool IsNameExist(string name)
        {// checar se o nome ja esxisste na lista

            foreach (Player player in Player.All)
            {
                if (player.Name == name) return true;

            }
            return false;

        }


    }
}
