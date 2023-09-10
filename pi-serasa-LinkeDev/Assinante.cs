using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi_serasa_LinkeDev
{
    internal class Assinante
    {
        public int id;
        public string nome;
        public string descricao;
        public int itens_vendidos;
        public string imagem_icon;

        public Assinante() { }

        public Assinante(int id, string nome, string descricao, int itens_vendidos, string imagem_icon)
        {
            this.id = id;
            this.nome = nome;
            this.descricao = descricao;
            this.itens_vendidos = itens_vendidos;
            this.imagem_icon = imagem_icon;
        }
        public Assinante retornaAssinante(int id)
        {
            string query = $"SELECT * FROM assinante WHERE id = {id};";

            DataTable tabela = Conexao.executaQuery(query);

            if (tabela.Rows.Count == 0)
                return null;

            Assinante assinante = carregaDados(tabela.Rows[0]);
            return assinante;
        }

        public Assinante carregaDados(DataRow linha)
        {
            int id = int.Parse(linha["id"].ToString());
            string nome = linha["nome"].ToString();
            string descricao = linha["descricao"].ToString();
            int itens_vendidos = int.Parse(linha["itens_vendidos"].ToString());
            string imagem_icon = linha["imagem_icon"].ToString();

            Assinante assinante = new Assinante(id, nome, descricao, itens_vendidos, imagem_icon);

            return assinante;
        }

        public Assinante editaAssinante(string nome, string descricao, string imagem_icon, int id)
        {
            string query1 = $"UPDATE assinante SET nome = '{nome}', descricao = '{descricao}', imagem_icon = '{imagem_icon}' WHERE id = {id};";
            string query2 = $"SELECT * FROM assinante WHERE id = {id}";

            Conexao.executaQuery(query1);

            DataTable tabela = Conexao.executaQuery(query2);

            Assinante assinante = carregaDados(tabela.Rows[0]);
            return assinante;
        }
    }
}
