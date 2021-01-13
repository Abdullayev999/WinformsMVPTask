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

namespace MVPwinForm.Views
{
    public partial class SecondToDoListView : Form,IToDoListView
    {
        public SecondToDoListView()
        {
            InitializeComponent();
        }

        public event Action Add;
        public event Action<string> Remove;

        public void UpdateTasks(IEnumerable<ToDo> toDo)
        {
            listView1.Clear();
            foreach (var item in toDo)
            {
                var lastViewItem = new ListViewItem(item.Title,0);
                lastViewItem.Tag = item;
                listView1.Items.Add(lastViewItem);
            }
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (listView1.SelectedItems.Count != 0) 
                {
                    foreach (ListViewItem item in listView1.SelectedItems)
                    {
                        if (listView1.SelectedItems!=null)
                        {
                            var id = (item.Tag as ToDo).Id;
                            Remove?.Invoke(id);
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add?.Invoke();
        }
    }
}
