using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    public class Telefone
    {
        public int id { get; set; }
        public string telefone { get; set; }
        public int idTipoTelefone { get; set; }
        public int idProprietario { get; set; }
        public Telefone()
        {
            id = 0;
            telefone = string.Empty;
            idTipoTelefone = 0;
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
                sql = "select id, telefone, idTipoTelefone, idProprietario \n";
                sql += "from tblTelefone \n";
                sql += "where idProprietario = @idProprietario \n";
                lista.Add(new SqlParameter("@idProprietario", idProprietario));
                dt = acesso.ConsultarSql(sql, lista);

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
                sql = "insert into tblTelefone (telefone, idTipoTelefone, idProprietario, idUsuario) \n";
                sql += "values \n";
                sql += "(@telefone, @idTipoTelefone, @idProprietario, @idUsuario)";
                lista.Add(new SqlParameter("@telefone", telefone));
                lista.Add(new SqlParameter("@idTipoTelefone", idTipoTelefone));
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
