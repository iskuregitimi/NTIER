﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTIER.ENTITY
{
    public class Address
    {
        public int AddressID { get; set; }
        public string AddressLine1 { get; set; }
        public object AddressLine2 { get; set; }
        public string City { get; set; }
        public int StateProvinceID { get; set; }
        public int PostalCode { get; set; }
        public string SpatialLocation { get; set; }
        public string rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
