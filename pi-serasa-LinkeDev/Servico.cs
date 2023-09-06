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
        private int id;
        private int id_assinante;
        private string nome;
        private string descricao;
        private string tipo;
        private string publicado_em;
        private double valor;
        private string imagem_1;
        private string imagem_2;
        private string imagem_3;
        private int vendidos;
        private int curtidas;
        private int qtd_favoritados;

        public Servico() { }

        public Servico(string imagem_1, string imagem_2, string imagem_3)
        { 
            this.imagem_1 = imagem_1;
            this.imagem_2 = imagem_2;
            this.imagem_3 = imagem_3;
        }

        public string getImagem_1 { get { return imagem_1; } }
        public string getImagem_2 { get { return imagem_2; } }
        public string getImagem_3 { get { return imagem_3; } }

        public Servico buscaImagensTelaVisitante(int id_postagem)
        {
           
            string query = $"SELECT imagem_1, imagem_2, imagem_3 FROM servicos WHERE id = {id_postagem};";

            DataTable tabela = Conexao.executaQuery(query);

            Servico servico = carregaImagens(tabela.Rows[0]);

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
    }
}
