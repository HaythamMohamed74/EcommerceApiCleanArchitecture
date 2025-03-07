using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
namespace EccomerceApiCleanArchitecture.Core.Bases
{
   public class ResponseHandler
    {

        public Response<T> UnAuthrized<T>()
        {
            return new Response<T>
            {
                StatusCode = HttpStatusCode.Unauthorized,
                IsSuccess = false,
                Message = "Unauthorized Access",
             
            };
        }

        public Response<T> Success<T>(T data,object meta=null)
        {
            return new Response<T>
            {
                StatusCode = HttpStatusCode.OK,
                IsSuccess = true,
                Message = "Success",
                Data = data,
                Meta = meta
            };
        }
        public Response<T> Failure<T>(string message)
        {
            return new Response<T>
            {
                StatusCode = HttpStatusCode.BadRequest,
                IsSuccess = false,
                Message = message
            };
        }
        
        public Response<T> Created<T>(T data)
        {
            return new Response<T>
            {
                StatusCode = HttpStatusCode.Created,
                IsSuccess = true,
                Message = "Created succesfully",
                Data=data,
              

            };
        }
        public Response<T> NotFound<T>(string message)
        {
            return new Response<T>
            {
                StatusCode = HttpStatusCode.NotFound,
                IsSuccess = false,
                Message = message
            };
        }
        public Response<T> Deleted<T>( string message)
        {
            return new Response<T>
            {
                StatusCode = HttpStatusCode.OK,
                IsSuccess = true,
                Message = message??"Deleted succesfully"

            };
        }
    }
}
