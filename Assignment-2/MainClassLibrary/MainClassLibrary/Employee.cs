namespace MainClassLibrary
{
    /// <summary>
    /// Employee class containing all the fields and property of Employee Entity
    /// </summary>
    internal class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public int ManagerID { get; set; }
        public string EmpEmail { get; set; }
    }
}