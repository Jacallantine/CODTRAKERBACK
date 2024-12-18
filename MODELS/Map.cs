namespace API.MODELS
{
    public abstract class Map
    {
        public string MapName { get; }
        public string PlayerName { get; }
        public string GameMode { get; }
        public int Kills { get; }
        public int Deaths { get; }
    }
}