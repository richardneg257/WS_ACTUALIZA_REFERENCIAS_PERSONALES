using System.ServiceProcess;
using System.Timers;

namespace WS_ACTUALIZA_REFERENCIAS_PERSONALES
{
    public partial class ServicioEnviaReferenciasPersonales : ServiceBase
    {
        private static Timer timerEnviaReferenciasPersonales = new Timer();

        public ServicioEnviaReferenciasPersonales()
        {
            InitializeComponent();

            timerEnviaReferenciasPersonales.Elapsed += new ElapsedEventHandler(CallServiceEnviaReferenciasPersonales);
            timerEnviaReferenciasPersonales.Enabled = true;
        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }

        private void CallServiceEnviaReferenciasPersonales(object sender, ElapsedEventArgs e)
        {
        }
    }
}
