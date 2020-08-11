using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Laundry.DAL
{
    public class BaseRepository
    {
        public IDbConnection con;
        public BaseRepository()
        {
            string connectionstring = @"Data Source=DESKTOP-IRVLQFI\SQL2019;Initial Catalog=laundry;Integrated Security=True";
            con = new SqlConnection(connectionstring);
        }
        
    }
}
