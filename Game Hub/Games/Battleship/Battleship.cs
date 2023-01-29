using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using static Game_Hub.Games.Battleship.Battleship.Panel.Ship;


namespace Game_Hub.Games.Battleship
{
    public static void Play()
    {
        


        
        public enum OccupationType
        {
            [Description("o")]
            Empty,

            [Description("B")]
            Battleship,

            [Description("C")]
            Cruiser,

            [Description("D")]
            Destroyer,

            [Description("S")]
            Submarine,

            [Description("A")]
            Carrier,

            [Description("X")]
            Hit,

            [Description("M")]
            Miss
        }

        public class Panel
        {
            public OccupationType OccupationType { get; set; }
            public Coordinates Coordinates { get; set; }

            public Panel(int row, int column)
            {
                Coordinates = new Coordinates(row, column);
                OccupationType = OccupationType.Empty;
            }

            public string Status
            {
                get
                {
                    return OccupationType.GetType().Name;
                }
            }

            public bool IsOccupied
            {
                get
                {
                    return OccupationType == OccupationType.Battleship
                    || OccupationType == OccupationType.Destroyer
                    || OccupationType == OccupationType.Cruiser
                    || OccupationType == OccupationType.Submarine
                    || OccupationType == OccupationType.Carrier;
                }
            }

            public bool isRandomAvailable
            {
                get
                {
                    return (Coordinates.Row % 2 == 0 && Coordinates.Column % 2 == 0)
                || (Coordinates.Row % 2 == 1 && Coordinates.Column % 2 == 1);
                }
            }

            public abstract class Ship
            {
                public string Name { get; set; }
                public int Width { get; set; }
                public int Hits { get; set; }
                public OccupationType OccupationType { get; set; }
                public bool isSunk
                {
                    get
                    {
                        return Hits >= Width;
                    }
                }
                public class Destroyer : Ship
                {
                    public Destroyer()
                    {
                        Name = "Destroyer";
                        Width = 2;
                        OccupationType = OccupationType.Destroyer;
                    }
                }

                public class Submarine : Ship
                {
                    public Submarine()
                    {
                        Name = "Submarine";
                        Width = 3;
                        OccupationType = OccupationType.Submarine;
                    }
                }

                public class Cruiser : Ship
                {
                    public Cruiser()
                    {
                        Name = "Cruiser";
                        Width = 3;
                        OccupationType = OccupationType.Cruiser;
                    }
                }

                public class Battleship : Ship
                {
                    public Battleship()
                    {
                        Name = "Battleship";
                        Width = 4;
                        OccupationType = OccupationType.Battleship;
                    }
                }

                public class Carrier : Ship
                {
                    public Carrier()
                    {
                        Name = "Aircraft Carrier";
                        Width = 5;
                        OccupationType = OccupationType.Carrier;
                    }
                }

                public class GameBoard
                {
                    public List<Panel> Panels { get; set; }

                    public GameBoard()
                    {
                        Panels = new List<Panel>();
                        for (int i = 1; i <= 8; i++)
                        {
                            for (int j = 1; j <= 8; j++)
                            {
                                Panels.Add(new Panel(i, j));
                            }
                        }
                    }
                }

            }
            public class FiringBoard : GameBoard
            {
                public List<Coordinates> GetOpenRandomPanels() { }

                public List<Coordinates> GetHitNeighbors() { }

                public List<Panel> Getneighbors(Coordinates coordinates) { }
            }

            public class Player
            {
                public string Name { get; set; }
                public GameBoard GameBoard { get; set; }
                public FiringBoard FiringBoard { get; set; }
                public List<Ship> Ships { get; set; }
                public bool HasLost
                {
                    get
                    {
                        return Ships.All(x => x.IsSunk);
                    }
                }

                public Player(string name)
                {
                    Name = name;
                    Ships = new List<Ship>()
                    {
                        new Destroyer(),
                        new Submarine(),
                        new Cruiser(),
                        new Battleship(),
                        new Carrier()
                    };
                    GameBoard = new GameBoard();
                    FiringBoard = new FiringBoard();
                }
            }

        }
    }
}
    
}
