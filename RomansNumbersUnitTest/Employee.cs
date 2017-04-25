namespace RomansNumbersUnitTest
{
    public class Employee
    {
        private string _name;
        private double _salary;
        private Responsibility _responsibility;

        public Employee(string name, double salary, Responsibility responsibility)
        {
            Name = name;
            Salary = salary;
            Responsibility = responsibility;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public Responsibility Responsibility
        {
            get { return _responsibility; }
            set { _responsibility = value; }
        }
    }
}