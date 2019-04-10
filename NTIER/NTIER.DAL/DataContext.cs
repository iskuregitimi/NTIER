using NTIER.ENTITY;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTIER.DAL
{
    public static class DataContext
    {
        static SqlConnection Connection;

        static DataContext()
        {
            string connectionString = ConfigurationManager.AppSettings["ConnectionString"].ToString();

            Connection = new SqlConnection(connectionString);
        }


        public static bool IsEmployeeExists(Person person)
        {
            SqlCommand cmd = new SqlCommand("SELEC_PERSON_BY_NAME", Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", person.FirstName);
            cmd.Parameters.AddWithValue("@MiddleName", person.MiddleName);
            cmd.Parameters.AddWithValue("@LastName", person.LastName);



            Connection.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            Person entity = new Person();
            while (dr.Read())
            {
                entity.BusinessEntityID = (int)dr["BusinessEntityID"];
            }

            dr.Close();


            Connection.Close();

            if (entity.BusinessEntityID > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static void InsertEmployeeEmail(int businessEntityId, string email)
        {
            SqlCommand cmd = new SqlCommand("[dbo].[INSERT_EMPLOYEE_EMAIL]", Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BusinessEntityID", businessEntityId);
            cmd.Parameters.AddWithValue("@EmailAddress", email);

            Connection.Open();

            cmd.ExecuteScalar();
            
            Connection.Close();
        }

        public static void InsertEmployeePhone(int businessEntityId, string phone)
        {
            SqlCommand cmd = new SqlCommand("[dbo].[INSERT_EMPLOYEE_PHONE]", Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BusinessEntityID", businessEntityId);
            cmd.Parameters.AddWithValue("@PhoneNumber", phone);

            Connection.Open();

            cmd.ExecuteScalar();

            Connection.Close();
        }

        public static BusinessEntity InsertBusinessEntity()
        {
            SqlCommand cmd = new SqlCommand("INSERT_BUSINESS_ENTITY", Connection);
            cmd.CommandType = CommandType.StoredProcedure;


            Connection.Open();


            SqlDataReader dr = cmd.ExecuteReader();
            BusinessEntity entity = new BusinessEntity();
            while (dr.Read())
            {
                entity.BusinessEntityID = (int)dr["BusinessEntityID"];
                entity.ModifiedDate = DateTime.Parse(dr["ModifiedDate"].ToString());
            }

            dr.Close();


            Connection.Close();


            return entity;
        }
        public static void InsertPerson(Person person)
        {

            SqlCommand cmd = new SqlCommand("[Person].[usp_PersonInsert]", Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BusinessEntityID", person.BusinessEntityID);
            cmd.Parameters.AddWithValue("@PersonType", "EM");
            cmd.Parameters.AddWithValue("@NameStyle", 0);
            cmd.Parameters.AddWithValue("@FirstName", person.FirstName);
            cmd.Parameters.AddWithValue("@MiddleName", person.MiddleName);
            cmd.Parameters.AddWithValue("@LastName", person.LastName);


            try
            {


                if (Connection.State != ConnectionState.Open)
                {

                    Connection.Open();

                }

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }

                throw;
            }

        }

        public static void InsertEmployee(Employee employee)
        {
            SqlCommand cmd = new SqlCommand("[HumanResources].[usp_EmployeeInsert]", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@BusinessEntityID", employee.BusinessEntityID);
            cmd.Parameters.AddWithValue("@NationalIDNumber", employee.NationalIDNumber);
            cmd.Parameters.AddWithValue("@LoginID", employee.LoginID);
            cmd.Parameters.AddWithValue("@JobTitle", employee.JobTitle);
            cmd.Parameters.AddWithValue("@BirthDate", employee.BirthDate);
            cmd.Parameters.AddWithValue("@MaritalStatus", 'M');
            cmd.Parameters.AddWithValue("@Gender", 'M');
            cmd.Parameters.AddWithValue("@HireDate", DateTime.Now.AddYears(-2));
            cmd.Parameters.AddWithValue("@SalariedFlag", 1);
            cmd.Parameters.AddWithValue("@VacationHours", 1);
            cmd.Parameters.AddWithValue("@SickLeaveHours", 1);
            cmd.Parameters.AddWithValue("@CurrentFlag", 1);

            try
            {
                ;
                if (Connection.State != ConnectionState.Open)
                {

                    Connection.Open();

                }

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }

                throw;
            }

        }

        public static DataTable SearchEmployee(string searchText)
        {
            SqlCommand cmd = new SqlCommand("[dbo].[SELECT_EMPLOYEE_BY_NAME]", Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SearchText", searchText);

            Connection.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);

            dr.Close();
            Connection.Close();
            return dt;
        }

    }
}
