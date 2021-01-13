using System.Collections.Generic;
using MVPwinForm.Models;

namespace MVPwinForm
{
    public interface IToDoRepository
    {
        IEnumerable<ToDo> GetToDos();
        void AddToDo(ToDo toDo);
        void RemoveToDo(string id);
    }
}