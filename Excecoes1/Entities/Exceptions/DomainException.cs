using System;

namespace Excecoes1.Entities.Exceptions
{
    public class DomainException : ApplicationException
    {
        public DomainException(string mensagem) : base(mensagem)
        {

        }
    }
}