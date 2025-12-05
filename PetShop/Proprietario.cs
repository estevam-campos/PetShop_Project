using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace PetShop
{
    public class Proprietario
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public Endereco endereco { get; set; }
        public List<Telefone> telefones { get; set; }
        public List<Animal> animais { get; set; }
        public Proprietario()
        {
            id = 0;
            nome = string.Empty;
            cpf = string.Empty;
            endereco = new Endereco();
            telefones = new List<Telefone>();
            animais = new List<Animal>();
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
                sql = "select id, nome, cpf \n";
                sql += "from tblProprietario \n";
                if (id != 0)
                {
                    sql += "where id = @id \n";
                    lista.Add(new SqlParameter("@id", id));
                }
                else if (cpf != string.Empty)
                {
                    sql += "where cpf = @cpf \n";
                    lista.Add(new SqlParameter("@cpf", cpf));
                }
                else if (nome != string.Empty)
                {
                    sql += "where nome like @nome \n";
                    lista.Add(new SqlParameter("@nome", "%" + nome + "%"));
                }
                sql += "order by nome";
                dt = acesso.ConsultarSql(sql, lista);
                if (id != 0 || (cpf != string.Empty && dt.Rows.Count > 0))
                {
                    id = Convert.ToInt32(dt.Rows[0]["id"]);
                    nome = dt.Rows[0]["nome"].ToString();
                    cpf = dt.Rows[0]["cpf"].ToString();

                    endereco.idProprietario = id;
                    endereco.Consultar();

                    animais.Clear();
                    Animal animal = new Animal();
                    animal.idProprietario = id;
                    foreach (DataRow linha in animal.Consultar().Rows)
                    {
                        Animal a = new Animal();
                        a.id = Convert.ToInt32(linha["id"]);
                        a.nome = linha["nome"].ToString();
                        a.dataNascimento = Convert.ToDateTime(linha["dataNascimento"]);
                        a.idRaca = Convert.ToInt32(linha["idRaca"]);
                        a.idSexo = Convert.ToInt32(linha["idSexo"]);
                        animais.Add(a);
                    }

                    telefones.Clear();
                    Telefone telefone = new Telefone();
                    telefone.idProprietario = id;
                    foreach (DataRow linha in telefone.Consultar().Rows)
                    {
                        Telefone t = new Telefone();
                        t.id = Convert.ToInt32(linha["id"]);
                        t.telefone = linha["telefone"].ToString();
                        t.idTipoTelefone = Convert.ToInt32(linha["idTipoTelefone"]);
                        t.idProprietario =  Convert.ToInt32(linha["idProprietario"]);
                        telefones.Add(t);
                    }
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
                using (TransactionScope transacao = new TransactionScope())
                {
                    lista.Clear();
                    if (id == 0)
                    {
                        sql = "insert into tblProprietario (nome, cpf, idUsuario) values (@nome, @cpf, @idUsuario);select @@identity";
                    }
                    else
                    {
                        sql = "update tblProprietario set \n";
                        sql += "nome = @nome, \n";
                        sql += "cpf = @cpf, \n";
                        sql += "idUsuario = @idUsuario \n";
                        sql += "where id = @id";
                        lista.Add(new SqlParameter("@id", id));
                    }
                    lista.Add(new SqlParameter("@nome", nome));
                    lista.Add(new SqlParameter("@cpf", cpf));
                    lista.Add(new SqlParameter("@idUsuario", Global.idUsuario));

                    if (id == 0)
                    {
                        id = acesso.ExecutarSqlIdentity(sql, lista);
                        endereco.idProprietario = id;
                    }
                    else
                    {
                        acesso.ExecutarSql(sql, lista);
                    }
                    endereco.Gravar();
                    RemoverTelefones();
                    foreach (Telefone telefone in  telefones)
                    {
                        telefone.Gravar();
                    }
                    transacao.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void RemoverTelefones()
        {
            try
            {
                lista.Clear();
                sql = "delete from tblTelefone \n";
                sql += "where idProprietario = @idProprietario \n";
                lista.Add(new SqlParameter("@idProprietario", id));
                acesso.ExecutarSql(sql, lista);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
