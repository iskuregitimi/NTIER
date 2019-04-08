﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTIER.ENTITY
{
    public class Person
    {
        public int BusinessEntityID { get; set; }
        public string PersonType { get; set; }
        public int NameStyle { get; set; }
        public object Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public object Suffix { get; set; }
        public int EmailPromotion { get; set; }
        public object AdditionalContactInfo { get; set; }
        public string Demographics { get; set; }
        public string rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
    }

}
