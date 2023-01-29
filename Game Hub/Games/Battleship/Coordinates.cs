using System.Data.Common;

namespace Game_Hub.Games.Battleship
{
    public class Coordinates
    {

        public class Battleship {

            public int Row { get; set; }
            public int Column { get; set; }
        }


        
        public Coordinates(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }
}
