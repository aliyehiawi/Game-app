using System.ComponentModel.DataAnnotations;

namespace GameApp.Data
{
    public class Game
    {
        [Key]
        public int idGame { get; set; }
        public string fullName { get; set; }
        public int number1 { get; set; }
        public int number2 { get; set; }
        public int wonAmount { get; set; }
    }
}
