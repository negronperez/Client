using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.Entity;

namespace Client.DataLayer
{
    public class CityData
    {
        public static Entity.City GetById(int id)
        {
            using (var model = new Entity.DbContextEntity())
            {
                model.Configuration.ProxyCreationEnabled = false;
                var result = (from c in model.Cities
                              where c.CityId == id
                              select c);

                return result.FirstOrDefault();
            }
        }

        public static List<Entity.City> GetAll()
        {
            using (var model = new Entity.DbContextEntity())
            {
                model.Configuration.ProxyCreationEnabled = false;
                var result = (from c in model.Cities                              
                              select c).ToList();

                return result;
            }
        }
    }
}
