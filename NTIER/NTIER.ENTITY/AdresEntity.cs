using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTIER.ENTITY
{
   public  class AdresEntity
    {
        public int AddressID { get; set; }

        public int BusinessEntityID { get; set; }
        public int AddressTypeID { get; set; }
        public string rowguid { get; set; }


        public DateTime ModifiedDate { get; set; }


    }
}
