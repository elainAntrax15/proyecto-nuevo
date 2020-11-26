using RecetaSpawn.Domain.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetaSpawn.Domain.DAO
{
    public class TblRecetaDAO
    {
		SqlConnection con = new SqlConnection();
		SqlCommand cmd = new SqlCommand();
		Conexion con2 = new Conexion();
		string sql;

		public List<TblRecetaBO> ListarTablaReceta()
		{
			List<TblRecetaBO> lista = new List<TblRecetaBO>();
			sql = "select * from TblReceta";
			SqlDataAdapter da = new SqlDataAdapter(sql, con2.establecerconexion());
			DataTable tabla = new DataTable();
			da.Fill(tabla);
			if (tabla.Rows.Count > 0)
			{
				foreach (DataRow row in tabla.Rows)
				{
					TblRecetaBO obj = new TblRecetaBO();
					obj.ID_RECETA = int.Parse(row["ID_Recetas"].ToString());
					obj.RECETA = (row["Receta"]).ToString();
					obj.TIEMPO = (row["Tiempo"]).ToString();
					obj.INGREDIENTES = (row["Ingredientes"]).ToString();
					obj.PREPARACION = (row["Preparacion"]).ToString();
					lista.Add(obj);
				}
			}
			return lista;
		}
		public int Crear(object obj)
		{

			TblRecetaBO datos = (TblRecetaBO)obj;
			cmd.Connection = con2.establecerconexion();
			con2.AbrirConexion();
			string sql = "INSERT INTO TblReceta(Receta, Tiempo, Ingredientes, Preparacion)" +
				"VALUES(@Receta, @Tiempo, @Ingredientes, @Preparacion)";

			cmd.Parameters.AddWithValue("@Receta", datos.RECETA);
			cmd.Parameters.AddWithValue("@Tiempo", datos.TIEMPO);
			cmd.Parameters.AddWithValue("@Ingredientes", datos.INGREDIENTES);

			cmd.Parameters.AddWithValue("@Preparacion", datos.PREPARACION);

			cmd.CommandText = sql;
			int i = cmd.ExecuteNonQuery();
			cmd.Parameters.Clear();

			if (i <= 0)
			{
				return 0;
			}
			return 1;
		}

		public int Eliminar(int id, int status)
		{
			cmd.Connection = con2.establecerconexion();
			con2.AbrirConexion();
			sql = "UPDATE Recetw SET Estatus = @Estatus WHERE IDAdmin = @IDAdmin;";
			cmd.Parameters.AddWithValue("@Estatus", status);
			cmd.Parameters.AddWithValue("@IDAdmin", id);
			cmd.CommandText = sql;

			int i = cmd.ExecuteNonQuery();
			cmd.Parameters.Clear();

			if (i <= 0)
			{
				return 0;
			}
			return 1;
		}
	}
}
