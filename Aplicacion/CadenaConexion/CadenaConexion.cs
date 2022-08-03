using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaConexion
{
	public static class CadenaConexion
	{

        private const string Servidor = @"LAPTOP-T31O2BQ3"; // Cambia
        private const string BaseDatos = @"Base Nueva";
        private const string Usuario = @"sa";
        private const string Password = @"13090704"; // Cambia

        // Propiedad
        public static string ObtenerCadenaSql => $"Data Source={Servidor}; " +
                                                 $"Initial Catalog={BaseDatos}; " +
                                                 $"User Id={Usuario}; " +
                                                 $"Password={Password};";

        public static string ObtenerCadenaWin => $"Data Source={Servidor}; " +
                                                 $"Initial Catalog={BaseDatos}; " +
                                                 $"Integrated Security=true;";
    }
}
