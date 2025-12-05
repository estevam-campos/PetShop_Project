using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    public class Animal
    {
        public int id { get; set; }
        public string nome { get; set; }
        public DateTime dataNascimento { get; set; }
        public int idRaca { get; set; }
        public int idSexo { get; set; }
        public int idProprietario { get; set; }
        public Animal()
        {
            id = 0;
            nome = string.Empty;
            dataNascimento = DateTime.Now;
            idRaca = 0;
            idSexo = 0;
            idProprietario = 0;
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
                sql = "select id, nome, dataNascimento, idRaca, idSexo, idProprietario \n";
                sql += "from tblAnimal \n";
                if (id != 0)
                {
                    sql += "where id = @id \n";
                    lista.Add(new SqlParameter("@id", id));
                }
                else if (nome != string.Empty)
                {
                    sql += "where nome like @nome \n";
                    lista.Add(new SqlParameter("@nome", "%" + nome + "%"));
                }
                else if (idProprietario != 0)
                {
                    sql += "where idProprietario = @idProprietario \n";
                    lista.Add(new SqlParameter("@idProprietario", idProprietario));
                }
                sql += "order by nome";
                dt = acesso.ConsultarSql(sql, lista);
                if (id != 0)
                {
                    id = Convert.ToInt32(dt.Rows[0]["id"]);
                    nome = dt.Rows[0]["nome"].ToString();
                    dataNascimento = Convert.ToDateTime(dt.Rows[0]["dataNascimento"]);
                    idRaca = Convert.ToInt32(dt.Rows[0]["idRaca"]);
                    idSexo = Convert.ToInt32(dt.Rows[0]["idSexo"]);
                    idProprietario = Convert.ToInt32(dt.Rows[0]["idProprietario"]);                    
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
                    sql = "insert into tblAnimal \n";
                    sql += "(nome, dataNascimento, idRaca, idSexo, idProprietario, idUsuario) \n";
                    sql += "values \n";
                    sql += "(@nome, @dataNascimento, @idRaca, @idSexo, @idProprietario, @idUsuario) \n";
                }
                else
                {
                    sql = "update tblAnimal set \n";
                    sql += "nome = @nome, \n";
                    sql += "dataNascimento	= @dataNascimento,\n";
                    sql += "idRaca = @idRaca, \n";
                    sql += "idSexo = @idSexo, \n";
                    sql += "idProprietario = @idProprietario, \n";
                    sql += "idUsuario = @idUsuario \n";
                    sql += "where id = @id";
                    lista.Add(new SqlParameter("@id", id));
                }
                lista.Add(new SqlParameter("@nome", nome));
                lista.Add(new SqlParameter("@dataNascimento", dataNascimento));
                lista.Add(new SqlParameter("@idRaca", idRaca));
                lista.Add(new SqlParameter("@idSexo", idSexo));
                lista.Add(new SqlParameter("@idProprietario", idProprietario));
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
