using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB207_ADO.Models
{
    public class Employe
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }

        public double Salary {  get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Surname: {Surname}, Salary: {Salary}";
        }
    }
}
