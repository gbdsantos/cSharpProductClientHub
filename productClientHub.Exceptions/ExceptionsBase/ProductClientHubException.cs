﻿using System.Net;

namespace productClientHub.Exceptions.ExceptionsBase
{
    public abstract class ProductClientHubException: SystemException
    {
        public ProductClientHubException(string errorMessage) : base(errorMessage)
        {
        }

        public abstract List<string> GetErrors();
        public abstract HttpStatusCode GetHttpStatusCode();
    }
}
