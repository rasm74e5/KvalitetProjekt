using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvalitetProjekt.Application
{
    class OrderRepo
    {
        private static string connectionString =
    "Server=EALSQL1.eal.local; Database= C_DB13_2018; User Id=C_STUDENT13; Password=C_OPENDB13;";

        public void PullOrdersFromDatabase()
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                        SqlCommand cmd2 = new SqlCommand("GetAllOrdre", con);
                        cmd2.CommandType = CommandType.StoredProcedure;

                        SqlDataReader reader = cmd2.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string ordreid = reader["OrdreID"].ToString();
                                string ordrelines = reader["OrdreLines"].ToString();
                                string customer = reader["Customer"].ToString();
                                string ordredate = reader["OrdreDate"].ToString();
                                string delivery = reader["Delivery"].ToString();
                                string picked = reader["Picked"].ToString();
                                Console.WriteLine($"\nOrdreID: {ordreid} \nOrdreLines: {ordrelines}\nCustomer: {customer} " +
                                    $"\nOrdreDate: {ordredate} \nDelivery: {delivery}\nPicked: {picked}\n");
                            }
                        }
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Fejl: " + e.Message);
                }
            }
        }
    }
}
