using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Parte1
{
    internal class Class1
    {
        static void ConsultaproductoVendidos()
        {
            string coneccionString = "Server=sql.bsite.net\\MSSQL2016;Database=alirioguedez_SistemaGestion;User Id=alirioguedez_SistemaGestion;Password=sanare;";
            try
            {
                using (SqlConnection sqlConec = new SqlConnection(coneccionString))
                {

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM ProductoVendido", sqlConec))
                    {

                        sqlConec.Open();
                        List<ProductoVendido> listaProductoVendido = new List<ProductoVendido>();
                        

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    ProductoVendido productoVendido = new ProductoVendido();

                                    productoVendido.Id = long.Parse(reader["Id"].ToString());
                                    productoVendido.IdVenta = long.Parse(reader["IdVenta"].ToString());
                                    productoVendido.Stock = double.Parse(reader["Stock"].ToString());
                                    productoVendido.IdProducto= long.Parse(reader["Idproducto"].ToString());


                                    listaProductoVendido.Add(productoVendido);

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
