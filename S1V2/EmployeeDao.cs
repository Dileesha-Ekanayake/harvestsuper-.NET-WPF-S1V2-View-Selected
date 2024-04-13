using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1V2
{
    internal class EmployeeDao
    {
        public static List<Employee> Get(string query)
        {
            List<Employee> emplist = new List<Employee>();

            try
            {
                MySqlDataReader reader = CommonDao.GetResult(query);

                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string name = reader.GetString("name");
                    string nic = reader.GetString("nic");
                    int genderId = reader.GetInt32("gender_id");
                    int designationId = reader.GetInt32("designation_id");
                    int statusId = reader.GetInt32("statusemployee_id");

                    Gender gender = GenderDao.GetGenderById(genderId);
                    Designation designation = DesignationDao.GetDesignationById(designationId);
                    Employeestatus employeestatus = EmployeestatusDao.GetEmployeestatusById(statusId);

                    Employee emp = new Employee();
                    emp.Id = id;
                    emp.Name = name;
                    emp.Nic = nic;
                    emp.Gender = gender;
                    emp.Designation = designation;
                    emp.Employeestatus = employeestatus;

                    emplist.Add(emp);
                }
                
            }
            catch (Exception ex) { Console.WriteLine("Can't Connect as : " + ex.Message); }

            return emplist;

        }
        public static List<Employee> GetAll()
        {

            return Get("SELECT * FROM employee");
            
        }

        public static List<Employee> GetAllByName(string name)
        {
            return Get("SELECT * FROM employee WHERE name like '" + name + "%'");
        }

        public static List<Employee> GetAllByGender(Gender gender)
        {
            return Get("SELECT * FROM employee WHERE gender_id = " + gender.Id);
        }

        public static List<Employee> GetAllByNameAndGender(string name, Gender gender)
        {
            return Get("SELECT * FROM employee WHERE name like '" + name + "%' AND gender_id = " + gender.Id );
        }

    }
}
