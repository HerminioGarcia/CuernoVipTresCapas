using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class Cuentas_VO
    {
        private int _Id_Cuenta;
        private int? _Mesa_Id; // Nullable para permitir valores nulos
        private int? _Cliente_Id; // Nullable para permitir valores nulos
        private int? _Reservacion_Id; // Nullable para permitir valores nulos
        private int _Empleado_Id;
        private DateTime _Fecha;
        private decimal _Total;
        private bool _Es_Reservacion;

        public int Id_Cuenta { get => _Id_Cuenta; set => _Id_Cuenta = value; }
        public int? Mesa_Id { get => _Mesa_Id; set => _Mesa_Id = value; }
        public int? Cliente_Id { get => _Cliente_Id; set => _Cliente_Id = value; }
        public int? Reservacion_Id { get => _Reservacion_Id; set => _Reservacion_Id = value; }
        public int Empleado_Id { get => _Empleado_Id; set => _Empleado_Id = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public decimal Total { get => _Total; set => _Total = value; }
        public bool Es_Reservacion { get => _Es_Reservacion; set => _Es_Reservacion = value; }

        public Cuentas_VO()
        {
            _Id_Cuenta = 0;
            _Mesa_Id = null; // Inicializa como nulo
            _Cliente_Id = null; // Inicializa como nulo
            _Reservacion_Id = null; // Inicializa como nulo
            _Empleado_Id = 0;
            _Fecha = DateTime.MinValue; // Inicializa como fecha mínima
            _Total = 0.0m; // Inicializa como 0
            _Es_Reservacion = false; // Inicializa como false
        }

        public Cuentas_VO(DataRow dr)
        {
            _Id_Cuenta = int.Parse(dr["Id_Cuenta"].ToString());
            _Mesa_Id = dr["Mesa_Id"] != DBNull.Value ? (int?)int.Parse(dr["Mesa_Id"].ToString()) : null;
            _Cliente_Id = dr["Cliente_Id"] != DBNull.Value ? (int?)int.Parse(dr["Cliente_Id"].ToString()) : null;
            _Reservacion_Id = dr["Reservacion_Id"] != DBNull.Value ? (int?)int.Parse(dr["Reservacion_Id"].ToString()) : null;
            _Empleado_Id = int.Parse(dr["Empleado_Id"].ToString());
            _Fecha = DateTime.Parse(dr["Fecha"].ToString());
            _Total = decimal.Parse(dr["Total"].ToString());
            _Es_Reservacion = Convert.ToBoolean(dr["Es_Reservacion"]);
        }
    }