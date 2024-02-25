using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyects.App.Exceptions
{
        public class ProductNotFound : Exception
        {
            public override string Message { get; }
            public ProductNotFound()
            {
                Message = "El producto no fue encontro.";
            }
        }
}
