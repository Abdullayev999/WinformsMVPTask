using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVPwinForm.Views
{
    public partial class ToDoAddView : Form,IToDoAddView
    {
        public ToDoAddView()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Add?.Invoke();
            Close();
        }

        public string Title
        { 
            get => titleTextBox.Text; 
            set => titleTextBox.Text = value;
        }

        public string Description
        {
            get => descriptionTextBox.Text; 
            set => descriptionTextBox.Text = value;
        }
        public event Action Add;
    }
}
