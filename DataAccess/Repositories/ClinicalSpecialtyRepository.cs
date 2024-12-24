using Models.Entities;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using DataAccess.SQLClient;
using System.Data;

namespace DataAccess.Repositories
{
    public class ClinicalSpecialtyRepository : IClinicalRepository<ClinicalSpecialty>
    {
        private readonly Client sqlClient;

        public ClinicalSpecialtyRepository(Client sqlClient)
        {
            //DEPENDENCY INJECTION
            this.sqlClient = sqlClient;
        }

        //INSERT A SPECIALT INTO THE DATABASE
        public bool CreateSpecialty(ClinicalSpecialty clinicalSpecialty)
        {
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = sqlClient.GetStringConnection();

                SqlCommand sqlCommand = new SqlCommand("INSERT INTO ClinicalSpecialty (field, specialty, description) VALUES (@field, @specialty, @description)", sqlConnection);

                sqlCommand.Parameters.Clear();
                List<SqlParameter> list = new List<SqlParameter>();

                list.Add(new SqlParameter("@field", clinicalSpecialty.field));
                list.Add(new SqlParameter("@specialty", clinicalSpecialty.specialty));
                list.Add(new SqlParameter("@description", clinicalSpecialty.description));

                sqlCommand.Parameters.AddRange(list.ToArray<SqlParameter>());

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();

                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine("{0}", ex);
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        //GET A LIST OF ALL THE EXISTING SPECIALTIES
        public IEnumerable<ClinicalSpecialty> GetAllSpecialties()
        {
            List<ClinicalSpecialty> specialtiesList = new List<ClinicalSpecialty>();
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = sqlClient.GetStringConnection();

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("SELECT id, field, specialty, description " +
                                                       "FROM ClinicalSpecialty", sqlConnection);
                sqlCommand.CommandType = CommandType.Text;

                SqlDataReader reader;

                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    ClinicalSpecialty clinicalSpecialty = new ClinicalSpecialty();
                    clinicalSpecialty.id = Int32.Parse(reader["id"].ToString());
                    clinicalSpecialty.field = reader["field"].ToString();
                    clinicalSpecialty.specialty = reader["specialty"].ToString();
                    clinicalSpecialty.description = reader["description"].ToString();
                    specialtiesList.Add(clinicalSpecialty);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("{0}", ex);
            }
            finally
            {
                sqlConnection.Close();
            }

            return specialtiesList;
        }

        //GET A SPECIALTY IN PARTICULAR
        public ClinicalSpecialty GetSpecialty(int id)
        {
            ClinicalSpecialty clinicalSpecialty = new ClinicalSpecialty();
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = sqlClient.GetStringConnection();

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("SELECT  id, field, specialty, description FROM ClinicalSpecialty WHERE id = @id", sqlConnection);

                sqlCommand.CommandType = CommandType.Text;

                sqlCommand.Parameters.Add("@id", SqlDbType.Int);

                sqlCommand.Parameters["@id"].Value = id;

                SqlDataReader reader;

                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    clinicalSpecialty.id = Int32.Parse(reader["id"].ToString());
                    clinicalSpecialty.field = reader["field"].ToString();
                    clinicalSpecialty.specialty = reader["specialty"].ToString();
                    clinicalSpecialty.description = reader["description"].ToString();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0}", ex);
            }
            finally
            {
                sqlConnection.Close();
            }
            return clinicalSpecialty;

        }

        //UPDATE AN ESPECIFIC SPECIALTY
        public bool UpdateSpecialty(ClinicalSpecialty clinicalSpecialty)
        {
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = sqlClient.GetStringConnection();

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("UPDATE ClinicalSpecialty SET description  = @description" +
                                                       " WHERE id = @id", sqlConnection);

                sqlCommand.CommandType = CommandType.Text;

                sqlCommand.Parameters.Clear();

                List<SqlParameter> list = new List<SqlParameter>();

                list.Add(new SqlParameter("@id", clinicalSpecialty.id));
                list.Add(new SqlParameter("@field", clinicalSpecialty.field));
                list.Add(new SqlParameter("@specialty", clinicalSpecialty.specialty));
                list.Add(new SqlParameter("@description", clinicalSpecialty.description));

                sqlCommand.Parameters.AddRange(list.ToArray<SqlParameter>());

                sqlCommand.ExecuteNonQuery();

                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine("{0}", ex);
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        //REMOVE AN ESPECIFIC SPECIALTY
        public bool RemoveSpecialty(int id)
        {
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = sqlClient.GetStringConnection();

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("DELETE FROM ClinicalSpecialty WHERE id = @id", sqlConnection);
                sqlCommand.CommandType = CommandType.Text;

                sqlCommand.Parameters.Add("@id", SqlDbType.Int);

                sqlCommand.Parameters["@id"].Value = id;

                SqlDataReader reader;

                reader = sqlCommand.ExecuteReader();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0}", ex);
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
