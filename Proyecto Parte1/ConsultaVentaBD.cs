using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proyecto_Parte1
{
    static class ConsultaVentaBD
    {
        static void ConsultaVentas()
        { 
            string coneccionString = "Server=sql.bsite.net\\MSSQL2016;Database=alirioguedez_SistemaGestion;User Id=alirioguedez_SistemaGestion;Password=sanare;";
            try
            {
                using (SqlConnection sqlConec = new SqlConnection(coneccionString))
                {

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM venta", sqlConec))
                    {

                        sqlConec.Open();
                        List<Venta> listaVenta = new List<Venta>();


                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Venta venta = new Venta();

                                    venta.Id = long.Parse(reader["Id"].ToString());
                                    venta.Comentarios = reader["Comentarios"].ToString();


                                    listaVenta.Add(venta);

                                }

                            }
                             else
{
                                Console.WriteLine("sin registro");

}
                        }
                        sqlConec.Close();
                    }
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
