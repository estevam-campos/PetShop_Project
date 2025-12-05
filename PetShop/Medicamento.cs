using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    public class Medicamento
    {
        public int id { get; set; }
        public DateTime data { get; set; }
        public string medicamento { get; set; }
        public decimal peso { get; set; }
        public int idAnimal { get; set; }
        public Medicamento()
        {
            id = 0;
            data = DateTime.Now;
            medicamento = string.Empty;
            peso = 0;
            idAnimal = 0;
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
                sql = "select id, data, medicamento, peso, idAnimal \n";
                sql += "from tblMedicamento \n";
                if (id != 0)
                {
                    sql += "where id = @id \n";
                    lista.Add(new SqlParameter("@id", id));
                }
                else if (idAnimal != 0)
                {
                    sql += "where idAnimal = @idAnimal \n";
                    lista.Add(new SqlParameter("@idAnimal", idAnimal));
                }
                sql += "order by data";
                dt = acesso.ConsultarSql(sql, lista);
                if (id != 0)
                {
                    id = Convert.ToInt32(dt.Rows[0]["id"]);
                    data = Convert.ToDateTime(dt.Rows[0]["data"]);
                    medicamento = dt.Rows[0]["medicamento"].ToString();
                    peso = Convert.ToDecimal(dt.Rows[0]["peso"]);
                    idAnimal = Convert.ToInt32(dt.Rows[0]["idAnimal"]);
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
                    sql = "insert into tblMedicamento \n";
                    sql += "(data, medicamento, peso, idAnimal, idUsuario) \n";
                    sql += "values \n";
                    sql += "(@data, @medicamento, @peso, @idAnimal, @idUsuario) \n";
                }
                else
                {
                    lista.Clear();
                    sql = "update tblMedicamento set \n";
                    sql += "data = @data, \n";
                    sql += "medicamento = @medicamento, \n";
                    sql += "peso = @peso, \n";
                    sql += "idAnimal = @idAnimal, \n";
                    sql += "idUsuario = @idUsuario \n";
                    sql += "where id = @id";
                    lista.Add(new SqlParameter("@id", id));
                }
                lista.Add(new SqlParameter("@data", data));
                lista.Add(new SqlParameter("@medicamento", medicamento));
                lista.Add(new SqlParameter("@peso", peso));
                lista.Add(new SqlParameter("@idAnimal", idAnimal));
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
