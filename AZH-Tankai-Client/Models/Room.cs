namespace AZH_Tankai_Client.Models
{
   public class Room
    {
        public bool IsPublic { get; set; }
        public string Password { get; set; }
        public short SizeLimit { get; set; }
        public bool IsSurvival { get; set; }
        public short Duration { get; set; }
    }
}
