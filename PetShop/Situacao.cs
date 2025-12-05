using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    public class Situacao
    {
        public int id { get; set; }
        public string situacao { get; set; }
        public Situacao()
        {
            id = 0;
            situacao = string.Empty;
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
                sql = "select id, situacao \n";
                sql += "from tblSituacao \n";

                if (id != 0)
                {
                    sql += "where id = @id \n";
                    lista.Add(new SqlParameter("@id", id));
                }
                else if (situacao != string.Empty)
                {
                    sql += "where situacao like @situacao \n";
                    lista.Add(new SqlParameter("@situacao", "%" + situacao + "%"));
                }
                sql += "order by situacao";
                dt = acesso.ConsultarSql(sql, lista);

                if (id != 0)
                {
                    id = Convert.ToInt32(dt.Rows[0]["id"]);
                    situacao = dt.Rows[0]["situacao"].ToString();
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
                    sql = "insert into tblSituacao \n";
                    sql += "(situacao, idUsuario) \n";
                    sql += "values \n";
                    sql += "(@situacao, @idUsuario) \n";
                }
                else
                {
                    sql = "update tblSituacao set \n";
                    sql += "situacao = @situacao, \n";
                    sql += "idUsuario = @idUsuario \n";
                    sql += "where id = @id";
                    lista.Add(new SqlParameter("@id", id));
                }
                lista.Add(new SqlParameter("@situacao", situacao));
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
