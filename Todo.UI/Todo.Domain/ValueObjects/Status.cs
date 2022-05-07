using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Domain.ValueObjects
{
    public enum Status
    {
        NOVO,
        ANDAMENTO,
        CANCELADO, 
        FINALIZADO, 
        ATRASADO
    }
}
