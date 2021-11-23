using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Shop_Versionado.Dao
{
    class Conexao
    {
        SqlConnection con = new SqlConnection();
        
        //Construtor
        public Conexao() {

            con.ConnectionString = @"Data Source=DESKTOP-GOUKEFT;Initial Catalog=Pet_Shop;User ID=sa;Password=123456";
             
        }

        //Metodo
        public SqlConnection conectar() {

            if (con.State == System.Data.ConnectionState.Closed) {
                con.Open();
            }

            return con;
        }

        public SqlConnection desconectar() {

            if (con.State == System.Data.ConnectionState.Open) {
                con.Close();
            }

            return con;
        }
    }
}
