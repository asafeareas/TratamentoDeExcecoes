using System;

namespace Tratamento {
    class DomainException : ApplicationException {
        public DomainException(string message) : base (message){
            
        }
    }
}