using Ecommerce.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Datos
{
    public class CategoriasDatos
    {
        //public List<Categoria> TodasLasCategorias()
        //{
        //    List<Categoria> ListaDeCategorias;

        //    ListaDeCategorias = new List<Categoria>()
        //    {
        //        new Categoria() {Id=1, Nombre="Electronica", Descripcion="Articulos de electronica super electronicos"},
        //        new Categoria() {Id=2, Nombre="Juguetes", Descripcion="Para que tus hijos se diviertan en cuartena y te dejen hacer ejercicios de csharp"},
        //        new Categoria() {Id=3,  Nombre="Art. Hogar", Descripcion="Para mantener la casa limpia"}
        //    };

        //    return ListaDeCategorias;
        //}

        private static string connectionString = "Server=localhost;Database=Northwind;Trusted_Connection=True;";

        public List<Categoria> TodasLasCategorias()
        {
            List<Categoria> ListaDeCategorias = new List<Categoria>();

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string consulta = "SELECT * FROM Categories";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                conexion.Open();
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Categoria categoria = new Categoria();

                        categoria.Id = reader.GetInt32(0);
                        categoria.Nombre = reader["CategoryName"].ToString();
                        categoria.Descripcion = reader["description"].ToString();

                        ListaDeCategorias.Add(categoria);
                    }
                }
            }

            return ListaDeCategorias;
        }
    }
}
