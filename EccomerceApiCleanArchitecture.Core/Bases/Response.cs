using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EccomerceApiCleanArchitecture.Core.Bases
{
    public class Response<T>
    {
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
        public object Meta { get; set; }
        public List<string> Errors { get; set; }
        public Response()
        {
            //Error = new List<string>();
        }

        public Response(HttpStatusCode statusCode, bool isSuccess, string message, T data, object meta = null)
        {
            StatusCode = statusCode;
            IsSuccess = isSuccess;
            Message = message;
            Data = data;
            Meta = meta;
            Errors = new List<string>();
        }

        public Response(HttpStatusCode statusCode, bool isSuccess, string message, List<string> error)
        {
            StatusCode = statusCode;
            IsSuccess = isSuccess;
            Message = message;
            Errors = error;
        }
        public static Response<T> Failure(List<string> errors)
        {
            return new Response<T>
            {
                StatusCode = HttpStatusCode.BadRequest,
                IsSuccess = false,
                Message = "Validation failed",
                Errors = errors
            };
        }
        public static Response<T> Failure(string message)
        {
          
            return new Response<T>
            {
                StatusCode = HttpStatusCode.BadRequest,
                IsSuccess = false,
                Message = message,
            };

        }
        public static Response<T> Success(T data)
        {
            return new Response<T>
            {
                StatusCode = HttpStatusCode.OK,
                IsSuccess = true,
                Message = "Success",
                Data = data,
               

            };
        }




    }
}
