namespace ChatGPT_Pratik
{
    public class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Employee()
        {

        }
        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{Name} adlı çalışanın kazancı: {Salary}");
        }
    }
}