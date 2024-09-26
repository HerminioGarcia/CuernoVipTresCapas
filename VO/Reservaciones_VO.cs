using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class Reservaciones_VO
    {
        private int _Id_Reservacion;
        private int? _Mesa_Id; // Nullable para permitir valores nulos
        private int? _Cliente_Id; // Nullable para permitir valores nulos
        private DateTime _Fecha_Reservacion;
        private TimeSpan _Horario;
        private int _Num_Personas;
        private string _Estatus;

        public int Id_Reservacion { get => _Id_Reservacion; set => _Id_Reservacion = value; }
        public int? Mesa_Id { get => _Mesa_Id; set => _Mesa_Id = value; }
        public int? Cliente_Id { get => _Cliente_Id; set => _Cliente_Id = value; }
        public DateTime Fecha_Reservacion { get => _Fecha_Reservacion; set => _Fecha_Reservacion = value; }
        public TimeSpan Horario { get => _Horario; set => _Horario = value; }
        public int Num_Personas { get => _Num_Personas; set => _Num_Personas = value; }
        public string Estatus { get => _Estatus; set => _Estatus = value; }

        public Reservaciones_VO()
        {
            _Id_Reservacion = 0;
            _Mesa_Id = null; // Inicializa como nulo
            _Cliente_Id = null; // Inicializa como nulo
            _Fecha_Reservacion = DateTime.MinValue; // Inicializa como fecha mínima
            _Horario = TimeSpan.Zero; // Inicializa como 00:00:00
            _Num_Personas = 0;
            _Estatus = string.Empty;
        }

        public Reservaciones_VO(DataRow dr)
        {
            _Id_Reservacion = int.Parse(dr["Id_Reservacion"].ToString());
            _Mesa_Id = dr["Mesa_Id"] != DBNull.Value ? (int?)int.Parse(dr["Mesa_Id"].ToString()) : null;
            _Cliente_Id = dr["Cliente_Id"] != DBNull.Value ? (int?)int.Parse(dr["Cliente_Id"].ToString()) : null;
            _Fecha_Reservacion = DateTime.Parse(dr["Fecha_Reservacion"].ToString());
            _Horario = TimeSpan.Parse(dr["Horario"].ToString());
            _Num_Personas = int.Parse(dr["Num_Personas"].ToString());
            _Estatus = dr["Estatus"].ToString();
        }
    }
}

