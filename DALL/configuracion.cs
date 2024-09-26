using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class configuracion
    {
        //cadena de conexion
        //data source= nombre del servidor de bd
        //local host
        //nombre de mi instancioa
        //initial catalogo= nombre de la bace de datos

        static string _cadenaConexion = @"Data Source= DESKTOP-LBEHBPS\MSSQLSERVER01 ;
                                          Initial catalog = Transporte;
                                          Integrated Security= true;";

        public static string CadenaConexion
        {
            get { return _cadenaConexion; }
        }//encapsuamiento

    }
}