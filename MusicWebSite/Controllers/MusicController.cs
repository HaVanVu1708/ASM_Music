using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicWebSite.Models;
using MusicWebSite.Services;

namespace MusicWebSite.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MusicController : Controller
    {
        public MusicController(JsonFileMusicServices musicServices)
        {
            this.MusicServices = musicServices;
        }
        public JsonFileMusicServices MusicServices { get; }
       

        [HttpGet]

        public IEnumerable<Music> Get()
        {
            return MusicServices.GetMusics();
        }

        //HtppPath
        [Route("Rate")]
        [HttpGet]
        public ActionResult Get(
            [FromQuery] string MusicId,
            [FromQuery] int Rating)
        {
            MusicServices.AddRating(MusicId, Rating);
            return Ok();
        }
    }
}
