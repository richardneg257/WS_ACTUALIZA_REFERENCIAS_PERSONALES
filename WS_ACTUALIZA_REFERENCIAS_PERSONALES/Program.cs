using System.ServiceProcess;
using System.Windows.Forms;

namespace WS_ACTUALIZA_REFERENCIAS_PERSONALES
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            //ServiceBase[] ServicesToRun;
            //ServicesToRun = new ServiceBase[]
            //{
            //    new ServicioEnviaReferenciasPersonales()
            //};
            //ServiceBase.Run(ServicesToRun);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmServicioEnviaReferenciasPersonales());
        }
    }
}
