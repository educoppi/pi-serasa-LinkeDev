using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi_serasa_LinkeDev
{
    internal class ServicosFavoritados
    {
        public int id;
        public int id_usuario;
        public int id_servico;
        public string nome_servico;
        public string imagem_1;
        public string tipo;

        public ServicosFavoritados() { }
        

        public ServicosFavoritados(int id, int id_usuario, int id_servico, string nome_servico, string imagem_1, string tipo)
        {
            this.id = id;
            this.id_usuario = id_usuario;
            this.id_servico = id_servico;
            this.nome_servico = nome_servico;
            this.imagem_1 = imagem_1;
            this.tipo = tipo;
        }

        public void insere(int id_usuario, int id_servico, string nome, string imagem, string tipo)
        {
            string query = $"INSERT INTO servicos_favoritados (id_usuario, id_servico, nome_servico, imagem_1, tipo) VALUES ({id_usuario}, {id_servico}, '{nome}', '{imagem}', '{tipo}');";

            Conexao.executaQuery(query);
        }

        public void remove(int id_usuario, int id_servico)
        {
            string query = $"DELETE FROM servicos_favoritados WHERE id_usuario = {id_usuario} AND id_servico = {id_servico};";

            Conexao.executaQuery(query);
        }

        public ServicosFavoritados retorna(int id_usuario, int id_servico)
        {
            string query = $"SELECT * FROM servicos_favoritados WHERE id_usuario = {id_usuario} AND id_servico = {id_servico};";

            DataTable tabela = Conexao.executaQuery(query);
            if (tabela.Rows.Count == 0)
                return null;

            ServicosFavoritados sf = carregaDados(tabela.Rows[0]);
            return sf;
        }

        
        public ServicosFavoritados carregaDados(DataRow linha)
        {
            int id = int.Parse(linha["id"].ToString());
            int id_usuario = int.Parse(linha["id_usuario"].ToString());
            int id_servico = int.Parse(linha["id_servico"].ToString());
            string nome_servico = linha["nome_servico"].ToString();
            string tipo = linha["tipo"].ToString();
            string imagem_1 = linha["imagem_1"].ToString();

            ServicosFavoritados sf = new ServicosFavoritados(id, id_usuario, id_servico, nome_servico, tipo, imagem_1);

            return sf;
        }
    }
}
