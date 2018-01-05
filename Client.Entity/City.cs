using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Entity
{
    public partial class City
    {
        
        public City()
        {
            //this.Clients = new HashSet<Client>();
        }

        public int CityId { get; set; }
        [Display(Name ="City")]
        public string CityDesc { get; set; }
        
        //public virtual ICollection<Client> Clients { get; set; }
    }
}
