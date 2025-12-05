using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    public class TipoTelefone
    {
        public int id { get; set; }
        public string tipoTelefone { get; set; }
        public TipoTelefone()
        {
            id = 0;
            tipoTelefone = string.Empty;
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
                sql = "select id, tipoTelefone \n";
                sql += "from tblTipoTelefone \n";

                if (id != 0)
                {
                    sql += "where id = @id \n";
                    lista.Add(new SqlParameter("@id", id));
                }                
                else if (tipoTelefone != string.Empty)
                {
                    sql += "where tipoTelefone like @tipoTelefone \n";
                    lista.Add(new SqlParameter("@tipoTelefone", "%" + tipoTelefone + "%"));
                }
                sql += "order by tipoTelefone";
                dt = acesso.ConsultarSql(sql, lista);

                if (id != 0)
                {
                    id = Convert.ToInt32(dt.Rows[0]["id"]);
                    tipoTelefone = dt.Rows[0]["tipoTelefone"].ToString();
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
                    sql = "insert into tblTipoTelefone \n";
                    sql += "(tipoTelefone, idUsuario) \n";
                    sql += "values \n";
                    sql += "(@tipoTelefone, @idUsuario) \n";
                }
                else
                {
                    sql = "update tblTipoTelefone set \n";
                    sql += "tipoTelefone = @tipoTelefone, \n";
                    sql += "idUsuario = @idUsuario \n";
                    sql += "where id = @id";
                    lista.Add(new SqlParameter("@id", id));
                }
                lista.Add(new SqlParameter("@tipoTelefone", tipoTelefone));
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
