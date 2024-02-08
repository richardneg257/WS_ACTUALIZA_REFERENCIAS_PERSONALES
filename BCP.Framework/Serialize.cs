using Newtonsoft.Json;
using System;
using System.Reflection;

namespace BCP.Framework
{
    public class Json
    {
        public static string ToObject(object _object)
        {
            try
            {
                return JsonConvert.SerializeObject(_object);
            }
            catch (Exception ex)
            {
                throw new Exception(MethodBase.GetCurrentMethod() + " - A problem occurred: ", ex);
            }
        }
    }
}
