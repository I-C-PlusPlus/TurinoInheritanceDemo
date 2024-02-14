//Dayan Turino dturino@cnm.edu
//Inheritance Demo
//Feb 14, 2024

namespace HRManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.EmpNum = 1;
            emp.FirstName = "Steve";
            emp.LastName = "Jobs";

            HourlyEmployee hourEmp = new HourlyEmployee();
            hourEmp.EmpNum = 2;
            hourEmp.FirstName = "Bill";
            hourEmp.LastName = "Gates";
            hourEmp.HourlyRate = 15.00M;

            Employee emp2 = hourEmp; // Polymorphism

            Console.WriteLine(emp.PaySummary);
            Console.WriteLine(emp.GetType());
            Console.WriteLine(hourEmp.PaySummary);
            Console.WriteLine(hourEmp.GetType());
            Console.WriteLine(emp2.PaySummary);
            Console.WriteLine(emp2.GetType());

            Console.Write("Press any key to continue....");
            Console.ReadKey(true);
        }
    }
}