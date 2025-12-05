using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    public class Vacina
    {
        public int id {  get; set; }
        public DateTime data { get; set; }
        public string vacina { get; set; }
        public int idAnimal { get; set; }
        public Vacina()
        {
            id = 0;
            data = DateTime.Now;
            vacina = string.Empty;
            idAnimal = 0;
        }
        AcessoBD acesso = new AcessoBD();
        List<SqlParameter> lista = new List<SqlParameter>();
        DataTable dt = new DataTable();
        string sql = string.Empty;
        public DataTable Consultar()
        {
            try
            {
                lista.Clear();
                sql = "select id, data, vacina, idAnimal \n";
                sql += "from tblVacina \n";
                if (id != 0)
                {
                    sql += "where id = @id \n";
                    lista.Add(new SqlParameter("@id", id));
                }
                else if (idAnimal != 0)
                {
                    sql += "where idAnimal = @idAnimal \n";
                    lista.Add(new SqlParameter("@idAnimal", idAnimal));
                }
                sql += "order by data";
                dt = acesso.ConsultarSql(sql, lista);
                if (id != 0)
                {
                    id = Convert.ToInt32(dt.Rows[0]["id"]);
                    data = Convert.ToDateTime(dt.Rows[0]["data"]);
                    vacina = dt.Rows[0]["vacina"].ToString();
                    idAnimal = Convert.ToInt32(dt.Rows[0]["idAnimal"]);
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Gravar()
        {
            try
            {
                lista.Clear();
                if (id == 0)
                {
                    sql = "insert into tblVacina \n";
                    sql += "(data, vacina, idAnimal, idUsuario) \n";
                    sql += "values \n";
                    sql += "(@data, @vacina, @idAnimal, @idUsuario) \n";
                }
                else
                {
                    lista.Clear();
                    sql = "update tblVacina set \n";
                    sql += "data = @data, \n";
                    sql += "vacina = @vacina, \n";
                    sql += "idAnimal = @idAnimal, \n";
                    sql += "idUsuario = @idUsuario \n";
                    sql += "where id = @id";
                    lista.Add(new SqlParameter("@id", id));
                }
                lista.Add(new SqlParameter("@data", data));
                lista.Add(new SqlParameter("@vacina", vacina));
                lista.Add(new SqlParameter("@idAnimal", idAnimal));
                lista.Add(new SqlParameter("@idUsuario", Global.idUsuario));

                acesso.ExecutarSql(sql, lista);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
