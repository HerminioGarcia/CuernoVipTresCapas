using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class Clientes_VO
    {
        private int _Id_Cliente;
        private string _Nombre_Cliente;
        private string _Apeido_P_Cliente;
        private string _Apeido_M_Cliente;
        private string _Email;
        private string _Telefono;

        public int Id_Cliente { get => _Id_Cliente; set => _Id_Cliente = value; }
        public string Nombre_Cliente { get => _Nombre_Cliente; set => _Nombre_Cliente = value; }
        public string Apeido_P_Cliente { get => _Apeido_P_Cliente; set => _Apeido_P_Cliente = value; }
        public string Apeido_M_Cliente { get => _Apeido_M_Cliente; set => _Apeido_M_Cliente = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }

        public Clientes_VO()
        {
            _Id_Cliente = 0;
            _Nombre_Cliente = string.Empty;
            _Apeido_P_Cliente = string.Empty;
            _Apeido_M_Cliente = string.Empty;
            _Email = string.Empty;
            _Telefono = string.Empty;
        }

        public Clientes_VO(DataRow dr)
        {
            _Id_Cliente = int.Parse(dr["Id_Cliente"].ToString());
            _Nombre_Cliente = dr["Nombre_Cliente"].ToString();
            _Apeido_P_Cliente = dr["Apeido_P_Cliente"] != DBNull.Value ? dr["Apeido_P_Cliente"].ToString() : string.Empty;
            _Apeido_M_Cliente = dr["Apeido_M_Cliente"] != DBNull.Value ? dr["Apeido_M_Cliente"].ToString() : string.Empty;
            _Email = dr["Email"] != DBNull.Value ? dr["Email"].ToString() : string.Empty;
            _Telefono = dr["Telefono"] != DBNull.Value ? dr["Telefono"].ToString() : string.Empty;
        }
    }
}