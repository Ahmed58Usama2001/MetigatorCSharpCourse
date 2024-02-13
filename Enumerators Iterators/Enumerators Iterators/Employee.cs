namespace Enumerators_Iterators
{
    class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Salary { get; set; }

        public string Department { get; set; }

        public override bool Equals(object? obj)
        {
            if(obj is null || obj is not Employee)
                return false;

            var emp=obj as Employee;

            return this.Id == emp.Id
                && this.Name == emp.Name
                && this.Salary == emp.Salary
                && this.Department == emp.Department;
        }

        public static bool operator == (Employee lhs,Employee rhs)=>lhs.Equals(rhs);
        public static bool operator !=(Employee lhs, Employee rhs) => lhs.Equals(rhs);
    }

}
