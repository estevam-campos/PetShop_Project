using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    public class Profissional
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string atuacao { get; set; }
        public bool ativo { get; set; }
        public int idUsuario { get; set; }
        public Profissional() 
        {
            id = 0;
            nome = string.Empty;
            atuacao = string.Empty;
            ativo = false;
            idUsuario = 0;
        }
        AcessoBD acesso = new AcessoBD();
        List<SqlParameter> lista = new List<SqlParameter>();
        DataTable dt = new DataTable();
        string sql = string.Empty;
        public DataTable Consultar(bool somenteAtivos = false)
        {
            try
            {
                lista.Clear();
                sql = "select id, nome, atuacao, ativo, idUsuario \n";
                sql += "from tblProfissional \n";
                sql += "where 1 = 1 \n";
                if (id != 0)
                {
                    sql += "and id = @id \n";
                    lista.Add(new SqlParameter("@id", id));
                }
                else if (nome != string.Empty)
                {
                    sql += "and nome like @nome \n";
                    lista.Add(new SqlParameter("@nome", "%" + nome + "%"));
                }
                if (somenteAtivos)
                {
                    sql += "and ativo = 1 \n";
                }
                sql += "order by nome";
                dt = acesso.ConsultarSql(sql, lista);

                if (id != 0)
                {
                    id = Convert.ToInt32(dt.Rows[0]["id"]);
                    nome = dt.Rows[0]["nome"].ToString();
                    atuacao = dt.Rows[0]["atuacao"].ToString();
                    ativo = Convert.ToBoolean(dt.Rows[0]["ativo"]);
                    idUsuario = Convert.ToInt32(dt.Rows[0]["idUsuario"]);
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
                    sql = "insert into tblProfissional \n";
                    sql += "(nome, atuacao, ativo, idUsuario) \n";
                    sql += "values \n";
                    sql += "(@nome, @atuacao, @ativo, @idUsuario) \n";
                }
                else
                {
                    sql = "update tblProfissional set \n";
                    sql += "nome = @nome, \n";
                    sql += "atuacao = @atuacao, \n";
                    sql += "ativo = @ativo, \n";                    
                    sql += "idUsuario = @idUsuario \n";
                    sql += "where id = @id";
                    lista.Add(new SqlParameter("@id", id));
                }
                lista.Add(new SqlParameter("@nome", nome));
                lista.Add(new SqlParameter("@atuacao", atuacao));
                lista.Add(new SqlParameter("@ativo", ativo));
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
