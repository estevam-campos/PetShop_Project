using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PetShop
{
    public static class Global
    {
        public static int idUsuario = 0;
        public static string conexao;
        public static string servidor;
        public static string banco;
        public static string nome;
        public static string user;
        private static AcessoBD acesso = new AcessoBD();
        private static List<SqlParameter> lista = new List<SqlParameter>();
        private static DataTable dt = new DataTable();
        private static string sql = string.Empty;
        public static void MontarStringConexao()
        {
            servidor =
                ConfigurationManager.AppSettings["servidor"].ToString();
            banco =
                ConfigurationManager.AppSettings["banco"].ToString();

            conexao = $"Data Source={servidor};Initial Catalog={banco};" +
                $"Integrated Security=true;";
        }
        public static string CriptografarSenha(string senha)
        {
            Byte[] original;
            Byte[] criptografado;
            MD5 md5 = new MD5CryptoServiceProvider();
            original = ASCIIEncoding.Default.GetBytes(senha);
            criptografado = md5.ComputeHash(original);

            return Regex.Replace(BitConverter.ToString(criptografado), "-", "").ToLower();
        }
        public static DataTable ConsultarEstados()
        {
            try
            {
                lista.Clear();
                sql = "select id, estado from tblEstado";
                dt = acesso.ConsultarSql(sql, lista);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable ConsultarCidades(int idEstado)
        {
            try
            {
                lista.Clear();
                sql = "select id, cidade from tblCidade where idEstado = @idEstado";
                lista.Add(new SqlParameter("@idEstado", idEstado));
                dt = acesso.ConsultarSql(sql, lista);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static int ConsultarEstado(int idCidade)
        {
            try
            {
                lista.Clear();
                sql = "select idEstado from tblCidade where id = @id";
                lista.Add(new SqlParameter("@id", idCidade));
                return acesso.ExecutarSqlIdentity(sql, lista);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static Image RetornarImagem(int escolha)
        {            
            if (escolha == 0)
            {
                return Properties.Resources.Historico;
            }
            else if (escolha == 1)
            {
                return Properties.Resources.Medicamentos;
            }
            else if (escolha == 2)
            {
                return Properties.Resources.Vacina;
            }
            else if (escolha == 3)
            {
                return Properties.Resources.Vermifugo;
            }
            return null;
        }
    }
}
