using System.Collections.Generic;
using System.Linq;

namespace opg_4_simple_rest_service.Managers
{
    public class FootballPlayerManager
    {
        private static int next_id = 1;
        private static List<FootballPlayer> fbp_catalog = new List<FootballPlayer>(){
            new FootballPlayer(next_id++,"andy", 100, 2)
        };

        public List<FootballPlayer> GetAll()
        {
            return fbp_catalog;
        }
        public FootballPlayer GetPlayer(int id)
        {
            try
            {
                return fbp_catalog.Where(f => f.Id == id).FirstOrDefault();
            }
            catch (System.Exception)
            {
                return null;
            }
        }

        public void Add(FootballPlayer fbp)
        {
            fbp.Id = next_id++;
            fbp_catalog.Add(fbp);
        }

        public void DeletePlayer(int id)
        {
            fbp_catalog.Remove(GetPlayer(id));
        }
        public void Update(FootballPlayer fbp, int id)
        {
            FootballPlayer temp = GetPlayer(id);
            temp.Name = fbp.Name;
            temp.Price = fbp.Price;
            temp.Shirt_number = fbp.Shirt_number;
        }
    }
}