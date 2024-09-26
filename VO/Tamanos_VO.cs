using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class Tamanos_VO
    {
        private int _Id_Tamano;
        private string _Descripcion;

        public int Id_Tamano { get => _Id_Tamano; set => _Id_Tamano = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }

        public Tamanos_VO()
        {
            _Id_Tamano = 0;
            _Descripcion = string.Empty;
        }

        public Tamanos_VO(DataRow dr)
        {
            _Id_Tamano = int.Parse(dr["Id_Tamano"].ToString());
            _Descripcion = dr["Descripcion"].ToString();
        }
    }
}