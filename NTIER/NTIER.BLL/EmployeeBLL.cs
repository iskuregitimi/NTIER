using NTIER.BLL.Validations;
using NTIER.DAL;
using NTIER.ENTITY;
using System;
using System.Collections.Generic;
using System.Data;
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

        public static void InsertEmployeeAdressBLL(int businessEntityId, Address adres)
        {
            if (AddressValidator.Validate(adres) == true)
            {
                DataContext.InsertEmployeeAddress(businessEntityId,adres);
            }
            else
            {
                throw new Exception("Lütfen adres verilerini kontrol ediniz");
            }
        }

        public static void InsertEmployeeEmailBLL(int businessEntityId, string text)
        {
            if (businessEntityId <= 0)
            {
                throw new Exception("Lütfen personel seçiniz");
            }
            DataContext.InsertEmployeeEmail(businessEntityId, text);
        }

        public static DataTable GetStateProvincesBLL(string searchText)
        {
            return DataContext.GetStateProvinces(searchText);
        }

        public static DataTable SearchEmployeeBLL(string searchText)
        {
            // karakterler örnek olarak eklenmiştir.
            if (searchText.Contains("--")
                || searchText.Contains("**"))

            {
                throw new Exception("Yasaklı karakterler kullanmayınız");
            }


            return DataContext.SearchEmployee(searchText);
        }

        public static DataSet SelectEmployeeDetails(int BusinessEntityID)
        {

            DataSet ds = new DataSet();

            return ds = DataContext.SelectEmployeeDetails(BusinessEntityID);
        }

		public static void EmailSil_BLL(int EmailAdresID)

		{
			DataContext.EmailSil(EmailAdresID);

		}

	}
}
