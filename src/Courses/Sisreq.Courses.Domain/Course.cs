namespace Sisreq.Courses.Domain
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public string Area { get; set; } = "";

        public virtual Class? Class { get; set; }
    }
}