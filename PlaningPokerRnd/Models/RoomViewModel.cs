using System.Collections.Generic;

namespace PlaningPokerRnd.Models
{
    public class RoomViewModel
    {
        public RoomViewModel()
        {
            Participants = new List<ParticipantViewModel>();
        }

        public List<ParticipantViewModel> Participants { get; set; }
    }
}