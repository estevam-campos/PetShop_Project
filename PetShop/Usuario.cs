using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    public class Usuario
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string user { get; set; }
        public string password { get; set; }
        public bool ativo { get; set; }
        public Usuario()
        {
            id = 0;
            nome = string.Empty;
            user = string.Empty;
            password = string.Empty;
            ativo = false;
        }
        AcessoBD acesso = new AcessoBD();
        List<SqlParameter> lista = new List<SqlParameter>();
        DataTable dt = new DataTable();
        string sql = string.Empty;
        public bool Autenticar(string senha)
        {
            bool result = false;
            string senhaCripto = Global.CriptografarSenha(senha);
            Consultar();
            result = password == senhaCripto;
            return result;
        }
        public DataTable Consultar()
        {
            try
            {
                lista.Clear();
                sql = "select id, nome, usuario, senha, ativo \n";
                sql += "from tblUsuario \n";

                if (id != 0)
                {
                    sql += "where id = @id \n";
                    lista.Add(new SqlParameter("@id", id));
                }
                else if (user != string.Empty)
                {
                    sql += "where usuario = @usuario \n";
                    lista.Add(new SqlParameter("@usuario", user));
                }
                else if (nome != string.Empty)
                {
                    sql += "where nome like @nome \n";
                    lista.Add(new SqlParameter("@nome", "%" + nome + "%"));
                }
                sql += "order by nome";
                dt = acesso.ConsultarSql(sql, lista);
                if (id != 0 || (user != string.Empty && dt.Rows.Count > 0))
                {
                    id = Convert.ToInt32(dt.Rows[0]["id"]);
                    nome = dt.Rows[0]["nome"].ToString();
                    user = dt.Rows[0]["usuario"].ToString();
                    password = dt.Rows[0]["senha"].ToString();
                    ativo = Convert.ToBoolean(dt.Rows[0]["ativo"]);
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
                    sql = "insert into tblUsuario \n";
                    sql += "(nome, usuario, senha, ativo) \n";
                    sql += "values \n";
                    sql += "(@nome, @usuario, @senha, @ativo) \n";
                }
                else
                {
                    sql = "update tblUsuario set \n";
                    sql += "nome = @nome, \n";
                    sql += "usuario	= @usuario,\n";
                    sql += "senha = @senha, \n";
                    sql += "ativo = @ativo \n";
                    sql += "where id = @id";
                    lista.Add(new SqlParameter("@id", id));
                }
                lista.Add(new SqlParameter("@nome", nome));
                lista.Add(new SqlParameter("@usuario", user));
                lista.Add(new SqlParameter("@senha", password));
                lista.Add(new SqlParameter("@ativo", ativo));

                acesso.ExecutarSql(sql, lista);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
