using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace S1V2
{
    internal class EmployeeController
    {
        public static List<Employee> Get(Hashtable ht)
        {
            List<Employee> employees = new List<Employee>();

            if (ht == null || ht.Count == 0)
            {
                employees = EmployeeDao.GetAll();
            }
            else
            {
                string? name = ht["name"] as string;
                Gender? gender = ht["gender"] as Gender;

                if (name != null && gender != null)
                {
                    employees = EmployeeDao.GetAllByNameAndGender(name, gender);
                }
                else if (name != null)
                {
                    employees = EmployeeDao.GetAllByName(name);
                }
                else if (gender != null)
                {
                    employees = EmployeeDao.GetAllByGender(gender);
                }
            }
            return employees;
        }
    }
}
