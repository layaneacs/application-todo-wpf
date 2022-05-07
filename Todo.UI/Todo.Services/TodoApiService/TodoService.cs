using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Domain.Models;
using Todo.Domain.Services.TodoApiService;

namespace Todo.Services.TodoApiService
{
    public class TodoService : ITodoService
    {
        //Implementar comunicação com a API TODO
        public Task<List<TodoModel>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
