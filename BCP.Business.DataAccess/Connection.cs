using System;

namespace BCP.Business.DataAccess
{
    public class Connection
    {
        public static string Connect(string server, string db, string user, string password, string name)
        {
            string connection = string.Empty;
            try
            {
                connection = "Persist Security Info=True;User ID=" + user + ";Pwd=" + password + ";Server=" + server + ";Database=" + db + ";Application Name =" + name;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return connection;
        }
    }
}
