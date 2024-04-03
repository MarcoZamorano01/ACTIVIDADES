namespace TIENDAACTIVIDADES.VISTAS
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());

            //LISTAR
            //Application.Run(new ClienteVistas.ClienteListarVista());
            Application.Run(new PedidoVistas.PedidoListarVista());

            //INSERTAR

            //EDITAR


        }
    }
}