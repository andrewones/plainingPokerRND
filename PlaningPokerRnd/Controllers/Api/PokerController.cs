using System.Web.Http;
using PlaningPokerRnd.Models;

namespace PlaningPokerRnd.Controllers.Api
{
    public class PokerController : ApiController
    {

        [HttpGet]
        public MainViewModel Rooms()
        {
            return new MainViewModel();
        }

        [HttpGet]
        public RoomViewModel Rooms(string code)
        {
            return new RoomViewModel();
        }

        [HttpPost]
        public IHttpActionResult AddUser(UserModel userModel)
        {
            return Ok();
        }
    }
}
