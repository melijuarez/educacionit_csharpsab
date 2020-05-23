using Ecommerce.EntidadesDeNegocio;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
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

        private readonly string connectionString;

        public CategoriasDatos()
        {
            connectionString = ConfigurationManager.ConnectionStrings["NorthwindDatabase"].ConnectionString;
        }

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

        public Categoria ObtenerCategoria(int id)
        {
            Categoria categoria = new Categoria();

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string consulta = $"Select * from Categories WHERE CategoryId = {id}";
                SqlCommand command = new SqlCommand(consulta, conexion);
                conexion.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        categoria.Id = reader.GetInt32(0);
                        categoria.Nombre = reader["CategoryName"].ToString();
                        categoria.Descripcion = reader["description"].ToString();
                    }
                }
            }

            return categoria;
        }

        public void ActualizarCategoria (Categoria categoria)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                String consulta = $"UPDATE Categories SET CategoryName = '{categoria.Nombre}', " +
                    $"Description = '{categoria.Descripcion}' WHERE CategoryId = {categoria.Id}";
                SqlCommand command = new SqlCommand(consulta, conexion);
                conexion.Open();
                command.ExecuteNonQuery();
            }
        }

        public void GuardarCategoria(Categoria categoria)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string consulta = $"INSERT INTO Categories (CategoryName,Description) " +
                    $"VALUES ('{categoria.Nombre}','{categoria.Descripcion}')";
                SqlCommand command = new SqlCommand(consulta, conexion);
                conexion.Open();
                command.ExecuteNonQuery();
            }
        }

        public int CantidadCategorias()
        {
            int result = 0;
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string consulta = "SELECT Count(*) FROM Categories";
                SqlCommand command = new SqlCommand(consulta, conexion);
                conexion.Open();
                result = Convert.ToInt32(command.ExecuteScalar());
            }
            return result;
        }
    }
}
