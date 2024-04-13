using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace S1V2
{
    internal class DesignationDao
    {
        public static Designation GetDesignationById(int designationId)
        {
            Designation designation = new Designation();
            try
            {
                MySqlDataReader reader = CommonDao.GetResult("SELECT * FROM designation WHERE id =" + designationId);
                reader.Read();
                int id = reader.GetInt32("id");
                string name = reader.GetString("name");

                designation.Id = id;
                designation.Name = name;

                reader.Close();
                
            }
            catch (Exception ex) { Console.WriteLine("Can't Connect as : " + ex.Message); }

            return designation;
        }

    }
}
