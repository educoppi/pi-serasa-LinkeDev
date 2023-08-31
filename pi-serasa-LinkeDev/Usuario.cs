using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi_serasa_LinkeDev
{
    internal class Usuario
    {
        private int id;
        private string email;
        private string senha;
        private bool assinante;

        public Usuario() { }

        public Usuario(int id) {
            this.id = id;
        }
        public Usuario(string email, string senha)
        {
            this.email = email;
            this.senha = senha;
        }

        public Usuario(int id, string email, string senha, bool assinante)
        {
            this.id = id;
            this.email = email;
            this.senha = senha;
            this.assinante = assinante;
        }

        public List<Usuario> buscaTodos()
        {
            string query = "SELECT * FROM usuario;";

            DataTable tabela = Conexao.executaQuery(query);

            List<Usuario> usuarios = new List<Usuario>();

            //Para cada LINHA dentro de tabela.Rows
            //Ele guarda na variável linha o valor do loop atual dentro da tabela
            foreach (DataRow linha in tabela.Rows)
            {
                Usuario usuario = carregaDados(linha);
                usuarios.Add(usuario);
            }
            return usuarios;
        }

        public bool login(string email, string senha)
        {
            string query = $"SELECT id FROM usuario WHERE email = '{email}' AND senha = '{senha}';";

            DataTable tabela = Conexao.executaQuery(query);

            try
            {
                Usuario usuario = carregaDadosLogin(tabela.Rows[0]);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public void insere(string email, string senha)
        {
            string query = $"INSERT INTO usuario (email, senha) VALUES ('{email}', '{senha}');";

            Conexao.executaQuery(query);
        }

        public Usuario carregaDadosLogin(DataRow linha)
        {
            int id = int.Parse(linha["id"].ToString());
            Usuario usuario = new Usuario(id);

            return usuario;
        }

        public Usuario carregaDados(DataRow linha)
        {
            int id = int.Parse(linha["id"].ToString());
            string email = linha["email"].ToString();
            string senha = linha["senha"].ToString();
            bool assinante = linha["assinante"].ToString() == "1" ? true : false;
             
            Usuario usuario = new Usuario(id, email, senha, assinante);

            return usuario;
        }
    }
}
