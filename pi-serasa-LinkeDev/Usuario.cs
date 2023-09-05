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

        public void insereUsuario(string email, string senha)
        {
            string query = $"INSERT INTO usuario (email, senha) VALUES ('{email}', '{senha}');";
            Conexao.executaQuery(query);
        }

        public void insereCliente(string nome)
        {
            Usuario usuario = retornaUltimoID();
            string query = $"INSERT INTO cliente (id, nome) VALUES ({usuario.id}, '{nome}');";

            Conexao.executaQuery(query);
        }

        public void insereAssinante(string nome)
        {
            Usuario usuario = retornaUltimoID();
            string query = $"INSERT INTO assinante (id, nome) VALUES ( {usuario.id}, '{nome}');";

            Conexao.executaQuery(query);
        }

        public Usuario carregaDadosLogin(DataRow linha)
        {
            int id = int.Parse(linha["id"].ToString());
            Usuario usuario = new Usuario(id);

            return usuario;
        }

        public Usuario retornaUltimoID()
        {
            string query = $"SELECT last_insert_id();";

            DataTable tabela = Conexao.executaQuery(query);

            Usuario usuario = carregaUltimoID(tabela.Rows[0]);

            return usuario;
        }
        public Usuario carregaUltimoID(DataRow linha)
        {
            int id = int.Parse(linha["last_insert_id()"].ToString());
            Usuario usuario = new Usuario(id);

            return usuario;
        }

        public bool login(string email, string senha)
        {
            string query = $"SELECT id FROM usuario WHERE email = '{email}' AND senha = '{senha}';";

            DataTable tabela = Conexao.executaQuery(query);

            try
            {
                Usuario usuario = carregaDadosLogin(tabela.Rows[0]);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
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
