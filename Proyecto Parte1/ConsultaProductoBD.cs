using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Parte1
{
    static class ConsultaProductoBD
    {
        static void ConsultaProducto()
        {
            string coneccionString = "Server=sql.bsite.net\\MSSQL2016;Database=alirioguedez_SistemaGestion;User Id=alirioguedez_SistemaGestion;Password=sanare;";
            try
            {
                using (SqlConnection sqlConec = new SqlConnection(coneccionString))
                {

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM producto", sqlConec))
                    {

                        sqlConec.Open();
                        List<Producto> listaProducto = new List<Producto>();


                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Producto producto = new Producto();
                                    producto.Id = long.Parse(reader["Id"].ToString());
                                    producto.Descripcion = reader["Descripcion"].ToString();
                                    producto.Costo= double.Parse(reader["Costo"].ToString());
                                    producto.PrecioVenta = double.Parse(reader["precioVenta"].ToString());
                                    producto.Stock = double.Parse(reader["Stock"].ToString());
                                    producto.IdUsuario= long.Parse(reader["IdUsuario"].ToString());

                                    listaProducto.Add(producto);

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

