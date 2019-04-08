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

            Connection.Close();

            return entity;
        }


        public static void InsertPerson(Person person)
        {
            //TODO: insert person kodu yazılacak
            SqlCommand cmd = new SqlCommand("INSERT_PERSON", Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@BusinessEntityID", SqlDbType.VarChar).Value = person.BusinessEntityID;
            cmd.Parameters.Add("@Title", SqlDbType.VarChar).Value = person.Title;
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = person.FirstName;
            cmd.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = person.MiddleName;
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = person.LastName;

            Connection.Open();
            cmd.ExecuteNonQuery();
            Connection.Close();
        }

        public static void InsertEmployee(Employee employee)
        {
            //TODO: insert employee kodu yazılacak
            SqlCommand cmd = new SqlCommand("INSERT_EMPLOYEE", Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@BusinessEntityID", SqlDbType.VarChar).Value = employee.BusinessEntityID;
            cmd.Parameters.Add("@JobTitle", SqlDbType.VarChar).Value = employee.JobTitle;
            cmd.Parameters.Add("@BirthDate", SqlDbType.VarChar).Value = employee.BirthDate;

            Connection.Open();
            cmd.ExecuteNonQuery();
            Connection.Close();
        }
    }
}
