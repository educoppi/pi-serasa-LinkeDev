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