using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace peerc
{
    class DBConnectie
    {
        /// <summary>
        /// Grabs data from a, specified, remote SQL source.
        /// </summary>
        /// <param name="statement">A String which represents the SQL statement.</param>
        /// <returns>DataTable</returns>
        public DataTable GrabData(string statement)
        {
            //Setup:
            ///Creeër een plaats om de data van ons request op te slaan.
            DataTable dataStore = new DataTable();
            ///Creeër de connectie die gebruikt zal worden om met de database te communiceren. 
            SqlConnection connection = new SqlConnection("Data Source=145.24.222.151,8080;" +
                                                         "Database=ProjectDB;Persist Security Info=True;" +
                                                         "User ID=sa; Password=Teemo1999");
            //Creeër de SQL statement.
            SqlCommand sqlStatement = new SqlCommand(statement, connection);
            ///Creeër de adapter die de data van de database ophaalt.
            SqlDataAdapter dataGrabber = new SqlDataAdapter(sqlStatement);

            //Work:
            ///Open de connectie naar de database.
            connection.Open();
            ///Vul met de adapter de "dataStore".
            dataGrabber.Fill(dataStore);
            ///Sluit de connectie naar de database.
            connection.Close();

            //Shutdown:
            ///Return de "dataStore".
            return dataStore;
        }
    }
}
