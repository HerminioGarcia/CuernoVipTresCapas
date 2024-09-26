using System;
using System.Data;

namespace VO
{
    public class Usuario_VO
    {
        private int _IdUsuario;
        private string _Username;
        private string _Password;
        private int? _EmpleadoId; // Nullable para permitir valores nulos
        private int? _ClienteId;  // Nullable para permitir valores nulos

        // Propiedades públicas con getter y setter
        public int IdUsuario
        {
            get => _IdUsuario;
            set => _IdUsuario = value;
        }

        public string Username
        {
            get => _Username;
            set => _Username = value;
        }

        public string Password
        {
            get => _Password;
            set => _Password = value;
        }

        public int? EmpleadoId
        {
            get => _EmpleadoId;
            set => _EmpleadoId = value;
        }

        public int? ClienteId
        {
            get => _ClienteId;
            set => _ClienteId = value;
        }

        // Constructor vacío
        public Usuario_VO()
        {
            _IdUsuario = 0;
            _Username = string.Empty;
            _Password = string.Empty;
            _EmpleadoId = null;
            _ClienteId = null;
        }

        // Constructor que inicializa con un DataRow
        public Usuario_VO(DataRow dr)
        {
            _IdUsuario = int.Parse(dr["Id_Usuario"].ToString());
            _Username = dr["Username"].ToString();
            _Password = dr["Password"].ToString();
            _EmpleadoId = dr["Empleado_Id"] != DBNull.Value ? (int?)int.Parse(dr["Empleado_Id"].ToString()) : null;
            _ClienteId = dr["Cliente_Id"] != DBNull.Value ? (int?)int.Parse(dr["Cliente_Id"].ToString()) : null;
        }
    }
}
