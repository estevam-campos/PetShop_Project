using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    public class Endereco
    {
        public int id { get; set; }
        public string endereco { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string cep { get; set; }
        public int idCidade { get; set; }
        public int idProprietario { get; set; }
        public Endereco()
        {
            id = 0;
            endereco = string.Empty;
            numero = string.Empty;
            complemento= string.Empty;
            bairro = string.Empty;
            cep= string.Empty;
            idCidade = 0;
            idProprietario = 0;
        }
        AcessoBD acesso = new AcessoBD();
        List<SqlParameter> lista = new List<SqlParameter>();
        DataTable dt = new DataTable();
        string sql = string.Empty;

        public void Consultar()
        {
            try
            {
                lista.Clear();
                sql = "select id, endereco, numero, complemento, bairro, cep, idCidade, idProprietario \n";
                sql += "from tblEndereco \n";
                sql += "where idProprietario = @idProprietario";
                lista.Add(new SqlParameter("@idProprietario", idProprietario));

                dt = acesso.ConsultarSql(sql, lista);

                if (dt.Rows.Count > 0)
                {
                    id = Convert.ToInt32(dt.Rows[0]["id"]);
                    endereco = dt.Rows[0]["endereco"].ToString();
                    numero = dt.Rows[0]["numero"].ToString();
                    complemento = dt.Rows[0]["complemento"].ToString();
                    bairro = dt.Rows[0]["bairro"].ToString();
                    cep = dt.Rows[0]["cep"].ToString();
                    idCidade = Convert.ToInt32(dt.Rows[0]["idCidade"]);
                    idProprietario = Convert.ToInt32(dt.Rows[0]["idProprietario"]);
                }
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
                    sql = "insert into tblEndereco \n";
                    sql += "(endereco, numero, complemento, bairro, cep, idCidade, idProprietario, idUsuario)\n";
                    sql += "values \n";
                    sql += "(@endereco, @numero, @complemento, @bairro, @cep, @idCidade, @idProprietario, @idUsuario)\n";
                }
                else
                {
                    sql = "update tblEndereco set \n";
                    sql += "endereco = @endereco, \n";
                    sql += "numero = @numero, \n";
                    sql += "complemento = @complemento, \n";
                    sql += "bairro = @bairro, \n";
                    sql += "cep = @cep, \n";
                    sql += "idCidade = @idCidade, \n";
                    sql += "idProprietario = @idProprietario, \n";
                    sql += "idUsuario = @idUsuario \n";
                    sql += "where id = @id";
                    lista.Add(new SqlParameter("@id", id));
                }
                lista.Add(new SqlParameter("@endereco", endereco));
                lista.Add(new SqlParameter("@numero", numero));
                lista.Add(new SqlParameter("@complemento", complemento));
                lista.Add(new SqlParameter("@bairro", bairro));
                lista.Add(new SqlParameter("@cep", cep));
                lista.Add(new SqlParameter("@idCidade", idCidade));
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
