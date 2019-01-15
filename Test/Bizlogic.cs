using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test
{
    using Models;
    public class Bizlogic
    {
        Model model = new Model();

        public List<String> ListEmployees()
        {
            return model.Employees.Select<Employee, String>
                                       (c => c.EmployeeID).ToList<String>();
        }

        public List<BriefEmp> ListEmployees2()
        {
            List<BriefEmp> list = model.Employees.Select<Employee, BriefEmp>
                (c => new BriefEmp()
                {
                    EmployeeID = c.EmployeeID,
                    Name = c.Name
                }).ToList<BriefEmp>();
            return list;
        }

        public Employee GetEmployee(String id)
        {
            List<Employee> es = model.Employees.Where
                                  (p => p.EmployeeID == id).ToList<Employee>();
            if (es.Count > 0)
                return es[0];
            else
                return null;
        }
    }
}