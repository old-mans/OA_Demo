using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA_Demo.Helper
{
    public class ReturnStd
    {
        public class ReturnJson
        {
            public string Status { get; set; }
            public string Message { get; set; }
            public object Data { get; set; }
        }
        public static ReturnJson ComJson(string responseMessage, string responseCode, object rtnData = null)
        {
            ReturnJson returnJson = new ReturnJson()
            {
                Status = responseCode,
                Message = responseMessage,
                Data = rtnData ?? string.Empty
            };
            return returnJson;
        }

        public static ReturnJson Success(object rtnData = null)
        {
            ReturnJson returnJson = new ReturnJson()
            {
                Status = "200",
                Message = string.Empty,
                Data = rtnData ?? string.Empty
            };
            return returnJson;
        }

        public static ReturnJson Error(string responseMessage, string responseCode = "400", object rtnData = null)
        {
            ReturnJson returnJson = new ReturnJson()
            {
                Status = responseCode,
                Message = responseMessage ?? string.Empty,
                Data = rtnData ?? string.Empty
            };
            return returnJson;
        }

        public static ReturnJson ModelError(ModelStateDictionary modelState, string responseCode = "400", object rtnData = null)
        {
            string messages = string.Join("; ", modelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage));

            ReturnJson returnJson = new ReturnJson()
            {
                Status = responseCode,
                Message = messages,
                Data = rtnData ?? string.Empty
            };
            return returnJson;
        }

        public static ReturnJson NotAuthorize(string responseMessage, string responseCode = "90", object rtnData = null)
        {
            ReturnJson returnJson = new ReturnJson()
            {
                Status = responseCode,
                Message = responseMessage ?? string.Empty,
                Data = rtnData ?? string.Empty
            };
            return returnJson;
        }
    }
}
