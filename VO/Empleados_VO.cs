using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class Empleados_VO
    {
        private int _Id_Empleado;
        private string _Nombre_Empleado;
        private string _Apeido_P_Empleado;
        private string _Apeido_M_Empleado;
        private string _Email_Empleado;
        private string _Telefono_Empleado;
        private int? _Rol_Id; // Nullable para permitir valores nulos

        public int Id_Empleado { get => _Id_Empleado; set => _Id_Empleado = value; }
        public string Nombre_Empleado { get => _Nombre_Empleado; set => _Nombre_Empleado = value; }
        public string Apeido_P_Empleado { get => _Apeido_P_Empleado; set => _Apeido_P_Empleado = value; }
        public string Apeido_M_Empleado { get => _Apeido_M_Empleado; set => _Apeido_M_Empleado = value; }
        public string Email_Empleado { get => _Email_Empleado; set => _Email_Empleado = value; }
        public string Telefono_Empleado { get => _Telefono_Empleado; set => _Telefono_Empleado = value; }
        public int? Rol_Id { get => _Rol_Id; set => _Rol_Id = value; }

        public Empleados_VO()
        {
            _Id_Empleado = 0;
            _Nombre_Empleado = string.Empty;
            _Apeido_P_Empleado = string.Empty;
            _Apeido_M_Empleado = string.Empty;
            _Email_Empleado = string.Empty;
            _Telefono_Empleado = string.Empty;
            _Rol_Id = null; // Inicializa como nulo
        }

        public Empleados_VO(DataRow dr)
        {
            _Id_Empleado = int.Parse(dr["Id_Empleado"].ToString());
            _Nombre_Empleado = dr["Nombre_Empleado"].ToString();
            _Apeido_P_Empleado = dr["Apeido_P_Empleado"] != DBNull.Value ? dr["Apeido_P_Empleado"].ToString() : string.Empty;
            _Apeido_M_Empleado = dr["Apeido_M_Empleado"] != DBNull.Value ? dr["Apeido_M_Empleado"].ToString() : string.Empty;
            _Email_Empleado = dr["Email_Empleado"] != DBNull.Value ? dr["Email_Empleado"].ToString() : string.Empty;
            _Telefono_Empleado = dr["Telefono_Empleado"].ToString();
            _Rol_Id = dr["Rol_Id"] != DBNull.Value ? (int?)int.Parse(dr["Rol_Id"].ToString()) : null;
        }
    }
}