namespace MVPwinForm.Models
{
    public class ToDo
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}