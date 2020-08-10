using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Laundry.DAL.Interface
{
   public class BaseRepository
    {
        public IDbConnection con;
        public BaseRepository()
        {
           string connectionstring = @"Data Source=desktop-b8n6v6g\sqlexpress;Initial Catalog=laundry;Integrated Security=True";
            con = new SqlConnection(connectionstring);
        }
    }
}
