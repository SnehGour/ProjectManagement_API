namespace ProjectManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Designation EmployeeDesignation { get; set; }
        public int HourRate { get; set; }

    }
    public enum Designation
    {
        Techlead=1,SoftwareEnginner,AssociateSoftwareEnginner
    }
}
