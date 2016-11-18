using System.Collections.Generic;

namespace PlaningPokerRnd.Models
{
    // Models returned by MeController actions.
    public class MainViewModel
    {
        public MainViewModel()
        {
            Rooms = new List<RoomListItemViewModel>();
        }

        public List<RoomListItemViewModel> Rooms { get; set; }
    }
}