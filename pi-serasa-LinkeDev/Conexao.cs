﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi_serasa_LinkeDev
{
    internal class Conexao
    {
        const string host = "srv793.hstgr.io";
        const string banco = "u647084545_serasa_jee";
        const string usuario = "u647084545_serasa_jee";
        const string senha = "Serasa2023";

        const string dadosConexao = $"Server={host};Database={banco};Uid={usuario};Pwd={senha};";
        static MySqlConnection conexao = new MySqlConnection(dadosConexao);

        public static DataTable executaQuery(string query)
        {
            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand(query, conexao);
                MySqlDataReader dados = comando.ExecuteReader();

                DataTable tabela = new DataTable();

                tabela.Load(dados);
                return tabela;
            }
            catch (Exception erro)
            {
                Console.WriteLine("Erro ao realizar consulta: ");
                Console.WriteLine(erro.Message);
                return null;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
