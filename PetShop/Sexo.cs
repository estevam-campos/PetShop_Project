using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    public class Sexo
    {
        public int id {  get; set; }
        public string sexo {  get; set; }
        public Sexo()
        {
            id = 0;
            sexo = string.Empty;
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
                sql = "select id, sexo \n";
                sql += "from tblSexo \n";

                if (id != 0)
                {
                    sql += "where id = @id \n";
                    lista.Add(new SqlParameter("@id", id));
                }
                else if (sexo != string.Empty)
                {
                    sql += "where sexo like @sexo \n";
                    lista.Add(new SqlParameter("@sexo", "%" + sexo + "%"));
                }
                sql += "order by sexo";
                dt = acesso.ConsultarSql(sql, lista);

                if (id != 0)
                {
                    id = Convert.ToInt32(dt.Rows[0]["id"]);
                    sexo = dt.Rows[0]["sexo"].ToString();
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
                    sql = "insert into tblsexo \n";
                    sql += "(sexo, idUsuario) \n";
                    sql += "values \n";
                    sql += "(@sexo, @idUsuario) \n";
                }
                else
                {
                    sql = "update tblsexo set \n";
                    sql += "sexo = @sexo, \n";
                    sql += "idUsuario = @idUsuario \n";
                    sql += "where id = @id";
                    lista.Add(new SqlParameter("@id", id));
                }
                lista.Add(new SqlParameter("@sexo", sexo));
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
