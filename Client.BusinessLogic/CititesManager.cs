using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.BusinessLogic
{
    public class CitiesManager
    {        
        public static Entity.City GetById(int id)
        {
            return DataLayer.CityData.GetById(id);
        }
        public static List<Entity.City> GetAll()
        {
            return DataLayer.CityData.GetAll();
        }
    }
}
