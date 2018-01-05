using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Entity
{
   public partial class Client
   {
      public int Id { get; set; }
      [Display(Name = "First Name")]
      public string FirstName { get; set; }
      [Display(Name = "Middle Name")]
      public string MiddleName { get; set; }
      [Display(Name = "Last Name 1")]
      public string LastName1 { get; set; }
      [Display(Name = "Last Name 2")]
      public string LastName2 { get; set; }
      [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
      public Nullable<System.DateTime> Birthdate { get; set; }
      [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
      public Nullable<int> Age { get; set; }
      [Display(Name ="Phone")]
      public string PhoneNo { get; set; }
      public string Email { get; set; }
      [Display(Name = "Address 1")]
      public string Address1 { get; set; }
      [Display(Name = "Address 2")]
      public string Address2 { get; set; }
      [Display(Name = "Zip Code")]
      public string ZipCode { get; set; }
      public Nullable<int> CityId { get; set; }

      public virtual City City { get; set; }
   }
}
