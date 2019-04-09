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


        public static BusinessEntity InsertBusinessEntity(SqlTransaction current = null)
        {
            SqlCommand cmd = new SqlCommand("INSERT_BUSINESS_ENTITY", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Transaction = current;
            if (cmd.Transaction == null)
            {
                Connection.Open();
            }


            SqlDataReader dr = cmd.ExecuteReader();
            BusinessEntity entity = new BusinessEntity();
            while (dr.Read())
            {
                entity.BusinessEntityID = (int)dr["BusinessEntityID"];
                entity.ModifiedDate = DateTime.Parse(dr["ModifiedDate"].ToString());
            }

            dr.Close();

            if (cmd.Transaction == null)
            {
                Connection.Close();
            }

            return entity;
        }


        public static void InsertPerson(Person person, SqlTransaction current = null)
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
                cmd.Transaction = current;

                if (Connection.State != ConnectionState.Open)
                {
                    cmd.Transaction = current;
                    if (cmd.Transaction == null)
                    {
                        Connection.Open();
                    }
                }

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                if (Connection.State == ConnectionState.Open)
                {

                    if (cmd.Transaction == null)
                    {
                        Connection.Close();
                    }
                }

                throw;
            }

        }

        public static void InsertEmployee(Employee employee, SqlTransaction current = null)
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
                cmd.Transaction = current;
                if (Connection.State != ConnectionState.Open)
                {
                    if (cmd.Transaction == null)
                    {
                        Connection.Open();
                    }
                }

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                if (Connection.State == ConnectionState.Open)
                {

                    if (cmd.Transaction == null)
                    {
                        Connection.Close();
                    }
                }

                throw;
            }

        }


        public static void InsertEmployeeWithTransaction(Employee employee, Person person)
        {

            Connection.Open();

            var currentTran = Connection.BeginTransaction();

            try
            {
                var be = InsertBusinessEntity(currentTran);

                person.BusinessEntityID = be.BusinessEntityID;
                InsertPerson(person, currentTran);


                employee.BusinessEntityID = be.BusinessEntityID;
                InsertEmployee(employee, currentTran);

                currentTran.Commit();
                Connection.Close();
            }
            catch (Exception)
            {
                currentTran.Rollback();
                Connection.Close();
                throw;
            }
        }
    }
}
