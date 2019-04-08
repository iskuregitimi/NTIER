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
            //TODO: employee yaşı 18 den büyükmü kontrol et
            int yas = DateTime.Now.Year - employee.BirthDate.Year;

            if (yas < 18)
            {
                throw new Exception("18 yaşından küçük personel insert edilemez");
            }


            //TODO: DAL Businessentity Insert Et
            BusinessEntity be = DataContext.InsertBusinessEntity();

            //TODO: DAL Person insert et
            person.BusinessEntityID = be.BusinessEntityID;
            DataContext.InsertPerson(person);

            //TODO: DAL Employee insert et
            employee.BusinessEntityID = be.BusinessEntityID;
            DataContext.InsertEmployee(employee);
        }
    }
}
