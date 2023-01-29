using Game_Hub.Controller;
using System.Reflection.PortableExecutable;
using Game_Hub.Model;
using Game_Hub.Games;
//todo: criar verificar para escolher player, criar arquivo separado de exceptions;
//todo: cirar LeaderBoard
namespace GameHub
{
    public class Program
    {

        public static void Main(String[] args)
        {
            List<Player> players = new List<Player>();
            Menu.Inicio();

            Menu.ShowMenu();
            

           
        }

    }
}