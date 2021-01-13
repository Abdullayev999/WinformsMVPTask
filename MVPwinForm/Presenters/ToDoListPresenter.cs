using System;
using System.Collections.Generic;
using MVPwinForm.Models;
using MVPwinForm.Views;

namespace MVPwinForm.Presenters
{
    public class ToDoListPresenter
    {
        private IToDoListView View { get; set; }
        private IToDoRepository Repository { get; set; }
        public ToDoListPresenter(IToDoListView view,IToDoRepository repository)
        {
            View = view;
            Repository = repository;
            
            View.UpdateTasks(repository.GetToDos());

            View.Add += AddTask;
            View.Remove += RemoveTask;

        }

        public void RemoveTask(string id)
        {
            Repository.RemoveToDo(id);
            View.UpdateTasks(Repository.GetToDos());
        }

        public void AddTask()
        {
            Program.OpenAddView();
            View.UpdateTasks(Repository.GetToDos());
        }
        
    }
}