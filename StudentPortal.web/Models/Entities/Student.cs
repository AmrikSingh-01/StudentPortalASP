namespace StudentPortal.web.Models.Entities
{
    public class Student
    {
        public Guid Id { get; set; }// no need to capture because entity framework core will automatically set this for us 
        public string Name { get; set; }
        public string FName { get; set; }
        public string MName { get; set; }
        public string Age { get; set; }
        public string Address { get; set; }
        public string RegDate { get; set; }
    }
}
