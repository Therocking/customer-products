using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custumers.Application.Exceptions
{
    public class CostumerNotFound: Exception
    {
        public override string Message { get; }
        public CostumerNotFound()
        {
            Message = "El usuario no fue encontrado.";
        }
    }
}
