using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using System.Windows.Forms;

namespace BLL
{
    class ClienteBLL
    {
        Conexao objConexao = new Conexao();

        public bool ValidarLogin(string user, string password)
        {
            string query = "SELECT * FROM tbl_cliente WHERE email = '" + user + "' AND senha = '" + password + "';";
            //string query = $"SELECT * FROM tbl_cliente WHERE email = '{user}' AND senha = '{password}';";

            DataTable resultado = new DataTable();

            resultado = objConexao.ExecutarConsulta(query);

            if(resultado.Rows.Count == 1) //Se encontra o usuário
            {
                return true;
            }else
            {
                return false;
            }
        }

        public bool ValidarLogin(string email)
        {
            string query = $"SELECT * FROM tbl_cliente WHERE email = '{email}';";

            DataTable resultado = new DataTable();

            resultado = objConexao.ExecutarConsulta(query);

            if (resultado.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int ValidarAcesso(string user, string password)
        {
            string query = $"SELECT * FROM tbl_cliente WHERE email = '{user}' AND senha = '{password}';";

            DataTable resultado = new DataTable();

            resultado = objConexao.ExecutarConsulta(query);

            if (resultado.Rows.Count == 1) //Retornar o nível de acesso do usuário que foi encontrado
            {
                //Retornar o conteúdo de uma coluna da tabela "TipoUsuario"
                return Convert.ToInt32(resultado.Rows[0]["TipoUsuario"]);
            }else
            {
                return -1; //-1 será considerado um valor inválido para tipo de usuário, ou seja, usuário não existe.
            }
        }

        public void AlterarSenha(string user, string password)
        {
            string sql = "UPDATE tbl_cliente SET senha = '" + password + "' WHERE email = '" + user + "';";
            objConexao.ExecutarComando(sql);
        }
    }
}
