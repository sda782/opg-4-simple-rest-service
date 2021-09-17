using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using opg_4_simple_rest_service.Managers;

namespace opg_4_simple_rest_service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FootballPlayerController : ControllerBase
    {
        private readonly FootballPlayerManager manager = new FootballPlayerManager();

        [HttpGet]
        public IEnumerable<FootballPlayer> Get()
        {
            return manager.GetAll();
        }
        [HttpGet("{id}")]
        public FootballPlayer Get(int id)
        {
            return manager.GetPlayer(id);
        }
        [HttpPost]
        public IEnumerable<FootballPlayer> Post([FromBody] FootballPlayer fbp)
        {
            manager.Add(fbp);
            return manager.GetAll();
        }
        [HttpDelete("{id}")]
        public IEnumerable<FootballPlayer> Delete(int id)
        {
            manager.DeletePlayer(id);
            return manager.GetAll();
        }
        [HttpPut("{id}")]
        public IEnumerable<FootballPlayer> Put(int id, [FromBody] FootballPlayer fbp)
        {
            manager.Update(fbp, id);
            return manager.GetAll();
        }

    }
}