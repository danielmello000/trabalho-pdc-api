using System.Net;

namespace pdc_api.Model
{
    public class BaseResponse
    {
        public bool Success { get; set; }
        public HttpStatusCode Code { get; set; }
        public string Message { get; set; }
        public object? Data { get; set; }

        public BaseResponse()
        {

        }

        public BaseResponse(Object? data)
        {
            Data = data;
        }

        public BaseResponse SuccessResponse()
        {
            Success = true;
            Code = HttpStatusCode.OK;
            Message = "Requisição processada com sucesso.";

            return this;
        }

        public BaseResponse SuccessResponse(object data)
        {
            SuccessResponse();
            Data = data;
            return this;
        }

        public BaseResponse NotFoundResponse()
        {
            Code = HttpStatusCode.NotFound;
            Message = "O recurso não encontrado no servidor.";

            return this;
        }

        public BaseResponse ErrorResponse(string message)
        {
            Code = HttpStatusCode.BadRequest;
            Message = message;

            return this;
        }
    }
}
