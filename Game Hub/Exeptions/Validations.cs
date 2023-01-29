using Game_Hub.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Hub.Validations;

public static class Validations
{
    // verificar se tem no minimo dois jogadores registrados na lista.
    public static bool CheckTwoPlayers()
    {
        if(Player.All.Count < 2)
        {
            return false;
        }
        return true;
    }

}
