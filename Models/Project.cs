namespace ProjectManagement.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public Client Client { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
