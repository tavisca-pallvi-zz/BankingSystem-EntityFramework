using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Entities;

namespace database
{
    public class Data
    {
        static SqlConnection conn = new SqlConnection();
        public void Connect() {

            // conn= new SqlConnection(ConfigurationManager.ConnectionStrings["connstring"].ConnectionString);

            conn.ConnectionString = @"Data Source=TAVDESK153;Initial Catalog=Accountdb;Integrated Security=true";


            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(conn.State+ex.Message);


            }
              
        }
            
           
          

        
        public void Insert(int id,string name,int balance,int banktype)
        {
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "Insert into accountbd VALUES(@id,@name,@balance,@banktype)";
            command.Parameters.Add(new SqlParameter("@id",id));
            command.Parameters.Add(new SqlParameter("@name",name));
            command.Parameters.Add(new SqlParameter("@balance", balance));
            command.Parameters.Add(new SqlParameter("@banktype",banktype));
            command.ExecuteNonQuery();

        }

        public void Update(int id,int balance)
        {
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "Update  accountbd set balance=@balance where id=@id";
            command.Parameters.Add(new SqlParameter("@balance", balance));
            command.Parameters.Add(new SqlParameter("@id", id));
            command.ExecuteNonQuery();

        }
       

        public int SearchData(int id)
        {
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "Select * from accountbd where id=@id";
            command.Parameters.Add(new SqlParameter("@id", id));
            SqlDataReader read = command.ExecuteReader();
            int bal = -1;
            if (read.HasRows)
            {
                while (read.Read())
                {
                    bal =read.GetInt32(read.GetOrdinal("balance"));

                }
            }
            read.Close();
            return bal; 
    
      }
        public Accounts DisplayData(int id)
        {
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "Select * from accountbd where id=@id";
            command.Parameters.Add(new SqlParameter("@id", id));
            SqlDataReader read = command.ExecuteReader();
            Accounts acc = null;
            if (read.HasRows)
            {
                while (read.Read())
                {
                    
                    acc= new Accounts();
                    acc._accountId= read.GetInt32(read.GetOrdinal("balance"));
                    acc._accountBranch = read.GetInt32(read.GetOrdinal("banktype"));
                    acc._accountHolder = read.GetString(read.GetOrdinal("custname"));
                    acc._balanceAmount = read.GetInt32(read.GetOrdinal("balance"));

                    
                }

            }

            return acc;
        }

        public int SearchType(int id)
        {
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "Select * from accountbd where id=@id";
            command.Parameters.Add(new SqlParameter("@id", id));
            SqlDataReader read = command.ExecuteReader();
            int type = -1;
            if (read.HasRows)
            {
                while (read.Read())
                {
                    //going to last column

                    type = read.GetInt32(read.GetOrdinal("banktype"));
                    Console.WriteLine("{0}", type);
                }

            }
         
            read.Close();
            return type;

        }





        public void Close()
        {
            conn.Close();

        }



    }

}
