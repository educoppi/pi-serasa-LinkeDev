namespace pi_serasa_LinkeDev
{
    internal static class Program
    {
        public static Usuario usuario;
        public static Servico servico;
        public static Assinante assinante;
        public static Cliente cliente;

        public static void servicoClicado(Servico servico)
        {
            Program.servico = servico;
            trocaMenuESQ.CarregaEntreTELAS(new Templates());
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