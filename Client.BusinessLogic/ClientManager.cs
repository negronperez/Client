using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.BusinessLogic
{
    public class ClientManager
    {
        public static void Insert(Entity.Client obj)
        {
            DataLayer.ClientData.Insert(obj);
        }
        public static void Update(Entity.Client obj)
        {
            DataLayer.ClientData.Update(obj);
        }
        public static Entity.Client GetById(int id)
        {
            return DataLayer.ClientData.GetById(id);
        }
        public static List<Entity.Client> GetAll()
        {
            return DataLayer.ClientData.GetAll();
        }
      public static void DeleteById(Entity.Client obj)
      {
         DataLayer.ClientData.DeleteById(obj);
      }
    }
}
