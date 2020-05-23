using Ecommerce.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Datos
{
    public class ReportesDatos
    {
        private readonly string connectionString;

        public ReportesDatos()
        {
            connectionString = ConfigurationManager.ConnectionStrings["NorthwindDatabase"].ConnectionString;
        }

        public List<ItemVentaPorCategoria> ObtenerVentaPorCategoria(string categoria,string anio)
        {
            List<ItemVentaPorCategoria> resultado = new List<ItemVentaPorCategoria>();

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string consulta = "SalesByCategory";
                SqlCommand command = new SqlCommand(consulta, conexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@CategoryName", categoria));
                command.Parameters.AddWithValue("@OrdYear", anio);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                conexion.Open();
                adapter.Fill(dataTable);

                foreach (DataRow fila in dataTable.Rows)
                {
                    ItemVentaPorCategoria itemVenta = new ItemVentaPorCategoria();

                    itemVenta.NombreProducto = fila[0].ToString();
                    itemVenta.VentaTotal = Convert.ToDecimal(fila["TotalPurchase"]);

                    resultado.Add(itemVenta);
                }
            }

            return resultado;
        }
    }
}
