using BB207_ADO.DataBase;
using BB207_ADO.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB207_ADO.Services
{
    public class EmployeService
    {
        AppDbContext dbContext;
        public EmployeService()
        {
            this.dbContext = new AppDbContext();
        }
        public void Create(Employe employe)
        {
            string createCommand = $"insert into Employes values('{employe.Name}','{employe.Surname}',{employe.Salary})";
            int result=dbContext.NonQuery(createCommand);
        }

        public void Delete(int id)
        {
            string command = $"delete from Employes where Id={id}";
            dbContext.NonQuery(command);
        }

        public void Uptade(string name,int id)
        {
            string command = $"update Employes SET Name='{name}' where Id={id}";
            dbContext.NonQuery(command);
        }
        public List<Employe> GetAll()
        {
            string query = "Select * from Employes";
            DataTable table = dbContext.Query(query);
            List<Employe> list = new List<Employe>();
            foreach (DataRow item in table.Rows) 
            {
                Employe employe = new Employe()
                {
                    Id = int.Parse(item["Id"].ToString()),

                    Name = item["Name"].ToString(),
                    Surname = item["Surname"].ToString(),
                    Salary = double.Parse(item["Salary"].ToString())
                };
                list.Add(employe);
            } 
            return list;
        }

    }
}
