using System.Web.Http;

namespace PlaningPokerRnd.Controllers.Api
{
    public class ParticipantController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Vote(string name, int vote)
        {

            return Ok();
        }
    }
}
