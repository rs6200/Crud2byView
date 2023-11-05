using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using DataAccessLayer.Model;

namespace DataAccessLayer
{
    public class DBContext
    {
        string cs = "server =LAPTOP-LEM8IGAG;initial catalog = AspDb;integrated security =true";

        public List<Doctors> ViewDosctorsDetails()
        {
            List<Doctors> lst = new List<Doctors>();
            string query = "select * from dbo.Doctortbl";
            SqlConnection conn = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Emp_id"]);
               
                string name = (string)reader["Emp_Name"];
                string speciality = (string)reader["Emp_Address"];
                Doctors doc = new Doctors()
                {
                    ID = id,
                    Name = name,
                    Speaciality = speciality
                };
                lst.Add(doc);
            }
            return lst;
        }
    }
}
