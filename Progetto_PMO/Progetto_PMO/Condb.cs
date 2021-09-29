using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Progetto_PMO
{
    class Condb
    {
        SqlConnection con;
        public Condb() 
        {
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\pulic\\source\\repos\\Progetto_PMO\\Progetto_PMO\\Database.mdf;Integrated Security=True");
        }

        public SqlConnection getCon()
        {
            return con;
        }

    }
}
