namespace Game_Hub.Model
{
    public class Player
    {
        public static List<Player> All = new List<Player>();
        public string Name { get; set; }
        public string ID { get; set; }

        public int PontosTictactoe { get; set; }
        public int PontosBattleShip { get; set; }

        public Player(string name)
        {
            Name = name;
            
        }   

        public void VitoriaTictactoe()
        {
            this.PontosTictactoe++;
        }
        public void VitoriaBattleShip()
        {
            this.PontosTictactoe++;
        }
        
    }

   
}