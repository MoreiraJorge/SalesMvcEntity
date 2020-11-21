using System;

namespace SalesWebMvc.Services.Exceptions
{
    public class DbConcurrencyExcpetion : ApplicationException
    {
        public DbConcurrencyExcpetion(string message) : base(message)
        {
        }
    }
}
