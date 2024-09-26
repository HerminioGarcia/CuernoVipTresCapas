using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class Mesas_VO
    {
        private int _ID_Mesa;
        private string _Codigo_Mesa;
        private int _Capacidad;

        public int ID_Mesa { get => _ID_Mesa; set => _ID_Mesa = value; }
        public string Codigo_Mesa { get => _Codigo_Mesa; set => _Codigo_Mesa = value; }
        public int Capacidad { get => _Capacidad; set => _Capacidad = value; }

        public Mesas_VO()
        {
            _ID_Mesa = 0;
            _Codigo_Mesa = string.Empty;
            _Capacidad = 0; // Inicializa como 0
        }

        public Mesas_VO(DataRow dr)
        {
            _ID_Mesa = int.Parse(dr["ID_Mesa"].ToString());
            _Codigo_Mesa = dr["Codigo_Mesa"].ToString();
            _Capacidad = int.Parse(dr["Capacidad"].ToString());
        }
    }
}