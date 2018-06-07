using System;
using System.Net;

namespace MySite.Shared
{
    public class ResponseModel : IResponseModel
    {
        public object Response
        {
            get => Response;
            set
            {
                if (value == null) return;

                ResponseType = value.GetType();
                Response = value;
            }
        }

        public Type ResponseType { get; set; }

        public HttpStatusCode Code { get; set; }

        public Exception Error { get; set; }
    }
}
