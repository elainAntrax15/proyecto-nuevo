using RecetaSpawn.Domain.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetaSpawn.Domain.Service
{
    public class TblUsuarioCTRL
    {


		TblUsuarioDAO Metodo = new TblUsuarioDAO();
		public int Agregar(object obj)
        {
			int final = 0;
			final = Metodo.Agregar(obj);
			return final;
        }

	}
}
