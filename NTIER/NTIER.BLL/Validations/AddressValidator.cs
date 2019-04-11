using NTIER.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTIER.BLL.Validations
{
    public static class AddressValidator
    {
        public static bool Validate(Address adress)
        {
            if (string.IsNullOrEmpty(adress.City))
                return false;

            if (adress.PostalCode == 0)
                return false;

            if (string.IsNullOrEmpty(adress.AddressLine1))
                return false;

            if (adress.StateProvinceID == 0)
                return false;

            return true;
        }
    }
}
