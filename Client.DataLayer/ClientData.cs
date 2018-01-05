using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.Entity;

namespace Client.DataLayer
{
    public class ClientData
    {
        public static void Insert(Entity.Client obj)
        {
            using (var model = new Entity.DbContextEntity())
            {
                model.Entry<Entity.Client>(obj).State = EntityState.Added;
                model.SaveChanges();
            }
        }
        public static void Update(Entity.Client obj)
        {
            using (var model = new Entity.DbContextEntity())
            {
                model.Entry<Entity.Client>(obj).State = EntityState.Modified;
                model.SaveChanges();
            }
        }
        public static Entity.Client GetById(int id)
        {
            using (var model = new Entity.DbContextEntity())
            {
                model.Configuration.ProxyCreationEnabled = false;
                var result = (from c in model.Clients                             
                              where c.Id == id
                              select c);
                //Cuando añadí el Include, se cambio el campo de CityId en el View de Editor a DropdownList
                // .Include(c => c.City)

                return result.FirstOrDefault();
            }
        }
        public static List<Entity.Client> GetAll()
        {
            using (var model = new Entity.DbContextEntity())
            {
                model.Configuration.ProxyCreationEnabled = false;
                var result = (from c in model.Clients
                              .Include(c => c.City)
                              select c).ToList();

                return result;
            }
        }
        public static void DeleteById(Entity.Client obj)
        {
            using (var model = new Entity.DbContextEntity())
            {
                model.Entry<Entity.Client>(obj).State = EntityState.Deleted;
                model.SaveChanges();
            }
        }
    }
}
