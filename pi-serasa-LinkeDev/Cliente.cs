using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi_serasa_LinkeDev
{
    internal class Cliente
    {
        public int id;
        public string nome;
        public string descricao;
        public string imagem_icon;

        public Cliente(int id, string nome, string descricao, string imagem_icon)
        {
            this.id = id;
            this.nome = nome;
            this.descricao = descricao;
            this.imagem_icon = imagem_icon;
        }

        public Cliente() { }

        public Cliente retornaCliente(int id)
        {
            string query = $"SELECT * FROM cliente WHERE id = {id};";

            DataTable tabela = Conexao.executaQuery(query);

            Cliente cliente = carregaDados(tabela.Rows[0]);

            return cliente;
        }

        public Cliente carregaDados(DataRow linha)
        {
            int id = int.Parse(linha["id"].ToString());
            string nome = linha["nome"].ToString();
            string descricao = linha["descricao"].ToString();
            string imagem_icon = linha["imagem_icon"].ToString();

            Cliente cliente = new Cliente(id, nome, descricao, imagem_icon);

            return cliente;
        }
    }
}
