using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace SQLConnectionADO
{
	public class SqlConnectionDb
	{
		public void Connection()
		{

			//string cs = "Data Source=LAPTOP-LEM8IGAG;Initial Catalog=ADO_Db;Integrated Security=True";
			//SqlConnection con = new SqlConnection(cs);
			//con.Open();
			//if(con.State == ConnectionState.Open)
			//{
			//	Console.WriteLine("conection open");
			//}



			//	con.Close();

			string cs = "Data Source=LAPTOP-LEM8IGAG;Initial Catalog=ADO_Db;Integrated Security=True";
			//SqlConnection con = new SqlConnection(cs);

			//try
			//{
			//	con.Open();
			//	if (con.State == ConnectionState.Open)
			//	{
			//		Console.WriteLine("conection open");
			//	}
			//}
			//catch (SqlException ex)
			//{

			//	Console.WriteLine(ex.Message);
			//}
			//finally
			//{
			//	con.Close();
			//}



			
			using(SqlConnection con = new SqlConnection(cs))
			{

				con.Open();
				if(con.State == ConnectionState.Open)
				{
					Console.WriteLine("database connected");
				}
			}
		}
	}
}
