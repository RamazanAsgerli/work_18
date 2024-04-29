using BB207_ADO.Models;
using BB207_ADO.Services;

namespace BB207_ADO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employe employe = new Employe()
            {
                Name = "Ramazan",
                Surname = "Asgerli",
                Salary = 900
            };
            EmployeService employeService = new EmployeService();
            //employeService.Create(employe);
            foreach (var item in employeService.GetAll())
            {
                Console.WriteLine(item);
            }
            //employeService.Uptade("ramo", 1);
            //employeService.Delete(2);
        }
    }
}
