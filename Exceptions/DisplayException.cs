using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Core.Data.Exceptions
{
    public class DisplayException : Exception
    {
        public DisplayException(string message, string type, HttpStatusCode code = HttpStatusCode.InternalServerError, string id = null, string level = "Error") : base(message)
        {
            Type = type;
            Code = code;
            Level = level;
            Id = id;
        }
        public string Id { get; private set; }
        public HttpStatusCode Code { get; private set; }
        public string Type { get; private set; }
        public string Level { get; private set; }
    }
}
