using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    public class AcessoBD
    {
        SqlConnection connection;

        private void Conectar()
        {
            try
            {
                connection = new SqlConnection(Global.conexao);
                connection.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void Desconectar()
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    connection.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable ConsultarSql(string query, List<SqlParameter> parametros)
        {
            try
            {
                Conectar();
                SqlCommand command = new SqlCommand(query, connection);
                foreach (SqlParameter p in parametros)
                {
                    command.Parameters.Add(p);
                }
                DataTable dt = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }
        public void ExecutarSql(string query, List<SqlParameter> parametros)
        {
            try
            {
                Conectar();
                SqlCommand command = new SqlCommand(query, connection);
                foreach (SqlParameter p in parametros)
                {
                    command.Parameters.Add(p);
                }
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }
        public int ExecutarSqlIdentity(string query, List<SqlParameter> parametros)
        {
            try
            {
                Conectar();
                SqlCommand command = new SqlCommand(query, connection);
                foreach (SqlParameter p in parametros)
                {
                    command.Parameters.Add(p);
                }
                return int.Parse(command.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }
    }
}
