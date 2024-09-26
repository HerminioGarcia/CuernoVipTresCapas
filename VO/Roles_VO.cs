using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace VO
    {
        public class Roles_VO
        {
            private int _Id_Rol;
            private string _Rol;
            private decimal _Pago;

            public int Id_Rol { get => _Id_Rol; set => _Id_Rol = value; }
            public string Rol { get => _Rol; set => _Rol = value; }
            public decimal Pago { get => _Pago; set => _Pago = value; }

            public Roles_VO()
            {
                _Id_Rol = 0;
                _Rol = string.Empty;
                _Pago = 0.0m; // Inicializa como 0
            }

            public Roles_VO(DataRow dr)
            {
                _Id_Rol = int.Parse(dr["Id_Rol"].ToString());
                _Rol = dr["Rol"].ToString();
                _Pago = decimal.Parse(dr["Pago"].ToString());
            }
        }
    }
}