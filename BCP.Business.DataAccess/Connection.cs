using System;

namespace BCP.Business.DataAccess
{
    public class Connection
    {
        public static string ConnectDb(string server, string db, string user, string password, string name)
        {
            string connection = string.Empty;
            try
            {
                //connection = "Persist Security Info=True;User ID=" + user + ";Pwd=" + password + ";Server=" + server + ";Database=" + db + ";Application Name =" + name;
                connection = "Data Source=DEVBMD01;Initial Catalog=BD_Billetera;Integrated Security=True";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return connection;
        }
    }
}
