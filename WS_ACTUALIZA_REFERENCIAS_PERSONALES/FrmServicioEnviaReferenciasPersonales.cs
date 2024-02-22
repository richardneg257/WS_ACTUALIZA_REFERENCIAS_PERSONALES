using BCP.Business.DataAccess;
using BCP.Business.DataAccess.DB;
using BCP.Business.Models;
using BCP.Framework.Logs;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace WS_ACTUALIZA_REFERENCIAS_PERSONALES
{
    public partial class FrmServicioEnviaReferenciasPersonales : Form
    {
        #region Obtencion de Parametros AppConfig

        //Parametros Base de datos                
        private static readonly string Database = ConfigurationManager.AppSettings.Get("ConnectionStrings_DB_API_Database");
        private static readonly string PasswordBD = ConfigurationManager.AppSettings.Get("ConnectionStrings_DB_API_Password");
        private static readonly string ServerBD = ConfigurationManager.AppSettings.Get("ConnectionStrings_DB_API_Server");
        private static readonly string TimeoutBD = ConfigurationManager.AppSettings.Get("ConnectionStrings_DB_API_Timeout");
        private static readonly string UserBD = ConfigurationManager.AppSettings.Get("ConnectionStrings_DB_API_User");
        private static readonly string NameBD = ConfigurationManager.AppSettings.Get("ConnectionStrings_DB_API_Name");

        //Settings
        private static readonly double Interval = double.Parse(ConfigurationManager.AppSettings.Get("IntervalTime"));
        private static readonly string ExecutionTime = ConfigurationManager.AppSettings.Get("ExecutionTime");

        //Paramtros Logs
        private static readonly string Path_Log_File = ConfigurationManager.AppSettings.Get("Path_Log_File");
        private static readonly string Level = ConfigurationManager.AppSettings.Get("Log_Level");

        #endregion

        #region Variables globales

        string connection;
        string moduleLog = "WS_ACTUALIZA_REFERENCIAS_PERSONALES.ServiceEnviaReferenciasPersonales.CallServiceEnviaReferenciasPersonales()";
        ReferenciaPersonalDA referenciaPersonalDA;
        Logger logger;
        private bool isTimerStarted;

        private static Timer timerEnviaReferenciasPersonales = new Timer();

        #endregion
        public FrmServicioEnviaReferenciasPersonales()
        {
            InitializeComponent();

            //Creacion timer 
            timerEnviaReferenciasPersonales = new Timer(Interval * 10000);
            timerEnviaReferenciasPersonales.Elapsed += CallServiceEnviaReferenciasPersonales;
            timerEnviaReferenciasPersonales.Enabled = true;
            isTimerStarted = true;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string moduleLog = "WS_ACTUALIZA_REFERENCIAS_PERSONALES.ServicioEnviaReferenciasPersonales";
            Logger.Debug(moduleLog, "/****************************** INICIA SERVICIO - ENVIA REFERENCIAS PERSONALES ***************************/");
            Logger.Debug("LogServiceEnvioReporte", "Se inició el servicio WS_ACTUALIZA_REFERENCIAS_PERSONALES a hrs:" + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString());
            //EventLog.WriteEntry("LogServiceEnvioReporte", "Se inició el servicio WS_ACTUALIZA_REFERENCIAS_PERSONALES a hrs:" + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString());
            timerEnviaReferenciasPersonales.Start();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {

        }

        private void CallServiceEnviaReferenciasPersonales(object sender, ElapsedEventArgs e)
        {
            var getDate = DateTime.Now.ToString("HH:mm");
            //if (getDate.Equals(ExecutionTime))
            //{
                try
                {
                    if (isTimerStarted)
                    {
                        timerEnviaReferenciasPersonales.Stop();
                        Initialize();
                        isTimerStarted = false;

                        var response = referenciaPersonalDA.InsertNewClientsIntoPersonalReferences();
                        if (response is null)
                        {
                            Logger.Debug(moduleLog + ": NO EXISTEN NUEVOS CLIENTES EN LA BASE DE DATOS¡");
                            return;
                        }

                        timerEnviaReferenciasPersonales.Start();
                        isTimerStarted = true;
                    }
                    else
                    {
                        Logger.Error("WS_REPORTE_API_PAGO.ServiceEnvioReporte", "Revisar! isTimerStarted: false");
                    }

                }
                catch (Exception ex)
                {
                    Logger.Error(moduleLog + ": Exception: " + ex.Message);
                    //Start servicio PRUEBA
                    timerEnviaReferenciasPersonales.Start();
                    isTimerStarted = true;
                    Logger.Error(moduleLog + ": isTimerStarted: True");
                }
            //}
        }

        private void Initialize()
        {
            //Instancia Logger
            if (logger is null)
                logger = new Logger(Path_Log_File + "/LogsReport.txt", Level);

            //Instancia para la conexion a base de datos
            if (connection is null)
                connection = Connection.ConnectDb(ServerBD, Database, UserBD, PasswordBD, NameBD);

            //Conexion a Referencias Personales
            if (referenciaPersonalDA is null)
                referenciaPersonalDA = new ReferenciaPersonalDA(connection, Convert.ToInt32(TimeoutBD));
        }
    }
}
