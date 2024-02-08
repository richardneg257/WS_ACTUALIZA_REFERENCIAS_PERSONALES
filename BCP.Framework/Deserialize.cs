using Newtonsoft.Json;
using System;
using System.Reflection;

namespace BCP.Framework
{
    public class JsonD
    {
        public static T ToObject<T>(string _object)
        {
            try
            {
                var res = JsonConvert.DeserializeObject<T>(_object);
                return JsonConvert.DeserializeObject<T>(_object);
            }
            catch (Exception ex)
            {
                throw new Exception(MethodBase.GetCurrentMethod() + " - A problem occurred: ", ex);
            }
        }
    }
}
