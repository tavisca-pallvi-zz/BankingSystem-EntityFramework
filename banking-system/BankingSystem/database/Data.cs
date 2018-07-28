using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace database
{
   public  class Data
    {
       static SqlConnection conn = new SqlConnection();
       //static SqlCommand command = conn.CreateCommand();
        public void Connect() {

            // conn= new SqlConnection(ConfigurationManager.ConnectionStrings["connstring"].ConnectionString);
         
            conn.ConnectionString = @"Data Source=TAVDESK153;Initial Catalog=Accountdb;Integrated Security=true";
            conn.Open();
            Console.WriteLine(conn.State);
        }
            
           
          

        
        public void Insert(int id,string name,float bal,int banktype)
        {
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "Insert into accountb VALUES(@id,@name,@bal,@banktype)";
            command.Parameters.Add(new SqlParameter("@id",id));
            command.Parameters.Add(new SqlParameter("@name",name));
            command.Parameters.Add(new SqlParameter("@bal", bal));
            command.Parameters.Add(new SqlParameter("@banktype",banktype));

            command.ExecuteNonQuery();

        }

        /*public void Deposit()
        {
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "Insert into accountb VALUES(@id,@name,@bal,@banktype)";
            command.Parameters.Add(new SqlParameter("@id", id));
            command.Parameters.Add(new SqlParameter("@name", name));
            command.Parameters.Add(new SqlParameter("@bal", bal));
            command.Parameters.Add(new SqlParameter("@banktype", banktype));

            command.ExecuteNonQuery();

        }
        */
        /*ublic void Search()
         {
         }
         */

        public int SearchData(int id)
        {
               SqlCommand command = conn.CreateCommand();
           /* try
            {
            */
                command.CommandText = "Select * from accountb where id=@id";
                command.Parameters.Add(new SqlParameter("@id", id));
                accountb c=  command.ExecuteNonQuery();
               return c; 
            /*
            catch (E)
            {

            }
            */
        }

        public void I(int id, string name, float bal, int banktype)
        {
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "Insert into accountb VALUES(@id,@name,@bal,@banktype)";
            command.Parameters.Add(new SqlParameter("@id", id));
            command.Parameters.Add(new SqlParameter("@name", name));
            command.Parameters.Add(new SqlParameter("@bal", bal));
            command.Parameters.Add(new SqlParameter("@banktype", banktype));

            command.ExecuteNonQuery();

        }
        /*
        public void Insert(int id, string name, float bal, int banktype)
        {
            command.CommandText = "Insert into accountb VALUES(id,name,bal,banktype)";

            command.ExecuteNonQuery();

        }

        /*
        public int Search (int id)
        {
            command.CommandText = "Insert into accountb VALUES(id,name,bal,banktype)";

            command.ExecuteNonQuery();

        }
        public int Search (int id)
        {
            command.CommandText = "Insert into accountb VALUES(id,name,bal,banktype)";

            command.ExecuteNonQuery();

        }
        */

        public void Close()
        {

            conn.Close();

        }



    }

}
