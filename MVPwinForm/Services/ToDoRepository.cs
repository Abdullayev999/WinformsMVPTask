using System;
using System.Collections.Generic;
using MVPwinForm.Models;

namespace MVPwinForm.Services
{
    public class ToDoRepository : IToDoRepository
    {
        private List<ToDo> task;

        public ToDoRepository()
        {
            task = new List<ToDo>();

            var tmp = new ToDo()
            {
                Id = Guid.NewGuid().ToString(),
                Description = "He is Programmer",
                Title = "Farid"
            };
            task.Add(tmp);

            tmp = new ToDo()
            {
                Id = Guid.NewGuid().ToString(),
                Description = "She is artist",
                Title = "Ceyran"
            };
            task.Add(tmp);

            tmp = new ToDo()
            {
                Id = Guid.NewGuid().ToString(),
                Description = "He is ekonomist",
                Title = "Cavid"
            };

            task.Add(tmp);
        }
        public IEnumerable<ToDo> GetToDos()
        {
            return task;
        }

        public void AddToDo(ToDo toDo)
        {
           task.Add(toDo);
        }

        public void RemoveToDo(string id)
        {
            task.RemoveAll(x => x.Id == id);
        }
    }
}