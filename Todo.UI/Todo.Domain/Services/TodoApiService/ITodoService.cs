using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Todo.Domain.Models;

namespace Todo.Domain.Services.TodoApiService
{
    public interface ITodoService
    {
        Task<List<TodoModel>> GetAll();
    }
}
