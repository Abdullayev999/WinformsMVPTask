using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using MVPwinForm.Models;
using Newtonsoft.Json;

namespace MVPwinForm.Services
{
    public class JsonToDoRepository : IToDoRepository
    {
        private const string Path = "tasks.json";
        public IEnumerable<ToDo> GetToDos()
        {
            if (File.Exists(Path))
            {  
                var task = Load();
                return task;
            }

            File.Create(Path).Close();
            return new List<ToDo>();
        }

        public void AddToDo(ToDo toDo)
        {
            var tasks = Load();  
            tasks.Add(toDo);
            Save(tasks);
        }

        public void RemoveToDo(string id)
        {
            var tasks = Load();

            tasks.RemoveAll(x => x.Id == id);
            Save(tasks);
        }

        private void Save(IEnumerable<ToDo> todos)
        {
            var json = JsonConvert.SerializeObject(todos);
            File.WriteAllText(Path, json);
        }

        private List<ToDo> Load()
        {
            var json = File.ReadAllText(Path);
            var tasks = JsonConvert.DeserializeObject<List<ToDo>>(json);
            
            if (tasks == null)
            {
                 tasks = new List<ToDo>();
            }

            return tasks;
        }
    }
}