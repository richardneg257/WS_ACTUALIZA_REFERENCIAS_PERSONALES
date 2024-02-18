using BCP.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCP.Business.Models
{
    public class Response
    {
        public string State { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
        public object Exceptions { get; set; }

        public static Response Success(object data)
        {
            Response response = new Response
            {
                State = "00",
                Message = Validation.Exception(Validation.Responses.COMPLETED),
                Data = data,
                Exceptions = null
            };
            return response;
        }

        public static Response Exception(object exception)
        {
            Response response = new Response
            {
                State = "97",
                Message = Validation.Exception(Validation.Responses.EXCEPTION),
                Data = null,
                Exceptions = exception
            };
            return response;
        }

        public static Response Error(object exception, Validation.ErrorMessages errorMessages)
        {
            Response response = new Response
            {
                State = "98",
                Message = Validation.ErrorMessage(errorMessages),
                Data = null,
                Exceptions = exception
            };
            return response;
        }
    }
}
