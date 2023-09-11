using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi_serasa_LinkeDev
{
    internal class ServicosComprados
    {
        public int id;
        public int id_usuario;
        public int id_servico;
        public string nome_servico;
        public string tipo;
        public string imagem_1;
        public double valor;
        public string comprado_em;

        public ServicosComprados(int id, int id_usuario, int id_servico, string nome_servico, string tipo, string imagem_1, double valor, string comprado_em)
        {
            this.id = id;
            this.id_usuario = id_usuario;
            this.id_servico = id_servico;
            this.nome_servico = nome_servico;
            this.tipo = tipo;
            this.imagem_1 = imagem_1;
            this.valor = valor;
            this.comprado_em = comprado_em;
        }

        public ServicosComprados() { }

        public void insere(int id_usuario, int id_servico, string nome_servico, string tipo, string imagem_1, double valor)
        {
            string query = $"INSERT INTO servicos_comprados (id_usuario, id_servico, nome_servico, tipo, imagem_1, valor) VALUES ({id_usuario}, {id_servico}, '{nome_servico}', '{tipo}', '{imagem_1}', {valor});";

            Conexao.executaQuery(query);
        }

        public List<ServicosComprados> buscaServicosComprados(int id)
        {
            string query = $"SELECT * FROM servicos_comprados WHERE id_usuario = {id} ORDER BY id DESC;";

            DataTable tabela = Conexao.executaQuery(query);
            List<ServicosComprados> comprados = new List<ServicosComprados>();

            foreach (DataRow linha in tabela.Rows)
            {
                ServicosComprados sc = carregaDados(linha);
                comprados.Add(sc);
            }
            return comprados;
        }

        public ServicosComprados carregaDados(DataRow linha)
        {
            int id = int.Parse(linha["id"].ToString());
            int id_usuario = int.Parse(linha["id_usuario"].ToString());
            int id_servico = int.Parse(linha["id_servico"].ToString());
            string nome_servico = linha["nome_servico"].ToString();
            string tipo = linha["tipo"].ToString();
            string imagem_1 = linha["imagem_1"].ToString();
            double valor = double.Parse(linha["valor"].ToString());
            string comprado_em = linha["comprado_em"].ToString();

            ServicosComprados sc = new ServicosComprados(id, id_usuario, id_servico, nome_servico, tipo, imagem_1, valor, comprado_em);

            return sc;
        }
    }
}
