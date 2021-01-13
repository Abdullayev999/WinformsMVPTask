using System;
using System.Collections.Generic;
using MVPwinForm.Models;

namespace MVPwinForm.Views
{
    public interface IToDoListView
    {
        event Action Add;
        event Action<string> Remove;
        void UpdateTasks(IEnumerable<ToDo> toDo);
    }
}