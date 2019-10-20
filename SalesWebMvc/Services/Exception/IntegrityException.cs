using System;


namespace SalesWebMvc.Services.Exception
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException(String message) : base(message)
        {
        }
    }
}
