using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVPwinForm.Models;
using MVPwinForm.Views;

namespace MVPwinForm.Presenters
{
    class ToDoAddPresenter
    {
        private readonly IToDoAddView view;
        private readonly IToDoRepository repository;

        public ToDoAddPresenter(IToDoAddView view,IToDoRepository repository)
        {
            this.view = view;
            this.repository = repository;

            view.Add += AddTask;
        }

        private void AddTask()
        {
            var tmp = new ToDo()
            {
                Id = Guid.NewGuid().ToString(),
                Description = view.Description,
                Title = view.Title
            };

            repository.AddToDo(tmp);

        }
    }
}
