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
        /*
        public ServicosFavoritados carregaDados(DataRow linha)
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
        */
    }
}
