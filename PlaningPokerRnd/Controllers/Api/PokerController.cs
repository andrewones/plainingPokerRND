using System.Web.Http;
using PlaningPokerRnd.Models;

namespace PlaningPokerRnd.Controllers.Api
{
    public class PokerController : ApiController
    {

        [HttpGet]
        public MainViewModel Rooms()
        {
            var retval = new MainViewModel();
            using (var context = new PokerDbContext())
            {
                var rooms =context.Rooms.ToList();
                foreach (var room in rooms)
                {
                    retval.Rooms.Add(new RoomListItemViewModel() {Code =room.Code, Name = room.Name});
                }
            }
            return retval;
        }

        [HttpGet]
        public RoomViewModel Rooms(string code)
        {
            var retval= new RoomViewModel();
            using (var context = new PokerDbContext())
            {
                var rooms = context.Rooms.Where(x=>x.Code==code).FirstOrDefault();
                retval.Participants = new List<ParticipantViewModel>();
                retval.Code = rooms.Code;
                retval.Name = rooms.Name;
                foreach (var participant in rooms.Participants)
                {
                    retval.Participants.Add(new ParticipantViewModel() {Nick = participant.NickName});
                }
            }
            return retval;
        }

        [HttpPost]
        public IHttpActionResult StartVoting()
        {
            
            return Ok();
        }

        [HttpPost]
        public IHttpActionResult AddUser(UserModel userModel)
        {
            return Ok();
        }
    }
}
