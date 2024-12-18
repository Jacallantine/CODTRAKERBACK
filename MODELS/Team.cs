namespace API.MODELS{
    public class Team
    {
        public string TeamName { get; set;}

        public List<Player> Players { get; set;} = new List<Player>();

    }
}