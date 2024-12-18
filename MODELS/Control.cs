using Microsoft.AspNetCore.Mvc;
using API.DATABASE;
namespace API.MODELS
{
    public class Control : Map
    {
        public string GameMode = "CONTROL";
        public int AttackTicks { get; set; }
        public int DefenceTicks { get; set; }


    }
}