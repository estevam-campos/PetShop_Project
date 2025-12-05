using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    public class Especie
    {
        public int id { get; set; }
        public string especie { get; set; }
        public Especie()
        {
            id = 0;
            especie = string.Empty;
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
                sql = "select id, especie \n";
                sql += "from tblEspecie \n";

                if (id != 0)
                {
                    sql += "where id = @id \n";
                    lista.Add(new SqlParameter("@id", id));
                }
                else if (especie != string.Empty)
                {
                    sql += "where especie like @especie \n";
                    lista.Add(new SqlParameter("@especie", "%" + especie + "%"));
                }
                sql += "order by especie";
                dt = acesso.ConsultarSql(sql, lista);

                if (id != 0)
                {
                    id = Convert.ToInt32(dt.Rows[0]["id"]);
                    especie = dt.Rows[0]["especie"].ToString();
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
                    sql = "insert into tblEspecie \n";
                    sql += "(especie, idUsuario) \n";
                    sql += "values \n";
                    sql += "(@especie, @idUsuario) \n";
                }
                else
                {
                    sql = "update tblEspecie set \n";
                    sql += "especie = @especie, \n";
                    sql += "idUsuario = @idUsuario \n";
                    sql += "where id = @id";
                    lista.Add(new SqlParameter("@id", id));
                }
                lista.Add(new SqlParameter("@especie", especie));
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
