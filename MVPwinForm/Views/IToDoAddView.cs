using System;

namespace MVPwinForm.Views
{
    public interface IToDoAddView
    {
        string Title { get; set; }
        string Description { get; set; }

        event Action Add ;
    }
}