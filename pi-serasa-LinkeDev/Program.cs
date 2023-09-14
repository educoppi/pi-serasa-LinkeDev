using System.Security.Cryptography.X509Certificates;

namespace pi_serasa_LinkeDev
{
    internal static class Program
    {
        public static Usuario usuario;
        public static Servico servico;
        public static Assinante assinante;
        public static Cliente cliente;
        public static int idUsuarioCurtiu;
        public static int idUsuarioFavoritou;

        public static void servicoClicado(Servico servico)
        {
            Program.servico = servico;
            trocaMenuESQ.CarregaEntreTELAS(new Templates());
        }

        public static bool deletaServicoFavoritado(int id_usuario, int id_servico)
        {
            bool usuarioDeletou = false;
            ServicosFavoritados sf = new ServicosFavoritados();
            sf.remove(id_usuario, id_servico);
            MessageBox.Show("Serviço removido de Favoritos com sucesso!");
            return usuarioDeletou = true;
        }

        //Essas variaveis estaticas foram criadas para guardar o
        //email, senha e nome inseridos, em detrimento dos forms de ASSINARBTN
        //e Jatenho1 porque as ações de adicionar usuario, assinante ou alterar
        //cliente devem ocorrer somente quando o usuario clicar em comprar(os
        //botoes que estao na tela Assinar)
        public static string GuardaEmail;
        public static string GuardaSenha;
        public static string GuardaNome;
        /* 
         * Disparador foi criado para eu saber de onde vem GuardaEmail e GuardaSenha
         * ja que ele pode vir de assinarBtn como um novo usuario, ou de jatenho1
         * como um usuario ja existente que busca deixar de ser cliente e se 
         * tornar um assinante
         * 
         * True = assinarBTN
         * False = jatenho1
         * 
         */
        public static bool disparador;


        /**
        * Sinalizador tem a utilidade de mudar a função do botao de fechar no form "Assinar", anteriormente
        * esse mesmo botão apenas carregava as imagens da tela inicial, sendo assim se o usuario
        * clicasse nesse botao, mesmo apos ter efetuado o login, o panelCentral receberia as imagens
        * da tela de visitante e não as imagens da tela inicial (ou seja, os templates).
        * 
        * True = o usuario acessou pelo botão "Assine já".
        * False = o usuario acessou apos entrar ou logar no site pela area de assinar da tela de visitante.
        */
        public static bool sinalizador;


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}