using System;
using Todo.Domain.ValueObjects;

namespace Todo.Domain.Models
{
    public class TodoModel
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }        
        public Status Status { get; set; }
        public DateTime DataRegistro { get; set; }
    }
}
