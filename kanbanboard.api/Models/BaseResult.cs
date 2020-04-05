using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace kanbanboard.api.Models
{
    public class BaseResult<T>
    {
        public T data { get; set; }
        public HttpStatusCode statusCode { get; set; }
        public string errorMessage { get; set; }

        public BaseResult()
        {
            data = (T)Activator.CreateInstance(typeof(T));
            statusCode = HttpStatusCode.OK;
            errorMessage = "İşleminiz Başarıyla Gerçekleştirildi";
        }
    }
}
