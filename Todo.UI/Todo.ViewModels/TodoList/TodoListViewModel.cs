using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Domain.Models;
using Todo.Domain.Services.TodoApiService;

namespace Todo.ViewModels.TodoList
{
    public class TodoListViewModel : BaseViewModel
    {
        public ObservableCollection<TodoModel> Todos { get; }
        private ITodoService _service { get; }


        public TodoListViewModel(ITodoService service)
        {
            Todos = new ObservableCollection<TodoModel>();
            _service = service;

            LoadTodos();
        }

        private async void LoadTodos()
        {
            Todos.Clear();
            var todos = await _service.GetAll();

            foreach (var todo in todos)
            {
                Todos.Add(todo);
            }
        }



    }
}
