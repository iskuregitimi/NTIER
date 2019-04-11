using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTIER.ENTITY
{
   public  class Adress
    {
        public int AddressID { get; set; }

        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string StateProvinceID { get; set; }
         public string PostalCode { get; set; }
        public string SpatialLocation { get; set; }

        public string rowguid { get; set; }


        public DateTime ModifiedDate { get; set; }

    }
}
