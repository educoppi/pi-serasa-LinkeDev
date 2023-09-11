using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi_serasa_LinkeDev
{
    internal class Servico
    {
        public int id;
        public int id_assinante;
        public string nome_assinante;
        public string nome;
        public string descricao;
        public string tipo;
        public string publicado_em;
        public double valor;
        public string imagem_1;
        public string imagem_2;
        public string imagem_3;
        public int vendidos;
        public int curtidas;
        public int qtd_favoritados;

        public Servico() { }

        public Servico(int id, int id_assinante, string nome_assinante, string nome, string descricao, string tipo, string publicado_em, double valor, string imagem_1, string imagem_2, string imagem_3, int vendidos, int curtidas, int qtd_favoritados)
        {
            this.id = id;
            this.id_assinante = id_assinante;
            this.nome_assinante = nome_assinante;
            this.nome = nome;
            this.descricao = descricao;
            this.tipo = tipo;
            this.publicado_em = publicado_em;
            this.valor = valor;
            this.imagem_1 = imagem_1;
            this.imagem_2 = imagem_2;
            this.imagem_3 = imagem_3;
            this.vendidos = vendidos;
            this.curtidas = curtidas;
            this.qtd_favoritados = qtd_favoritados;
        }

        public Servico(int id, int id_assinante, string nome, string tipo, string publicado_em, double valor, string imagem_1, int vendidos)
        {
            this.id = id;
            this.id_assinante = id_assinante;
            this.nome = nome;
            this.tipo = tipo;
            this.publicado_em = publicado_em;
            this.valor = valor;
            this.imagem_1 = imagem_1;
            this.vendidos = vendidos;
        }

        public Servico(int id, string imagem_1)
        {
            this.id = id;
            this.imagem_1 = imagem_1;
        }

        public Servico(string imagem_1, string imagem_2, string imagem_3)
        {
            this.imagem_1 = imagem_1;
            this.imagem_2 = imagem_2;
            this.imagem_3 = imagem_3;
        }
        public Servico(int curtidas, int vendidos, int qtd_favoritados)
        {
            this.curtidas = curtidas;
            this.vendidos = vendidos;
            this.qtd_favoritados = qtd_favoritados;
        }

        public string getImagem_1 { get { return imagem_1; } }
        public string getImagem_2 { get { return imagem_2; } }
        public string getImagem_3 { get { return imagem_3; } }


        public List<Servico> buscaServicosDeAssinante(int id)
        {
            string query = $"SELECT * FROM servicos WHERE id_assinante = {id} ORDER BY publicado_em DESC;";

            DataTable tabela = Conexao.executaQuery(query);
            List<Servico> servicos = new List<Servico>();

            foreach (DataRow linha in tabela.Rows)
            {
                Servico servico = carregaDados(linha);
                servicos.Add(servico);
            }

            return servicos;
        }

        /*
        public Servico carregaDadosServicoDeAssinante(DataRow linha)
        {
            int id = int.Parse(linha["id"].ToString());
            int id_assinante = int.Parse(linha["id_assinante"].ToString());
            string nome = linha["nome"].ToString();
            string tipo = linha["tipo"].ToString();
            string publicado_em = (linha["publicado_em"].ToString());
            double valor = double.Parse(linha["valor"].ToString());
            string imagem_1 = linha["imagem_1"].ToString();
            int vendidos = int.Parse(linha["vendidos"].ToString());

            Servico servico = new Servico(id, id_assinante, nome, tipo, publicado_em,
                valor, imagem_1, vendidos);

            return servico;
        }
        */

        public List<Servico> buscaImagensTemplates()
        {
            string query = $"SELECT * FROM servicos WHERE tipo = 'templates';";

            DataTable tabela = Conexao.executaQuery(query);
            List<Servico> servicos = new List<Servico>();

            foreach (DataRow linha in tabela.Rows)
            {
                Servico servico = carregaDados(linha);
                servicos.Add(servico);
            }

            return servicos;
        }

        public List<Servico> buscaImagensMobile()
        {
            string query = $"SELECT * FROM servicos WHERE tipo = 'mobile';";

            DataTable tabela = Conexao.executaQuery(query);
            List<Servico> servicos = new List<Servico>();

            foreach (DataRow linha in tabela.Rows)
            {
                Servico servico = carregaDados(linha);
                servicos.Add(servico);
            }

            return servicos;
        }

        public List<Servico> buscaImagensWeb()
        {
            string query = $"SELECT * FROM servicos WHERE tipo = 'web';";

            DataTable tabela = Conexao.executaQuery(query);
            List<Servico> servicos = new List<Servico>();

            foreach (DataRow linha in tabela.Rows)
            {
                Servico servico = carregaDados(linha);
                servicos.Add(servico);
            }

            return servicos;
        }

        public List<Servico> buscaImagensGames()
        {
            string query = $"SELECT * FROM servicos WHERE tipo = 'games';";

            DataTable tabela = Conexao.executaQuery(query);
            List<Servico> servicos = new List<Servico>();

            foreach (DataRow linha in tabela.Rows)
            {
                Servico servico = carregaDados(linha);
                servicos.Add(servico);
            }

            return servicos;
        }

        public List<Servico> buscaImagensBancoDeDados()
        {
            string query = $"SELECT * FROM servicos WHERE tipo = 'banco de dados';";

            DataTable tabela = Conexao.executaQuery(query);
            List<Servico> servicos = new List<Servico>();

            foreach (DataRow linha in tabela.Rows)
            {
                Servico servico = carregaDados(linha);
                servicos.Add(servico);
            }

            return servicos;
        }

        public List<Servico> buscaImagensBackEnd()
        {
            string query = $"SELECT * FROM servicos WHERE tipo = 'back-end';";

            DataTable tabela = Conexao.executaQuery(query);
            List<Servico> servicos = new List<Servico>();

            foreach (DataRow linha in tabela.Rows)
            {
                Servico servico = carregaDados(linha);
                servicos.Add(servico);
            }

            return servicos;
        }

        public List<Servico> buscaImagensFrontEnd()
        {
            string query = $"SELECT * FROM servicos WHERE tipo = 'front-end';";

            DataTable tabela = Conexao.executaQuery(query);
            List<Servico> servicos = new List<Servico>();

            foreach (DataRow linha in tabela.Rows)
            {
                Servico servico = carregaDados(linha);
                servicos.Add(servico);
            }

            return servicos;
        }

        public List<Servico> buscaImagensFullStack()
        {
            string query = $"SELECT * FROM servicos WHERE tipo = 'full-stack';";

            DataTable tabela = Conexao.executaQuery(query);
            List<Servico> servicos = new List<Servico>();

            foreach (DataRow linha in tabela.Rows)
            {
                Servico servico = carregaDados(linha);
                servicos.Add(servico);
            }
            return servicos;
        }

        public List<Servico> buscaImagensDesktop()
        {
            string query = $"SELECT * FROM servicos WHERE tipo = 'desktop';";

            DataTable tabela = Conexao.executaQuery(query);
            List<Servico> servicos = new List<Servico>();

            foreach (DataRow linha in tabela.Rows)
            {
                Servico servico = carregaDados(linha);
                servicos.Add(servico);
            }
            return servicos;
        }

 
        
        public List<Servico> buscaImagens()
        {
            string query = $"SELECT imagem_1, imagem_2, imagem_3 FROM servicos;";

            DataTable tabela = Conexao.executaQuery(query);

            List<Servico> servicos = new List<Servico>();

            foreach (DataRow linha in tabela.Rows)
            {
                Servico servico = carregaDadosImagens(linha);
                servicos.Add(servico);
            }
            return servicos;
        }

        public Servico carregaDadosImagens(DataRow linha)
        {
            string imagem_1 = linha["imagem_1"].ToString();
            string imagem_2 = linha["imagem_2"].ToString();
            string imagem_3 = linha["imagem_3"].ToString();

            Servico servico = new Servico(imagem_1, imagem_2, imagem_3);

            return servico;
        }


        public Servico carregaDados(DataRow linha)
        {
            int id = int.Parse(linha["id"].ToString());
            int id_assinante = int.Parse(linha["id_assinante"].ToString());
            string nome_assinante = linha["nome_assinante"].ToString();
            string nome = linha["nome"].ToString();
            string descricao = linha["descricao"].ToString();
            string tipo = linha["tipo"].ToString();
            string publicado_em = (linha["publicado_em"].ToString());
            double valor = double.Parse(linha["valor"].ToString());
            string imagem_1 = linha["imagem_1"].ToString();
            string imagem_2 = linha["imagem_2"].ToString();
            string imagem_3 = linha["imagem_3"].ToString();
            int vendidos = int.Parse(linha["vendidos"].ToString());
            int curtidas = int.Parse(linha["curtidas"].ToString());
            int qtd_favoritados = int.Parse(linha["qtd_favoritados"].ToString());

            Servico servico = new Servico(id, id_assinante, nome_assinante, nome, descricao, tipo, publicado_em,
                valor, imagem_1, imagem_2, imagem_3, vendidos, curtidas, qtd_favoritados);

            return servico;
        }
        public Servico carregaImagens(DataRow linha)
        {
            string imagem1 = linha["imagem_1"].ToString();
            string imagem2 = linha["imagem_2"].ToString();
            string imagem3 = linha["imagem_3"].ToString();
            Servico servico = new Servico(imagem1, imagem2, imagem3);

            return servico;
        }

        public void atualizaCurtida(int numeroCurtidas, int id)
        {
            string query = $"UPDATE servicos SET curtidas = {numeroCurtidas} WHERE id = {id};";

            Conexao.executaQuery(query);
        }

        public void atualizaFavoritado(int numeroFavoritados, int id)
        {
            string query = $"UPDATE servicos SET qtd_favoritados = {numeroFavoritados} WHERE id = {id};";

            Conexao.executaQuery(query);
        }
        public void atualizaVendidos(int numeroFavoritados, int id)
        {
            string query = $"UPDATE servicos SET vendidos = {numeroFavoritados} WHERE id = {id};";

            Conexao.executaQuery(query);
        }

        public Servico retornaNumeros(int id)
        {
            string query = $"SELECT vendidos, curtidas, qtd_favoritados FROM servicos WHERE id = {id};";

            DataTable tabela = Conexao.executaQuery(query);

            Servico servico = carregaDadosNumericos(tabela.Rows[0]);
            return servico;
        }
        public Servico carregaDadosNumericos(DataRow linha)
        {
            int vendidos = int.Parse(linha["vendidos"].ToString());
            int curtidas = int.Parse(linha["curtidas"].ToString());
            int qtd_favoritados = int.Parse(linha["qtd_favoritados"].ToString());

            Servico servico = new Servico(curtidas, vendidos, qtd_favoritados);

            return servico;
        }

        public void insereServico(int id_assinante, string nome_assinante, string nome, string descricao, string tipo, double valor, string imagem_1, string imagem_2, string imagem_3)
        {
            string query = $"INSERT INTO servicos (id_assinante, nome_assinante, nome, descricao, tipo, valor, imagem_1, imagem_2, imagem_3) VALUES ({id_assinante}, '{nome_assinante}', '{nome}','{descricao}', '{tipo}', {valor}, '{imagem_1}', '{imagem_2}', '{imagem_3}');";

            Conexao.executaQuery(query);
        }

        public void editaNomeAssinante(int id, string novoNomeAssinante)
        {
            string query = $"UPDATE servicos SET nome_assinante = '{novoNomeAssinante}' WHERE id_assinante = {id};";

            Conexao.executaQuery(query);
        }

        public Servico buscaPorId(int id)
        {
            string query = $"SELECT * FROM servicos WHERE id = {id};";

            Conexao.executaQuery(query);

            DataTable tabela = Conexao.executaQuery(query);

            Servico servico = carregaDados(tabela.Rows[0]);
            return servico;
        }
    }
}