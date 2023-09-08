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
        public int id;
        private string email;
        private string senha;
        private bool assinante;

        public Usuario() { }

        public Usuario(int id)
        {
            this.id = id;
        }
        public Usuario(int id, bool assinante)
        {
            this.id = id;
            this.assinante = assinante;
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

                                    //INSERE NAS TABELAS:
                                   //USUARIO
                                  //CLIENTE
                                 //ASSINANTE

        public void insereUsuario(string email, string senha, bool assinante)
        {
            string query = $"INSERT INTO usuario (email, senha, assinante) VALUES ('{email}', '{senha}', {assinante});";
            Conexao.executaQuery(query);
        }

        public void insereCliente(int id,string nome)
        {
            string query = $"INSERT INTO cliente (id, nome) VALUES ({id}, '{nome}');";

            Conexao.executaQuery(query);
        }

        public void insereAssinante(int id, string nome)
        {
            string query = $"INSERT INTO assinante (id, nome) VALUES ( {id}, '{nome}');";

            Conexao.executaQuery(query);
        }

                                      //LOGIN

        public Usuario login(string email, string senha)
        {
            string query = $"SELECT id, assinante FROM usuario WHERE email = '{email}' AND senha = '{senha}';";

            DataTable tabela = Conexao.executaQuery(query);

            if (tabela.Rows.Count == 0)
                return null;

            Usuario usuario = carregaDadosLogin(tabela.Rows[0]);
            return usuario;
        }

        public Usuario carregaDadosLogin(DataRow linha)
        {
            int id = int.Parse(linha["id"].ToString());
            bool assinante = linha["assinante"].ToString() == "1" ? true : false;

            Usuario usuario = new Usuario(id, assinante);

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

        //TRANSFORMA CLIENTE EM ASSINANTE, NA TABELA DE USUARIOS E DELETA 
        //DA TABELA CLIENTES AQUELE QUE SE TORNOU UM NOVO ASSINANTE
        /*
        public Usuario alteraClienteParaAssinante(Usuario usuario)
        {
            string query1 = "UPDATE usuario SET assinante = 1 WHERE id = {usuario.id};";
            string query2 = "DELETE FROM cliente WHERE id = {usuario.id};";
        }
        */
    }
}
