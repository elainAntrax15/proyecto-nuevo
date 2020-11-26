using RecetaSpawn.Domain.BO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetaSpawn.Domain.DAO
{
    public class TblUsuarioDAO
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        Conexion con2 = new Conexion();
        string sql;

        public int Agregar(object obj)
        {
			TblUsuariosBO Crear = (TblUsuariosBO)obj;
			cmd.Connection = con2.establecerconexion();
			con2.AbrirConexion();
			string sql = "INSERT INTO TblUsuarios(Nombre, Apellido, Correo, Contraseña, Genero, Rol)"+
						 "VALUES (@Nombre, @Apellido, @Correo, @Contraseña, @Genero, @Rol)";
			cmd.Parameters.AddWithValue("@Nombre", Crear.Nombre);
			cmd.Parameters.AddWithValue("@Usuario", Crear.Apellido);
			cmd.Parameters.AddWithValue("@Correo", Crear.Correo);
			cmd.Parameters.AddWithValue("@Contraseña", Crear.Contraseña);
			cmd.Parameters.AddWithValue("@Genero", Crear.Genero);
			cmd.Parameters.AddWithValue("@Rol", Crear.Rol);

			cmd.CommandText = sql;
			int x = cmd.ExecuteNonQuery();
			cmd.Parameters.Clear();
            if (x <= 0)
            {
				return 0;

            }
			return 1;
		}




	}

}
