using NTIER.DAL;
using NTIER.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTIER.BLL
{
    public static class EmployeeBLL
    {
        public static void InsertEmployee(Person person, Employee employee)
        {
            int yas = DateTime.Now.Year - employee.BirthDate.Year;

            if (yas < 18)
            {
                throw new Exception("18 yaşından küçük personel insert edilemez");
            }


            if (DataContext.IsEmployeeExists(person))
            {
                throw new Exception("Aynı isimle personel insert edilemez");
            }

            BusinessEntity be = DataContext.InsertBusinessEntity();

            person.BusinessEntityID = be.BusinessEntityID;
            DataContext.InsertPerson(person);

            employee.BusinessEntityID = be.BusinessEntityID;
            DataContext.InsertEmployee(employee);
        }
    }
}
