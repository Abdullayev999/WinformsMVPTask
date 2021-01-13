using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVPwinForm.Models;
using MVPwinForm.Presenters;

namespace MVPwinForm.Views
{
    public partial class ToDoListView : Form, IToDoListView
    {
        public ToDoListView()
        {
            InitializeComponent();
        }

        public event Action Add;
        public event Action<string> Remove;

        public void UpdateTasks(IEnumerable<ToDo> toDo)
        {
            taskListBox.Items.Clear();
            taskListBox.Items.AddRange(toDo.ToArray());
            descriptionTextBox.Clear();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {

            if (taskListBox.SelectedItem != null)
            {
                var id = (taskListBox.SelectedItem as ToDo).Id;
               Remove?.Invoke(id);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Add?.Invoke();
        }

        private void taskListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (taskListBox.SelectedItem != null)
            {
                var description = (taskListBox.SelectedItem as ToDo).Description;
                descriptionTextBox.Text = description;
            }
        }

    }
}
