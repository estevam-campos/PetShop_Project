using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    public class Raca
    {
        public int id {  get; set; }
        public string raca {  get; set; }
        public int idEspecie { get; set; }
        public Raca()
        {
            id = 0;
            raca = string.Empty;
            idEspecie = 0;
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
                sql = "select id, raca, idEspecie \n";
                sql += "from tblRaca rac \n";                

                if (id != 0)
                {
                    sql += "where id = @id \n";
                    lista.Add(new SqlParameter("@id", id));
                }
                else if (idEspecie != 0)
                {
                    sql += "where idEspecie = @idEspecie \n";
                    lista.Add(new SqlParameter("@idEspecie", idEspecie));
                }
                else if (raca != string.Empty)
                {
                    sql += "where raca like @raca \n";
                    lista.Add(new SqlParameter("@raca", "%" + raca + "%"));
                }
                sql += "order by raca";
                dt = acesso.ConsultarSql(sql, lista);
                if (id != 0)
                {
                    id = Convert.ToInt32(dt.Rows[0]["id"]);
                    raca = dt.Rows[0]["raca"].ToString();
                    idEspecie = Convert.ToInt32(dt.Rows[0]["idEspecie"]);
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
                    sql = "insert into tblRaca \n";
                    sql += "(raca, idEspecie, idUsuario) \n";
                    sql += "values \n";
                    sql += "(@raca, @idEspecie, @idUsuario) \n";
                }
                else
                {
                    sql = "update tblRaca set \n";
                    sql += "raca = @raca, \n";
                    sql += "idEspecie = @idEspecie, \n";
                    sql += "idUsuario = @idUsuario \n";
                    sql += "where id = @id";
                    lista.Add(new SqlParameter("@id", id));
                }
                lista.Add(new SqlParameter("@raca", raca));
                lista.Add(new SqlParameter("@idEspecie", idEspecie));
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
