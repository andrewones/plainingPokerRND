using System.Collections.Generic;

namespace PlaningPokerRnd.Models
{
    public class RoomViewModel
    {
        public RoomViewModel()
        {
            Participants = new List<ParticipantViewModel>();
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public List<ParticipantViewModel> Participants { get; set; }
    }
}