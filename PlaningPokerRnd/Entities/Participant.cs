using System.ComponentModel.DataAnnotations.Schema;

namespace PlaningPokerRnd.Entities
{
    public class Participant
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string NickName { get; set; }
    }
}