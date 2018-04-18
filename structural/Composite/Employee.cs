public abstract class Employee{
    
    protected string name;
    protected double salary;

    public Employee(string name, double salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public abstract void Add(Employee employee);

        public abstract void Remove(Employee employee);

        public abstract string GetData();
}