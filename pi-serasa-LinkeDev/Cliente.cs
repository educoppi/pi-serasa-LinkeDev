﻿using System;
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
            if (tabela.Rows.Count == 0)
                return null;

            Cliente cliente = carregaDados(tabela.Rows[0]);
            return cliente;
        }

        public Cliente editaCliente(string nome, string descricao, string imagem_icon, int id)
        {
            string query1 = $"UPDATE cliente SET nome = '{nome}', descricao = '{descricao}', imagem_icon = '{imagem_icon}' WHERE id = {id};";
            string query2 = $"SELECT * FROM cliente WHERE id = {id}";

            Conexao.executaQuery(query1);

            DataTable tabela = Conexao.executaQuery(query2);

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
