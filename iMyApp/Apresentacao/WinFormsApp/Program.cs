using Negocio.Entidades;
using WinFormsApp.Telas.Cargos;
using WinFormsApp.Telas.clientes.fonecedores;
using WinFormsApp.Telas.Clientes;
using WinFormsApp.Telas.clientes.Usuario;
namespace WinFormsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                ApplicationConfiguration.Initialize();
                Application.Run(new frmUsuario());
            }
            catch (Exception)
            {

                throw;
            }
           
        }
    }
}