using System;

namespace ExcecoesPersonalizadas.Entities.Excepctions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {            
        }
    }
}
