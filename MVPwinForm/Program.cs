using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVPwinForm.Presenters;
using MVPwinForm.Services;
using MVPwinForm.Views;

namespace MVPwinForm
{
    static class Program
    {
        private static IToDoRepository toDoRepository;
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            toDoRepository = new JsonToDoRepository();
            // toDoRepository = new ToDoRepository();


            ToDoListView toDoListView = new ToDoListView();
            //SecondToDoListView toDoListView = new SecondToDoListView();
            ToDoListPresenter toDoListPresenter = new ToDoListPresenter(toDoListView,toDoRepository);

            
            
            Application.Run(toDoListView);
        }

        public static void OpenAddView()
        {
            ToDoAddView toDoAddView = new ToDoAddView();
            ToDoAddPresenter toDoAddPresenter = new ToDoAddPresenter(toDoAddView, toDoRepository);
            toDoAddView.ShowDialog();
        }
    }
}
