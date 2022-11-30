using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Parte1
{
    static class ConsultaClienteBD
    {
        static void ConsultaCliente()
        {
            string coneccionString = "Server=sql.bsite.net\\MSSQL2016;Database=alirioguedez_SistemaGestion;User Id=alirioguedez_SistemaGestion;Password=sanare;";
            try
            {
                using (SqlConnection sqlConec = new SqlConnection(coneccionString))
                {

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM usuario", sqlConec))
                    {

                        sqlConec.Open();
                        List<Usuario> lista = new List<Usuario>();


                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Usuario usuario = new Usuario();
                                    usuario.Id= long.Parse(reader["id"].ToString());
                                    usuario.Nombre = reader["Nombre"].ToString();
                                    usuario.Apellido = reader["Apellido"].ToString();
                                    usuario.Contrasenia = reader["contraseña"].ToString();
                                    usuario.NombreUsuario = reader["nombreUsuario"].ToString();
                                    usuario.Email = reader["email"].ToString();
                                    lista.Add(usuario);

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

