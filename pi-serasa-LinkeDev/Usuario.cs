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
        public string email;
        private string senha;
        public bool isAssinante;

        public Usuario() { }

        public Usuario(int id)
        {
            this.id = id;
        }
        public Usuario(int id, bool assinante)
        {
            this.id = id;
            this.isAssinante = assinante;
        }

        public Usuario(string email, string senha)
        {
            this.email = email;
            this.senha = senha;
        }

        public Usuario(string email, string senha, bool isAssinante)
        {
            this.email = email;
            this.senha = senha;
            this.isAssinante = isAssinante;
        }

        public Usuario(int id, string email, string senha, bool isAssinante)
        {
            this.id = id;
            this.email = email;
            this.senha = senha;
            this.isAssinante = isAssinante;
        }
        public Usuario(string email)
        {
            this.email = email;
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

        public Usuario carregaDados(DataRow linha)
        {
            int id = int.Parse(linha["id"].ToString());
            string email = linha["email"].ToString();
            string senha = linha["senha"].ToString();
            bool assinante = Convert.ToBoolean(linha["assinante"].ToString());

            Usuario usuario = new Usuario(id, email, senha, assinante);

            return usuario;
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

        public void insereAssinante(int id, string nome, string descricao, string imagem_icon)
        {
            string query = $"INSERT INTO assinante (id, nome, descricao, imagem_icon) VALUES ( {id}, '{nome}', '{descricao}', '{imagem_icon}');";

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
        public Usuario buscaPorId(int id)
        {
            string query = $"SELECT id, assinante FROM usuario WHERE id = {id};";

            DataTable tabela = Conexao.executaQuery(query);

            if (tabela.Rows.Count == 0)
                return null;

            Usuario usuario = carregaDadosLogin(tabela.Rows[0]);
            return usuario;
        }

        public Usuario carregaDadosLogin(DataRow linha)
        {
            int id = int.Parse(linha["id"].ToString());
            bool isAssinante = Convert.ToBoolean(linha["assinante"].ToString());

            Usuario usuario = new Usuario(id, isAssinante);

            return usuario;
        }

        //TRANSFORMA CLIENTE EM ASSINANTE, NA TABELA DE USUARIOS E DELETA 
        //DA TABELA CLIENTES AQUELE QUE SE TORNOU UM NOVO ASSINANTE
        
        public void alteraClienteParaAssinante(Usuario usuario)
        {
            Cliente cliente = new Cliente();
            cliente = cliente.retornaCliente(usuario.id);

            insereAssinante(usuario.id, cliente.nome, cliente.descricao, cliente.imagem_icon);
            string query1 = $"UPDATE usuario SET assinante = 1 WHERE id = {usuario.id};";
            string query2 = $"DELETE FROM cliente WHERE id = {usuario.id};";

            Conexao.executaQuery(query1);
            Conexao.executaQuery(query2);

            Usuario u = new Usuario();
            Program.usuario = u.buscaPorId(usuario.id);
        }

        public Usuario retornaEmailUsuario(int id)
        {
            string query = $"SELECT email FROM usuario WHERE id = {id};";

            DataTable tabela = Conexao.executaQuery(query);

            Usuario usuario = carregaDadosEmail(tabela.Rows[0]);
            return usuario;
        }

        public Usuario carregaDadosEmail(DataRow linha)
        {
            string email = linha["email"].ToString();

            Usuario usuario = new Usuario(email);

            return usuario;
        }
    }
}
